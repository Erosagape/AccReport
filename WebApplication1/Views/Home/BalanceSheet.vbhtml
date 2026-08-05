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
    Dim mode As Int16 = 0
    If Not Request.QueryString("Mode") Is Nothing Then
        mode = Convert.ToInt16(Request.QueryString("Mode"))
    End If
    Dim dateFrom = New Date(yy, 1, 1).ToString("yyyy-MM-dd")
    Dim dateTo = DateAdd("d", -1, New Date(yy + 1, 1, 1)).ToString("yyyy-MM-dd")
    Dim sql = "EXEC dbo.GetBalanceSheetCompare_V2 {0},{1}"
    Dim sumDebit1 As Double = 0
    Dim sumCredit1 As Double = 0
    Dim sumDebit2 As Double = 0
    Dim sumCredit2 As Double = 0
    Dim sumDebit3 As Double = 0
    Dim sumCredit3 As Double = 0
    Dim dt = obj.GetDataFromSQL(String.Format(sql, yy, mode))
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
    Dim modeString As String = ""
    Select Case mode
        Case 0
            modeString = If(lang = "TH", "แบบแสดงบัญชีย่อย", "Detail")
        Case 1
            modeString = If(lang = "TH", "แบบสรุป", "Summary")
        Case 2
            modeString = If(lang = "TH", "แบบแสดงบัญชีหลัก", "For Main Account")
        Case 3
            modeString = If(lang = "TH", "แบบแสดงบัญชีคุม", "For Control Account")
    End Select
End Code
@If lang = "EN" Then
    @<a href="#" onclick="SwitchMode()"><h2>Balance Sheet (@modeString)</h2></a>
    @If yy <> "" Then
        @<b>Fiscal Year @(Convert.ToInt32(yy))</b>
    End If
Else
    @<a href="#" onclick="SwitchMode()"><h2>งบแสดงสถานะทางการเงิน (@modeString)</h2></a>
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
    function SwitchMode() {
        var mode = Number('@mode');
        mode++;
        if (mode > 3) {
            mode = 0;
        }
        window.location.href = "?Form=BalanceSheet&SRC=@dbSource&DB=@dbName&Period=@yy&Mode=" + mode + "&LANG=@lang";
    }
    function PrintGL(accCode) {
        window.location.href = "?Form=GeneralLedger&SRC=@dbSource&DB=@dbName&Code=" + accCode + "&DateFrom=@dateFrom&DateTo=@dateTo";
    }
</script>