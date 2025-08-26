@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report A/P"
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
    Dim dateTo = DateAdd("d", -1, New Date(DateTime.Now.Year, Now.Month + 1, 1))
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
        sqlW &= String.Format(" AND EXISTS(select 1 from vAP_D where AccDocNo=a.AccDocNo and (SalesDescription like '%{0}%'  OR PartyName like '%{0}%' OR DocRefNo like '%{0}%'))", qry)
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)

    Dim dh = obj.GetDataFromSQL(String.Format("SELECT * FROM vAP_H a WHERE DocStatus<>99 {0} ORDER BY AccDocNo", sqlW))
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
    <h4>Purchase Invoice Report</h4>
    <h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    @Code
        If custCode <> "" Then
            @<h4>Supplier Code :@custCode</h4>
        End If
        If qry <> "" Then
            @<h4>Filter :*@qry*</h4>
        End If
        Dim totalVat As Double=0
        Dim totalWht As Double=0
        Dim totalNet As Double=0
        Dim totalAmt As Double=0
        @<table>
            <thead>
                <tr>
                    <th>Bill No</th>
                    <th>Bill Date</th>
                    <th>Due Date</th>
                    <th>Supplier Name</th>
                    <th>Ref No</th>
                    <th>Amount</th>
                    <th>Vat</th>
                    <th>Wht</th>
                    <th>Net</th>
                </tr>
            </thead>
            <tbody>
                @For each rh As Data.DataRow In dh.Rows
                    totalVat+=obj.GetDouble(rh("TotalVat"))
                    totalWht+=obj.GetDouble(rh("TotalWht"))
                    totalNet+=obj.GetDouble(rh("TotalNet"))
                    totalAmt+=obj.GetDouble(rh("TotalAmount"))
                    @<tr style="font-weight:bold;">
                        <td>@rh("AccDocNo")</td>
                        <td>
                            @Convert.ToDateTime(rh("AccBatchDate")).ToString("dd/MM/yyyy")
                        </td>
                        <td>
                            @Convert.ToDateTime(rh("AccEffectiveDate")).ToString("dd/MM/yyyy")
                        </td>
                        <td>@rh("PartyName")</td>
                        <td>@rh("DocRefNo")</td>
                        <td style="text-align:right">@Convert.ToDouble(rh("TotalAmount")).ToString("#,##0.00") </td>
                        <td style="text-align:right">@Convert.ToDouble(rh("TotalVat")).ToString("#,##0.00") </td>
                        <td style="text-align:right">@Convert.ToDouble(rh("TotalWht")).ToString("#,##0.00") </td>
                        <td style="text-align:right">@Convert.ToDouble(rh("TotalNet")).ToString("#,##0.00") </td>
                    </tr>                
                Next                
            </tbody>
            <tfoot>
                <tr style="font-weight:bold;text-decoration:underline">
                    <td colspan="5">TOTAL</td>
                    <td style="text-align:right">@totalAmt.ToString("#,##0.00")</td>
                    <td style="text-align:right">@totalVat.ToString("#,##0.00")</td>
                    <td style="text-align:right">@totalWht.ToString("#,##0.00")</td>
                    <td style="text-align:right">@totalNet.ToString("#,##0.00")</td>
                </tr>
            </tfoot>
        </table>
    End Code
</div>

