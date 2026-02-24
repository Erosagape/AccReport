@Code
    ViewData("Title") = "ReportJob"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim bPost As Boolean = False
    Dim dt As New Data.DataTable
    Dim dtSum As New Data.DataTable
    Dim dtTrans As New Data.DataTable
    Dim JobNo As String = ""
    Dim sql As String = "
select JournalNo,EntryDate,AccCode,AccName,AccDesc,
sum(Debit) as Debit,sum(Credit) as Credit
from vJournal_All where AccRemark='{0}'
group by EntryDate,JournalNo,AccCode,AccName,AccDesc
order by EntryDate,JournalNo,6 DESC,7
"
    Dim sqlSum As String = "
select * from (
select AccCode,AccName,
sum(Debit) as Debit,sum(Credit) as Credit,
(case when Sum(Debit)>Sum(Credit) then Sum(Debit)-Sum(Credit) else 0 end) as BalDebit,
(case when Sum(Debit)<Sum(Credit) then Sum(Credit)-Sum(Debit) else 0 end) as BalCredit
from vJournal_All where AccRemark='{0}'
group by AccCode,AccName
union all
select b.AccCode,b.AccName,
sum(Debit) as Debit,sum(Credit) as Credit,
(case when Sum(Debit)>Sum(Credit) then Sum(Debit)-Sum(Credit) else 0 end) as BalDebit,
(case when Sum(Debit)<Sum(Credit) then Sum(Credit)-Sum(Debit) else 0 end) as BalCredit
from vJournal_All a,vMas_AccCode b 
where AccRemark='ES25080169' and b.AccCode=dbo.GetAccConfig('GL_CONFIG','ProfitLoss')
and substring(a.AccCode,1,1)>='4' and substring(a.AccCode,1,1)<='5'
group by b.AccCode,b.AccName
) t
"
    Dim sqlTrans As String = "
select AccDocType,TName as AccDocTypeName,ProductName,
sum(Amount) as AMT,sum(DVatAmt) as VAT,sum(DWhtAmt) as WHT,sum(DNetAmt) as NET
from vTransaction_All inner join Mas_DocConfig on AccDocType=Category
where SalesDescription='{0}'
group by AccDocType,TName,ProductName 
"
    If Not Request.Form("JobNo") Is Nothing Then
        bPost = True
        JobNo = Request.Form("JobNo")
        dt = obj.GetDataFromSQL(String.Format(sql, JobNo))
        dtSum = obj.GetDataFromSQL(String.Format(sqlSum, JobNo))
        dtTrans = obj.GetDataFromSQL(String.Format(sqlTrans, JobNo))
    End If
End Code

<h2>Report Posting Data By Job</h2>
<form method="post" action="">
    <input type="text" id="txtJNo" name="JobNo" value="@JobNo" />
    <input type="submit" value="Show Posted Data" />
    <table id="tbJournal" border="1" style="border-collapse:collapse;border-style:solid;border-width:thin">
        @If dt.Rows.Count > 0 Then
            @<thead>
                <tr>
                    <th>Doc.No#</th>
                    <th>Doc.Date</th>
                    <th>Acc.Code</th>
                    <th>Acc.Name</th>
                    <th>Debit</th>
                    <th>Credit</th>
                    <th>Remark</th>
                </tr>
            </thead>
            @<tbody>
                @For each dr As Data.DataRow in dt.Rows
                    @<tr>
                        <td>
                            @dr("JournalNo").ToString()
                        </td>
                        <td>
                            @Convert.ToDateTime(dr("EntryDate")).ToString("dd/MM/yyyy")
                        </td>
                        <td>
                            @dr("AccCode").ToString()
                        </td>
                        <td>
                            @dr("AccName").ToString()
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("Debit")).ToString("#,###,##0.00")
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("Credit")).ToString("#,###,##0.00")
                        </td>
                        <td>
                            @dr("AccDesc").ToString()
                        </td>
                    </tr>
                Next
            </tbody>
        End If
    </table>
    @If bPost Then
        @<b>Balance</b>
    End If
    <table id="tbSum" border="1" style="border-collapse:collapse;border-style:solid;border-width:thin">
        @If dtSum.Rows.Count > 0 Then
            @<thead>
                <tr>
                    <th rowspan="2">Acc.Code</th>
                    <th rowspan="2">Acc.Name</th>
                    <th colspan="2">Movement</th>
                    <th colspan="2">Balance</th>
                </tr>
                <tr>
                    <th>Debit</th>
                    <th>Credit</th>
                    <th>Debit</th>
                    <th>Credit</th>
                </tr>
            </thead>
            @<tbody>
                @For each dr As Data.DataRow In dtSum.Rows
                    @<tr>
                        <td>
                            @dr("AccCode").ToString()
                        </td>
                        <td>
                            @dr("AccName").ToString()
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("Debit")).ToString("#,###,##0.00")
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("Credit")).ToString("#,###,##0.00")
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("BalDebit")).ToString("#,###,##0.00")
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("BalCredit")).ToString("#,###,##0.00")
                        </td>
                    </tr>
                Next
            </tbody>
        End If
    </table>
    @If bPost Then
        @<b>Transaction Lists</b>
    End If
    <table id="tbTrans" border="1" style="border-collapse:collapse;border-style:solid;border-width:thin">
        @If dtTrans.Rows.Count > 0 Then
            Dim chk As String = ""
            @<thead>
                <tr>
                    <th>Description</th>
                    <th>AMT</th>
                    <th>VAT</th>
                    <th>WHT</th>
                    <th>NET</th>
                </tr>
            </thead>
            @<tbody>
                @For each dr As Data.DataRow In dtTrans.Rows
                    If chk <> dr("AccDocType").ToString() Then
                        @<tr>
                             <td colspan="5"><b>@dr("AccDocType").ToString() / @dr("AccDocTypeName").ToString()</b></td>
                         </tr>
                        chk = dr("AccDocType").ToString()
                    End If
                    @<tr>
                        <td>
                            @dr("ProductName").ToString()
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("AMT")).ToString("#,###,##0.00")
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("VAT")).ToString("#,###,##0.00")
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("WHT")).ToString("#,###,##0.00")
                        </td>
                        <td style="text-align:right">
                            @Convert.ToDouble(dr("NET")).ToString("#,###,##0.00")
                        </td>
                    </tr>
                Next
            </tbody>
        End If
    </table>
</form>

