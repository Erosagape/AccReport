@Code
    ViewData("Title") = "Post data to GL Accounts"
    Dim dbName = ViewBag.JobDatabase
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
    Dim dateto = DateAdd("d", -1, New Date(DateTime.Now.Year + 1, 1, 1)).ToString("yyyy-MM-dd")
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
    Dim dbSource = ViewBag.AccDatabase
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
End Code
<h2>@ViewBag.Title</h2>
@If Not bConn Then
    @<div class="container">
        Cannot connect database
    </div>
Else
    @<div class="container">
        <div class="row">
            <div class="col-md-3">
                Database : <input type="text" id="txtDatabase" value="@dbName" />
            </div>
            <div class="col-md-3">
                Date From : <input type="date" id="txtDateFrom" value="@datefrom" />
            </div>
            <div class="col-md-3">
                To : <input type="date" id="txtDateTo" value="@dateto" />
            </div>
            <div class="col-md-3">
                Branch : <input type="text" id="txtBranch" value="@branch" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-2">
                <input type="button" class="btn btn-success" onclick="PostAdvance()" value="Post Advance" />
            </div>
            <div class="col-md-2">
                <input type="button" class="btn btn-success" onclick="PostPayIn()" value="Post Pay-in" />
            </div>
            <div class="col-md-2">
                <input type="button" class="btn btn-success" onclick="PostInvoice()" value="Post Invoice" />
            </div>
            <div class="col-md-2">
                <input type="button" class="btn btn-success" onclick="PostReceipt()" value="Post Receipt" />
            </div>
            <div class="col-md-2">
                <input type="button" class="btn btn-success" onclick="PostCost()" value="Post Cost" />
            </div>
        </div>
    </div>
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
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
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
where d.AccBatchDate>=@@datefrom and d.AccBatchDate<=@@dateto
union all
select
dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
h.AccDocNo,0 as Debit,h.TotalVat as Credit,
h.PartyName as AccDesc,h.DocRefNo as RefNo
from vAR_H h
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
and h.TotalVat>0
union all
select
d.IncomeAccCode as AccCode,
d.AccDocNo,0 as Debit,d.TotalAmount as Credit,
d.SalesDescription as AccDesc,CONCAT(d.AccSourceDocNo,'#',d.AccSourceDocItem) as RefNo
from vAR_D d
where d.AccBatchDate>=@@datefrom and d.AccBatchDate<=@@dateto
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
) tb
where tb.EntryId not in(select EntryID from Acc_JournalDT)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b
on a.EntryID=b.EntryID
where a.EntryDate>=@@datefrom and a.EntryDate<=@@dateto

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
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
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
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
union all
select
dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
h.AccDocNo,h.TotalVat as Debit,0 as Credit,
h.PartyName as AccDesc,h.DocRefNo as RefNo
from vAP_H h
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
and h.TotalVat>0
union all
select
d.AssetAccCode as AccCode,
d.AccDocNo,d.TotalAmount as Debit,0 as Credit,
d.SalesDescription as AccDesc,CONCAT(d.AccSourceDocNo,'#',d.AccSourceDocItem) as RefNo
from vAP_D d
where d.AccBatchDate>=@@datefrom and d.AccBatchDate<=@@dateto
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
) tb
where tb.EntryId not in(select EntryID from Acc_JournalDT)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b
on a.EntryID=b.EntryID
where a.EntryDate>=@@datefrom and a.EntryDate<=@@dateto

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
    Dim sqlHead = "
declare @@datefrom date='{1}';
declare @@dateto date='{2}';
declare @@branchcode varchar(3)='{0}';
declare @@userid varchar(10)='" + userid + "';
declare @@maxid int;
"
    'Sync Master File
    Dim sql = "EXEC dbo.Insert_ProductsCodeFromJob"
    If debugMode = False Then
        msg = obj.ExecuteSQL(sql)
    Else
        msg = sql
    End If
    @<ul>
        <li>Sync Master File: @msg</li>
    </ul>
    If postadv Then
        'process advance
        sql = sqlHead & "
delete c
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on a.AdvNo=b.JournalNo
inner join Acc_JournalDT c on b.EntryID=c.EntryID
where a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto

delete b
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on a.AdvNo=b.JournalNo
where a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto

delete b
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_AdditionData b
on a.AdvNo=b.DocNo
where a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Delete Old Advance Imported: @msg</li>
        </ul>

        sql = sqlHead & "
set @@maxid=(SELECT isnull(MAX(EntryId),0) from Acc_JournalHD);

" & setIdentityON & "

insert into Acc_JournalHD (EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select
ROW_NUMBER() OVER(ORDER BY a.AdvNo)+@@maxid as EntryID,
a.AdvNO as JournalNo,
a.PaymentDate as EntryDate,
a.PaymentDate as EffectiveDate,
@@userid,a.PaymentRef,(a.TotalAdvance+a.Total50Tavi),(a.TotalAdvance+a.Total50Tavi)
from [" + dbName + "].dbo.Job_AdvHeader a
where a.DocStatus<>99 and  a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
and a.AdvNo not in(select JournalNo FROM Acc_JournalHD)
order by a.AdvNo

" & setIdentityOFF & "

insert into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Text3,Text4)
select a.AdvNo,0,'PV',a.EmpCode,a.PayChqTo,a.TRemark
from [" + dbName + "].dbo.Job_AdvHeader a
where a.DocStatus<>99 and  a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
and not exists(select 1 FROM Acc_AdditionData WHERE DocNo=a.AdvNo AND Seq=0)

insert into Acc_JournalDT
select
DENSE_RANK() OVER(ORDER BY AdvNo)+@@maxid as EntryID,
ROW_NUMBER() OVER(PARTITION BY AdvNo ORDER BY AdvNo) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
--Dr. เงินทดรองจ่ายพนักงาน (ยอด Net+Wht)
select b.AdvNo,b.PaymentDate,a.AccCode,b.PayChqTo as AccName,b.TRemark as AccDesc,(b.TotalAdvance+b.Total50Tavi) as Debit,0 as Credit
from [" + dbName + "].dbo.Job_AdvHeader b,Mas_AccCode a
where b.BranchCode=@@branchcode and b.DocStatus<>99
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','Cashin')
union all
--Cr.เงินสดย่อย (ยอด net)
select b.AdvNo,b.PaymentDate,a.AccCode,c.SDescription,concat(c.AdvNo,'#',c.ItemNo) as AccDesc,0 as Debit,c.AdvNet as Credit
from [" + dbName + "].dbo.Job_AdvHeader b inner join [" + dbName + "].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
,Mas_AccCode a
where b.BranchCode=@@branchcode and b.DocStatus<>99
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
union all
--Cr. หัก ณ ที่จ่ายในนามลูกค้า
select b.AdvNo,b.PaymentDate,a.AccCode,concat(c.SDescription,'@',c.AdvAmount),concat(isnull(e.NameThai,b.CustCode),' #',b.Doc50Tavi) as AccDesc,0 as Debit,c.Charge50Tavi as Credit
from [" + dbName + "].dbo.Job_AdvHeader b inner join [" + dbName + "].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
left join [" + dbName + "].dbo.Mas_Company e on b.CustCode=e.CustCode and b.CustBranch=e.Branch
inner join [" + dbName + "].dbo.Job_SrvSingle d on c.SICode=d.SICode
,Mas_AccCode a
where b.BranchCode=@@branchcode
and b.DocStatus<>99  and c.Charge50Tavi>0 and d.IsCredit=1
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCustomer')
union all
--Cr. หัก ณ ที่จ่าย
select b.AdvNo,b.PaymentDate,a.AccCode,concat(c.SDescription,'@',c.Charge50Tavi),concat(isnull(e.TName,c.VenCode),' #',b.Doc50Tavi) as AccDesc,0 as Debit,c.Charge50Tavi as Credit
from [" + dbName + "].dbo.Job_AdvHeader b inner join [" + dbName + "].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
left join [" + dbName + "].dbo.Job_SrvSingle d on c.SICode=d.SICode
left join [" + dbName + "].dbo.Mas_Vender e on c.VenCode=e.VenCode
,Mas_AccCode a
where b.BranchCode=@@branchcode
and b.DocStatus<>99 and  c.Charge50Tavi>0 and isnull(d.IsCredit,0)=0
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
) t
where t.PaymentDate>=@@datefrom and t.PaymentDate<=@@dateto
order by AdvNo,AccCode

insert into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Num1,Text3,Text4)
select c.AdvNo,a.Seq,c.SICode,c.ForJNo,c.AdvAmount,c.PayChqTo,c.VenCode
from Acc_JournalDT a inner join [" + dbName + "].dbo.Job_AdvDetail c
on a.AccDesc=concat(c.AdvNo,'#',c.ItemNo)
inner join [" + dbName + "].dbo.Job_AdvHeader b
on c.BranchCode=b.BranchCode and c.AdvNo=b.AdvNo
where not exists(select 1 from Acc_AdditionData where DocNo=c.AdvNo and Seq=a.Seq)
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Process Advance Data: @msg</li>
        </ul>
    End If
    If postap Then
        'Process A/P Data
        sql = sqlHead & "
delete d
from [" + dbName + "].dbo.Job_PaymentHeader h
inner join Acc_TransactionDT d
on h.DocNo=d.AccDocNo
where h.BranchCode=@@branchcode
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

delete d
from [" + dbName + "].dbo.Job_PaymentHeader h
inner join Acc_TransactionHD d
on h.DocNo=d.AccDocNo
where h.BranchCode=@@branchcode
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

delete d
from [" + dbName + "].dbo.Job_PaymentHeader h
inner join Acc_JournalHD d
on h.DocNo=d.JournalNo
where  h.BranchCode=@@branchcode
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

delete h
from Acc_JournalDT h
left join Acc_JournalHD d
on h.EntryID=d.EntryId
where d.EntryID is null

delete b
from [" + dbName + "].dbo.Job_PaymentHeader a inner join Acc_AdditionData b
on a.DocNo=b.DocNo
where a.BranchCode=@@branchcode
and a.DocDate>=@@datefrom and a.DocDate<=@@dateto
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Delete Old Pay-in Data: @msg</li>
        </ul>

        sql = sqlHead & "
insert into Acc_TransactionHD
select h.DocNo,h.DocDate,h.DocDate,
isnull(c.VenCode,'-'),isnull(c.TaxNumber,'-'),isnull(c.TName,'-'),CONCAT(isnull(c.TAddress1,''),' ',isnull(c.TAddress2,'')),@@userid,
'PI',h.DocDate,h.DocDate,1,h.RefNo
from [" + dbName + "].dbo.Job_PaymentHeader h
left join [" + dbName + "].dbo.Mas_Vender c
on h.VenCode=c.VenCode
where h.BranchCode=@@branchcode
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto
and not h.CancelProve<>''
and exists(
select d.DocNo from [" + dbName + "].dbo.Job_PaymentDetail d
inner join [" + dbName + "].dbo.Job_SrvSingle s
on d.SICode=s.SICode
and d.BranchCode=h.BranchCode and d.DocNo=h.DocNo
)
and h.DocNo not in (select AccDocNo from Acc_TransactionHD)

insert into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Text3,Text4)
select a.DocNo,0,'PO',a.VenCode,a.PoNo,a.RefNo
from [" + dbName + "].dbo.Job_PaymentHeader a
where a.BranchCode=@@branchcode
and a.DocDate>=@@datefrom and a.DocDate<=@@dateto
and not isnull(a.CancelProve,'')<>''
and not exists(select 1 FROM Acc_AdditionData WHERE DocNo=a.DocNo AND Seq=0)

insert into Acc_TransactionDT
select d.DocNo,
d.ItemNo,'',0,0,d.Qty,
((d.Amt-d.AmtDisc)/h.ExchangeRate)/d.Qty
,d.QtyUnit,h.CurrencyCode,h.ExchangeRate,
(d.Amt-d.AmtDisc)
,d.SICode,d.SDescription,
(case when d.AmtVAT>0 then h.VATRate else 0 end) as VatRate,
(case when d.AmtWHT>0 then h.TaxRate else 0 end) as TaxRate,
1 as VatRate
from [" + dbName + "].dbo.Job_PaymentHeader h
inner join [" + dbName + "].dbo.Job_PaymentDetail d
on h.BranchCode=d.BranchCode and h.DocNo=d.DocNo
inner join [" + dbName + "].dbo.Job_SrvSingle s
on d.SICode=s.SICode
where h.BranchCode=@@branchcode and not h.CancelProve<>'' and
h.DocDate>=@@datefrom and h.DocDate<=@@dateto


insert into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Text3)
select h.DocNo,d.ItemNo,
d.ForJNo,d.BookingRefNo,d.SRemark
from [" + dbName + "].dbo.Job_PaymentHeader h
inner join [" + dbName + "].dbo.Job_PaymentDetail d
on h.BranchCode=d.BranchCode and h.DocNo=d.DocNo
inner join [" + dbName + "].dbo.Job_SrvSingle s
on d.SICode=s.SICode
where h.BranchCode=@@branchcode and not h.CancelProve<>'' and
h.DocDate>=@@datefrom and h.DocDate<=@@dateto

EXEC dbo.Insert_PITojournal_ByDate @@datefrom,@@dateto,@@userid
"

        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Process Pay-In Data: @msg</li>
        </ul>
    End If
    If postar Then
        sql = sqlHead & "
delete d
from [" + dbName + "].dbo.Job_InvoiceHeader h
inner join Acc_TransactionDT d
on h.DocNo=d.AccDocNo
where h.BranchCode=@@branchcode
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

delete d
from [" + dbName + "].dbo.Job_InvoiceHeader h
inner join Acc_TransactionHD d
on h.DocNo=d.AccDocNo
where h.BranchCode=@@branchcode
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

delete d
from [" + dbName + "].dbo.Job_InvoiceHeader h
inner join Acc_JournalHD d
on h.DocNo=d.JournalNo
where h.BranchCode=@@branchcode
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

delete h
from Acc_JournalDT h
left join Acc_JournalHD d
on h.EntryID=d.EntryId
where d.EntryID is null
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Delete Old Invoices Data: @msg</li>
        </ul>

        sql = sqlHead & "
insert into Acc_TransactionHD
select h.DocNo,h.DocDate,isnull(h.DueDate,h.DocDate) as DueDate,
isnull(c.CustCode,'-'),isnull(c.TaxNumber,'-'),
isnull(c.NameThai,'-'),CONCAT(isnull(c.TAddress1,''),' ',isnull(c.TAddress2,'')),@@userid,
'SI',h.DocDate,h.DocDate,1,h.RefNo
from [" + dbName + "].dbo.Job_InvoiceHeader h
left join [" + dbName + "].dbo.Mas_Company c
on h.BillToCustCode=c.CustCode and h.BillToCustBranch=c.Branch
where h.BranchCode=@@branchcode
and not isnull(h.CancelProve,'')<>''
and h.DocNo not in (select AccDocNo from Acc_TransactionHD)
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

insert into Acc_TransactionDT
select d.DocNo,
ROW_NUMBER() OVER(PARTITION BY d.DocNo ORDER BY d.ItemNo) as Seq,'' as SourceDocNo,0 as SourceDocItem,0 as StockTransNo,
(case when d.AmtAdvance>0 then 1 else d.Qty end),
(case when d.AmtAdvance>0 then d.AmtAdvance else d.UnitPrice end)
,d.QtyUnit,d.CurrencyCode,d.ExchangeRate,
(case when d.AmtAdvance>0 then d.AmtAdvance*d.ExchangeRate else d.Amt end)
,p.ProductCode,d.SDescription,
(case when d.AmtCharge>0 AND d.AmtVat>0 then d.VATRate else 0 end),
(case when d.AmtCharge>0 AND d.Amt50Tavi>0 then d.Rate50Tavi else 0 end),
1 as VatType
from [" + dbName + "].dbo.Job_InvoiceHeader h
inner join [" + dbName + "].dbo.Job_InvoiceDetail d
on h.DocNo=d.DocNo and h.BranchCode=d.BranchCode
inner join vMas_Product p on d.SICode=p.ProductCode
where h.BranchCode=@@branchcode
and not isnull(h.CancelProve,'')<>''
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

EXEC dbo.Insert_SIToJournal_ByDate @@datefrom,@@dateto,@@userid
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Process Invoice Data: @msg</li>
        </ul>
    End If

    If postrc Then

        sql = "
alter view vRV_LinkJob
as
select BranchCode,DocNo,ItemNo,CustTaxID,CustBranch,custName,SICode,AmtCharge,AmtAdvance,ReceiptNet,ReceiptWht,ReceiptNo,ReceiptDAte,ReceiptItemNo,
case when CountAdvPay>0 then 1 else 0 end as IsFromAdv,
case when CountAdvPay=0 and CountBillPay>0 then 1 else 0 end as IsFromAP,
case when CountAdvPay=0 and CountBillPay=0 then 1 else 0 end as IsAccrue
from (
select BranchCode,custTaxID,CustBranch,CustName,DocNo,ItemNo,SICode,AmtCharge,AmtAdvance,ReceiptNo,ReceiptDate,ReceiptItemNo,Net-Amt50Tavi as ReceiptNet,Amt50Tavi as ReceiptWht,
count(*) as countRec,
sum(case when isnull(AdvNO,'')<>'' then 1 else 0 end) as CountAdvPay,
sum(case when not isnull(AdvNO,'')<>'' and isnull(VenderBillingNo,'')<>'' then 1 else 0 end) as CountBillPay,
sum(case when not isnull(AdvNO,'')<>'' and not isnull(VenderBillingNo,'')<>'' then 1 else 0 end) as CountAP
from (
select rh.BillToCustCode,rh.BillToCustBranch,isnull(cu.NameThai,'-') as CustName,
isnull(cu.TaxNumber,'-') as CustTaxID,isnull(cu.Branch,'-') as CustBranch,
rd.InvoiceNo as DocNo,rd.InvoiceItemNo as ItemNo,id.AmtCharge,id.AmtAdvance,rd.SICode,cd.AdvNO,cd.VenderBillingNo,rd.ReceiptNo,rh.ReceiptDate,rd.ItemNo as ReceiptItemNo,rd.Net,rd.Amt50Tavi,
cd.ClrNo,cd.JobNo,rh.BranchCode
from [" + dbName + "].dbo.Job_ReceiptDetail rd
inner join [" + dbName + "].dbo.Job_ReceiptHeader rh
on rd.BranchCode=rh.BranchCode and rd.ReceiptNo=rh.ReceiptNo
left join [" + dbName + "].dbo.Job_InvoiceDetail id
on rd.BranchCode=id.BranchCode and rd.InvoiceNo=id.DocNo and rd.InvoiceItemNo=id.ItemNo
left join [" + dbName + "].dbo.Mas_Company cu
on rh.BillToCustCode=cu.CustCode and rh.BillToCustBranch=cu.Branch
left join
(
select a.* from [" + dbName + "].dbo.Job_ClearDetail a
inner join [" + dbName + "].dbo.Job_ClearHeader b
on a.ClrNo=b.ClrNO and a.BranchCode=b.BranchCode
where b.DocStatus<>99
) cd
on rd.BranchCode=cd.BranchCode and rd.InvoiceNo=cd.LinkBillNo and rd.InvoiceItemNo=cd.LinkItem
and rd.SICode=cd.SICode
where rh.BranchCode={0} and
rh.ReceiptDate>='{1}' and rh.ReceiptDate<='{2}' and
not rh.CancelProve<>''
) r
group by BranchCode,CustTaxID,CustBranch,CustName,DocNo,ItemNo,SICode,AmtCharge,AmtAdvance,ReceiptNo,ReceiptDate,ReceiptItemNo,Net ,Amt50Tavi
) t
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Prepare View: @msg</li>
        </ul>

        sql = sqlHead & "
delete d
from [" + dbName + "].dbo.Job_ReceiptHeader h
inner join Acc_TransactionDT d
on h.ReceiptNo=d.AccDocNo
where h.BranchCode=@@branchcode
and h.ReceiptDate>=@@datefrom and h.ReceiptDate<=@@dateto

delete d
from [" + dbName + "].dbo.Job_ReceiptHeader h
inner join Acc_TransactionHD d
on h.ReceiptNo=d.AccDocNo
where h.BranchCode=@@branchcode
and h.ReceiptDate>=@@datefrom and h.ReceiptDate<=@@dateto

delete b
from [" + dbName + "].dbo.Job_ReceiptHeader a inner join Acc_JournalHD b
on a.ReceiptNo=b.JournalNo
where  a.BranchCode=@@branchcode
and a.ReceiptDate>=@@datefrom and a.ReceiptDate<=@@dateto

delete h
from Acc_JournalDT h
left join Acc_JournalHD d
on h.EntryID=d.EntryId
where d.EntryID is null
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Delete Old Receipt Data: @msg</li>
        </ul>
        sql = sqlHead & "
insert into Acc_TransactionHD
select h.ReceiptNo,h.ReceiptDate,h.ReceiptDate,
isnull(c.CustCode,'-'),isnull(c.TaxNumber,'-'),
isnull(c.NameThai,'-'),CONCAT(isnull(c.TAddress1,''),' ',isnull(c.TAddress2,'')),@@userid,
'DO',h.ReceiptDate,h.ReceiptDate,1,h.ReceiveRef
from [" + dbName + "].dbo.Job_ReceiptHeader h
left join [" + dbName + "].dbo.Mas_Company c
on h.BillToCustCode=c.CustCode and h.BillToCustBranch=c.Branch
where h.BranchCode=@@branchcode
and not isnull(h.CancelProve,'')<>''
and h.ReceiptNo not in (select AccDocNo from Acc_TransactionHD)
and h.ReceiptDate>=@@datefrom and h.ReceiptDate<=@@dateto

insert into Acc_TransactionDT
select d.ReceiptNo,
ROW_NUMBER() OVER(PARTITION BY d.ReceiptNo ORDER BY d.ItemNo) as Seq,d.InvoiceNo as SourceDocNo,d.InvoiceItemNo as SourceDocItem,0 as StockTransNo,
1,
(case when s.IsCredit=1 then (d.Amt+d.AmtVAT)/d.DExchangeRate else d.FAmt end)
,'SET',d.DCurrencyCode,d.DExchangeRate,
(case when s.IsCredit=1 then d.Amt+d.AmtVAT else d.Amt end)
,d.SICode,d.SDescription,
(case when s.IsCredit=0 AND d.AmtVat>0 then d.VATRate else 0 end),
(case when s.IsCredit=0 AND d.Amt50Tavi>0 then d.Rate50Tavi else 0 end),
1 as VatType
from [" + dbName + "].dbo.Job_ReceiptHeader h
inner join [" + dbName + "].dbo.Job_ReceiptDetail d
on h.ReceiptNo=d.ReceiptNo and h.BranchCode=d.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on d.SICode=s.SICode
where h.BranchCode=@@branchcode
and not isnull(h.CancelProve,'')<>''
and h.ReceiptDate>=@@datefrom and h.ReceiptDate<=@@dateto
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Process Receipt Data: @msg</li>
        </ul>

        sql = sqlHead & "
set @@maxid=(SELECT isnull(MAX(EntryId),0) from Acc_JournalHD);

" & setIdentityON & "

insert into Acc_JournalHD (EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @@maxid+ROW_NUMBER() OVER(ORDER BY r.ReceiptNo) as EntryID,
r.ReceiptNo,r.ReceiptDAte,r.ReceiptDAte,@@userid,concat(r.CustTaxID,' / ',r.custName),sum(r.ReceiptNet+r.ReceiptWht),sum(r.ReceiptNet+r.ReceiptWht)
from vRV_LinkJob r
inner join vMas_Product p
on r.SICode=p.ProductCode
where r.ReceiptNo not in(select JournalNo from Acc_JournalHD)
group by r.ReceiptNo,r.ReceiptDAte,r.CustTaxID,r.custName

" & setIdentityOFF & "

insert into Acc_JournalDT
select
@@maxid+DENSE_RANK() OVER(ORDER BY ReceiptNo) as EntryID,
ROW_NUMBER() OVER(PARTITION BY ReceiptNo ORDER BY ReceiptNo) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
select r.ReceiptNo,
a.AccCode,a.AccName,r.DocNo as AccDesc,
sum(case when r.AmtAdvance>0 then r.ReceiptNet+r.ReceiptWht else r.ReceiptNet end) as Debit,0 as Credit
from vRV_LinkJob r,
vMas_AccCode a
where a.AccCode=dbo.GetAccConfig('AR_CONFIG','CashIn')
group by r.ReceiptNo,a.AccCode,a.AccName,r.DocNo
union all
select r.ReceiptNo,
p.AssetAccCode,p.AssetAccName,p.ProductName,0,r.ReceiptNet
from vRV_LinkJob r
inner join vMas_Product p
on r.SICode=p.ProductCode
where r.IsFromAdv=1 and r.AmtAdvance>0
union all
select r.ReceiptNo,
p.AssetAccCode,p.AssetAccName,p.ProductName,0,r.ReceiptNet+r.ReceiptWht
from vRV_LinkJob r
inner join vMas_Product p
on r.SICode=p.ProductCode
where r.AmtCharge>0
union all
select r.ReceiptNo,
p.AssetAccCode,p.AssetAccName,p.ProductName,0,r.ReceiptNet
from vRV_LinkJob r
inner join vMas_Product p
on r.SICode=p.ProductCode
where r.AmtAdvance>0
and r.IsFromAdv=0
union all
select r.ReceiptNo,
a.AccCode,a.AccName,'ถูกหัก ณ ที่จ่าย' as AccDesc,sum(r.ReceiptWht) as Debit,0 as Credit
from vRV_LinkJob r,
vMas_AccCode a
where r.Amtcharge>0
and a.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
group by r.ReceiptNo,a.AccCode,a.AccName,r.DocNo
union all
select r.ReceiptNo,
a.AccCode,a.AccName,'หัก ณ ที่จ่าย' as AccDesc,0 as Debit,sum(r.ReceiptWht) as Credit
from vRV_LinkJob r,
vMas_AccCode a
where r.AmtAdvance>0
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCustomer')
group by r.ReceiptNo,a.AccCode,a.AccName,r.DocNo
) t
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Posting Receipt Data: @msg</li>
        </ul>
    End If
    If postcost Then
        sql = sqlHead & "
delete b
from (
select ch.ClrNo,ch.ClrDate,sum(cd.UsedAmount+cd.ChargeVAT) as totalClr
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo and cd.BranchCode=ch.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
inner join vMas_Product p
on cd.SICode=p.ProductCode
where ch.BranchCode=@@branchcode
and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and isnull(cd.VenderbillingNo,'')=''
and ch.DocStatus<>99 and s.IsExpense=1
group by ch.ClrNo,ch.ClrDate
) a inner join Acc_JournalHD b
on a.ClrNo=b.JournalNo

delete h
from Acc_JournalDT h
left join Acc_JournalHD d
on h.EntryID=d.EntryId
where d.EntryID is null
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Deleting Old Cost Data: @msg</li>
        </ul>

        sql = sqlHead & "
set @@maxid=(SELECT isnull(MAX(EntryId),0) from Acc_JournalHD);

" & setIdentityON & "

insert into Acc_JournalHD (EntryId,JournalNo,Entrydate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @@maxid+ROW_NUMBER() OVER(ORDER BY ClrNo) as EntryID,
ClrNo,ClrDate,ClrDate,@@userid,'-',TotalClr,TotalClr
from (
select ch.ClrNo,ch.ClrDate,sum(cd.UsedAmount+cd.ChargeVAT) as totalClr
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo and cd.BranchCode=ch.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
inner join vMas_Product p
on cd.SICode=p.ProductCode
where ch.BranchCode=@@branchcode
and isnull(cd.VenderbillingNo,'')=''
and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and ch.DocStatus<>99 and s.IsExpense=1
group by ch.ClrNo,ch.ClrDate
) t
where t.ClrNo not in(select JournalNo from Acc_JournalHD)

" & setIdentityOFF & "

--Insert Detail
insert into Acc_JournalDT
select @@maxid+DENSE_RANK() OVER(ORDER BY ClrNo) as EntryID,
ROW_NUMBER() OVER(PARTITION BY ClrNo ORDER BY ClrNo) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
select p.ExpenseAccCode as AccCode,cd.SDescription as AccName,
cd.UsedAmount as Debit,0 as Credit
,cd.JobNo as AccDesc,cd.ClrNo,ch.ClrDate
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo and cd.BranchCode=ch.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
left join [" + dbName + "].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
and cd.BranchCode=a.BranchCode
inner join vMas_Product p
on cd.SICode=p.ProductCode
where ch.BranchCode=@@branchcode
and isnull(cd.VenderbillingNo,'')=''
and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and ch.DocStatus<>99 and s.IsExpense=1
union all
select c.AccCode,cd.SDescription,cd.ChargeVAT as Debit,0 as Credit
,cd.JobNo,cd.ClrNo,ch.ClrDate
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo and cd.BranchCode=ch.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
inner join [" + dbName + "].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
and cd.BRanchCode=a.BranchCode
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.BranchCode=@@branchcode
and isnull(cd.VenderbillingNo,'')=''
and cd.ChargeVAT>0
and c.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')
and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and ch.DocStatus<>99 and s.IsExpense=1
union all
select c.AccCode,cd.SDescription,cd.ChargeVAT as Debit,0 as Credit
,cd.JobNo,cd.ClrNo,ch.ClrDate
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo and cd.BranchCode=ch.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
left join [" + dbName + "].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
and cd.BranchCode=a.BranchCode
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.BranchCode=@@branchcode
and isnull(cd.VenderbillingNo,'')='' and a.AdvNo is null
and cd.ChargeVAT>0
and c.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and ch.DocStatus<>99 and s.IsExpense=1
union all
select c.AccCode,cd.SDescription,
0 as Debit,cd.UsedAmount+cd.ChargeVAT-cd.Tax50Tavi as Credit
,cd.JobNo,cd.ClrNo,ch.ClrDate
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo and cd.BranchCode=ch.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
inner join [" + dbName + "].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
and cd.BranchCode=a.BranchCode
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.BranchCode=@@branchcode
and isnull(cd.VenderbillingNo,'')=''
and c.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and ch.DocStatus<>99 and s.IsExpense=1
union all
select c.AccCode,cd.SDescription,0 as Debit,cd.Tax50Tavi as Credit
,cd.JobNo,cd.ClrNo,ch.ClrDate
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo and cd.BranchCode=ch.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
inner join [" + dbName + "].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
and cd.BranchCode=a.BranchCode
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.BranchCode=@@branchcode
and isnull(cd.VenderbillingNo,'')=''
and cd.Tax50Tavi>0
and c.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and ch.DocStatus<>99 and s.IsExpense=1
union all
select c.AccCode as AccCode,cd.SDescription as AccName,
0 as Debit,cd.UsedAmount+cd.ChargeVAT as Credit
,cd.JobNo as AccDesc,cd.ClrNo,ch.ClrDate
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo and cd.BranchCode=ch.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
left join [" + dbName + "].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
and cd.BranchCode=a.BranchCode
inner join vMas_Product p
on cd.SICode=p.ProductCode ,
vMas_AccCode c
where ch.BranchCode=@@branchcode
and isnull(cd.VenderbillingNo,'')='' and a.AdvNO is null
and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and c.AccCode=dbo.GetAccConfig('AP_CONFIG','Purchase')
and ch.DocStatus<>99 and s.IsExpense=1
) t
"
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Cost Data Posted: @msg</li>
        </ul>

        sql = sqlHead & "
set @@maxid=(SELECT isnull(MAX(EntryId),0) from Acc_JournalHD);

insert into Acc_JournalDT
select
@@maxid+DENSE_RANK() OVER(ORDER BY ClrNo) as EntryID,
ROW_NUMBER() OVER(PARTITION BY ClrNo ORDER BY ClrNo) as Seq,
AccCode,AccName,AccDesc,Dr,Cr
from (
select h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription as AccDesc,sum(d.UsedAmount+d.ChargeVAT) as Dr,0 as Cr
from [" + dbName + "].dbo.Job_ClearDetail d
inner join [" + dbName + "].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo
and d.BranchCode=h.BranchCode
inner join vMas_Product p
on d.SICode=p.ProductCode,
vMas_AccCode a
where h.BranchCode=@@branchcode
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
and h.DocStatus<>99 and d.BNet=0
group by h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription
union all
select h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription,0 as Dr,sum(d.UsedAmount+d.ChargeVAT) as Cr
from [" + dbName + "].dbo.Job_ClearDetail d
inner join [" + dbName + "].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo
and d.BranchCode=h.BranchCode
inner join vMas_Product p
on d.SICode=p.ProductCode,
vMas_AccCode a
where h.BranchCode=@@branchcode
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
and h.DocStatus<>99 and d.BNet=0
group by h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription
) t
where ClrDate>=@@datefrom and ClrDate<=@@dateto

" & setIdentityON & "

insert into Acc_JournalHD (EntryId,JournalNo,Entrydate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @@maxid+ROW_NUMBER() OVER(ORDER BY ClrNo) as EntryID,
ClrNo,ClrDate,ClrDate,@@userid,'-',sum(Dr),sum(Cr)
from (
select h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription as AccDesc,sum(d.UsedAmount+d.ChargeVAT) as Dr,0 as Cr
from [" + dbName + "].dbo.Job_ClearDetail d
inner join [" + dbName + "].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo
and d.BranchCode=h.BranchCode
inner join vMas_Product p
on d.SICode=p.ProductCode,
vMas_AccCode a
where h.BranchCode=@@branchcode
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
and h.DocStatus<>99 and d.BNet=0
group by h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription
union all
select h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription,0 as Dr,sum(d.UsedAmount+d.ChargeVAT) as Cr
from [" + dbName + "].dbo.Job_ClearDetail d
inner join [" + dbName + "].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo
and d.BranchCode=h.BranchCode
inner join vMas_Product p
on d.SICode=p.ProductCode,
vMas_AccCode a
where h.BranchCode=@@branchcode
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
and h.DocStatus<>99 and d.BNet=0
group by h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription
) t
where ClrDate>=@@datefrom and ClrDate<=@@dateto
group by ClrNo,ClrDAte

" & setIdentityOFF
        sql = String.Format(sql, branch, datefrom, dateto)
        If debugMode = False Then
            msg = obj.ExecuteSQL(sql)
        Else
            msg = sql
        End If
        @<ul>
            <li>Cost Payment received Posted: @msg</li>
        </ul>
    End If
End If

<script type="text/javascript">
    var setIden = '@(IIf(setIden = True, "Y", "N"))';
    function PostAdvance() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?Form=TransferJob&IDEN="+setIden+"&Adv=Y&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt;
    }
    function PostPayIn() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?Form=TransferJob&IDEN=" + setIden +"&AP=Y&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt;
    }
    function PostInvoice() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?Form=TransferJob&IDEN=" + setIden +"&AR=Y&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt;
    }
    function PostReceipt() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?Form=TransferJob&IDEN=" + setIden +"&RCV=Y&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt;
    }
    function PostCost() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?Form=TransferJob&IDEN=" + setIden +"&CST=Y&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt;
    }
</script>
