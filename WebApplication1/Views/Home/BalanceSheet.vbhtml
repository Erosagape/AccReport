<style>
    #topMenu {
        display: none;
    }
</style>
@Code
    Layout = "~/Views/Shared/A4.vbhtml"
    ViewData("Title") = "Balance Sheet"
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
    Dim sql = "EXEC dbo.GetBalanceSheetCompare {0}"
    Dim sumDebit1 = 0
    Dim sumCredit1 = 0
    Dim sumDebit2 = 0
    Dim sumCredit2 = 0
    Dim sumDebit3 = 0
    Dim sumCredit3 = 0
    Dim dt = obj.GetDataFromSQL(String.Format(sql, yy))
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
End Code
@If lang = "EN" Then
    @<h2>Balance Sheet</h2>
    @If yy <> "" Then
        @<b>Fiscal Year @(Convert.ToInt32(yy))</b>
    End If
Else
    @<h2>งบแสดงสถานะทางการเงิน</h2>
    @If yy <> "" Then
        @<b>ประจำปี @(Convert.ToInt32(yy) + 543)</b>
    End If
End If
<table border="1" style="border-collapse:collapse;border-style:solid;">
    <thead>
        @If lang = "EN" Then
            @<tr>
                <th rowspan="2"> Acc.Code</th>
                <th rowspan="2"> Acc.Name</th>
                <th colspan="2"> @(Convert.ToInt32(yy) - 1)</th>
                <th colspan="2"> Change</th>
                <th colspan="2"> @(Convert.ToInt32(yy))</th>
            </tr>
        Else
            @<tr>
                <th rowspan="2">เลขที่บัญชี</th>
                <th rowspan="2">ชื่อบัญชี</th>
                <th colspan="2">@(Convert.ToInt32(yy) + 542)</th>
                <th colspan="2">เปลี่ยนแปลง</th>
                <th colspan="2">@(Convert.ToInt32(yy) + 543)</th>
            </tr>
        End If
        <tr>
            <th>Debit</th>
            <th>Credit</th>
            <th>Debit</th>
            <th>Credit</th>
            <th>Debit</th>
            <th>Credit</th>
        </tr>
    </thead>
    <tbody>
        @For Each dr In dt.Rows
            sumDebit1 += obj.GetDouble(dr("LastDr"))
            sumCredit1 += obj.GetDouble(dr("LastCr"))
            sumDebit2 += obj.GetDouble(dr("ChangeDr"))
            sumCredit2 += obj.GetDouble(dr("ChangeCr"))
            sumDebit3 += obj.GetDouble(dr("CurrentDr"))
            sumCredit3 += obj.GetDouble(dr("CurrentCr"))
            @<tr>
    <td>
        <a href="#" onclick="PrintGL('@dr("AccCode").ToString()')">@dr("AccCode").ToString()</a>
    </td>
    <td>@dr("AccName").ToString()</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("LastDr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("LastCr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("ChangeDr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("ChangeCr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("CurrentDr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("CurrentCr")).ToString("#,##0.00")</td>
</tr>
        Next
    </tbody>
    <tfoot>
        <tr>
            <td colspan="2">TOTAL</td>
            <td style="text-align:right;">@sumDebit1.ToString("#,##0.00")</td>
            <td style="text-align:right;">@sumCredit1.ToString("#,##0.00")</td>
            <td style="text-align:right;">@sumDebit2.ToString("#,##0.00")</td>
            <td style="text-align:right;">@sumCredit2.ToString("#,##0.00")</td>
            <td style="text-align:right;">@sumDebit3.ToString("#,##0.00")</td>
            <td style="text-align:right;">@sumCredit3.ToString("#,##0.00")</td>
        </tr>
    </tfoot>
</table>
<script type="text/javascript">
    function PrintGL(accCode) {
        window.location.href = "?Form=GeneralLedger&SRC=@dbSource&DB=@dbName&Code=" + accCode + "&DateFrom=@dateFrom&DateTo=@dateTo";
    }
</script>