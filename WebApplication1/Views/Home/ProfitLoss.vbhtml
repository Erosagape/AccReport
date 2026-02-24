<style>
    #topMenu {
        display: none;
    }
</style>
@Code
    Layout = "~/Views/Shared/A4.vbhtml"
    ViewData("Title") = "Profit and Loss"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim lang = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
    End If
    Dim yy As String = DateTime.Now.Year().ToString()
    If Not Request.QueryString("Period") Is Nothing Then
        yy = Request.QueryString("Period")
    End If
    Dim dateFrom = New Date(yy, 1, 1).ToString("yyyy-MM-dd")
    Dim dateTo = DateAdd("d", -1, New Date(yy + 1, 1, 1)).ToString("yyyy-MM-dd")
    Dim sql = "
select AccCode,AccName,
(case when sum(Debit)>=sum(credit) then sum(Debit)-sum(Credit) else 0 end) as Dr,
(case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end) as Cr
from vProfitLoss {0}
group by AccCode,AccName order by AccCode
"
    Dim sqlw = ""
    If yy <> "" Then
        sqlw += String.Format(" WHERE Period='{0}'", yy)
    End If
    Dim sumDebit = 0
    Dim sumCredit = 0

    Dim dt = obj.GetDataFromSQL(String.Format(sql, sqlw))
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
End Code
@If lang = "EN" Then
    @<h2>Profit and Loss</h2>
    @If yy <> "" Then
        @<b>Fiscal Year @(Convert.ToInt32(yy))</b>
    End If
Else
    @<h2>งบกำไรขาดทุน</h2>
    @If yy <> "" Then
        @<b>ประจำปี @(Convert.ToInt32(yy) + 543)</b>
    End If
End If
<table border="1" style="border-collapse:collapse;border-style:solid;">
    <thead>
        <tr>
            <th>Acc.Code</th>
            <th>Acc.Name</th>
            <th>Debit</th>
            <th>Credit</th>
        </tr>
    </thead>
    <tbody>
        @For Each dr In dt.Rows
            sumDebit += obj.GetDouble(dr("Dr"))
            sumCredit += obj.GetDouble(dr("Cr"))
            @<tr>
                <td>
                    <a href="#" onclick="PrintGL('@dr("AccCode").ToString()')">@dr("AccCode").ToString()</a>
                </td>
                <td>@dr("AccName").ToString()</td>
                <td style="text-align:right;">@Convert.ToDouble(dr("Dr")).ToString("#,##0.00")</td>
                <td style="text-align:right;">@Convert.ToDouble(dr("Cr")).ToString("#,##0.00")</td>
            </tr>
        Next
    </tbody>
    <tfoot>
        <tr>
            <td colspan="2">TOTAL</td>
            <td style="text-align:right;">@sumDebit.ToString("#,##0.00")</td>
            <td style="text-align:right;">@sumCredit.ToString("#,##0.00")</td>
        </tr>
    </tfoot>
</table>
@msg
<script type="text/javascript">
    function PrintGL(accCode) {
        window.location.href = "?Form=GeneralLedger&SRC=@dbSource&DB=@dbName&Code=" + accCode + "&DateFrom=@dateFrom&DateTo=@dateTo";
    }
</script>