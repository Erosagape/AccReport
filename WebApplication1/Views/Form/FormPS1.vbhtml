<style>
    #topMenu {
        display: none;
    }
</style>
@Code
    Layout = "~/Views/Shared/A4.vbhtml"
    ViewData("Title") = "FormPC"
    Dim docno As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        docno = Request.QueryString("Code")
    End If
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql = "
select * from vTransaction_All where AccDocNo='{0}' order by AccDocNo,AccItemNo
"

    Dim dt = obj.GetDataFromSQL(String.Format(sql, docno))
End Code
<h2>Payment Receipts / ใบกำกับภาษี</h2>
@If dt.Rows.Count > 0 Then
    @<div style="display:flex;flex-direction:row">
        <div style="flex:2">
<table style="width:100%;vertical-align:top;">
        <tr>            
            <td><b>Vender / ผู้ให้บริการ :</b><br>@dt.Rows(0)("PartyName")</td>
        </tr>
        <tr>            
            <td><b>Address / ที่อยู่ :</b><br>@dt.Rows(0)("PartyAddress")</td>
        </tr>
        <tr>            
            <td><b>Tax ID / เลขประจำตัวผู้เสียภาษี :</b><br>@dt.Rows(0)("PartyTaxCode")</td>
        </tr>
    </table>
        </div>
        <div style="flex:1">
<table style="width:100%">
    <tr>        
        <td><b>Tax-Receipt No / เลขที่เอกสาร :</b><br>@dt.Rows(0)("AccDocNo")</td>
    </tr>
    <tr>        
        <td><b>Payment Date / วันที่ :</b><br>@Convert.ToDateTime(dt.Rows(0)("AccBatchDate")).ToString("dd/MM/yyyy")</td>
    </tr>
    <tr>        
        <td><b>Reference No / อ้างถึง :</b>@dt.Rows(0)("DocRefNo")</td>
    </tr>
</table>
        </div>
    </div>
        
    @<table border="1" style="border-width:thin;border-collapse:collapse;width:100%;">
         <tr>
             <th>No</th>
             <th>Ref#</th>
             <th>Description</th>
             <th>Qty</th>
             <th>Price</th>
             <th>Currency</th>
             <th>Amount</th>
         </tr>
        @For Each dr As Data.DataRow In dt.Rows
            @<tr>
    <td>@dr("AccItemNo")</td>
    <td>@dr("AccSourceDocNo").ToString</td>
    <td>@dr("ProductName").ToString / @dr("SalesDescription").ToString</td>
    <td>@dr("Qty").ToString @dr("UnitMea").ToString</td>
    <td class="colnum">@Convert.ToDouble(dr("Price")).ToString("#,###,#0.00")</td>
    <td>@dr("Currency").ToString = @dr("ExchangeRate")</td>
    <td class="colnum">@Convert.ToDouble(dr("Amount")).ToString("#,###,#0.00")</td>
</tr>
        Next
        <tr>
            <td colspan="4" rowspan="4">
            REMARKS:
            </td>
            <td colspan="2"> Total Amount</td>
            <td Class="colnum">@Convert.ToDouble(dt.Rows(0)("TotalAmount")).ToString("#,###,#0.00")</td>
        </tr>
        <tr>
            <td colspan="2"> Vat</td>
            <td Class="colnum">@Convert.ToDouble(dt.Rows(0)("TotalVat")).ToString("#,###,#0.00")</td>
        </tr>
        <tr>
            <td colspan="2">With-holding Tax</td>
            <td Class="colnum">@Convert.ToDouble(dt.Rows(0)("TotalWht")).ToString("#,###,#0.00")</td>
        </tr>
        <tr>
            <td colspan="2"> Total Net</td>
            <td Class="colnum">@Convert.ToDouble(dt.Rows(0)("TotalNet")).ToString("#,###,#0.00")</td>
        </tr>
    </table>
    @<table border="1" style="border-width:thin;width:100%;border-collapse:collapse;text-align:center;">
         <tr>
             <td>FOR THE CUSTOMER</td>
             <td>FOR THE COMPANY</td>
         </tr>
         <tr>
             <td> <br /><br /><br /></td>
             <td></td>
         </tr>
    </table>
End If