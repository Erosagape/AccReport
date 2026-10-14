@Code
    ViewData("Title") = "StockTrans"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql As String = ""
    Dim msg As String = ""
    Dim transId As Integer = 0
    If Not Request.QueryString("ID") Is Nothing Then
        transId = Convert.ToInt32(Request.QueryString("ID"))
    End If
    Dim transNum As String = ""
    Dim transType As String = ""
    Dim stockProductCode As String = ""
    Dim stockProductName As String = ""
    Dim transQty As Decimal = 0
    Dim transPrice As Decimal = 0
    Dim transCurrency As String = ""
    Dim transRate As Decimal = 0
    Dim transAmount As Decimal = 0
    Dim assetAccCode As String = ""
    Dim assetAccName As String = ""
    Dim warehouseCode As String = ""
    Dim warehouseName As String = ""
    Dim refDocNo As String = ""

    If Not Request.Form("Submit") Is Nothing Then
        transId = Request.Form("TransId")
        transNum = Request.Form("TransNum")
        transType = Request.Form("TransType")
        stockProductCode = Request.Form("StockProductCode")
        transQty = Request.Form("TransQty")
        transPrice = Request.Form("TransPrice")
        transCurrency = Request.Form("TransCurrency")
        transRate = Request.Form("TransRate")
        assetAccCode = Request.Form("AssetAccCode")
        warehouseCode = Request.Form("WarehouseCode")
        refDocNo = Request.Form("RefDocNo")
        sql = "DECLARE @@tid int=(SELECT ISNULL(MAX(TransID),0)+1 FROM Acc_StockTransaction)
IF ('{0}'='0')
BEGIN
    SET IDENTITY_INSERT Acc_StockTransaction ON

    INSERT INTO Acc_StockTransaction
    (TransID,TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,
    TransRate,AssetAccCode,WarehouseCode,RefDocNo)
    SELECT @@tid,'{1}','{2}','{3}',{4},{5},'{6}',{7},'{8}','{9}','{10}'

    SET IDENTITY_INSERT Acc_StockTransaction OFF
END
ELSE
BEGIN
    SET @@tid={0}
    UPDATE Acc_StockTransaction 
    SET TransNum='{1}',
        TransType='{2}',
        StockProductCode='{3}',
        TransQty={4},
        TransPrice={5},
        TransCurrency='{6}',
        TransRate={7},
        AssetAccCode='{8}',    
        WarehouseCode='{9}',
        RefDocNo='{10}'
    WHERE TransId=@@tid
END

UPDATE Acc_TransactionDT 
SET StockTransNo=0
WHERE StockTransNo=@@tid

UPDATE Acc_TransactionDT 
SET StockTransNo=@@tid
WHERE CONCAT(AccDocNo,'#',AccItemNo)='{1}'
"
        sql = String.Format(sql,
                          transId, transNum, transType, stockProductCode,
                          transQty, transPrice, transCurrency, transRate,
                          assetAccCode, warehouseCode, refDocNo
        )
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            If transId = 0 Then
                Dim rs = obj.GetDataFromSQL(String.Format("SELECT * FROM Acc_StockTransaction WHERE TransNum='{0}'", transNum))
                If rs.Rows.Count > 0 Then
                    transId = rs.Rows(0)("TransId")
                End If
            End If
            msg = "Save Successfully"
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
        End If
    End If

    sql = String.Format("select a.*,
b.ProductName,c.Name as WarehouseName,d.AccName as AssetAccName
from Acc_StockTransaction a
left join Mas_Products b on a.StockProductCode=b.ProductCode
left join Mas_Warehouse c on a.WarehouseCode=c.WarehouseCode
left join Mas_AccCode d on a.AssetAccCode=d.AccCode 
WHERE a.TransID={0}", transId)
    Dim dt As New Data.DataTable
    dt = obj.GetDataFromSQL(sql)
    If dt.Rows.Count > 0 Then
        Dim dr As System.Data.DataRow = dt.Rows(0)
        transNum = dr("TransNum").ToString
        transType = dr("TransType").ToString
        refDocNo = dr("RefDocNo").ToString
        stockProductCode = dr("StockProductCode").ToString
        stockProductName = dr("ProductName").ToString
        transQty = dr("TransQty")
        transPrice = dr("TransPrice")
        transCurrency = dr("TransCurrency").ToString
        transRate = dr("TransRate")
        transAmount = transQty * transPrice * transRate
        assetAccCode = dr("AssetAccCode").ToString
        assetAccName = dr("AssetAccName").ToString
        warehouseCode = dr("WarehouseCode").ToString
        warehouseName = dr("WarehouseName").ToString
    End If
End Code
<h2>Inventory Transaction / บันทึกสินค้าคงคลัง</h2>
<input type="button" class="btn btn-primary" value="Add New" onclick="ClearForm()"/>
<form action="" method="post">
    <input type="hidden" id="txtTransID" name="TransId" value="@transId" />
    <div class="row">
        <div class="col-sm-4">
            <label>Transaction#</label>
        </div>
        <div class="col-sm-8" style="display:flex">
            <input type="text" id="txtTransNum" name="TransNum" class="form-control" value="@transNum" />
            <input type="button" data-toggle="modal" data-target="#mdlDocument" class="btn btn-default" value="..." />
        </div>
    </div>
    <div class="modal" role="document" id="mdlDocument">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    @Code
                        Dim dtDoc = obj.GetDataFromSQL("select
(case when AccDocType='DO' THEN 'OUT' ELSE 'IN' END) as TransType,
concat(AccDocNo,'#',AccItemNo) as TransNo,
(case when AccSourceDocitem>0 then concat(AccSourceDocNo,'#',AccSourceDocItem)
else DocRefNo end) as RefDocNo,
ProductCode,ProductName,Qty,Price,Currency,ExchangeRate,WarehouseCode,
WarehouseName,AssetAccCode,AssetAccName
from vTransaction_All
where AccDocType in('DI','DO') and StockTransNo=0 and IsService=0
and DocStatus<>99")
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Document</th>
                        <th>Product Name</th>
                        <th>Qty</th>
                    </tr>
                </thead>
                <tbody>
                    @For each dr As Data.DataRow In dtDoc.Rows
                        @<tr>
                            <td>
                                <input type="button" class="btn btn-success" value="Select" data-dismiss="modal"
                                       onclick="SetData('@dr("TransNo")', '@dr("TransType")', '@dr("RefDocNo")'
                                                    , '@dr("ProductCode")', '@dr("ProductName")', '@dr("Qty")', '@dr("Price")', '@dr("Currency")', '@dr("ExchangeRate")'
                                                    , '@dr("WarehouseCode")', '@dr("WarehouseName")', '@dr("AssetAccCode")', '@dr("AssetAccName")')" />
                            </td>
                            <td>@dr("TransNo")</td>
                            <td>@dr("ProductName")</td>
                            <td>@dr("Qty")</td>
                        </tr>
                    Next
                </tbody>
            </table>
                    End Code
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Transaction Type</label>
        </div>
        <div class="col-sm-8">
            <select id="txtTransType" name="TransType" class="form-control dropdown">
                <option value="IN" @IIf(transType.Equals("IN"), "selected", "")>IN</option>
                <option value="OUT" @IIf(transType.Equals("OUT"), "selected", "")>OUT</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Document Ref#</label>
        </div>
        <div class="col-sm-8">
            <input type="text" id="txtRefDocNo" name="RefDocNo" class="form-control" value="@refDocNo" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Stock Code</label>
        </div>
        <div class="col-sm-8" style="display:flex;">
            <input type="text" id="txtStockProductCode" class="form-control" name="StockProductCode" value="@stockProductCode" />
            <input type="button" data-toggle="modal" data-target="#mdlProduct" class="btn btn-default" value="..." />
            <label id="txtStockProductName">@stockProductName</label>
        </div>
    </div>
    <div class="modal" role="document" id="mdlProduct">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    @Code
                        Dim dtProduct = obj.GetDataFromSQL("SELECT * FROM vMas_Product WHERE IsService=0")
                        @<table class="table table-bordered">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Product Code</th>
                                    <th>Product Name</th>
                                    <th>A/C Code</th>
                                </tr>
                            </thead>
                            <tbody>
                                @For each dr As Data.DataRow In dtProduct.Rows
                                    @<tr>
                                        <td>
                                            <input type="button" class="btn btn-success" value="Select" data-dismiss="modal" onclick="SetProduct('@dr("ProductCode")','@dr("ProductName")','@dr("AssetAccCode")','@dr("AssetAccName")','@dr("WarehouseCode")','@dr("WarehouseName")')" />
                                        </td>
                                        <td>@dr("ProductCode")</td>
                                        <td>@dr("ProductName")</td>
                                        <td>@dr("AssetAccCode")-@dr("AssetAccName")</td>
                                    </tr>
                                Next
                            </tbody>
                        </table>
                    End Code
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Qty</label>
        </div>
        <div class="col-sm-8">
            <input type="number" onchange="CalAmount()" step="any" inputmode="decimal" id="txtTransQty" name="TransQty" value="@transQty.ToString("0.0000")" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Unit Price</label>
        </div>
        <div class="col-sm-8">
            <input type="number" onchange="CalAmount()" step="any" inputmode="decimal" id="txtTransPrice" name="TransPrice" value="@transPrice.ToString("0.0000")" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Currency Code</label>
        </div>
        <div class="col-sm-8">
            <input type="text" id="txtTransCurrency" name="TransCurrency" class="form-control" value="@transCurrency" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Currency Rate</label>
        </div>
        <div class="col-sm-8">
            <input type="number" onchange="CalAmount()" step="any" inputmode="decimal" id="txtTransRate" name="TransRate" value="@transRate.ToString("0.0000")" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Trans Amount</label>
        </div>
        <div class="col-sm-8">
            <input type="number" step="any" inputmode="decimal" id="txtTransAmount" name="TransAmount" value="@transAmount.ToString("0.0000")" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Asset Account Code</label>
        </div>
        <div class="col-sm-8" style="display:flex;">
            <input type="text" id="txtAssetAccCode" name="AssetAccCode" class="form-control" value="@assetAccCode" />
            <input type="button" data-toggle="modal" data-target="#mdlAccCode" class="btn btn-default" value="..." />
            <label id="txtAssetAccName">@assetAccName</label>
        </div>
    </div>
    <div class="modal" role="document" id="mdlAccCode">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    @Code
                        dtProduct = obj.GetDataFromSQL("SELECT * FROM vMas_AccCode")
                        @<table class="table table-bordered">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Code</th>
                                    <th>Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                @For each dr As Data.DataRow In dtProduct.Rows
                                    @<tr>
                                        <td>
                                            <input type="button" class="btn btn-success" value="Select" data-dismiss="modal" onclick="SetAccCode('@dr("AccCode")','@dr("AccName")')" />
                                        </td>
                                        <td>@dr("AccCode")</td>
                                        <td>@dr("AccName")</td>
                                    </tr>
                                Next
                            </tbody>
                        </table>
                    End Code
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Warehouse Code</label>
        </div>
        <div class="col-sm-8" style="display:flex;">
            <input type="text" id="txtWarehouseCode" name="WarehouseCode" class="form-control" value="@warehouseCode" />
            <input type="button" data-toggle="modal" data-target="#mdlWarehouse" class="btn btn-default" value="..." />
            <label id="txtWarehouseName">@warehouseName</label>
        </div>
    </div>
    <div class="modal" role="document" id="mdlWarehouse">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    @Code
                        dtProduct = obj.GetDataFromSQL("SELECT *,[Name] as WarehouseName FROM vMas_Warehouse")
                        @<table class="table table-bordered">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Code</th>
                                    <th>Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                @For each dr As Data.DataRow In dtProduct.Rows
                                    @<tr>
                                        <td>
                                            <input type="button" class="btn btn-success" value="Select" data-dismiss="modal" onclick="SetWarehouse('@dr("WarehouseCode")','@dr("WarehouseName")')" />
                                        </td>
                                        <td>@dr("WarehouseCode")</td>
                                        <td>@dr("WarehouseName")</td>
                                    </tr>
                                Next
                            </tbody>
                        </table>
                    End Code
                </div>
            </div>
        </div>
    </div>
    <input type="submit" name="Submit" class="btn btn-success" value="Save" />
</form>
<script type="text/javascript">
    var msg = '@msg';
    if (msg !== '') {
        alert(msg);
    }
    function SetData(tno, typ, ref, pcode, pname, qty, price, curr, rate, whcode, whname, accode, acname) {
        document.getElementById("txtTransNum").value = tno;
        document.getElementById("txtRefDocNo").value = ref;
        document.getElementById("txtTransType").value = typ;
        SetProduct(pcode, pname, accode, acname, whcode, whname);
        document.getElementById("txtTransQty").value = qty;
        document.getElementById("txtTransPrice").value = price;
        document.getElementById("txtTransCurrency").value = curr;
        document.getElementById("txtTransRate").value = rate;
        CalAmount();
    }
    function SetProduct(code, name, accode,acname,whcode,whname) {
        document.getElementById("txtStockProductCode").value = code;
        document.getElementById("txtStockProductName").textContent = name;
        SetAccCode(accode, acname);
        SetWarehouse(whcode, whname);
    }
    function SetAccCode(accode, acname) {
        document.getElementById("txtAssetAccCode").value = accode;
        document.getElementById("txtAssetAccName").textContent = acname;
    }
    function SetWarehouse(whcode, whname) {
        document.getElementById("txtWarehouseCode").value = whcode;
        document.getElementById("txtWarehouseName").textContent = whname;
    }
    function CalAmount() {
        let a = Number(document.getElementById("txtTransQty").value);
        let b = Number(document.getElementById("txtTransPrice").value);
        let c = Number(document.getElementById("txtTransRate").value);
        document.getElementById("txtTransAmount").value = (a * b * c);
    }
    function ClearForm() {
        window.location.href = '?Form=StockTrans&DB=@dbName&SRC=@dbSource';
    }

</script>

