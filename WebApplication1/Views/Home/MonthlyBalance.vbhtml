<style>
    table {
        font-size:10px;
    }
</style>
@Code
    ViewData("Title") = "Monthly Balance"
End Code
<h2>Monthly Balance</h2>
@Code
    Dim sql As String = ""
    sql = "
select distinct Period from vSum_BalanceMonthly
"
    Dim obj = New AccReport.CUtil()
    Dim dt = obj.GetDataFromSQL(sql)
    Dim period = ""
    Dim accu = ""
    If Not Request.QueryString("Type") Is Nothing Then
        accu = Request.QueryString("Type")
    End If
    If Not Request.QueryString("Period") Is Nothing Then
        period = Request.QueryString("Period")
    Else
        If dt.Rows.Count > 0 Then
            period = dt.Rows(0)(0).ToString()
        End If
    End If
End Code
@If dt.Rows.Count > 0 Then
    @<div class="container">
      Select Month: 
    <select id="cboPeriod" onchange="SetPeriod(this.value)">
    @For each dr In dt.Rows
        If dr("Period").ToString().Equals(period) Then
            @<option value="@dr("Period")" selected>@(Convert.ToInt32(dr("Period")) + 543)</option>
        Else
            @<option value="@dr("Period")">@(Convert.ToInt32(dr("Period")) + 543)</option>
        End If
    Next
</select>
    <a href="?Form=TrialBalance&Period=@period">Trial Balance</a>
    @Code
        sql = String.Format("SELECT * FROM vSum_BalanceMonthly" & accu & " WHERE Period='{0}' ORDER BY AccCode", period)
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

            @<table border="1" style="border-style:solid;border-width:thin;">
                <thead>
                    <tr>
                        <th rowspan="2">Acc Code</th>
                        <th rowspan="2">Acc Name</th>
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
                        <th colspan="2">Total</th>
                    </tr>
                    <tr>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
                        <td>Debit</td>
                        <td>Credit</td>
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
                        @<tr>
    <td>@dr("AccCode")</td>
    <td>@dr("AccName")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Jan")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Jan")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Feb")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Feb")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Mar")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Mar")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Apr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Apr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_May")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_May")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Jun")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Jun")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Jul")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Jul")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Aug")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Aug")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Sep")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Sep")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Oct")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Oct")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Nov")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Nov")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Dr_Dec")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("Cr_Dec")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("TotalDr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@obj.GetDouble(dr("TotalCr")).ToString("#,##0.00")</td>
</tr>
                    Next
                </tbody>
    <tfoot>
        <tr>
            <td colspan="2">Total</td>
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
            <td style="text-align:right;">@tot(0).ToString("#,##0.00")</td>
            <td style="text-align:right;">@tot(1).ToString("#,##0.00")</td>
        </tr>
    </tfoot>
            </table>
        End If
        End Code
    </div>    
        End If
<script type="text/javascript">
    function SetPeriod(period) {
        window.location.href = "?Form=MonthlyBalance&Period=" + period;
    }
</script>

