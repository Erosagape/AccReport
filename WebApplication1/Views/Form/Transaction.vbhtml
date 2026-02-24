<style>
    .form-control {
        width: fit-content;
    }
</style>
@Code
    ViewData("Title") = "Transaction"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

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

    Dim forsup As String = ""
    If Not Request.QueryString("Sup") Is Nothing Then
        forsup = Request.QueryString("Sup")
    End If

    Dim forcust As String = ""
    If Not Request.QueryString("Cust") Is Nothing Then
        forcust = Request.QueryString("Cust")
    End If

    Dim AccDocNo As String = ""
    Dim AccBatchDate As Date = DateTime.Today
    Dim AccEffectiveDate As Date = DateTime.MinValue
    Dim PartyCode As String = ""
    Dim PartyTaxCode As String = ""
    Dim PartyName As String = ""
    Dim PartyAddress As String = ""
    Dim IssueBy As String = ViewBag.User
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
    Dim Currency As String = "THB"
    Dim ExchangeRate As Double = 1
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
    Dim dtParty As New Data.DataTable

    Dim msg As String = ""
End Code
@If obj.IsConnect Then
    If forsup <> "" Then
        PartyCode = forsup
        dtParty = obj.GetDataFromSQL(String.Format("SELECT * FROM Mas_Supplier Where SupplierCode='{0}'", forsup))
        If dtParty.Rows.Count > 0 Then
            PartyName = dtParty.Rows(0)("SupplierName")
            PartyTaxCode = dtParty.Rows(0)("TaxNumber") + "/" + dtParty.Rows(0)("TaxBranch")
            PartyAddress = dtParty.Rows(0)("Address1") + " " + dtParty.Rows(0)("Address2")
        End If
    End If
    If forcust <> "" Then
        PartyCode = forcust
        dtParty = obj.GetDataFromSQL(String.Format("SELECT * FROM Mas_Customer Where CustomerCode='{0}'", forcust))
        If dtParty.Rows.Count > 0 Then
            PartyName = dtParty.Rows(0)("CustomerName")
            PartyTaxCode = dtParty.Rows(0)("TaxNumber") + "/" + dtParty.Rows(0)("TaxBranch")
            PartyAddress = dtParty.Rows(0)("Address1") + " " + dtParty.Rows(0)("Address2")
        End If
    End If

    If Not Request.Form("submitHdr") Is Nothing Then
        msg = "Save Document {0} Complete"
        AccDocNo = Request.Form("AccDocNo").ToString()
        AccBatchDate = Request.Form("AccBatchDate")
        AccEffectiveDate = Request.Form("AccEffectiveDate")
        PartyCode = Request.Form("PartyCode").ToString()
        PartyTaxCode = Request.Form("PartyTaxCode").ToString()
        PartyName = Request.Form("PartyName").ToString()
        PartyAddress = Request.Form("PartyAddress").ToString()
        IssueBy = Request.Form("IssueBy").ToString()
        AccDocType = Request.Form("AccDocType").ToString()
        AccPostDate = Request.Form("AccPostDate")
        FiscalYear = New Date(Request.Form("FiscalYear"), 12, 31)
        DocStatus = Request.Form("DocStatus")
        DocRefNo = Request.Form("DocRefNo").ToString()

        Dim sqlh = "
DECLARE @@RC int
DECLARE @@ip varchar(50)='{0}'
DECLARE @@dbname varchar(50)='{1}'
DECLARE @@accdocno varchar(50)='{2}'
DECLARE @@docdate date='{3}'
DECLARE @@effdate date='{4}'
DECLARE @@partycode varchar(50)='{5}'
DECLARE @@partytaxcode varchar(50)='{6}'
DECLARE @@partyname varchar(2000)='{7}'
DECLARE @@partyaddr varchar(2000)='{8}'
DECLARE @@issueby varchar(50)='{9}'
DECLARE @@doctype varchar(3)='{10}'
DECLARE @@postdate date='{11}'
DECLARE @@fiscalyear date='{12}'
DECLARE @@docstatus int={13}
DECLARE @@docrefno varchar(2000)='{14}'

-- TODO: Set parameter values here.

EXECUTE @@RC = [dbo].[SetTransactionHeader]
@@ip
,@@dbname
,@@accdocno
,@@docdate
,@@effdate
,@@partycode
,@@partytaxcode
,@@partyname
,@@partyaddr
,@@issueby
,@@doctype
,@@postdate
,@@fiscalyear
,@@docstatus
,@@docrefno
"
        sqlh = String.Format(sqlh,
            Request.UserHostAddress,
            dbSource,
            AccDocNo,
            AccBatchDate.ToString("yyyy-MM-dd"),
            AccEffectiveDate.ToString("yyyy-MM-dd"),
            PartyCode,
            PartyTaxCode,
            PartyName,
            PartyAddress,
            ViewBag.User,
            AccDocType,
            AccPostDate.ToString("yyyy-MM-dd"),
            FiscalYear.ToString("yyyy-MM-dd"),
            DocStatus,
            DocRefNo
        )
        Dim dtHeader = obj.GetDataFromSQL(sqlh)
        If dtHeader.Rows.Count > 0 Then
            AccDocNo = dtHeader.Rows(0)("AccDocNo").ToString()
            msg = String.Format(msg, AccDocNo)
        Else
            msg = obj.Message
        End If
        showmodal = 0
    End If

    If Not Request.Form("submitDtl") Is Nothing Then
        msg = "Save Item {0} Complete"

        AccDocNo = Request.Form("AccDocNo").ToString()
        AccItemNo = Request.Form("AccItemNo")
        AccSourceDocNo = Request.Form("AccSourceDocNo").ToString()
        AccSourceDocItem = Request.Form("AccSourceDocItem")
        StockTransNo = Request.Form("StockTransNo")
        Qty = Request.Form("Qty")
        Price = Request.Form("Price")
        Currency = Request.Form("Currency").ToString()
        UnitMea = Request.Form("UnitMea").ToString()
        ExchangeRate = Request.Form("ExchangeRate")
        Amount = Request.Form("Amount")
        SaleProductCode = Request.Form("SaleProductCode").ToString()
        SalesDescription = Request.Form("SalesDescription").ToString()
        RateVat = Request.Form("RateVat")
        RateWht = Request.Form("RateWht")
        VatType = Request.Form("VatType")

        If AccDocNo = "" Then
            msg = "Please Save Document Header first"
        Else
            Dim sqlD As String = "
DECLARE @@RC int
DECLARE @@ip varchar(50)='{0}'
DECLARE @@dbname varchar(50)='{1}'
DECLARE @@doctype varchar(3)='{2}'
DECLARE @@accdocno varchar(50)='{3}'
DECLARE @@itemno int={4}
DECLARE @@sourceno varchar(50)='{5}'
DECLARE @@sourceitem int={6}
DECLARE @@transno int={7}
DECLARE @@qty numeric(10,4)={8}
DECLARE @@price numeric(10,4)={9}
DECLARE @@unit varchar(50)='{10}'
DECLARE @@curr varchar(50)='{11}'
DECLARE @@rate float={12}
DECLARE @@amt float={13}
DECLARE @@product varchar(50)='{14}'
DECLARE @@desc varchar(2000)='{15}'
DECLARE @@vatrate float={16}
DECLARE @@whtrate float={17}
DECLARE @@vattype float={18}
DECLARE @@userid varchar(50)='{19}'

-- TODO: Set parameter values here.

EXECUTE @@RC = [dbo].[SetTransactionDetail]
@@ip
,@@dbname
,@@doctype
,@@accdocno
,@@itemno
,@@sourceno
,@@sourceitem
,@@transno
,@@qty
,@@price
,@@unit
,@@curr
,@@rate
,@@amt
,@@product
,@@desc
,@@vatrate
,@@whtrate
,@@vattype
,@@userid"
            sqlD = String.Format(sqlD,
                 Request.UserHostAddress,
                 dbSource,
                 AccDocType,
                 AccDocNo,
                 AccItemNo,
                 AccSourceDocNo,
                 AccSourceDocItem,
                 StockTransNo,
                 Qty,
                 Price,
                 UnitMea,
                 Currency,
                 ExchangeRate,
                 Amount,
                 SaleProductCode,
                 SalesDescription,
                 RateVat,
                 RateWht,
                 VatType,
                 ViewBag.User
            )

            Dim dtDetail = obj.GetDataFromSQL(sqlD)
            If dtDetail.Rows.Count > 0 Then
                AccDocNo = dtDetail.Rows(0)("DocNo").ToString()
                AccItemNo = dtDetail.Rows(0)("AccItemNo")
                msg = String.Format(msg, AccItemNo)
            Else
                msg = obj.Message
            End If
        End If

        showmodal = 0
    End If

    Dim sql = "
SELECT * from vTransaction_All where AccDocNo='{0}'
"

    sql = String.Format(sql, docno)

    Dim dt = New Data.DataTable
    dt = obj.GetDataFromSQL(sql)
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

        TotalAmount = obj.GetDouble(dt.Rows(0)("TotalAmount"))
        TotalVat = obj.GetDouble(dt.Rows(0)("TotalVat"))
        TotalWht = obj.GetDouble(dt.Rows(0)("TotalWht"))
        TotalNet = obj.GetDouble(dt.Rows(0)("TotalNet"))

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
    <input type="hidden" id="txtAccDocType" name="AccDocType" value="@AccDocType" />
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
    @If AccDocType <> "" Then
        @<div>
            <input type="button" id="btnAdd" class="btn btn-warning" onclick="ShowDetail(0)" value="Add Detail" />
            <input type="submit" name="submitHdr" class="btn btn-success" value="Save Document" />
        </div>
    End If
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
                    If Not DBNull.Value.Equals(dr("AccItemNo")) Then
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
                    End If
                Next
            </tbody>
        </table>
    End If
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
    <div Class="modal fade" id="frmDetail">
        <div Class="modal-dialog modal-lg" role="document">
            <div Class="modal-content">
                <div Class="modal-header">
                    <div Class="row">
                        <div Class="col-sm-3">
                            #No
                            <br />
                            <input type="number" name="AccItemNo" id="txtAccItemNo" Class="form-control" value="@AccItemNo" />
                        </div>
                        <div class="col-sm-9">
                            From
                            <br />
                            <div style="display:flex;flex-direction:row;">
                                <input type="text" name="AccSourceDocNo" id="txtAccSourceDocNo" class="form-control" value="@AccSourceDocNo" />
                                <input type="number" name="AccSourceDocItem" id="txtAccSourceDocItem" class="form-control" value="@AccSourceDocItem" />
                            </div>
                        </div>

                    </div>
                </div>
                <div class="modal-body">
                    <input type="hidden" name="StockTransNo" id="txtStockTransNo" value="@StockTransNo" />
                    <div class="row" id="dvService" style="display:none;">
                        <div class="col-sm-12">
                            <table class="dataTable table">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Name</th>
                                        <th>Type</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    @If obj.IsConnect Then
                                        Dim tbProduct = obj.GetDataFromSQL("Select * from vMas_Product where IsService=1 order by ProductName")
                                        If tbProduct.Rows.Count > 0 Then
                                            For Each dr As Data.DataRow In tbProduct.Rows
                                                @<tr>
                                                    <td>
                                                        <a href="#txtQty" class="btn btn-success" onclick="SetService('@dr("ProductCode")','@dr("ProductName")','@dr("VatType")',@dr("RateVat"),@dr("RateWht"))">Select</a>
                                                    </td>
                                                    <td>@dr("ProductName") - @dr("ProductCode")</td>
                                                    @If dr("VatType") = "0" Then
                                                        @<td>N-@Convert.ToInt32(dr("RateVat"))@Convert.ToInt32(dr("RateWht"))</td>
                                                    End If
                                                    @If dr("VatType") = "1" Then
                                                        @<td>E-@Convert.ToInt32(dr("RateVat"))@Convert.ToInt32(dr("RateWht"))</td>
                                                    End If
                                                    @If dr("VatType") = "2" Then
                                                        @<td>I-@Convert.ToInt32(dr("RateVat"))@Convert.ToInt32(dr("RateWht"))</td>
                                                    End If
                                                </tr>
                                            Next
                                        End If
                                    End If
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class="row" id="dvProduct" style="display:none;">
                        <div class="col-sm-12">
                            <table class="dataTable table">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Name</th>
                                        <th>Type</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    @If obj.IsConnect Then
                                        Dim tbProduct = obj.GetDataFromSQL("Select * from vMas_Product where IsService=0 order by ProductName")
                                        If tbProduct.Rows.Count > 0 Then
                                            For Each dr As Data.DataRow In tbProduct.Rows
                                                @<tr>
                                                    <td>
                                                        <a href="#txtQty" class="btn btn-success" onclick="SetProduct('@dr("ProductCode")','@dr("ProductName")','@dr("VatType")',@dr("RateVat"),@dr("RateWht"))">Select</a>
                                                    </td>
                                                    <td>@dr("ProductName") - @dr("ProductCode")</td>
                                                    @If dr("VatType") = "0" Then
                                                        @<td>N-@Convert.ToInt32(dr("RateVat"))@Convert.ToInt32(dr("RateWht"))</td>
                                                    End If
                                                    @If dr("VatType") = "1" Then
                                                        @<td>E-@Convert.ToInt32(dr("RateVat"))@Convert.ToInt32(dr("RateWht"))</td>
                                                    End If
                                                    @If dr("VatType") = "2" Then
                                                        @<td>I-@Convert.ToInt32(dr("RateVat"))@Convert.ToInt32(dr("RateWht"))</td>
                                                    End If
                                                </tr>
                                            Next
                                        End If
                                    End If
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <a href="#frmProduct" onclick="ShowProduct()">Products</a> / <a href="#frmService" onclick="ShowService()">Services</a>
                            <br />
                            <input type="text" class="form-control" name="SaleProductCode" id="txtSaleProductCode" value="@SaleProductCode" />
                        </div>
                        <div class="col-sm-9">
                            Description
                            <br />
                            <input type="text" class="form-control w-auto" name="SalesDescription" id="txtSalesDescription" value="@SalesDescription" />
                        </div>
                        <div class="col-sm-3">
                            Qty
                            <br />
                            <input type="number" id="txtQty" name="Qty" step="any" inputmode="decimal" class="form-control" onchange="CalAmount()" value="@Qty" />
                        </div>
                        <div class="col-sm-9">
                            Unit
                            <br />
                            <input type="text" id="txtUnitMea" name="UnitMea" class="form-control" value="@UnitMea" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            Price
                            <br />
                            <input type="number" id="txtPrice" name="Price" step="any" inputmode="decimal" onchange="CalAmount()" class="form-control" value="@Price" />
                        </div>
                        <div class="col-sm-9">
                            Currency/Rate
                            <br />
                            <div style="display:flex;flex-direction: row;">
                                <input type="text" id="txtCurrency" name="Currency" class="form-control" value="@Currency" />
                                <input type="number" id="txtExchangeRate" name="ExchangeRate" step="any" inputmode="decimal" class="form-control" value="@ExchangeRate" onchange="CalAmount()" />
                            </div>

                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            Amount <br />
                            <input type="number" id="txtAmount" name="Amount" step="any" inputmode="decimal" class="form-control" value="@Amount" readonly />
                        </div>
                        <div class="col-sm-9">
                            Vat/Tax Rate
                            <br />
                            <div style="display:flex;flex-direction:row">
                                <input type="number" id="txtRateVat" name="RateVat" step="any" inputmode="decimal" class="form-control" value="@RateVat" />
                                <input type="number" id="txtRateWht" name="RateWht" step="any" inputmode="decimal" class="form-control" value="@RateWht" />
                                @Select Case VatType
                                    Case 0
                @<select id="txtVatType" class="form-control dropdown" name="VatType">
                    <option value="0" selected>Not calculate</option>
                    <option value="1">Exclude</option>
                    <option value="2">Include</option>
                </select>
                                    Case 1
                @<select id="txtVatType" class="form-control dropdown" name="VatType">
                    <option value="0">Not Calculate</option>
                    <option value="1" selected> Exclude</option>
                    <option value="2">Include</option>
                </select>
                                    Case 2
                                        @<select id="txtVatType" class="form-control dropdown" name="VatType">
                                            <option value="0">Not Calculate</option>
                                            <option value="1">Exclude</option>
                                            <option value="2" selected>Include</option>
                                        </select>
                                End Select
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    @If AccDocType <> "" Then
                        @<div style="float:left">
                            <input type="submit" class="btn btn-success" name="submitDtl" value="Save Detail" />
                        </div>
                    End If
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
    var msg = '@msg';
    var docno = '@AccDocNo';
    window.onload = function () {
        if (editdetail == 1) {
            document.getElementById('btnMdl').click();
        }
        if (msg !== '') {
            alert(msg);
            if (window.location.href.indexOf(docno) < 0) {
                window.location = window.location.href + '&Code=' + docno;
            }
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
        window.location.href = window.location.pathname + '?DB=@dbName&SRC=@dbSource&Form=Transaction&Code=@AccDocNo&Item=' + itemno;
    }
    function ShowProduct() {
        document.getElementById('dvProduct').style.display='inline';
    }
    function ShowService() {
        document.getElementById('dvService').style.display = 'inline';
    }
    function SetProduct(code, name, typ,vat,wht) {
        document.getElementById('txtSaleProductCode').value = code;
        document.getElementById('txtSalesDescription').value = name;
        document.getElementById('txtRateVat').value = vat;
        document.getElementById('txtRateWht').value = wht;
        switch (typ) {
            case 'N':
                document.getElementById('txtVatType').value = 0;
                break;
            case 'E':
                document.getElementById('txtVatType').value = 1;
                break;
            case 'I':
                document.getElementById('txtVatType').value = 2;
                break;
        }
        document.getElementById('dvProduct').style.display = 'none';
    }
    function SetService(code, name, typ, vat, wht) {
        document.getElementById('txtSaleProductCode').value = code;
        document.getElementById('txtSalesDescription').value = name;
        document.getElementById('txtRateVat').value = vat;
        document.getElementById('txtRateWht').value = wht;
        switch (typ) {
            case 'N':
                document.getElementById('txtVatType').value = 0;
                break;
            case 'E':
                document.getElementById('txtVatType').value = 1;
                break;
            case 'I':
                document.getElementById('txtVatType').value = 2;
                break;
        }
        document.getElementById('dvService').style.display='none';
    }
    function CalAmount() {
        let qty = document.getElementById('txtQty').value;
        let price = document.getElementById('txtPrice').value;
        let rate = document.getElementById('txtExchangeRate').value;
        document.getElementById('txtAmount').value = Number(qty) * Number(price) * Number(rate);
    }
</script>