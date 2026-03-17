@Code 
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report A/R"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If

    Dim sqlW As String = ""
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    sqlW &= String.Format(" AND AccBatchDate>='{0}'", dateFrom)
    Dim dateTo = DateAdd("d", -1, DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If
    sqlW &= String.Format(" AND AccBatchDate<='{0}'", dateTo)
    Dim custCode = ""
    If Not Request.QueryString("Code") Is Nothing Then
        custCode = Request.QueryString("Code")
        custCode = "'" & custCode.Replace(",", "','") & "'"
        sqlW &= String.Format(" AND PartyCode IN({0})", custCode)
    End If
    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND EXISTS(select 1 from vAR_D where AccDocNo=a.AccDocNo and (SalesDescription like '%{0}%'  OR PartyName like '%{0}%' OR DocRefNo like '%{0}%'))", qry)
    End If
    Dim isSum As Boolean = False
    If Not Request.QueryString("Type") Is Nothing Then
        If Request.QueryString("Type") = "Sum" Then
            isSum = True
        End If
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim dh = obj.GetDataFromSQL(String.Format("SELECT * FROM vAR_H a WHERE DocStatus<>99 {0} ORDER BY PartyName,AccDocNo", sqlW))
    Dim tb As New Data.DataTable
    Dim id As String = ""
End Code
<style>
    #reportArea {
        font-size: 10px;
    }

    td {
        padding-left: 2px;
    }
</style>
<div id="reportArea">
    <h4>Sale Invoice Report <label onclick="ToggleSummary('@IIf(isSum, "Y", "N")')">@IIf(isSum, "(Summary)", "(Detail)")</label></h4> 
    <h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    @Code 
        If custCode <> "" Then
            @<h4>Customer Code :@custCode</h4>
        End If
        If qry <> "" Then
            @<h4>Filter :*@qry*</h4>
        End If
        Dim totalVat As Double = 0
        Dim totalWht As Double = 0
        Dim totalWht1 As Double = 0
        Dim totalWht2 As Double = 0
        Dim totalWht3 As Double = 0
        Dim totalWht5 As Double = 0
        Dim totalWht10 As Double = 0
        Dim totalNet As Double = 0
        Dim totalAmt As Double = 0
        Dim totalAmtVAT As Double = 0
        Dim totalAmtWHT1 As Double = 0
        Dim totalAmtWHT2 As Double = 0
        Dim totalAmtWHT3 As Double = 0
        Dim totalAmtWHT5 As Double = 0
        Dim totalAmtWHT10 As Double = 0
        Dim sumAmtVAT As Double = 0
        Dim sumAmtWHT1 As Double = 0
        Dim sumAmtWHT2 As Double = 0
        Dim sumAmtWHT3 As Double = 0
        Dim sumAmtWHT5 As Double = 0
        Dim sumAmtWHT10 As Double = 0
        Dim sumVat As Double = 0
        Dim sumWht As Double = 0
        Dim sumNet As Double = 0
        Dim sumWht1 As Double = 0
        Dim sumWht2 As Double = 0
        Dim sumWht3 As Double = 0
        Dim sumWht5 As Double = 0
        Dim sumWht10 As Double = 0
        Dim groupValue As String = ""
        @<table>
            <thead>
                <tr>
                    @If isSum Then
                        @<th rowspan="2">Customer</th>
                    Else
                        @<th rowspan = "2" > Inv No</th>
                        @<th rowspan = "2" > Inv Date</th>
                        @<th rowspan = "2" > Due Date</th>
                        @<th rowspan = "2" > Ref No</th>
                    End If
                    <th colspan = "6" > Amount</th>
                    <th rowspan = "2" > VAT</th>
                    <th rowspan = "2" > WHT</th>
                    <th rowspan = "2" > Net</th>
                </tr>
                <tr>
                    <th>VAT</th>
                    <th>WHT(1%)</th>
                    <th>WHT(2%)</th>
                    <th>WHT(3%)</th>
                    <th>WHT(5%)</th>
                    <th>WHT(10%)</th>
                </tr>
            </thead>
            <tbody>
                @For Each rh As Data.DataRow In dh.Rows
                    If groupValue <> rh("PartyName") Then
                        If totalNet > 0 Then
                            @<tr style="background-color:@IIf(isSum, "white", "lightblue");font-weight:bold;text-align:right;">
                                @If isSum Then
                                    @<td>@groupValue</td>
                                Else
                                    @<td colspan="4">@groupValue</td>
                                End If
                                <td style="text-align:right">@totalAmtVAT.ToString("#,##0.00")</td>
                                <td style="text-align:right">@totalAmtWHT1.ToString("#,##0.00")</td>
                                <td style="text-align:right">@totalAmtWHT2.ToString("#,##0.00")</td>
                                <td style="text-align:right">@totalAmtWHT3.ToString("#,##0.00")</td>
                                <td style="text-align:right">@totalAmtWHT5.ToString("#,##0.00")</td>
                                <td style="text-align:right">@totalAmtWHT10.ToString("#,##0.00")</td>
                                <td style="text-align:right">@totalVat.ToString("#,##0.00")</td>
                                <td style="text-align:right">@totalWht.ToString("#,##0.00")</td>
                                <td style="text-align:right">@totalNet.ToString("#,##0.00")</td>
                            </tr>
                            totalAmt = 0
                            totalAmtVAT = 0
                            totalAmtWHT1 = 0
                            totalAmtWHT2 = 0
                            totalAmtWHT3 = 0
                            totalAmtWHT5 = 0
                            totalAmtWHT10 = 0
                            totalVat = 0
                            totalWht = 0
                            totalWht1 = 0
                            totalWht2 = 0
                            totalWht3 = 0
                            totalWht5 = 0
                            totalWht10 = 0
                            totalNet = 0
                        End If
                        If isSum = False Then
                            @<tr style="background-color:lightyellow;color:blue;font-weight:bold;">
                                <td colspan="14">@rh("PartyName")</td>
                            </tr>
                        End If
                        groupValue = rh("PartyName")
                    End If
                    totalVat += obj.GetDouble(rh("TotalVat"))
                    totalWht += obj.GetDouble(rh("TotalWht"))
                    totalNet += obj.GetDouble(rh("TotalNet"))
                    totalAmt += obj.GetDouble(rh("TotalAmount"))
                    totalAmtVAT += obj.GetDouble(rh("TotalVatBase"))
                    totalAmtWHT1 += obj.GetDouble(rh("TotalTaxBase1"))
                    totalAmtWHT2 += obj.GetDouble(rh("TotalTaxBase2"))
                    totalAmtWHT3 += obj.GetDouble(rh("TotalTaxBase3"))
                    totalAmtWHT5 += obj.GetDouble(rh("TotalTaxBase5"))
                    totalAmtWHT10 += obj.GetDouble(rh("TotalTaxBase10"))
                    sumAmtVAT += obj.GetDouble(rh("TotalVatBase"))
                    sumAmtWHT1 += obj.GetDouble(rh("TotalTaxBase1"))
                    sumAmtWHT2 += obj.GetDouble(rh("TotalTaxBase2"))
                    sumAmtWHT3 += obj.GetDouble(rh("TotalTaxBase3"))
                    sumAmtWHT5 += obj.GetDouble(rh("TotalTaxBase5"))
                    sumAmtWHT10 += obj.GetDouble(rh("TotalTaxBase10"))
                    sumVat += obj.GetDouble(rh("TotalVat"))
                    sumWht += obj.GetDouble(rh("TotalWht"))
                    sumNet += obj.GetDouble(rh("TotalNet"))
                    If isSum = False Then
                        @<tr style="font-weight:bold;">
                            <td>
                                <a class="btn btn-success" href="~/Form?Form=FormSI&SRC=@dbSource&DB=@dbname&Code=@rh("AccDocNo")">@rh("AccDocNo")</a>
                            </td>
                            <td>
                                @Convert.ToDateTime(rh("AccBatchDate")).ToString("dd/MM/yyyy")
                            </td>
                            <td>
                                @Convert.ToDateTime(rh("AccEffectiveDate")).ToString("dd/MM/yyyy")
                            </td>
                            <td>@rh("DocRefNo")</td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalVatBase")).ToString("#,##0.00") </td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalTaxBase1")).ToString("#,##0.00") </td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalTaxBase2")).ToString("#,##0.00") </td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalTaxBase3")).ToString("#,##0.00") </td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalTaxBase5")).ToString("#,##0.00") </td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalTaxBase10")).ToString("#,##0.00") </td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalVat")).ToString("#,##0.00") </td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalWht")).ToString("#,##0.00") </td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalNet")).ToString("#,##0.00") </td>
                        </tr>
                    End If
                Next
            <tr style="background-color:@IIf(isSum, "white", "lightblue");font-weight:bold;text-align:right;">
                @If isSum Then
                    @<td>@groupValue</td>
                Else
                    @<td colspan="4">@groupValue</td>
                End If
                <td style="text-align:right">@totalAmtVAT.ToString("#,##0.00")</td>
                <td style="text-align:right">@totalAmtWHT1.ToString("#,##0.00")</td>
                <td style="text-align:right">@totalAmtWHT2.ToString("#,##0.00")</td>
                <td style="text-align:right">@totalAmtWHT3.ToString("#,##0.00")</td>
                <td style="text-align:right">@totalAmtWHT5.ToString("#,##0.00")</td>
                <td style="text-align:right">@totalAmtWHT10.ToString("#,##0.00")</td>
                <td style="text-align:right">@totalVat.ToString("#,##0.00")</td>
                <td style="text-align:right">@totalWht.ToString("#,##0.00")</td>
                <td style="text-align:right">@totalNet.ToString("#,##0.00")</td>
            </tr>
                <tr style="background-color:@IIf(isSum, "lightblue", "white");font-weight:bold;text-align:right;">
                    @If isSum Then
                        @<td> GRAND TOTAL</td>
                    Else
                        @<td colspan="4"> GRAND TOTAL</td>
                    End If
                    
                    <td style = "text-align:right" >@sumAmtVAT.ToString("#,##0.00")</td>
                    <td style="text-align:right">@sumAmtWHT1.ToString("#,##0.00")</td>
                    <td style="text-align:right">@sumAmtWHT2.ToString("#,##0.00")</td>
                    <td style="text-align:right">@sumAmtWHT3.ToString("#,##0.00")</td>
                    <td style="text-align:right">@sumAmtWHT5.ToString("#,##0.00")</td>
                    <td style="text-align:right">@sumAmtWHT10.ToString("#,##0.00")</td>
                    <td style="text-align:right">@sumVat.ToString("#,##0.00")</td>
                    <td style="text-align:right">@sumWht.ToString("#,##0.00")</td>
                    <td style="text-align:right">@sumNet.ToString("#,##0.00")</td>
                </tr>
            </tbody>
        </table> 
    End Code
</div>
<script type="text/javascript">
    function ToggleSummary(b) {
        if (b == 'Y') {
            updateQueryStringParam('Type', 'Detail');
        } else {
            updateQueryStringParam('Type', 'Sum');
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
