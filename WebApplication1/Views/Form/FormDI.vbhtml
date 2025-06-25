<style>
    #topMenu {
        display:none;
    }
</style>
@Code
    Layout = "~/Views/Shared/A4.vbhtml"
    ViewData("Title") = "FormDI"
    Dim docno As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        docno = Request.QueryString("Code")
    End If
    Dim dbName = ViewBag.AccDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim sql = "
select a.*,b.WarehouseCode as ReceiveWarehouseCode,b.WarehouseName as ReceiveWarehouseName
from vTransaction_All a
left join vStock_Card b on a.StockTransNo=b.TransID
where a.AccDocNo='{0}'
"

    Dim obj = New AccReport.CUtil(".", dbName)
    Dim dt = obj.GetDataFromSQL(String.Format(sql, docno))
End Code
<h2>Stock Receive Note / ใบตรวจรับสินค้า</h2>
@If dt.Rows.Count > 0 Then
    @<table style="width:100%">
        <tr>
            <td>Document No / เลขที่เอกสาร :</td>
            <td>@dt.Rows(0)("AccDocNo")</td>
        </tr>
        <tr>
            <td>Delivery Date / วันที่รับเข้า :</td>
            <td>@Convert.ToDateTime(dt.Rows(0)("AccEffectiveDate")).ToString("dd/MM/yyyy")</td>
        </tr>
        <tr>
            <td>Reference No / อ้างถึง :</td>
            <td>@dt.Rows(0)("DocRefNo")</td>
        </tr>
    </table>
    @<table style="width:100%;vertical-align:top;">
        <tr>
            <td>From / จากบริษัท :</td>
            <td>@dt.Rows(0)("PartyName")</td>
        </tr>
        <tr>
            <td>Address / ที่อยู่ :</td>
            <td>@dt.Rows(0)("PartyAddress")</td>
        </tr>
        <tr>
            <td>Tax ID / เลขประจำตัวผู้เสียภาษี :</td>
            <td>@dt.Rows(0)("PartyTaxCode")</td>
        </tr>
    </table>
    @<table border="1" style="border-width:thin;border-collapse:collapse;width:100%;">
         <tr>
             <td>No</td>
             <td>Reference PO#</td>
             <td>Description</td>
             <td>Qty</td>
             <td>Price</td>
             <td>Currency</td>
             <td>Amount</td>
         </tr>
        @For Each dr As Data.DataRow In dt.Rows
            @<tr>
    <td>@dr("AccItemNo")</td>
    <td>@dr("AccSourceDocNo")#@dr("AccSourceDocItem")</td>
    <td>@dr("SaleProductCode") @dr("SalesDescription")</td>
    <td>@dr("Qty").ToString @dr("UnitMea").ToString</td>
    <td class="text-right">@Convert.ToDouble(dr("Price")).ToString("#,###,#0.00")</td>
    <td>@dr("Currency").ToString = @dr("ExchangeRate")</td>
    <td class="text-right">@Convert.ToDouble(dr("Amount")).ToString("#,###,#0.00")</td>
</tr>
        Next
        <tr>
            <td colspan="4" rowspan="4">
                Warehouse Code : @dt.Rows(0)("WarehouseReceiveCode")
                <br />
                Warehouse Name : @dt.Rows(0)("WarehouseReceiveName")
            </td>
            <td colspan="2"> Total Amount</td>
            <td Class="text-right">@Convert.ToDouble(dt.Rows(0)("TotalAmount")).ToString("#,###,#0.00")</td>
        </tr>
        <tr>
            <td colspan="2"> Vat</td>
            <td Class="text-right">@Convert.ToDouble(dt.Rows(0)("TotalVat")).ToString("#,###,#0.00")</td>
        </tr>
        <tr>
            <td colspan="2">With-holding Tax</td>
            <td Class="text-right">@Convert.ToDouble(dt.Rows(0)("TotalWht")).ToString("#,###,#0.00")</td>
        </tr>
        <tr>
            <td colspan="2"> Total Net</td>
            <td Class="text-right">@Convert.ToDouble(dt.Rows(0)("TotalNet")).ToString("#,###,#0.00")</td>
        </tr>
    </table>
    @<table border="1" style="border-width:thin;width:100%;border-collapse:collapse;text-align:center;">
         <tr>
             <td>ผู้รับของ / Receive By</td>
             <td>ผู้ตรวจสอบ / Checked By</td>
             <td>ผู้บันทึกบัญชี / Posted By</td>
         </tr>
         <tr>
             <td> <br /><br /><br /></td>
             <td></td>
             <td></td>
         </tr>
         <tr>
             <td></td>
             <td></td>
             <td></td>
         </tr>
    </table>
End If