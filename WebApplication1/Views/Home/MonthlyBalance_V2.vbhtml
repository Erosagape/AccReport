<style>
    #topMenu {
        display: none;
    }

    table {
        font-size: 10px;
    }
</style>
@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Monthly Balance"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim lang = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
    End If
    Dim filter As String = ""
    If Not Request.QueryString("FILTER") Is Nothing Then
        filter = Request.QueryString("FILTER")
    End If
    Dim sql As String = ""
    sql = "
select distinct Period from vSum_BalanceMonthly
order by Period DESC
"
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt = obj.GetDataFromSQL(sql)
    Dim period = ""
    Dim accu = ""
    Dim nextpage = ""
    Dim type = 0
    If Not Request.QueryString("Type") Is Nothing Then
        type = Convert.ToInt32(Request.QueryString("Type"))
    End If
    Select Case type
        Case 0
            accu = ""
            nextpage = "Calculate"
        Case 1
            accu = "Calculate"
            nextpage = "Accumulate"
        Case 2
            accu = "Accumulate"
            nextpage = "Draft"
    End Select
    If Not Request.QueryString("Period") Is Nothing Then
        period = Request.QueryString("Period")
    Else
        If dt.Rows.Count > 0 Then
            period = dt.Rows(0)(0).ToString()
        End If
    End If
    If accu <> "" Then
        @<h2>Monthly Balance (@accu)</h2>
    Else
        @<h2>Monthly Balance (Draft)</h2>
    End If
End Code
@If dt.Rows.Count > 0 Then
    @<div class="container">
        Select Year:
        <select id="cboPeriod" onchange="SetPeriod(this.value)">
            @For each dr In dt.Rows
                If dr("Period").ToString().Equals(period) Then
                    @<option value="@dr("Period")" selected>@(Convert.ToInt32(dr("Period")) + 543)</option>
                Else
                    @<option value="@dr("Period")">@(Convert.ToInt32(dr("Period")) + 543)</option>
                End If
            Next
        </select>
        <a href="?Form=TrialBalance&LANG=@lang&SRC=@dbSource&DB=@dbName&Period=@period&month=@DateTime.Now.Month()"> Trial Balance</a>
        @Code
            @<input type="button" value="Switch to @nextpage" onclick="SetAccu(@type,'@period')" />
            'sql = String.Format("SELECT * FROM vSum_BalanceMonthly" & accu & " WHERE Period='{0}' and (balDr+Balcr+dr_jan+cr_jan+dr_feb+cr_feb+dr_mar+cr_mar+dr_jun+cr_jun+dr_jul+cr_jul+dr_aug+cr_aug+dr_sep+cr_sep+dr_oct+cr_oct+dr_nov+cr_nov+dr_dec+cr_dec)>0 ORDER BY AccCode", period)
            sql = String.Format("EXEC dbo.GetWorkSheet_ByHeader_V2 {0},'{1}',{2}", period, filter, type)
            dt = obj.GetDataFromSQL(sql)
            If dt.Rows.Count > 0 Then
                Dim jan(2) As Double
                Dim feb(2) As Double
                Dim mar(2) As Double
                Dim apr(2) As Double
                Dim may(2) As Double
                Dim jun(2) As Double
                Dim jul(2) As Double
                Dim aug(2) As Double
                Dim sep(2) As Double
                Dim oct(2) As Double
                Dim nov(2) As Double
                Dim dec(2) As Double
                Dim tot(2) As Double
                Dim bal(2) As Double
                @<table border="1" class="table DataTable" style="border-collapse:collapse;">
                    <thead>
                        <tr>
                            <th rowspan="2">Acc Code</th>
                            <th rowspan="2">Acc Name</th>
                            @If accu <> "" Then
                                @<th colspan="2">Balance</th>
                            End If
                            <th colspan="2">Jan</th>
                            <th colspan="2">Feb</th>
                            <th colspan="2">Mar</th>
                            <th colspan="2">Apr</th>
                            <th colspan="2">May</th>
                            <th colspan="2">Jun</th>
                            <th colspan="2">Jul</th>
                            <th colspan="2">Aug</th>
                            <th colspan="2">Sep</th>
                            <th colspan="2">Oct</th>
                            <th colspan="2">Nov</th>
                            <th colspan="2">Dec</th>
                            @If accu <> "" Then
                            Else
                                @<th colspan="2"> Total</th>
                            End If
                        </tr>
                        <tr>
                            @If accu <> "" Then
                                @<th>Debit</th>
                                @<th>Credit</th>
                            End If
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            <th>Debit</th>
                            <th>Credit</th>
                            @If accu = "" Then
                                @<th>Debit</th>
                                @<th>Credit</th>
                            Else
                            End If
                        </tr>
                    </thead>
                    <tbody>
                        @For each dr In dt.Rows
                            jan(0) += obj.GetDouble(dr("Dr_Jan"))
                            jan(1) += obj.GetDouble(dr("Cr_Jan"))
                            feb(0) += obj.GetDouble(dr("Dr_Feb"))
                            feb(1) += obj.GetDouble(dr("Cr_Feb"))
                            mar(0) += obj.GetDouble(dr("Dr_Mar"))
                            mar(1) += obj.GetDouble(dr("Cr_Mar"))
                            apr(0) += obj.GetDouble(dr("Dr_Apr"))
                            apr(1) += obj.GetDouble(dr("Cr_Apr"))
                            may(0) += obj.GetDouble(dr("Dr_May"))
                            may(1) += obj.GetDouble(dr("Cr_May"))
                            jun(0) += obj.GetDouble(dr("Dr_Jun"))
                            jun(1) += obj.GetDouble(dr("Cr_Jun"))
                            jul(0) += obj.GetDouble(dr("Dr_Jul"))
                            jul(1) += obj.GetDouble(dr("Cr_Jul"))
                            aug(0) += obj.GetDouble(dr("Dr_Aug"))
                            aug(1) += obj.GetDouble(dr("Cr_Aug"))
                            sep(0) += obj.GetDouble(dr("Dr_Sep"))
                            sep(1) += obj.GetDouble(dr("Cr_Sep"))
                            oct(0) += obj.GetDouble(dr("Dr_Oct"))
                            oct(1) += obj.GetDouble(dr("Cr_Oct"))
                            nov(0) += obj.GetDouble(dr("Dr_Nov"))
                            nov(1) += obj.GetDouble(dr("Cr_Nov"))
                            dec(0) += obj.GetDouble(dr("Dr_Dec"))
                            dec(1) += obj.GetDouble(dr("Cr_Dec"))
                            tot(0) += (jan(0) + feb(0) + mar(0) + apr(0) + may(0) + jun(0) + jul(0) + aug(0) + sep(0) + oct(0) + nov(0) + dec(0))
                            tot(1) += (jan(1) + feb(1) + mar(1) + apr(1) + may(1) + jun(1) + jul(1) + aug(1) + sep(1) + oct(1) + nov(1) + dec(1))
                            If accu <> "" Then
                                bal(0) += obj.GetDouble(dr("BalDr"))
                                bal(1) += obj.GetDouble(dr("BalCr"))
                            End If
                            @<tr>
                                <td>@dr("AccCode")</td>
                                <td>@dr("AccName")</td>
                                @If accu <> "" Then
                                    @<td style="text-align:right;">@obj.GetDouble(dr("BalDr")).ToString("#,##0.00")</td>
                                    @<td style="text-align:right;">@obj.GetDouble(dr("BalCr")).ToString("#,##0.00")</td>
                                End If
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',1)">@obj.GetDouble(dr("Dr_Jan")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',1)">@obj.GetDouble(dr("Cr_Jan")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',2)">@obj.GetDouble(dr("Dr_Feb")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',2)">@obj.GetDouble(dr("Cr_Feb")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',3)">@obj.GetDouble(dr("Dr_Mar")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',3)">@obj.GetDouble(dr("Cr_Mar")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',4)">@obj.GetDouble(dr("Dr_Apr")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',4)">@obj.GetDouble(dr("Cr_Apr")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',5)">@obj.GetDouble(dr("Dr_May")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',5)">@obj.GetDouble(dr("Cr_May")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',6)">@obj.GetDouble(dr("Dr_Jun")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',6)">@obj.GetDouble(dr("Cr_Jun")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',7)">@obj.GetDouble(dr("Dr_Jul")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',7)">@obj.GetDouble(dr("Cr_Jul")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',8)">@obj.GetDouble(dr("Dr_Aug")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',8)">@obj.GetDouble(dr("Cr_Aug")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',9)">@obj.GetDouble(dr("Dr_Sep")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',9)">@obj.GetDouble(dr("Cr_Sep")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',10)">@obj.GetDouble(dr("Dr_Oct")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',10)">@obj.GetDouble(dr("Cr_Oct")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',11)">@obj.GetDouble(dr("Dr_Nov")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',11)">@obj.GetDouble(dr("Cr_Nov")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',12)">@obj.GetDouble(dr("Dr_Dec")).ToString("#,##0.00")</a></td>
                                <td style="text-align:right;"><a href="#" onclick="PrintGL('@dr("AccCode")',12)">@obj.GetDouble(dr("Cr_Dec")).ToString("#,##0.00")</a></td>
                                @If accu = "" Then
                                    @<td style="text-align:right;">@obj.GetDouble(dr("TotalDr")).ToString("#,##0.00")</td>
                                    @<td style="text-align:right;">@obj.GetDouble(dr("TotalCr")).ToString("#,##0.00")</td>
                                End If
                            </tr>
                        Next
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan="2"> Total</td>
                            @If accu <> "" Then
                                @<td style="text-align:right;">@bal(0).ToString("#,##0.00")</td>
                                @<td style="text-align:right;">@bal(1).ToString("#,##0.00")</td>
                            End If
                            <td style="text-align:right;">@jan(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@jan(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@feb(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@feb(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@mar(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@mar(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@apr(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@apr(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@may(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@may(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@jun(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@jun(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@jul(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@jul(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@aug(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@aug(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@sep(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@sep(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@oct(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@oct(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@nov(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@nov(1).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@dec(0).ToString("#,##0.00")</td>
                            <td style="text-align:right;">@dec(1).ToString("#,##0.00")</td>
                            @If accu = "" Then
                                @<td style="text-align:right;">@tot(0).ToString("#,##0.00")</td>
                                @<td style="text-align:right;">@tot(1).ToString("#,##0.00")</td>
                            End If
                        </tr>
                    </tfoot>
                </table>
            End If
        End Code
    </div>
End If
<script type="text/javascript">
    var accu = '@type';
    function CDate(dt) {
        let d = dt,
            month = '' + (d.getMonth()+1),
            day = d.getDate(),
            year = d.getFullYear();

        if (month.length < 2) month = '0' + month;
        if (day.length < 2) day = '0' + day;

        return [year, month, day].join('-');
    }
    function PrintGL(accCode, mm) {
        var m = mm - 1;
        var dateFrom = new Date(@period, m, 1);
        var dateTo = new Date(@period, m + 1, 0);
        window.location.href = "?Form=GeneralLedger&SRC=@dbSource&DB=@dbName&Code=" + accCode + "&DateFrom="+CDate(dateFrom)+"&DateTo="+CDate(dateTo);
    }
    function SetPeriod(period) {
        window.location.href = "?Form=MonthlyBalance_V2&SRC=@dbSource&DB=@dbName&Period=" + period + (accu==''?'':'&Type='+accu);
    }
    function SetAccu(val, period) {
        switch (val) {
            case 0:
                accu = 1;
                break;
            case 1:
                accu = 2;
                break;
            case 2:
                accu = 0;
                break;
        }
        SetPeriod(period);
    }
</script>

