@Code
    ViewData("Title") = "Report RC"
    Layout = "~/Views/Shared/Report.vbhtml"
    Dim sql As String = "
select 
AccDocNo,AccSourceDocNo,AccBatchDate,PartyCode,PartyTaxCode,PartyName,DocRefNo,
sum(Amount) as TotalAmount,
sum(case when DVatAmt=0 and DWhtAmt=0 then Amount else 0 end) as TotalNonvatAmt,
sum(case when DVatAmt>0 then Amount else 0 end) as TotalVatBase,
sum(case when DWhtAmt>0 then Amount else 0 end) as TotalTaxBase,
sum(DVatAmt) as TotalVat,
sum(DWhtAmt) as TotalTax,
sum(DNetAmt) as TotalNet
from vTransaction_All 
where AccDocType='RC' {0}
group by AccDocNo,AccSourceDocNo,AccBatchDate,PartyCode,PartyTaxCode,PartyName,DocRefNo
"
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
    Dim partyName As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        partyName = Request.QueryString("Query")
    End If
    sqlW &= String.Format(" AND PartyName like '%{0}%'", partyName)
    Dim statusDoc As String = ""
    If Not Request.QueryString("Status") Is Nothing Then
        statusDoc = Request.QueryString("Status")
    End If
    sqlW &= String.Format(" AND AccSourceDocNo like '%{0}%'", statusDoc)
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable
End Code
<style>
    #reportArea {
        font-size: 10px;
    }

    td {
        padding-left: 2px;
    }
</style>
<h2>Sales Receipt Report</h2>
<h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
<div id="reportArea">
    @Code
        dt = obj.GetDataFromSQL(String.Format(sql, sqlW))
        If dt.Rows.Count > 0 Then
            Dim totalAmt As Double = 0
            Dim totalNonvat As Double = 0
            Dim totalVatBase As Double = 0
            Dim totalTaxBase As Double = 0
            Dim totalVat As Double = 0
            Dim totalTax As Double = 0
            Dim totalNet As Double = 0
            @<table>
                <thead>
                    <tr>
                        @For each dc As Data.DataColumn In dt.Columns
                                @<th>@dc.ColumnName</th>
                        Next
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt.Rows
                        totalAmt += dr("TotalAmount")
                        totalNonvat += dr("TotalNonvatAmt")
                        totalVatBase += dr("TotalVatBase")
                        totalTaxBase += dr("TotalTaxBase")
                        totalVat += dr("TotalVat")
                        totalTax += dr("TotalTax")
                        totalNet += dr("TotalNet")
                        @<tr>
                            @For each dc As Data.DataColumn In dt.Columns
                                If dc.ColumnName.IndexOf("Total") >= 0 Then
                                    @<td class="colnum">@Convert.ToDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                                Else
                                    If dc.ColumnName.IndexOf("Date") >= 0 Then
                                        @<td>@Convert.ToDateTime(dr(dc.ColumnName)).ToString("dd/MM/yyyy")</td>
                                    Else
                                        @<td>@dr(dc.ColumnName)</td>
                                    End If

                                End If
                            Next
                        </tr>
                    Next
                    <tr style="font-weight:bold;">
                        <td colspan="@(dt.Columns.Count - 7)">TOTAL</td>
                        <td class="colnum">@totalAmt.ToString("#,##0.00")</td>
                        <td class="colnum">@totalNonvat.ToString("#,##0.00")</td>
                        <td class="colnum">@totalVatBase.ToString("#,##0.00")</td>
                        <td class="colnum">@totalTaxBase.ToString("#,##0.00")</td>
                        <td class="colnum">@totalVat.ToString("#,##0.00")</td>
                        <td class="colnum">@totalTax.ToString("#,##0.00")</td>
                        <td class="colnum">@totalNet.ToString("#,##0.00")</td>
                    </tr>
                </tbody>
            </table>
        Else
            @<span>No Data Found</span>
        End If
    End Code
</div>
