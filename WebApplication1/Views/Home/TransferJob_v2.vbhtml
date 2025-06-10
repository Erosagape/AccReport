@Code
    ViewData("Title") = "Post data to GL Accounts"
    Dim dbName = "job_demo"
    Dim debugMode = False
    If Not Request.QueryString("DEBUG") Is Nothing Then
        debugMode = IIf(Request.QueryString("DEBUG") = "Y", True, False)
    End If
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim branch = "00"
    If Not Request.QueryString("Branch") Is Nothing Then
        branch = Request.QueryString("Branch")
    End If
    Dim datefrom = "2020-01-01"
    If Not Request.QueryString("DateFrom") Is Nothing Then
        datefrom = Request.QueryString("DateFrom")
    End If
    Dim dateto = Today.Date.ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateto = Request.QueryString("DateTo")
    End If
    Dim postadv = False
    If Not Request.QueryString("Adv") Is Nothing Then
        postadv = IIf(Request.QueryString("Adv") = "Y", True, False)
    End If

    Dim postap = False
    If Not Request.QueryString("AP") Is Nothing Then
        postap = IIf(Request.QueryString("AP") = "Y", True, False)
    End If

    Dim postar = False
    If Not Request.QueryString("AR") Is Nothing Then
        postar = IIf(Request.QueryString("AR") = "Y", True, False)
    End If

    Dim postrc = False
    If Not Request.QueryString("RCV") Is Nothing Then
        postrc = IIf(Request.QueryString("RCV") = "Y", True, False)
    End If

    Dim postcost = False
    If Not Request.QueryString("CST") Is Nothing Then
        postcost = IIf(Request.QueryString("CST") = "Y", True, False)
    End If
    Dim setIden As Boolean = True
    If Not Request.QueryString("IDEN") Is Nothing Then
        setIden = IIf(Request.QueryString("IDEN") = "Y", True, False)
    End If
    'Dim cnnStr = "Data Source=.;Initial Catalog=AccConcept;User id=sa;Password='9t;yogm851';Persist Security Info=False"
    'Dim obj = New AccReport.CUtil(cnnStr)
    Dim dbSource = "AccConcept"
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim msg As String = ""
    Dim bConn = obj.IsConnect()
    Dim setIdentityON As String = "SET IDENTITY_INSERT Acc_JournalHD ON"
    Dim setIdentityOFF As String = "SET IDENTITY_INSERT Acc_JournalHD OFF"
    If setIden = False Then
        setIdentityON = ""
        setIdentityOFF = ""
    End If
    Dim sql = ""

End Code
<h2>Transfer Data to GL</h2>
@If bConn = False Then
    @<span>@obj.Message</span>
Else
    Dim userid = "ADMIN"
    Dim sqlAlterView = "
ALTER procedure [dbo].[Insert_SIToJournal_ByDate]
(
@@datefrom date,
@@dateto date,
@@userid nvarchar(50)
)
as
begin
declare @@maxid int;
set @@maxid=(SELECT MAX(EntryId) as t from Acc_JournalHD)

" & setIdentityON & "

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @@maxid+ROW_NuMBER() OVER(ORDER BY h.AccDocNo) as EntryID,
h.AccDocNo,h.AccBatchDate  as EntryDate,
h.AccEffectiveDate,@@userid as UserID,
h.DocRefNo,0,0
from vAR_H h
where h.AccEffectiveDate>=@@datefrom and h.AccEffectiveDate<=@@dateto
and h.AccDocNo not in(select JournalNo from Acc_JournalHD)

" & setIdentityOFF & "

insert into Acc_JournalDT
select * from (
select @@maxid+DENSE_RANK() OVER(ORDER BY AccDocNo)  as EntryId,
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY RefNo) as Seq,
b.AccCode,a.AccDesc,RefNo,a.Debit,a.Credit from
(
select
d.AssetAccCode as AccCode,
d.AccDocNo,d.TotalAmount+d.VatAmount as Debit,0 as Credit,
d.SalesDescription as AccDesc,CONCAT(d.AccSourceDocNo,'#',d.AccSourceDocItem) as RefNo
from vAR_D d
where d.AccEffectiveDate>=@@datefrom and d.AccEffectiveDate<=@@dateto
union all
select
dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
h.AccDocNo,0 as Debit,h.TotalVat as Credit,
h.PartyName as AccDesc,h.DocRefNo as RefNo
from vAR_H h
where h.AccEffectiveDate>=@@datefrom and h.AccEffectiveDate<=@@dateto
and h.TotalVat>0
union all
select
d.IncomeAccCode as AccCode,
d.AccDocNo,0 as Debit,d.TotalAmount as Credit,
d.SalesDescription as AccDesc,CONCAT(d.AccSourceDocNo,'#',d.AccSourceDocItem) as RefNo
from vAR_D d
where d.AccEffectiveDate>=@@datefrom and d.AccEffectiveDate<=@@dateto
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
) tb
where tb.EntryId not in(select EntryID from Acc_JournalDT)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b
on a.EntryID=b.EntryID
where a.EffectiveDate>=@@datefrom and a.EffectiveDate<=@@dateto

update a set a.AccPostDate=b.EntryDate,a.DocStatus=2
from Acc_TransactionHD a
inner join Acc_JournalHD b
on a.AccDocNo=b.JournalNo
where a.DocStatus=1
end
"
    msg &= IIf(obj.ExecuteSQL(sqlAlterView) = "OK", "", vbCrLf & obj.Message)

    sqlAlterView = "
ALTER procedure [dbo].[Insert_PIToJournal_ByDate]
(
@@datefrom date,
@@dateto date,
@@userid nvarchar(50)
)
as
begin
declare @@maxid int;
set @@maxid=(SELECT MAX(EntryId) as t from Acc_JournalHD)

" & setIdentityON & "

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @@maxid+ROW_NuMBER() OVER(ORDER BY h.AccDocNo) as EntryID,
h.AccDocNo,h.AccBatchDate  as EntryDate,
h.AccEffectiveDate,@@userid as UserID,
h.DocRefNo,0,0
from vAP_H h
where h.AccEffectiveDate>=@@datefrom and h.AccEffectiveDate<=@@dateto
and h.AccDocNo not in(select JournalNo from Acc_JournalHD)

" & setIdentityOFF & "

insert into Acc_JournalDT
select * from (
select @@maxid+DENSE_RANK() OVER(ORDER BY AccDocNo)  as EntryId,
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY RefNo) as Seq,
b.AccCode,a.AccDesc,RefNo,a.Debit,a.Credit from
(
select
dbo.GetAccConfig('AP_CONFIG','Purchase') as AccCode,
h.AccDocNo,0 as Debit,h.TotalAmount+h.TotalVat as Credit,
h.PartyName as AccDesc,h.DocRefNo as RefNo
from vAP_H h
where h.AccEffectiveDate>=@@datefrom and h.AccEffectiveDate<=@@dateto
union all
select
dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
h.AccDocNo,h.TotalVat as Debit,0 as Credit,
h.PartyName as AccDesc,h.DocRefNo as RefNo
from vAP_H h
where h.AccEffectiveDate>=@@datefrom and h.AccEffectiveDate<=@@dateto
and h.TotalVat>0
union all
select
d.AssetAccCode as AccCode,
d.AccDocNo,d.TotalAmount as Debit,0 as Credit,
d.SalesDescription as AccDesc,CONCAT(d.AccSourceDocNo,'#',d.AccSourceDocItem) as RefNo
from vAP_D d
where d.AccEffectiveDate>=@@datefrom and d.AccEffectiveDate<=@@dateto
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
) tb
where tb.EntryId not in(select EntryID from Acc_JournalDT)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b
on a.EntryID=b.EntryID
where a.EffectiveDate>=@@datefrom and a.EffectiveDate<=@@dateto

update a set a.AccPostDate=b.EntryDate,a.DocStatus=2
from Acc_TransactionHD a
inner join Acc_JournalHD b
on a.AccDocNo=b.JournalNo
where a.DocStatus=1

end
"
    msg &= IIf(obj.ExecuteSQL(sqlAlterView) = "OK", "", vbCrLf & obj.Message)

    sqlAlterView = "
ALTER procedure [dbo].[Insert_ProductsCodeFromJob]
as
begin
--ลบก่อน
delete a
from dbo.Mas_Products a inner join [" + dbName + "].dbo.Job_SrvSingle s
on a.ProductCode=s.SICode
--รหัสค่าบริการที่คิด VAT หัก 3 เข้ากลุ่มสินค้า SV1
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV1'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT หัก 1 เข้ากลุ่มสินค้า SV2 (ค่าขนส่งต่างๆ)
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV2'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ หัก 1 เข้ากลุ่ม SV3 (ถ้ามี)
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV3'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ ไม่มีหัก  เข้ากลุ่ม SV4 (ถ้ามี)
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV4'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=0
--รหัสค่าบริการที่ไม่คิด VAT และ หัก 3 เข้ากลุ่ม SV5 (ถ้ามี)
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV5'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT และ ไม่หักเลยเข้ากลุ่ม SV6 (ถ้ามี)
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV6'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=0
--รหัสค่าใช้จ่ายต้นทุนที่คิด VAT หัก 3 เข้ากลุ่ม CSV
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSV'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT หัก 1 เข้ากลุ่ม CTR
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CTR'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT ไม่ได้หัก 1 เข้ากลุ่ม CSN
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSN'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND NOT s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่มีใบเสร็จเข้ากลุ่ม CEX
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CEX'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=0 and s.IsExpense=1
--รหัสเงินค่าใช้จ่ายของลูกค้าเข้า ADV
insert into dbo.Mas_Products
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','ADV'
from [" + dbName + "].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsCredit=1 and s.IsExpense=0
end
"
    msg &= IIf(obj.ExecuteSQL(sqlAlterView) = "OK", "", vbCrLf & obj.Message)
    @<ul>
        <li>Prepare Views: @msg</li>
    </ul>
    'Sync Master File
    sql = "EXEC dbo.Insert_ProductsCodeFromJob"
    If debugMode = False Then
        msg = obj.ExecuteSQL(sql)
    Else
        msg = sql
    End If
    @<ul>
        <li>Sync Master File: @msg</li>
    </ul>
    Dim sqlHead = "
declare @@datefrom date='{1}';
declare @@dateto date='{2}';
declare @@branchcode varchar(3)='{0}';
declare @@userid varchar(10)='" + userid + "';
declare @@maxid int;
"
    If postadv Then
        'process advance
        sql = sqlHead & "
delete c
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_TransactionHD b
on concat(a.AdvNo,'-',a.BranchCode)=b.AccDocNo
inner join Acc_TransactionDT c on b.AccDocNo=c.AccDocNo
where a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto

delete b
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_TransactionHD b
on concat(a.AdvNo,'-',a.BranchCode)=b.AccDocNo
where a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto

delete c
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on concat('PV-',a.AdvNo,'-',a.BranchCode)=b.JournalNo
inner join Acc_JournalDT c on b.EntryID=c.EntryID
where a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto

delete b
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on concat('PV-',a.AdvNo,'-',a.BranchCode)=b.JournalNo
where a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto

delete b
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_AdditionData b
on concat('PV-',a.AdvNo,'-',a.BranchCode)=b.DocNo
where a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
            @<ul>
                <li>Delete Old Advance Imported: @msg</li>
            </ul>
        Else
            msg = obj.ExecuteSQL(sql)
            @<textarea>
                @sql
            </textarea>
            @<ul>
                <li>Result: @msg</li>
            </ul>
        End If


        sql = sqlHead & "
set @@maxid=(SELECT isnull(MAX(EntryId),0) from Acc_JournalHD);

insert into Acc_TransactionHD
select concat(a.AdvNo,'-',a.BranchCode) as DocNo,a.AdvDate,a.PaymentDate,
a.CustCode,concat(b.TaxNumber,' / ',b.Branch),b.NameThai,b.TAddress,
a.AdvBy,'PI',a.PaymentDate,a.PaymentDate,2,a.PaymentRef
from [" + dbName + "].dbo.Job_AdvHeader a
inner join [" + dbName + "].dbo.Mas_Company b
on a.CustCode=b.CustCode and a.CustBranch=b.Branch
left join Acc_TransactionHD c
on concat(a.AdvNo,'-',a.BranchCode)=c.AccDocNo
where c.AccDocNo is null and a.DocStatus<>99 and a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto

insert into Acc_TransactionDT
select concat(a.AdvNo,'-',a.BranchCode),
a.ItemNo,'',0,0,a.AdvQty,a.UnitPrice,'SET',a.CurrencyCode,a.ExchangeRate,a.AdvAmount,
a.SICode,a.SDescription,a.VATRate,a.Rate50Tavi,1
from [" + dbName + "].dbo.Job_AdvDetail a
inner join Acc_TransactionHD b
on concat(a.AdvNo,'-',a.BranchCode)=b.AccDocNo
left join Acc_TransactionDT c
on concat(a.AdvNo,'-',a.BranchCode)=c.AccDocNo
and a.ItemNo=c.AccItemNo
where c.AccDocNo is null

" & setIdentityON & "

insert into Acc_JournalHD (EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select
ROW_NUMBER() OVER(ORDER BY a.AdvNo)+@@maxid as EntryID,
concat('PV-',a.AdvNo,'-',a.BranchCode) as JournalNo,
a.AdvDate as EntryDate,
a.PaymentDate as EffectiveDate,
@@userid,a.PaymentRef,(a.TotalAdvance),(a.TotalAdvance)
from [" + dbName + "].dbo.Job_AdvHeader a
where a.DocStatus<>99 and a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
and concat(a.AdvNo,'-',a.BranchCode) not in(select JournalNo FROM Acc_JournalHD)
order by a.AdvNo

" & setIdentityOFF & "

insert into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Text3,Text4)
select concat('PV-',a.AdvNo,'-',a.BranchCode),0,'PV',a.EmpCode,a.PayChqTo,a.TRemark
from [" + dbName + "].dbo.Job_AdvHeader a
where a.DocStatus<>99 and  a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
and not exists(select 1 FROM Acc_AdditionData WHERE DocNo=concat(a.AdvNo,'-',a.BranchCode) AND Seq=0)

insert into Acc_JournalDT
select
s.EntryId as EntryID,
ROW_NUMBER() OVER(PARTITION BY AdvNo ORDER BY AdvNo) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
--Cr.เงินสดย่อย (ยอด net)
select concat('PV-',b.AdvNo,'-',b.BranchCode) as AdvNo,b.PaymentDate,a.AccCode,b.PayChqTo as AccName,concat(b.AdvNo,'-',b.BranchCode) as AccDesc,0 as Debit,b.TotalAdvance as Credit
from [job_evb].dbo.Job_AdvHeader b,Mas_AccCode a
where b.BranchCode=@@branchcode and b.DocStatus<>99
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
union all
--Dr. เงินทดรองจ่ายพนักงาน (ยอด Net+Wht)
select concat('PV-',b.AdvNo,'-',b.BranchCode),b.PaymentDate,a.AccCode,c.SDescription,concat(c.AdvNo,'#',c.ItemNo) as AccDesc,c.AdvNet as Debit,0 as Credit
from [job_evb].dbo.Job_AdvHeader b inner join [job_evb].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
,Mas_AccCode a
where b.BranchCode=@@branchcode and b.DocStatus<>99
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
) t inner join Acc_JournalHD s on t.AdvNo=s.JournalNo
where t.PaymentDate>=@@datefrom and t.PaymentDate<=@@dateto
order by AdvNo,AccCode

insert into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Num1,Text3,Text4)
select concat('PV-',c.AdvNo,'-',c.BranchCode),a.Seq,c.SICode,c.ForJNo,c.AdvAmount,c.PayChqTo,c.VenCode
from Acc_JournalDT a inner join [" + dbName + "].dbo.Job_AdvDetail c
on a.AccDesc=concat(c.AdvNo,'#',c.ItemNo)
inner join [" + dbName + "].dbo.Job_AdvHeader b
on c.BranchCode=b.BranchCode and c.AdvNo=b.AdvNo
where not exists(select 1 from Acc_AdditionData where DocNo=concat('PV-',c.AdvNo,'-',c.BranchCode) and Seq=a.Seq)
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
            @<ul>
                <li>Process Advance Data: @msg</li>
            </ul>
        Else
            msg = obj.ExecuteSQL(sql)
            @<textarea>
                @sql
            </textarea>
            @<ul>
                <li>Result: @msg</li>
            </ul>
        End If
    End If
End If
