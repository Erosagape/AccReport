@Code
    ViewData("Title") = "CheckJob"
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
    Dim dateto = DateAdd("d", -1, New Date(DateTime.Now.Year + 1, 1, 1)).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateto = Request.QueryString("DateTo")
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

    Dim sqlHead = "
declare @@datefrom date='{1}';
declare @@dateto date='{2}';
declare @@branchcode varchar(3)='{0}';
"
    Dim sql = ""
End Code
<h2>Check data after posted</h2>
@If Not bConn Then
    @<div class="container">
        Cannot connect Database
    </div>
Else
    sql = sqlHead & "
select a.AdvNo,round(b.TotalDebit,2),round(b.TotalCredit,2),round(a.TotalAdvance+a.Total50Tavi,2) as TotalAdvance,
format(a.TotalAdvance+a.Total50Tavi,'0.00'),format(isnull(b.TotalDebit,0),'0.00')
from [" + dbName + "].dbo.Job_AdvHeader a left join Acc_JournalHD b
on a.AdvNo=b.JournalNo
where a.BranchCode=@@branchcode and format(a.TotalAdvance+a.Total50Tavi,'0.00')<>format(isnull(b.TotalDebit,0),'0.00')
and a.DocStatus<>99 and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
"
    sql = String.Format(sql, branch, datefrom, dateto)
    Dim dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Advance slip failed to post</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName)</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    sql = sqlHead & "
select c.AccCode,d.AccName,sum(c.Debit) as Debit,sum(c.Credit) as Credit
from [" + dbName + "].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on a.AdvNo=b.JournalNo
inner join Acc_JournalDT c
on b.EntryId=c.EntryId
inner join Mas_AccCode d on c.AccCode=d.AccCode
where a.BranchCode=@@branchcode
and a.DocStatus<>99 and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
group by c.AccCode,d.AccName order by c.AccCode
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Advance slip posted</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName) &nbsp;&nbsp;&nbsp;</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    'pay-in not transfer completely
    sql = sqlHead & "
select a.DocNo,
b.TotalDebit as TotalDebit,
b.TotalCredit as TotalCredit,
c.TotalExpense,b.TotalCredit-c.TotalExpense as Diff
from [" + dbName + "].dbo.Job_PaymentHeader a left join Acc_JournalHD b
on a.DocNo=b.JournalNo
inner join
(
select c.BranchCode,c.DocNo,sum(c.Amt-c.AmtDisc+c.AmtVAT) as TotalExpense
from [" + dbName + "].dbo.Job_PaymentDetail c
inner join [" + dbName + "].dbo.Job_SrvSingle s
on c.SICode=s.SICode
group by c.BranchCode,c.DocNo
) c on a.BranchCode=c.BranchCode and a.DocNo=c.DocNo
where a.BranchCode=@@branchcode and not isnull(a.CancelProve,'')<>''
and a.DocDate>=@@datefrom and a.DocDate<=@@dateto
and format(c.TotalExpense,'0.00')<>format(isnull(b.TotalCredit,0),'0.00')
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Pay-in slip failed to post</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName)</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    'payin completed
    sql = sqlHead & "
select c.AccCode,d.AccName,sum(c.Debit) as Debit,sum(c.Credit) as Credit
from [" + dbName + "].dbo.Job_PaymentHeader a inner join Acc_JournalHD b
on a.DocNo=b.JournalNo
inner join Acc_JournalDT c
on b.EntryId=c.EntryId
inner join Mas_AccCode d on c.AccCode=d.AccCode
where a.BranchCode=@@branchcode and not isnull(a.CancelProve,'')<>''
and a.DocDate>=@@datefrom and a.DocDate<=@@dateto
group by c.AccCode,d.AccName order by c.AccCode
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Pay-in slip posted</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName) &nbsp;&nbsp;&nbsp;</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    sql = sqlHead & "
select a.*,b.TotalAmt from (
select DocNo,h.BillToCustCode,NameThai,
TotalCharge,TotalAdvance
from [" + dbName + "].dbo.Job_InvoiceHeader h
left join [" + dbName + "].dbo.Mas_Company c
on h.BillToCustCode=c.CustCode and h.BillToCustBranch=c.Branch
where h.BranchCode=@@branchcode and not isnull(cancelprove,'')<>''
and DocDate>=@@datefrom and DocDate<=@@dateto
) a left join
(
select accdocno,sum(Amount) TotalAmt from vTransaction_All
where AccDocType='SI'
group by accdocno
) b
on a.DocNo=b.AccDocNo
where round(a.TotalCharge+a.TotalAdvance,3)-round(b.TotalAmt,3)<>0 or b.accdocno is null
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Invoice failed to post</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName)</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    sql = sqlHead & "
select c.AccCode,d.AccName,sum(c.Debit) as Debit,sum(c.Credit) as Credit
from [" + dbName + "].dbo.Job_InvoiceHeader a inner join Acc_JournalHD b
on a.DocNo=b.JournalNo
inner join Acc_JournalDT c
on b.EntryId=c.EntryId
inner join Mas_AccCode d on c.AccCode=d.AccCode
where a.BranchCode=@@branchcode and not isnull(a.CancelProve,'')<>''
and a.DocDate>=@@datefrom and a.DocDate<=@@dateto
group by c.AccCode,d.AccName order by c.AccCode
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Invoice posted</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName) &nbsp;&nbsp;&nbsp;</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    sql = sqlHead & "
select a.*,b.TotalDebit,b.TotalCredit from
(
select rh.ReceiptNo,sum(rd.Net) as TotalReceipt
from [" + dbName + "].dbo.Job_ReceiptDetail rd
inner join [" + dbName + "].dbo.Job_ReceiptHeader rh
on rd.BranchCode=rh.BranchCode and rd.ReceiptNo=rh.ReceiptNo
where rh.BranchCode=@@branchcode and not isnull(rh.CancelProve,'')<>''
and rh.ReceiptDate>=@@datefrom and rh.ReceiptDate<=@@dateto
group by rh.ReceiptNo
) a left join Acc_JournalHD b on a.ReceiptNo=b.JournalNo
where FORMAT(a.TotalReceipt,'0.00')<>FORMAT(b.TotalDebit,'0.00') or b.JournalNo is null
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Receipt failed to post</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName) &nbsp;&nbsp;&nbsp;</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    sql = sqlHead & "
select c.AccCode,d.AccName,sum(c.Debit) as Debit,sum(c.Credit) as Credit
from [" + dbName + "].dbo.Job_ReceiptHeader a inner join Acc_JournalHD b
on a.ReceiptNo=b.JournalNo
inner join Acc_JournalDT c
on b.EntryId=c.EntryId
inner join Mas_AccCode d on c.AccCode=d.AccCode
where a.BranchCode=@@branchcode and not isnull(a.CancelProve,'')<>''
and a.ReceiptDate>=@@datefrom and a.ReceiptDate<=@@dateto
group by c.AccCode,d.AccName order by c.AccCode
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Receipt posted</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName) &nbsp;&nbsp;&nbsp;</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    sql = sqlHead & "
    select h.*,d.TotalDebit,d.TotalCredit from (
        select cd.ClrNo,sum(cd.UsedAmount+cd.ChargeVAT) as TotalCost
        from [" + dbName + "].dbo.Job_ClearDetail cd
        inner join [" + dbName + "].dbo.Job_ClearHeader ch
        on cd.BranchCode=ch.BranchCode and cd.ClrNo=ch.ClrNo
        left join [" + dbName + "].dbo.Job_AdvDetail a
        on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
        and cd.BranchCode=a.BranchCode
        inner join [" + dbName + "].dbo.Job_SrvSingle s
        on cd.SICode=s.SICode
        inner join vMas_Product p
        on cd.SICode=p.ProductCode
        where ch.BranchCode=@@branchcode
        and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
        and ch.DocStatus<>99 and s.IsExpense=1
        and isnull(cd.VenderbillingNo,'')=''
        group by cd.ClrNo
    ) h left join ( 
        select JournalNo,sum(TotalDebit) as TotalDebit,sum(TotalCredit) as TotalCredit
        from Acc_JournalHD 
        group by JournalNo
    ) d
    on h.ClrNo=d.JournalNo
    where FORMAT(h.TotalCost,'0.00')<>FORMAT(d.TotalDebit,'0.00')
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Costing input failed to post</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName) &nbsp;&nbsp;&nbsp;</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
    sql = sqlHead & "
select c.AccCode,d.AccName,sum(c.Debit) as Debit,sum(c.Credit) as Credit
from [" + dbName + "].dbo.Job_ClearHeader a inner join Acc_JournalHD b
on a.ClrNo=b.JournalNo
inner join Acc_JournalDT c
on b.EntryId=c.EntryId
inner join Mas_AccCode d on c.AccCode=d.AccCode
where a.BranchCode=@@branchcode and not isnull(a.CancelProve,'')<>''
and a.ClrDate>=@@datefrom and a.ClrDate<=@@dateto
group by c.AccCode,d.AccName order by c.AccCode
"
    sql = String.Format(sql, branch, datefrom, dateto)
    dt = obj.GetDataFromSQL(sql)
    If obj.Message = "" And dt.Rows.Count > 0 Then
        @<div>
            <b>Costing posted</b>
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
                                    If Not obj.IsDouble(dr(dc.ColumnName)) Then
                                        @<td>@dr(dc.ColumnName) &nbsp;&nbsp;&nbsp;</td>
                                    Else
                                        @<td style="text-align:right;">@obj.GetDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                    End If
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
End If

