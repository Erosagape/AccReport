@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "ReportGL"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If

    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    Dim dateTo = DateAdd("d", -1, New Date(DateTime.Now.Year, Now.Month + 1, 1))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If
    Dim pdcode As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        pdcode = Request.QueryString("Code")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable
    If pdcode <> "" Then
        dt = obj.GetDataFromSQL(String.Format("EXEC dbo.GetStockCard '{0}', '{1}', '{2}'", dateFrom, dateTo, pdcode))
    End If
    Dim lang As String = "EN"
    If Not Request.QueryString("Lang") Is Nothing Then
        lang = Request.QueryString("Lang")
    End If
End Code
<h3>@IIf(lang = "TH", "รายงานสินค้าและวัตถุดิบ", "Product and Material Movement Report")</h3>
@If dt.Rows.Count > 0 Then
    @<b>@IIf(lang = "TH", "ระหว่างวันที่ " & dateFrom & " ถึงวันที่ " & dateTo, "Date From " & dateFrom & " To " & dateTo)</b>
    @<br />
    @<b>@Iif(lang = "TH", "รหัสสินค้า: " & pdcode, "Product Code: " & pdcode) @IIf(lang = "TH", "ชื่อสินค้า: " & dt.Rows(0)("ProductName"), "Product Name: " & dt.Rows(0)("ProductName"))  @IIf(lang = "TH", "หน่วยนับ: " & dt.Rows(0)("UnitStock"), "Unit : " & dt.Rows(0)("UnitStock"))</b>
    @<table border="1" style="border-collapse:collapse;border-width:thin;">
        <thead>
            <tr>
                <th>@IIf(lang = "TH", "วันที่", "Date")</th>
                <th>@IIf(lang = "TH", "เลขที่ใบสำคัญ", "Reference")</th>
                <th>@IIf(lang = "TH", "ผู้ติดต่อ", "Contact")</th>
                <th>@IIf(lang = "TH", "รับ", "IN")</th>
                <th>@IIf(lang = "TH", "จ่าย", "OUT")</th>
                <th>@IIf(lang = "TH", "ราคา", "Price")</th>
                <th>@IIf(lang = "TH", "มูลค่า", "Value")</th>
                <th>@IIf(lang = "TH", "คงเหลือ", "Balance")</th>
                <th>@IIf(lang = "TH", "มูลค่าคงเหลือ", "Total")</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>@Convert.ToDateTime(dr("AccBatchDate")).ToString("dd/MM/yyyy")</td>
                    <td>@dr("AccDocNo")</td>
                    <td>@dr("PartyName")</td>
                    <td class="colnum">@Convert.ToDecimal(dr("QtyIN")).ToString("N2")</td>
                    <td class="colnum">@Convert.ToDecimal(dr("QtyOUT")).ToString("N2")</td>
                    <td class="colnum">@Convert.ToDecimal(dr("TransPrice")).ToString("N2")</td>
                    <td class="colnum">@Convert.ToDecimal(dr("TransAmount")).ToString("N2")</td>
                    <td class="colnum">@Convert.ToDecimal(dr("QtyBal")).ToString("N2")</td>
                    <td class="colnum">@Convert.ToDecimal(dr("TotalBal")).ToString("N2")</td>
                </tr>
            Next
        </tbody>
    </table>
End If