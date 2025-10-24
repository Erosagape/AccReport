<style>
    .form-control {
        width:fit-content;
    }
</style>
@Code
    ViewData("Title") = "Transaction"
    Dim dbName = ViewBag.AccDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim docno As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        docno = Request.QueryString("Code")
    End If
    Dim itemno As Integer = -1
    Dim showmodal As Integer = 0
    If Not Request.QueryString("Item") Is Nothing Then
        itemno = Convert.ToInt16(Request.QueryString("Item"))
        showmodal = 1
    End If
    Dim doctype As String = ""
    If Not Request.QueryString("Type") Is Nothing Then
        doctype = Request.QueryString("Type")
    End If
    Dim obj = New AccReport.CUtil(".", dbName)
    Dim sql = "
SELECT * from vTransaction_All where AccDocNo='{0}'
"

    sql = String.Format(sql, docno)

    Dim dt = New Data.DataTable
    dt = obj.GetDataFromSQL(sql)
    Dim AccDocNo As String = ""
    Dim AccBatchDate As Date = DateTime.Today
    Dim AccEffectiveDate As Date = DateTime.MinValue
    Dim PartyCode As String = ""
    Dim PartyTaxCode As String = ""
    Dim PartyName As String = ""
    Dim PartyAddress As String = ""
    Dim IssueBy As String = ""
    Dim AccDocType As String = doctype
    Dim AccPostDate As Date = DateTime.MinValue
    Dim FiscalYear As Date = DateTime.Today
    Dim DocStatus As Integer = 0
    Dim DocRefNo As String = ""

    Dim AccItemNo As Integer = itemno
    Dim AccSourceDocNo As String = ""
    Dim AccSourceDocItem As Integer = 0
    Dim StockTransNo As Integer = 0
    Dim Qty As Double = 0
    Dim Price As Double = 0
    Dim UnitMea As String = ""
    Dim Currency As String = ""
    Dim ExchangeRate As Double = 0
    Dim Amount As Double = 0
    Dim SaleProductCode As String = ""
    Dim SalesDescription As String = ""
    Dim RateVat As Integer = 0
    Dim RateWht As Integer = 0
    Dim VatType As Integer = 0
    Dim TotalAmount As Double = 0
    Dim TotalVat As Double = 0
    Dim TotalWht As Double = 0
    Dim TotalNet As Double = 0
    Dim dtStatus As New Data.DataTable
End Code
@If obj.IsConnect Then
    @<form method="post" action="">
    @If dt.Rows.Count > 0 Then
        AccDocNo = dt.Rows(0)("AccDocNo").ToString()
        AccBatchDate = dt.Rows(0)("AccBatchDate")
        AccEffectiveDate = dt.Rows(0)("AccEffectiveDate")
        PartyCode = dt.Rows(0)("PartyCode").ToString()
        PartyTaxCode = dt.Rows(0)("PartyTaxCode").ToString()
        PartyName = dt.Rows(0)("PartyName").ToString()
        PartyAddress = dt.Rows(0)("PartyAddress").ToString()
        IssueBy = dt.Rows(0)("IssueBy").ToString()
        AccDocType = dt.Rows(0)("AccDocType").ToString()
        AccPostDate = dt.Rows(0)("AccPostDate")
        FiscalYear = dt.Rows(0)("FiscalYear")
        DocStatus = dt.Rows(0)("DocStatus")
        DocRefNo = dt.Rows(0)("DocRefNo").ToString()

        TotalAmount = dt.Rows(0)("TotalAmount")
        TotalVat = dt.Rows(0)("TotalVat")
        TotalWht = dt.Rows(0)("TotalWht")
        TotalNet = dt.Rows(0)("TotalNet")

        If AccItemNo > 0 Then
            AccSourceDocNo = dt.Rows(AccItemNo - 1)("AccSourceDocNo").ToString()
            AccSourceDocItem = dt.Rows(AccItemNo - 1)("AccSourceDocItem")
            StockTransNo = dt.Rows(AccItemNo - 1)("StockTransNo")
            Qty = dt.Rows(AccItemNo - 1)("Qty")
            Price = dt.Rows(AccItemNo - 1)("Price")
            Currency = dt.Rows(AccItemNo - 1)("Currency").ToString()
            UnitMea = dt.Rows(AccItemNo - 1)("UnitMea").ToString()
            ExchangeRate = dt.Rows(AccItemNo - 1)("ExchangeRate")
            Amount = dt.Rows(AccItemNo - 1)("Amount")
            SaleProductCode = dt.Rows(AccItemNo - 1)("SaleProductCode").ToString()
            SalesDescription = dt.Rows(AccItemNo - 1)("SalesDescription").ToString()
            RateVat = dt.Rows(AccItemNo - 1)("RateVat")
            RateWht = dt.Rows(AccItemNo - 1)("RateWht")
            VatType = dt.Rows(AccItemNo - 1)("VatType")
        End If
    End If
    @If AccDocType <> "" Then
        dtStatus = obj.GetDataFromSQL(String.Format("SELECT * FROM Mas_AccConfig WHERE ConfigCode='{0}_STATUS' ", AccDocType))
    End If
    <h2>Transaction (@AccDocType)</h2>
    <input type="hidden" id="txtAccDocType" value="@AccDocType" />
    <div class="row">
        <div class="col-sm-2">
            <label for="txtAccDocNo" id="lblAccDocNo">Doc#</label>
        </div>
        <div class="col-sm-4">
            <input type="text" id="txtAccDocNo" name="AccDocNo" class="form-control" value="@AccDocNo" readonly />
        </div>
        <div class="col-sm-2">
            <label for="txtAccBatchDate" id="lblAccBatchDate">Doc Date</label>
        </div>
        <div class="col-sm-4">
            <input type="date" id="txtAccBatchDate" name="AccBatchDate" onchange="DataChanged()" class="form-control" value="@AccBatchDate.ToString("yyyy-MM-dd")" readonly />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label for="txtIssueBy" id="lblIssueBy">Issue By</label>
        </div>
        <div class="col-sm-4">
            <input type="text" id="txtIssueBy" name="IssueBy" class="form-control" value="@IssueBy" readonly />
        </div>
        <div class="col-sm-2">
            <label for="txtAccEffectiveDate" id="lblAccEffectiveDate">Due Date</label>
        </div>
        <div class="col-sm-4">
            <input type="date" id="txtAccEffectiveDate" name="AccEffectiveDate" onchange="DataChanged()" class="form-control" value="@AccEffectiveDate.ToString("yyyy-MM-dd")" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label for="txtPartyCode" id="lblPartyCode">Party Code#</label>
        </div>
        <div class="col-sm-4">
            <input type="text" id="txtPartyCode" name="PartyCode" onchange="DataChanged()" class="form-control" value="@PartyCode" />
        </div>
        <div class="col-sm-2">
            <label for="txtPartyTaxCode" id="lblPartyTaxCode">Party Tax#</label>
        </div>
        <div class="col-sm-4">
            <input type="text" id="txtPartyTaxCode" name="PartyTaxCode" onchange="DataChanged()" class="form-control" value="@PartyTaxCode" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label for="txtPartyName" id="lblPartyName">Party Name</label>
        </div>
        <div class="col-sm-10" style="display:flex;">
            <input type="text" style="width:100%;" id="txtPartyName" onchange="DataChanged()" name="PartyName" class="form-control" value="@PartyName" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label for="txtPartyAddress" id="lblPartyAddress">Address</label>
        </div>
        <div class="col-sm-10" style="display:flex;">
            <textarea id="txtPartyAddress" style="width:100%" onchange="DataChanged()" name="PartyAddress" class="form-control">@PartyAddress</textarea>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label for="txtAccPostDate" id="lblAccPostDate">Post Date</label>
        </div>
        <div class="col-sm-4">
            <input type="date" id="txtAccPostDate" name="AccPostDate" class="form-control" value="@AccPostDate.ToString("yyyy-MM-dd")" readonly />
        </div>
        <div class="col-sm-2">
            <label for="txtFiscalYear" id="lblFiscalYear">Fiscal Year</label>
        </div>
        <div class="col-sm-4">
            <input type="number" id="txtFiscalYear" name="FiscalYear" class="form-control" value="@FiscalYear.Year" readonly />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label for="txtDocRefNo" id="lblDocRefNo">Ref#</label>
        </div>
        <div class="col-sm-4">
            <input type="text" id="txtDocRefNo" name="DocRefNo" onchange="DataChanged()" class="form-control" value="@DocRefNo" />
        </div>
        <div class="col-sm-2">
            <label for="txtDocStatus" id="lblDocStatus">Status</label>
        </div>
        <div class="col-sm-4">
            <select id="txtDocStatus" name="DocStatus" class="form-control dropdown" disabled>
                @If dtStatus.Rows.Count > 0 Then
                    For Each dr As Data.DataRow In dtStatus.Rows
                        If DocStatus.Equals(Convert.ToInt32(dr("ConfigKey"))) Then
                            @<option value="@dr("ConfigKey")" selected>@dr("ConfigValue")</option>
                        Else
                            @<option value="@dr("ConfigKey")">@dr("ConfigValue")</option>
                        End If
                    Next
                End If
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-3">
            Total Amount<br />
            <input type="text" class="form-control" value="@TotalAmount.ToString("#,##0.00")" readonly />
        </div>
        <div class="col-sm-3">
            Total Vat<br />
            <input type="text" class="form-control" value="@TotalVat.ToString("#,##0.00")" readonly />
        </div>
        <div class="col-sm-3">
            Total Withholding-Tax<br />
            <input type="text" class="form-control" value="@TotalWht.ToString("#,##0.00")" readonly />
        </div>
        <div class="col-sm-3">
            Total Net<br />
            <input type="text" class="form-control" value="@TotalNet.ToString("#,##0.00")" readonly />
        </div>
    </div>
    <input type="button" id="btnAdd" class="btn btn-warning" onclick="ShowDetail(0)" value="Add Detail" />
    <input type="submit" class="btn btn-success" value="Save Document" />
    @If dt.Rows.Count > 0 Then
        Dim iRow As Integer = 0
        @<table border="1" class="table table-responsive" style="border-collapse:collapse;border-width:thin">
            <thead>
                <tr>
                    <th>Action</th>
                    <th>#</th>
                    <th>Description of Goods</th>
                    <th>Qty/Unit</th>
                    <th>Price</th>
                    <th>Amount</th>
                </tr>
            </thead>
            <tbody>
                @For each dr As Data.DataRow In dt.Rows
                    iRow += 1
                    @<tr>
                <td>
                    <input type="button" class="btn btn-primary" value="Edit" onclick="ShowDetail(@dr("AccItemNo"))" />
                </td>
                        <td>@iRow</td>
                        <td>@dr("SalesDescription")</td>
                        <td>@dr("Qty") @dr("UnitMea")</td>
                        <td>@dr("Price")</td>
                        <td class="text-right">@dr("Amount") @dr("Currency")</td>
                    </tr>
                Next
            </tbody>
        </table>
    End If
     <div class="modal fade" id="frmDetail">
         <div class="modal-dialog modal-lg" role="document"> 
             <div class="modal-content">
                 <div class="modal-header">
                     <div class="row">
                         <div class="col-sm-2">
                             #No
                         </div>
                         <div class="col-sm-3">
                             <input type="number" name="AccItemNo" id="txtAccItemNo" class="form-control" value="@AccItemNo" />
                         </div>
                         <div class="col-sm-2">
                             From
                         </div>
                         <div class="col-sm-3">
                             <input type="text" name="AccSourceDocNo"  id="txtAccSourceDocNo" class="form-control" value="@AccSourceDocNo" />
                             <input type="number" name="AccSourceDocItem" id="txtAccSourceDocItem" class="form-control" value="@AccSourceDocItem" />
                         </div>
                     </div>
                 </div>
                 <div class="modal-body">
                     <input type="hidden" name="StockTransNo" id="txtStockTransNo" value="@StockTransNo" />
                     <div class="row">
                         <div class="col-sm-2">
                             Code
                         </div>
                         <div class="col-sm-3">
                             <input type="text" class="form-control" name="SaleProductCode" id="txtSaleProductCode" value="@SaleProductCode" />
                         </div>
                         <div class="col-sm-2">
                             Description
                         </div>
                         <div class="col-sm-3">
                             <input type="text" class="form-control" name="SalesDescription" id="txtSalesDescription" value="@SalesDescription" />
                         </div>
                     </div>
                     <div class="row">
                         <div class="col-sm-2">
                             Qty
                         </div>
                         <div class="col-sm-3">
                             <input type="number" id="txtQty" name="Qty" class="form-control" value="@Qty" />
                         </div>
                         <div class="col-sm-2">
                             Unit
                         </div>
                         <div class="col-sm-3">
                             <input type="text" id="txtUnitMea" name="UnitMea" class="form-control" value="@UnitMea" />
                         </div>
                     </div>
                     <div class="row">
                         <div class="col-sm-2">
                             Price
                         </div>
                         <div class="col-sm-3">
                             <input type="number" id="txtPrice" name="Price" class="form-control" value="@Price" />
                         </div>
                         <div class="col-sm-2">
                             Currency/Rate
                         </div>
                         <div class="col-sm-5" >
                             <input type="text" id="txtCurrency" name="Currency" class="form-control" value="@Currency" />
                             <input type="number" id="txtExchangeRate" name="ExchangeRate" class="form-control" value="@ExchangeRate" />
                         </div>
                     </div>
                     <div class="row">
                         <div class="col-sm-2">
                             Amount
                         </div>
                         <div class="col-sm-3">
                             <input type="number" id="txtAmount" name="Amount" class="form-control" value="@Amount" />
                         </div>
                         <div class="col-sm-2">
                             Vat/Tax Type
                         </div>
                         <div class="col-sm-5">
                             <input type="number" id="txtRateVat" name="RateVat" class="form-control" value="@RateVat" />
                             <input type="number" id="txtRateWht" name="RateWht" class="form-control" value="@RateWht" />
                             @Select Case VatType
                                 Case 0
             @<select id="txtVatType" class="form-control dropdown" name="VatType">
                 <option value="0" selected> N</option>
                 <option value="1"> E</option>
                 <option value="2">I</option>
             </select>
                                 Case 1
             @<select id="txtVatType" class="form-control dropdown" name="VatType">
                 <option value="0"> N</option>
                 <option value="1" selected> E</option>
                 <option value="2">I</option>
             </select>
                                 Case 2
                                     @<select id="txtVatType" class="form-control dropdown" name="VatType">
                                         <option value="0"> N</option>
                                         <option value="1"> E</option>
                                         <option value="2" selected>I</option>
                                     </select>
                             End Select
                         </div>
                     </div>
                 </div>
                 <div class="modal-footer">
                     <div style="float:left">                         
                         <input type="submit" class="btn btn-success" name="submitDtl" value="Save Detail" />
                     </div>
                     
                     <div style="float:right">
                         <input type="button" class="btn btn-danger" data-dismiss="modal" value="Close" />
                     </div>
                     
                 </div>
             </div>
         </div>
     </div>
    <input type="button" data-toggle="modal" data-target="#frmDetail" value="" id="btnMdl" style="display:none;" />
</form>

End If
<script type="text/javascript">
    var datachanged = 0;
    var editdetail =@showmodal;
    window.onload = function () {
        if (editdetail == 1) {
            document.getElementById('btnMdl').click();
        }
    }
    function DataChanged() {
        datachanged = 1;
    }
    function ShowDetail(itemno) {
        if (datachanged == 1) {
            alert('Data has changed,Please save document before!');
            return;
        }
        window.location.href = window.location.pathname + '?DB=@dbName&Form=Transaction&Code=@AccDocNo&Item=' + itemno;
    }
</script>