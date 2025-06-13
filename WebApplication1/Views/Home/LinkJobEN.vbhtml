@Code
    ViewData("Title") = "Current State of Data"
    Dim dbName = ViewBag.JobDatabase
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
    Dim dateto = "2025-02-28"
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateto = Request.QueryString("DateTo")
    End If
    Dim setIden As Boolean = True
    If Not Request.QueryString("IDEN") Is Nothing Then
        setIden = IIf(Request.QueryString("IDEN") = "Y", True, False)
    End If
    Dim setIdentityON As String = "SET IDENTITY_INSERT Acc_JournalHD ON"
    Dim setIdentityOFF As String = "SET IDENTITY_INSERT Acc_JournalHD OFF"
    If setIden = False Then
        setIdentityON = ""
        setIdentityOFF = ""
    End If
    'Dim cnnStr = "Data Source=.;Initial Catalog=AccConcept;User id=sa;Password='9t;yogm851';Persist Security Info=False"
    'Dim obj = New AccReport.CUtil(cnnStr)
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim msg As String = ""
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
dbo.GetAccConfig('AR_CONFIG','Sales') as AccCode,
h.AccDocNo,h.TotalAmount+h.TotalVat as Debit,0 as Credit,
h.PartyName as AccDesc,h.DocRefNo as RefNo
from vAR_H h
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
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

    sqlAlterView = "
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
	where not rh.CancelProve<>''
) r
group by BranchCode,CustTaxID,CustBranch,CustName,DocNo,ItemNo,SICode,AmtCharge,AmtAdvance,ReceiptNo,ReceiptDate,ReceiptItemNo,Net ,Amt50Tavi
) t
"
    msg &= IIf(obj.ExecuteSQL(sqlAlterView) = "OK", "", vbCrLf & obj.Message)

    Dim sqlHead = "
declare @@datefrom date='{1}';
declare @@dateto date='{2}';
declare @@branchcode varchar(3)='{0}';
"
    Dim sql = sqlHead & "
declare @@payadv float;
declare @@whdcust float;
declare @@whdcomp float;
declare @@netadv float;
--source
select @@payadv =sum(TotalAdvance+Total50Tavi),@@netadv=sum(TotalAdvance),
@@whdcust=sum(WhtCust),@@whdcomp=sum(whtComp)
from
[" + dbName + "].dbo.Job_AdvHeader a
inner join (
select d.BranchCode,d.advNo,sum(case when s.IsCredit=1 then d.Charge50Tavi else 0 end) as whtcust,
sum(case when not isnull(s.IsCredit,0)=1 then d.Charge50Tavi else 0 end) as whtcomp
from [" + dbName + "].dbo.Job_AdvDetail d left join [" + dbName + "].dbo.Job_SrvSingle s on d.SICode=s.SICode
group by d.BranchCode,d.AdvNo
) b on a.BranchCode=b.BranchCode and a.AdvNO=b.AdvNo
where a.BranchCode=@@branchcode and a.DocStatus<>99 and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
select round(@@payadv,2) as DebitPaymentSum,
round(@@whdcomp,2) as CreditWhtComp,
round(@@whdcust,2) as CreditWhtCust,
round(@@netadv,2) as CreditCashOut
"
    sql = String.Format(sql, branch, datefrom, dateto)
    Dim dt = obj.GetDataFromSQL(sql)

    Dim bComplete = obj.IsConnect()
End Code
<h2>@ViewBag.Title</h2>
<div class="container">
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
</div>
<input type="button" onclick="RefreshPage()" value="Show Pre-Process Data" />
<input type="button" onclick="ProcessData()" value="Process Data" />
@If Not bComplete Then
    @msg
Else
    @msg
    @Code
        If obj.Message = "" Then
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If
    End Code
    @<div class="container">
        <b><a href="#" onclick="GetDetailAdv()">Advance Paid from Job System</a></b>
        @If dt.Rows.Count > 0 Then
            @<table>
                <tr>
                    <td>Dr. Advance Paymented&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(0)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. WH-Tax Receivables&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(1)).ToString("#,##0.00")</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. WH-Tax Customers&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(2)).ToString("#,##0.00")</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Petty Cash&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(3)).ToString("#,##0.00")</td>
                </tr>
            </table>
        Else
            @msg
        End If
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @Code
        sql = sqlHead & "
declare @@paynet float;
declare @@unduevatbuy float;
select @@paynet=sum(Amt-AmtDisc),@@unduevatbuy=sum(AmtVat)
from [" + dbName + "].dbo.Job_PaymentDetail d
inner join [" + dbName + "].dbo.Job_PaymentHeader h on
d.BranchCode=h.BranchCode and d.DocNo=h.DocNo
inner join [" + dbName + "].dbo.Job_SrvSingle s on d.SICode=s.SICode
where h.BranchCode=@@branchcode and not h.CancelProve<>''
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

select @@paynet+@@unduevatbuy as CreditDebtSum,@@unduevatbuy as DebitVatBuy,@@paynet as DebitNet
"
        sql = String.Format(sql, branch, datefrom, dateto)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            bComplete = True
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If
    End Code
    @<div class="container">
        <b>Account Payables Setting</b>
        @If dt.Rows.Count > 0 Then
            @<table>
                <tr>
                    <td>Dr. Services Cost&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(2)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Dr. Undue Input Vat&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(1)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Account Payables&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(0)).ToString("#,##0.00")</td>
                </tr>
            </table>
        Else
            @msg

        End If
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @code
        sql = sqlHead & "
select sum(TotalCharge) as TotalCreditIncome,
sum(TotalVat) as TotalCreditVATSale
,sum(TotalCharge)+sum(TotalVat) as TotalDebitService
,sum(TotalAdvance) as TotalDebitAdvance
from [" + dbName + "].dbo.Job_InvoiceHeader h
where h.BranchCode=@@branchcode and not isnull(cancelprove,'')<>''
and DocDate>=@@datefrom and DocDate<=@@dateto
"

        sql = String.Format(sql, branch, datefrom, dateto)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            bComplete = True
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If
    End Code
    @<div class="container">
        <b>Account Receivables Setting</b>
        @If dt.Rows.Count > 0 Then
            @<table>
                <tr>
                    <td>Dr. Advance Receiables&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(3)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Dr. Account Receivables&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(2)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Undue Output Vat&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(1)).ToString("#,##0.00")</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Service Charges&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(0)).ToString("#,##0.00")</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Advance Payment&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(3)).ToString("#,##0.00")</td>
                </tr>
            </table>
        Else
            @msg
        End If
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @Code
        sql = sqlHead & "
declare @@netserv float;
declare @@compwht float;
declare @@rcvserv float;
declare @@rcvadv float;
declare @@rcvap float;
declare @@custwht float;

select @@netserv=sum(ReceiptNet),@@compwht=sum(ReceiptWht),
@@rcvserv=sum(ReceiptNet+ReceiptWht) from vRV_LinkJob where amtCharge>0
and ReceiptDate>=@@datefrom and ReceiptDate<=@@dateto

select @@rcvadv=sum(case when IsFromAdv=1 then ReceiptNet else 0 end),
@@rcvap=sum(case when IsFromAdv=0 then ReceiptNet else 0 end),@@custwht=sum(ReceiptWht)
from vRV_LinkJob where amtAdvance>0
and ReceiptDate>=@@datefrom and ReceiptDate<=@@dateto

select sum(rd.Net) as DebitCal,isnull(@@netserv,0)+isnull(@@rcvadv,0)+isnull(@@rcvap,0)+isnull(@@custwht,0) as DebitCash,@@compwht as DebitWhtComp,
isnull(@@netserv,0)+isnull(@@rcvadv,0)+isnull(@@rcvap,0)+isnull(@@custwht,0)+isnull(@@compwht,0) as DebitSum
,@@rcvserv as CreditServ,@@rcvadv as CreditAdv,@@rcvap as CreditAP,@@custwht as CreditCustWht
from [" + dbName + "].dbo.Job_ReceiptDetail rd
inner join [" + dbName + "].dbo.Job_ReceiptHeader rh
on rd.BranchCode=rh.BranchCode and rd.ReceiptNo=rh.ReceiptNo
where rh.BranchCode=@@branchcode 
and rh.ReceiptDate>=@@datefrom and rh.ReceiptDate<=@@dateto
and not isnull(rh.CancelProve,'')<>''
"
        sql = String.Format(sql, branch, datefrom, dateto)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            bComplete = True
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If

    End Code
    @<div class="container">
        <b>Customer Paymented</b>
        @If dt.Rows.Count > 0 Then
            @<table>
                <tr>
                    <td>Dr. Cash Received&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(1)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Dr. WH-Tax&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(2)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Account Receivables&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(4)).ToString("#,##0.00")</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Advance Receiables&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(5)).ToString("#,##0.00")</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Service Costs&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(obj.GetDouble(dt.Rows(0)(6)) + obj.GetDouble(dt.Rows(0)(7))).ToString("#,##0.00")</td>
                </tr>
            </table>
        Else
            @msg
        End If
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @Code
        sql = sqlHead & "
select
sum(cd.UsedAmount) as DebitSum,
sum(case when a.AdvNO is not null then cd.ChargeVAT else 0 end) as DebitVAT,
sum(case when a.AdvNO is not null then 0 else cd.ChargeVAT end) as DebitVATUndue,
sum(case when a.AdvNO is not null then cd.Tax50Tavi else 0 end) as CreditWHT,
sum(case when a.AdvNO is not null then cd.UsedAmount+cd.ChargeVAT-cd.Tax50Tavi else 0 end) as CreditAdv,
sum(case when a.AdvNO is not null then 0 else cd.UsedAmount+cd.ChargeVAT end) as CreditAP
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.BranchCode=ch.BranchCode and cd.ClrNo=ch.ClrNo
left join [" + dbName + "].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
and cd.BranchCode=a.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
where ch.BranchCode=@@branchcode and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and ch.DocStatus<>99 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')=''
"
        sql = String.Format(sql, branch, datefrom, dateto)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            bComplete = True
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If
    End Code
    @<div class="container">
        <b>Costs</b>
        @If dt.Rows.Count > 0 Then
            @<table>
                <tr>
                    <td>Dr. Service Costs&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(0)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Dr. Input Vat&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(1)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Dr. Undue Input Vat&nbsp;&nbsp;&nbsp;</td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(2)).ToString("#,##0.00")</td>
                    <td></td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Petty Cash&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(obj.GetDouble(dt.Rows(0)(3)) + obj.GetDouble(dt.Rows(0)(4))).ToString("#,##0.00")</td>
                </tr>

                <tr>
                    <td>&nbsp;&nbsp;&nbsp;Cr. Account Payables&nbsp;&nbsp;&nbsp;</td>
                    <td></td>
                    <td style="text-align:right;">@obj.GetDouble(dt.Rows(0)(5)).ToString("#,##0.00")</td>
                </tr>
            </table>
        Else
            @msg
        End If
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
End If
<script type="text/javascript">
    function GetDetailAdv() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?Form=LinkJobAdv&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt;
    }
    function RefreshPage() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href="?Form=LinkJobEN&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt;
    }
    function ProcessData() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?Form=TransferJob&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt +"&Adv=Y&AR=Y&AP=Y&RCV=Y&CST=Y";
    }
</script>