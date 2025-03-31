@Code
    ViewData("Title") = "Transfer Job"
    Dim dbName = "job_ace"
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
    'Dim cnnStr = "Data Source=.;Initial Catalog=AccConcept;User id=sa;Password='9t;yogm851';Persist Security Info=False"
    'Dim obj = New AccReport.CUtil(cnnStr)
    Dim obj = New AccReport.CUtil()
    Dim msg As String = ""
    Dim bConn = obj.IsConnect()
End Code
<h2>Transfer Job</h2>
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
            <div class="col">
                <input type="button" onclick="RefreshPage()" value="Submit" />
            </div>
        </div>
    </div>
    Dim userid = "ADMIN"
    Dim sqlHead = "
declare @@datefrom date='{1}';
declare @@dateto date='{2}';
declare @@branchcode varchar(3)='{0}';
declare @@userid varchar(10)='" + userid + "';
declare @@maxid int;
"
    'Sync Master File
    Dim sql = "EXEC dbo.Insert_ProductsCodeFromJob"
    msg = obj.ExecuteSQL(sql)
    @<ul>
        <li>Sync Master File @msg</li>
    </ul>
    'process advance
    sql = sqlHead & "
delete c
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on a.AdvNo=b.JournalNo
inner join Acc_JournalDT c on b.EntryID=c.EntryID
where a.BranchCode=@@branchcode and a.DocStatus<>99
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto

delete b
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on a.AdvNo=b.JournalNo
where a.BranchCode=@@branchcode and a.DocStatus<>99
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
"
    sql = String.Format(sql, branch, datefrom, dateto)
    msg = obj.ExecuteSQL(sql)
    @<ul>
        <li>Delete Old Advance Imported @msg</li>
    </ul>

    sql = sqlHead & "
set @@maxid=(SELECT isnull(MAX(EntryId),0) from Acc_JournalHD);

SET IDENTITY_INSERT Acc_JournalHD ON

insert into Acc_JournalHD (EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select
ROW_NUMBER() OVER(ORDER BY a.AdvNo)+@@maxid as EntryID,
a.AdvNO as JournalNo,
a.AdvDate as EntryDate,
a.PaymentDate as EffectiveDate,
@@userid,a.PaymentRef,(a.TotalAdvance+a.Total50Tavi),(a.TotalAdvance+a.Total50Tavi)
from [" + dbName + "].dbo.Job_AdvHeader a
where a.DocStatus<>99 and  a.BranchCode=@@branchcode
and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
and a.AdvNo not in(select JournalNo FROM Acc_JournalHD)
order by a.AdvNo

SET IDENTITY_INSERT Acc_JournalHD OFF

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
select b.AdvNo,b.PaymentDate,a.AccCode,c.SDescription,c.ForJNo as AccDesc,0 as Debit,c.AdvNet as Credit
from [" + dbName + "].dbo.Job_AdvHeader b inner join [" + dbName + "].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
,Mas_AccCode a
where b.BranchCode=@@branchcode and b.DocStatus<>99
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
union all
--Cr. หัก ณ ที่จ่ายในนามลูกค้า
select b.AdvNo,b.PaymentDate,a.AccCode,c.SDescription,concat(isnull(e.NameThai,b.CustCode),' #',b.Doc50Tavi) as AccDesc,0 as Debit,c.Charge50Tavi as Credit
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
select b.AdvNo,b.PaymentDate,a.AccCode,c.SDescription,concat(isnull(e.TName,c.VenCode),' #',b.Doc50Tavi) as AccDesc,0 as Debit,c.Charge50Tavi as Credit
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
"
    sql = String.Format(sql, branch, datefrom, dateto)
    msg = obj.ExecuteSQL(sql)
    @<ul>
        <li>Process Advance Data @msg</li>
    </ul>
End If

<script type="text/javascript">
    function RefreshPage() {
        var br = document.getElementById('txtBranch').value;
        var db = document.getElementById('txtDatabase').value;
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?Form=TransferJob&DB=" + db + "&Branch=" + br + "&DateFrom=" + df + "&DateTo=" + dt;
    }
</script>
