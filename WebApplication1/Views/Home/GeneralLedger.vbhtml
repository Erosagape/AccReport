<style>
    #topMenu {
        display: none;
    }

    td {
        padding: 5px 5px 5px 5px;
    }
</style>
@Html.Partial("~/Views/Shared/ReportHeader.vbhtml")
@Code
    ViewData("Title") = "General Ledger"
    Dim accCode As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        accCode = Request.QueryString("Code")
    End If
    Dim lang = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    Dim dateTo = DateAdd("d", -1, New Date(DateTime.Now.Year, Now.Month + 1, 1))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If
    Dim typereport As String = "N"
    If Not Request.QueryString("SUM") Is Nothing Then
        typereport = Request.QueryString("SUM")
    End If
    Dim sql As String = String.Format("EXEC dbo.Generate_ReportGL '{0}','{1}','{2}'", accCode, dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"))
    'Dim cnnStr = "Data Source=.;Initial Catalog=AccConcept;User id=sa;Password='9t;yogm851';Persist Security Info=False"
    'Dim obj = New AccReport.CUtil(cnnStr)
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim dt = obj.GetDataFromSQL(sql)
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
        If typereport = "Y" Then
            sql = "select *,ABS(SUM(CASE WHEN JournalNo<>'-' THEN Debit-Credit ELSE 0 END) OVER(PARTITION BY AccCode ORDER BY ItemNo)) as Balance
from (
SELECT *,ROW_NUMBER() OVER (order by AccCode) as ItemNo FROM (
select 0 as Lvl,JournalNo,AccCode,AccName,sum(debit) as Debit,sum(Credit) as Credit from Acc_TempGL
where JournalNo=''
group by JournalNo,AccCode,AccName
union all
select 1 as Lvl,JournalNo,AccCode,AccName,sum(debit) as Debit,sum(Credit) as Credit from Acc_TempGL
where JournalNo NOT IN('-','')
group by JournalNo,AccCode,AccName
union all
select 2 as Lvl,JournalNo,AccCode,AccName,sum(debit) as Debit,sum(Credit) as Credit from Acc_TempGL
where JournalNo='-'
group by JournalNo,AccCode,AccName
) t
) src"
            dt = obj.GetDataFromSQL(sql)
        End If
    Else
        msg = obj.Message
    End If
    Dim i = 0
    Dim prevBal As Double = 0
    Dim nextBal As Double = 0
    Dim moveBal As Double = 0
    Dim sumDebit As Double = 0
    Dim sumCredit As Double = 0
    Dim groupVal As String = ""
End Code
@If lang = "EN" Then
    @<h3>General Ledger (<a onclick="ToggleSummary('@typereport')">@IIf(typereport = "Y", "Summary", "Detailed")</a>)</h3>
    @<h4>Account Code @accCode From @DateAdd("yyyy", 0, dateFrom).ToString("dd/MM/yyyy") To @DateAdd("yyyy", 0, dateTo).ToString("dd/MM/yyyy") </h4>

Else
    @<h3>แยกประเภททั่วไป (<a onclick="ToggleSummary('@typereport')">@IIf(typereport = "Y", "แบบสรป", "แบบละเอียด")</a>)</h3>
    @<h4>รหัสบัญชี @accCode ระหว่างวันที่ @DateAdd("yyyy", 543, dateFrom).ToString("dd/MM/yyyy") ถึงวันที่ @DateAdd("yyyy", 543, dateTo).ToString("dd/MM/yyyy") </h4>

End If

<div>
    <table border="1" style="border-collapse:collapse;border-style:solid;">
        <thead>
            <tr>
                <th>#</th>
                @If typereport <> "Y" Then
                    @<th>Date</th>
                    @<th>Ref#</th>
                    @<th>Description</th>
                Else
                    @<th>Ref#</th>
                End If
                <th>Debit</th>
                <th>Credit</th>
                <th>Balance</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr In dt.Rows
                If typereport <> "Y" Then
                    If i = 0 Then
                        @<tr style="font-weight:bold;">
                            <td colspan="2">@dt.Rows(i)("AccCode").ToString()</td>
                            <td colspan="5">@dt.Rows(i)("AccName").ToString()</td>
                        </tr>
                        prevBal = obj.GetDouble(dr("Balance"))
                    End If
                    i += 1
                    If groupVal <> dr("JournalNo") Then
                        @<tr style="font-style:italic;font-weight:bold;">
                             <td colspan="7">
                                 @If String.Concat(dr("JournalNo").ToString(), "XX").Substring(0, 2) = "RV" Then
                                     @<a href="~/Form?Form=FormRV&SRC=@dbSource&DB=@dbname&Code=@dr("JournalNo")">@dr("JournalNo")</a>
                                 Else
                                     If String.Concat(dr("JournalNo").ToString(), "XX").Substring(0, 2) = "PV" Then
                                         @<a href="~/Form?Form=FormPV&SRC=@dbSource&DB=@dbname&Code=@dr("JournalNo")">@dr("JournalNo")</a>
                                     Else
                                         If dr("JournalNo").ToString().Length > 8 Then
                                             @<a href="~/Form?Form=FormGL&SRC=@dbSource&DB=@dbname&Code=@dr("JournalNo")">@dr("JournalNo")</a>
                                         Else
                                             @dr("JournalNo")
                                         End If
                                     End If
                                 End If
                             </td>
                        </tr>
                        groupVal = dr("JournalNo")
                    End If
                    If i = dt.Rows.Count Then
                        nextBal = obj.GetDouble(dr("Balance"))
                        moveBal = nextBal - prevBal
                        @<tr style="font-weight:bold">
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>TOTAL</td>
                            <td style="text-align:right;">@sumDebit.ToString("#,##0.00")</td>
                            <td style="text-align:right;">@sumCredit.ToString("#,##0.00")</td>
                            <td style="text-align:right;">@moveBal.ToString("#,##0.00")</td>
                        </tr>
                        @<tr style="font-weight:bold">
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>@dr("AccDesc").ToString()</td>
                            <td style="text-align:right;">@Convert.ToDouble(dr("Debit")).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@Convert.ToDouble(dr("Credit")).ToString("#,##0.00")</td>
                            <td style="text-align:right;"></td>
                        </tr>
                    Else
                        If i >= 1 Then
                            sumDebit += obj.GetDouble(dr("Debit"))
                            sumCredit += obj.GetDouble(dr("Credit"))
                        End If
                        @<tr>
                            <td>@i</td>
                            <td>@Convert.ToDateTime(dr("EffectiveDate")).ToString("dd/MM/yyyy")</td>
                            <td>@dr("AccDesc").ToString()</td>
                            <td>@dr("AccRemark").ToString()</td>
                            <td style="text-align:right;">@Convert.ToDouble(dr("Debit")).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@Convert.ToDouble(dr("Credit")).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@Convert.ToDouble(dr("Balance")).ToString("#,##0.00")</td>
                        </tr>
                    End If
                Else
                    If i = 0 Then
                        @<tr style="font-weight:bold;">
                            <td>@dt.Rows(i)("AccCode").ToString()</td>
                            <td colspan="4">@dt.Rows(i)("AccName").ToString()</td>
                        </tr>
                        prevBal = obj.GetDouble(dr("Balance"))
                    End If
                    i += 1
                    If i >= 1 Then
                        sumDebit += obj.GetDouble(dr("Debit"))
                        sumCredit += obj.GetDouble(dr("Credit"))
                    End If
                    @<tr>
                        <td>@i</td>
                        <td>
                            @If String.Concat(dr("JournalNo").ToString(), "XX").Substring(0, 2) = "RV" Then
                                @<a href="~/Form?Form=FormRV&SRC=@dbSource&DB=@dbname&Code=@dr("JournalNo")">@dr("JournalNo")</a>
                            Else
                                If String.Concat(dr("JournalNo").ToString(), "XX").Substring(0, 2) = "PV" Then
                                    @<a href="~/Form?Form=FormPV&SRC=@dbSource&DB=@dbname&Code=@dr("JournalNo")">@dr("JournalNo")</a>
                                Else
                                    If dr("JournalNo").ToString().Length > 8 Then
                                        @<a href="~/Form?Form=FormGL&SRC=@dbSource&DB=@dbname&Code=@dr("JournalNo")">@dr("JournalNo")</a>
                                    Else
                                        @dr("JournalNo")
                                    End If
                                End If
                            End If
                        </td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Debit")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Credit")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Balance")).ToString("#,##0.00")</td>
                    </tr>
                End If
            Next
        </tbody>
    </table>
</div>
@msg Rows Reported
<script type="text/javascript">
    function ToggleSummary(b) {
        if (b == 'Y') {
            updateQueryStringParam('SUM', 'N');
        } else {
            updateQueryStringParam('SUM', 'Y');
        }
        window.location = window.location.href;
    }
    function updateQueryStringParam(key, value) {
        // 1. Create a URL object from the current window location
        const url = new URL(window.location.href);

        // 2. Use the URLSearchParams.set() method to set the new value
        // This will overwrite the parameter if it exists, or create it if it doesn't.
        url.searchParams.set(key, value);

        // 3. Update the browser's address bar using History.replaceState()
        // This changes the URL without reloading the page.
        window.history.replaceState(null, null, url.toString());
    }
</script>
