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
    Dim msg As String = ""
    Dim sql As String = ""
    If Not Request.Form("Submit") Is Nothing Then
        sql = "DECLARE @@RC int
DECLARE @@warehousecode varchar(20)='{0}'
DECLARE @@assetcode varchar(20)='{1}'
DECLARE @@deliveryno varchar(50)='{2}'
DECLARE @@firstdate date='{3}'
DECLARE @@lastdate date='{4}'
DECLARE @@remark nvarchar(max)='{5}'
DECLARE @@userid varchar(20)='{6}'
DECLARE @@doctype varchar(5)='{7}'

-- TODO: Set parameter values here.

EXECUTE @@RC = [dbo].[Insert_DepreByDate]
@@warehousecode
  ,@@assetcode
  ,@@deliveryno
  ,@@firstdate
  ,@@lastdate
  ,@@remark
  ,@@userid
  ,@@doctype
"
        dt = obj.GetDataFromSQL(String.Format(sql,
                             Request.Form("WarehouseCode"),
                             Request.Form("ProductCode"),
                             Request.Form("DeliveryNo"),
                             Request.Form("DateFrom"),
                             Request.Form("DateTo"),
                             Request.Form("Remark"),
                             ViewBag.User,
                             "JV"))
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)(1).ToString() <> "" Then
                Response.StatusCode = 200
                msg = "Save To Journal " & dt.Rows(0)(1).ToString()
            Else
                msg = obj.Message
                Response.StatusCode = 500
            End If
            Response.SuppressFormsAuthenticationRedirect = True
        Else
            msg = obj.Message
        End If
    End If

    sql = String.Format("select * from vCalculate_Depre_Straight WHERE ProductCode like '{0}%'", productCode)
End Code
<link rel="stylesheet" href="~/Content/bootstrap.min.css" />
<style>
    #reportArea {
        font-size: 10px;
    }

    td {
        padding-left: 2px;
    }

    th {
        text-align: center;
    }

    @@media print {
        @@page {
            size: A4 landscape;
            margin: 10mm; /* Adjust margins as needed */
        }

        body {
            zoom: 50%;
        }

        #mdlApprove {
            display: none;
        }

        table {
            border-collapse: separate !important;
            border-spacing: 0 !important;
        }

        th {
            border: 1px solid #000000 !important;
            background-color: darkblue !important;
            color: white !important;
            -webkit-print-color-adjust: exact !important; /* For Chrome, Safari, Edge */
            print-color-adjust: exact !important;
        }
    }
</style>
<div id="reportArea" class="container-fluid">
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
    <table border="1" style="border-collapse:collapse;">
        @If Not lang = "TH" Then
            @<thead>
                <tr>
                    <th rowspan="2">Delivery#</th>
                    <th rowspan="2">Asset Code</th>
                    <th rowspan="2">Asset Name</th>
                    <th rowspan="2">Store</th>
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
                    <th rowspan="2">ใบส่งของ</th>
                    <th rowspan="2">รหัสสินทรัพย์</th>
                    <th rowspan="2">ชื่อสินทรัพย์</th>
                    <th rowspan="2">คลัง</th>
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
                            <td>
                                <a href="#txtProductCode" onclick="ShowData('@dr("ProductCode")','@dr("WarehouseCode")','@dr("DeliveryNo")')" data-toggle="modal" data-target="#mdlApprove">@dr("DeliveryNo")</a>
                            </td>
                            <td>@dr("ProductCode")</td>
                            <td>@dr("ProductName")</td>
                            <td>@dr("WarehouseCode")</td>
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
<div class="modal" role="dialog" id="mdlApprove">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                @If lang = "TH" Then
                    @<h5 class="modal-title">บันทึกค่าเสื่อมราคา</h5>
                Else
                    @<h5 class="modal-title">Depreciation Approval</h5>
                End If
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-6">
                            Warehouse Code:
                        </div>
                        <div class="col-sm-6">
                            <input type="text" class="form-control" id="txtWarehouseCode" name="WarehouseCode" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            Product Code:
                        </div>
                        <div class="col-sm-6">
                            <input type="text" class="form-control" id="txtProductCode" name="ProductCode" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            Delivery No:
                        </div>
                        <div class="col-sm-6">
                            <input type="text" class="form-control" id="txtDeliveryNo" name="DeliveryNo" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            Date From:
                        </div>
                        <div class="col-sm-6">
                            <input type="date" class="form-control" id="txtDateFrom" name="DateFrom" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            Date To:
                        </div>
                        <div class="col-sm-6">
                            <input type="date" class="form-control" id="txtDateTo" name="DateTo" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            Remark:
                        </div>
                        <div class="col-sm-6">
                            <input type="text" class="form-control" id="txtRemark" name="Remark" />
                        </div>
                    </div>
                    <input type="hidden" id="txtUserID" name="UserID" />
                    <input type="hidden" id="txtDocType" name="DocType" value="JV" />
                    <input type="submit" value="Create Journal" name="Submit" class="btn btn-success" />
                </form>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
@msg
<script type="text/javascript">
    var msg = '@msg';
    if (msg !== '') {
        alert(msg);
    }
    function ShowData(productCode, warehouseCode, deliveryNo) {
        document.getElementById("txtProductCode").value = productCode;
        document.getElementById("txtWarehouseCode").value = warehouseCode;
        document.getElementById("txtDeliveryNo").value = deliveryNo;
    }
</script>