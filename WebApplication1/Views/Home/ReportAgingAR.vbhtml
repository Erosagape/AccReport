@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report A/R Aging"
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
        sqlW &= String.Format(" AND AccBatchDate>='{0}'", dateFrom)
    End If
    Dim dateTo = DateAdd("d", -1, DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        sqlW &= String.Format(" AND AccBatchDate<='{0}'", dateTo)
    End If
    Dim custCode = ""
    If Not Request.QueryString("Code") Is Nothing Then
        custCode = Request.QueryString("Code")
        custCode = "'" & custCode.Replace(",", "','") & "'"
        sqlW &= String.Format(" AND PartyCode IN({0})", custCode)
    End If
    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND EXISTS(select 1 from vAR_D where AccDocNo=a.AccDocNo and (SalesProductName like '%{0}%'  OR PartyName like '%{0}%' OR DocRefNo like '%{0}%'))", qry)
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim dh = obj.GetDataFromSQL(String.Format("SELECT *,(case when RCNo is null then DNetAmt else 0 end) as TotalDue,(case when RCNO is null then DATEDIFF(day,AccBatchDate,GETDATE()) else 0 end) as OverDueDays FROM vTransaction_LinkBack a WHERE AccdocType='SI' {0} ORDER BY PartyCode,AccBatchDate,AccDocNo", sqlW))

    Dim tb As New Data.DataTable
    Dim totalNet As Decimal = 0
    Dim totalOverDue As Decimal = 0
    Dim partyCode As String = ""
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
    <h2>Sales Invoice Aging Report</h2>
    <h4>Customer Code: @custCode</h4>
    <h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    <table>
        <thead>
            <tr>
                <th>Invoice No.</th>
                <th>Invoice Date</th>
                <th>Description</th>
                <th>Amount</th>
                <th>Vat</th>
                <th>Wht</th>
                <th>Net</th>
                <th>Receipt No</th>
                <th>Receipt Date</th>
                <th>Days</th>
                <th>Total</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dh.Rows
                totalNet += Convert.ToDecimal(dr("DNetAmt"))
                totalOverDue += Convert.ToDecimal(dr("TotalDue"))
                If partyCode <> dr("PartyCode") Then
                    partyCode = dr("PartyCode").ToString()
                    @<tr>
                        <td colspan="11"><strong>@dr("PartyCode") / @dr("PartyName")</strong></td>
                    </tr>
                End If
                @<tr>
                    <td>@dr("AccDocNo")</td>
                    <td>@Convert.ToDateTime(dr("AccBatchDate")).ToString("dd/MM/yyyy")</td>
                    <td>@dr("SalesDescription")</td>
                    <td style="text-align:right">@String.Format("{0:N2}", dr("Amount"))</td>
                    <td style="text-align:right">@String.Format("{0:N2}", dr("DVatAmt"))</td>
                    <td style="text-align:right">@String.Format("{0:N2}", dr("DWhtAmt"))</td>
                    <td style="text-align:right">@String.Format("{0:N2}", dr("DNetAmt"))</td>
                    <td>@dr("RCNo")</td>
                    <td>@(If(IsDBNull(dr("RCDate")), "", Convert.ToDateTime(dr("RCDate")).ToString("dd/MM/yyyy")))</td>
                    <td style="text-align:right">@dr("OverDueDays")</td>
                    <td style="text-align:right">@String.Format("{0:N2}", dr("TotalDue"))</td>
                </tr>
            Next
            <tr>
                <td colspan="6" style="text-align:right"><strong>Total:</strong></td>
                <td style="text-align:right">@String.Format("{0:N2}", totalNet)</td>
                <td colspan="3">Total Over Due:</td>
                <td style="text-align:right">@String.Format("{0:N2}", totalOverDue)</td>
            </tr>
        </tbody>
    </table>
</div>


