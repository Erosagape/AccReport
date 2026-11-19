<style>
    #topMenu {
        display: none;
    }
</style>
@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Trial Balance"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim yy = DateTime.Now.Year
    Dim dateFrom = New Date(yy, 1, 1).ToString("yyyy-MM-dd")
    Dim dateStart = DateAdd("d", -1, New Date(yy, 1, 1)).ToString("yyyy-MM-dd")
    Dim dateTo = DateAdd("d", -1, New Date(yy + 1, 1, 1)).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateStart") Is Nothing Then
        dateStart = Request.QueryString("DateStart")
    End If
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("dateFrom")
    End If
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("dateTo")
    End If
    Dim fromCode As String = "1"
    If Not Request.QueryString("FromCode") Is Nothing Then
        fromCode = Request.QueryString("FromCode")
    End If
    Dim toCode As String = "9"
    If Not Request.QueryString("ToCode") Is Nothing Then
        toCode = Request.QueryString("ToCode")
    End If
    Dim sql = "EXEC dbo.GetTrialBalance_ByDate '{0}','{1}','{2}','{3}','{4}'"
    sql = String.Format(sql, dateStart, dateFrom, dateTo, fromCode, toCode)
    Dim dt = obj.GetDataFromSQL(sql)
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
    Dim sumDebit As Double = 0
    Dim sumCredit As Double = 0
    Dim sumPDebit As Double = 0
    Dim sumPCredit As Double = 0
    Dim sumNDebit As Double = 0
    Dim sumNCredit As Double = 0
    Dim sumBSDebit As Double = 0
    Dim sumBSCredit As Double = 0
    Dim sumPLDebit As Double = 0
    Dim sumPLCredit As Double = 0
End Code
<h3 onclick="ShowCliteria()">งบทดลอง</h3>
<b>เริ่มต้น @dateStart</b>
<b>ตั้งแต่วันที่ @dateFrom ถึงวันที่ @dateTo</b>
<b>ตั้งแต่รหัส @fromCode ถึง @toCode</b>
<div id="criteriaArea" style="display:none;">
    Journal Date <input type="date" id="txtDateFrom" value="@dateFrom" />-<input type="date" id="txtDateTo" value="@dateTo" />
    <br />
    Start Date <input type="date" id="txtDateStart" value="@dateStart" />
    <br />
    Account Code <input type="text" id="txtFromCode" value="@fromCode" />-<input type="text" id="txtToCode" value="@toCode" />
    <br />
    <button id="btnRun" onclick="RefreshPage()">Refresh</button>
</div>
<div id="reportArea">
    <table border="1" style="border-collapse:collapse;border-style:solid;">
        <thead>
            <tr>
                <th rowspan="2"> รหัสบัญชี</th>
                <th rowspan="2"> ชื่อบัญชี</th>
                <th colspan="2"> ยกมา</th>
                <th colspan="2"> เปลี่ยนแปลง</th>
                <th colspan="2"> ยกไป</th>
                <th colspan="2"> งบดุล</th>
                <th colspan="2"> งบกำไรขาดทุน</th>
            </tr>
            <tr>
                <th>เดบิค</th>
                <th>เครดิต</th>
                <th>เดบิค</th>
                <th>เครดิต</th>
                <th>เดบิค</th>
                <th>เครดิต</th>
                <th>เดบิค</th>
                <th>เครดิต</th>
                <th>เดบิค</th>
                <th>เครดิต</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr In dt.Rows
                sumDebit += obj.GetDouble(dr("CurrentDr"))
                sumCredit += obj.GetDouble(dr("CurrentCr"))
                sumPDebit += obj.GetDouble(dr("PrevDr"))
                sumPCredit += obj.GetDouble(dr("PrevCr"))
                sumNDebit += obj.GetDouble(dr("NextDr"))
                sumNCredit += obj.GetDouble(dr("NextCr"))
                If obj.GetDouble(dr("PrevDr")) > 0 Or obj.GetDouble(dr("PrevCr")) > 0 Or obj.GetDouble(dr("NextDr")) > 0 Or obj.GetDouble(dr("NextCr")) > 0 Or obj.GetDouble(dr("CurrentDr")) > 0 Or obj.GetDouble(dr("CurrentCr")) > 0 Then
                    @<tr>
                        <td><a href="?Form=GeneralLedger&SRC=@dbSource&DB=@dbName&Code=@dr("AccCode")&DateFrom=@dateFrom&DateTo=@dateTo">@dr("AccCode").ToString()</a></td>
                        <td>@dr("AccName").ToString()</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("PrevDr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("PrevCr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("CurrentDr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("CurrentCr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("NextDr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("NextCr")).ToString("#,##0.00")</td>
                        @If dr("AccCode").ToString().Substring(0, 1) = "4" Or dr("AccCode").ToString().Substring(0, 1) = "5" Then
                            @<td style="text-align:right;"></td>
                            @<td style="text-align:right;"></td>
                            @<td style="text-align:right;">@Convert.ToDouble(dr("NextDr")).ToString("#,##0.00")</td>
                            @<td style="text-align:right;">@Convert.ToDouble(dr("NextCr")).ToString("#,##0.00")</td>
                            sumPLDebit += obj.GetDouble(dr("NextDr"))
                            sumPLCredit += obj.GetDouble(dr("NextCr"))
                        Else
                            @<td style="text-align:right;">@Convert.ToDouble(dr("NextDr")).ToString("#,##0.00")</td>
                            @<td style="text-align:right;">@Convert.ToDouble(dr("NextCr")).ToString("#,##0.00")</td>
                            @<td style="text-align:right;"></td>
                            @<td style="text-align:right;"></td>
                            sumBSDebit += obj.GetDouble(dr("NextDr"))
                            sumBSCredit += obj.GetDouble(dr("NextCr"))
                        End If
                    </tr>
                End If
            Next
        </tbody>
        <tfoot>
            <tr style="font-weight:bold;">
                <td colspan="2">TOTAL/ยอดรวม</td>
                <td style="text-align:right;">@sumPDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumPCredit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumCredit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumNDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumNCredit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumBSDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumBSCredit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumPLDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumPLCredit.ToString("#,##0.00")</td>
            </tr>
            <tr>
                @If sumBSDebit > sumBSCredit Then
                    @<td colspan="2"> PROFIT / กำไร</td>
                Else
                    @<td colspan="2"> LOSS / ขาดทุน</td>
                End If
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                @If sumBSDebit > sumBSCredit Then
                    @<td style="text-align:right;"></td>
                    @<td style="text-align:right;">@Convert.ToDouble(sumBSDebit - sumBSCredit).ToString("#,##0.00")</td>
                Else
                    @<td style="text-align:right;">@Convert.ToDouble(sumBSCredit - sumBSDebit).ToString("#,##0.00")</td>
                    @<td style="text-align:right;"></td>
                End If
                @If sumPLDebit > sumPLCredit Then
                    @<td style="text-align:right;"></td>
                    @<td style="text-align:right;">@Convert.ToDouble(sumPLDebit - sumPLCredit).ToString("#,##0.00")</td>
                Else
                    @<td style="text-align:right;">@Convert.ToDouble(sumPLCredit - sumPLDebit).ToString("#,##0.00")</td>
                    @<td style="text-align:right;"></td>
                End If
            </tr>
        </tfoot>
    </table>
</div>
@msg
<script type="text/javascript">
    function ShowCliteria() {
        document.getElementById("criteriaArea").style.display = "block";
    }
    function RefreshPage() {
        var dateFrom = document.getElementById("txtDateFrom").value;
        var dateTo = document.getElementById("txtDateTo").value;
        var fromCode = document.getElementById("txtFromCode").value;
        var toCode = document.getElementById("txtToCode").value;
        var dateStart = document.getElementById("txtDateStart").value;

        var url = "?Form=TrialBalance_V2&gDB=@dbName&SRC=@dbSource&DateStart=" + dateStart + "&DateFrom=" + dateFrom + "&DateTo=" + dateTo + "&FromCode=" + fromCode + "&ToCode=" + toCode;
        window.location.href = url;
    }
</script>
