@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "DepreReport"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If

    Dim productCode As String = "N/A"
    If Not Request.QueryString("Code") Is Nothing Then
        productCode = Request.QueryString("Code").ToString()
    End If

    Dim lang = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable
    Dim sql As String = String.Format("select * from vCalculate_Depre_Straight WHERE ProductCode like '{0}%'", productCode)

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
    @If Not lang = "TH" Then
        @<div>
            <h4>Depreciation Report</h4>
            <b>Asset Code:</b> @productCode
        </div>
    Else
        @<div>
            <h4>สรุปค่าเสื่อมราคา</h4>
            <b>รหัสสินทรัพย์:</b> @productCode
        </div>
    End If
    <table border="1" style="width:100%;border-style:solid; border-collapse: collapse;">
        @If Not lang = "TH" Then
            @<thead>
                <tr>
                    <th rowspan="2">Reference#</th>
                    <th rowspan="2">Asset Code</th>
                    <th rowspan="2">Asset Name</th>
                    <th rowspan="2">GL Code</th>
                    <th rowspan="2">Begin Date</th>
                    <th rowspan="2">Expiration Date</th>
                    <th rowspan="2">Total Value</th>
                    <th rowspan="2">TotalYears</th>
                    <th rowspan="2">TotalDays</th>
                    <th rowspan="2">Scrap Value</th>
                    <th colspan="2">Depreciation (Calculated)</th>
                    <th colspan="2">Depreciation (Taxable)</th>
                    <th colspan="2">Depreciation (Non-Taxable)</th>
                </tr>
                <tr>
                    <th>Yearly</th>
                    <th>Daily</th>
                    <th>Yearly</th>
                    <th>Daily</th>
                    <th>Yearly</th>
                    <th>Daily</th>
                </tr>
            </thead>
        Else
            @<thead>
                <tr>
                    <th rowspan="2">เลขอ้างอิง</th>
                    <th rowspan="2">รหัสสินทรัพย์</th>
                    <th rowspan="2">ชื่อสินทรัพย์</th>
                    <th rowspan="2">รหัสบัญชี</th>
                    <th rowspan="2">วันที่พร้อมใช้งาน</th>
                    <th rowspan="2">วันที่สิ้นสุด</th>
                    <th rowspan="2">มูลค่ารวม</th>
                    <th rowspan="2">จำนวนปี</th>
                    <th rowspan="2">จำนวนวัน</th>
                    <th rowspan="2">มูลค่าเศษ</th>
                    <th colspan="2">ค่าเสื่อม (ทางบัญชี)</th>
                    <th colspan="2">ค่าเสื่อม (ทางภาษี)</th>
                    <th colspan="2">ค่าเสื่อม (ต้องบวกกลับ)</th>
                </tr>
                <tr>
                    <th>รายปี</th>
                    <th>รายวัน</th>
                    <th>รายปี</th>
                    <th>รายวัน</th>
                    <th>รายปี</th>
                    <th>รายวัน</th>
                </tr>
            </thead>
        End If
        <tbody>
            @If obj.IsConnect Then
                dt = obj.GetDataFromSQL(sql)
                If dt.Rows.Count > 0 Then
                    For Each dr As System.Data.DataRow In dt.Rows
                        @<tr>
                            <td>@dr("AccDocNo")</td>
                            <td>@dr("ProductCode")</td>
                            <td>@dr("ProductName")</td>
                            <td>@dr("AssetAccCode")</td>
                            <td>@Convert.ToDateTime(dr("AccBatchDate")).ToString("dd/MM/yyyy")</td>
                            <td>@Convert.ToDateTime(dr("ExpirationDate")).ToString("dd/MM/yyyy")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("BuyPrice")).ToString("F2")</td>
                            <td>@dr("TotalYears")</td>
                            <td>@dr("DaysTotal")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("ScrapPrice")).ToString("F2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("DepreYearly")).ToString("F2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("DeprePerDay")).ToString("F2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("DepreYearlyMax")).ToString("F2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("DepreMaxPerDay")).ToString("F2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("DepreAddBack")).ToString("F2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("DepreAddBackPerDay")).ToString("F2")</td>
                        </tr>
                    Next
                End If
            End If
        </tbody>
    </table>


</div>
