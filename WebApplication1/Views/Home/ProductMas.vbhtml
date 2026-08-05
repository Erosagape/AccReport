@Code
    ViewData("Title") = "Products And Services"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim tsql As String = ""
    Dim dt As New System.Data.DataTable
    Dim code As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        code = Request.QueryString("Code")
    End If
    Dim msg As String = ""
    Dim postMessage As String = ""
End Code
<h2>@ViewBag.Title</h2>
<div class="container">
    <input type="button" data-toggle="modal" data-target="#mdlProduct" class="btn btn-primary" value="Products" />
    <input type="button" data-toggle="modal" data-target="#mdlService" class="btn btn-primary" value="Services" />
</div>
<div class="modal fade" id="mdlProduct">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Select Products
            </div>
            <div class="modal-body">
                @Code
                    dt = obj.GetDataFromSQL("select * from vMas_Product where IsService=0")
                End Code
                <table border="1" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Code</th>
                            <th>Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        @If dt.Rows.Count > 0 Then
                            For Each dr As Data.DataRow In dt.Rows
                                @<tr>
                                    <td>
                                        <input type="button" data-dismiss="modal" class="btn btn-warning" value="Select" onclick="ShowProduct('@dr("ProductCode").ToString()')" />
                                    </td>
                                    <td>
                                        @dr("ProductCode").ToString()
                                    </td>
                                    <td>
                                        @dr("ProductName").ToString()
                                    </td>
                                </tr>
                            Next
                        End If
                    </tbody>
                </table>
            </div>
            <div class="modal-footer">
                <input type="button" class="btn btn-danger" data-dismiss="modal" value="X" />
            </div>
        </div>
    </div>
</div>
<div class="modal fade" id="mdlWarehouse">
    <div class="modal-dialog" role="dialog">
        <div class="modal-content">
            <div class="modal-header">
                Select Warehouse
            </div>
            <div class="modal-body">
                <table class="table table-responsive" border="1">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Warehouse Code</th>
                            <th>Warehouse Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        @Code
                            Dim dw As Data.DataView = obj.GetDataFromSQL("SELECT * FROM vMas_Warehouse").DefaultView
                            For Each dr As Data.DataRow In dw.ToTable().Rows
                                @<tr>
                                    <td>
                                        <input type="button" class="btn btn-warning" onclick="SetDataWarehouse('@dr("WarehouseCode").ToString()','@dr("Name").ToString()','@dr("AssetAccCode").ToString()','@dr("IncomeAccCode").ToString()','@dr("ExpenseAccCode").ToString()','@dr("AssetAccName").ToString()','@dr("IncomeAccName").ToString()','@dr("ExpenseAccName").ToString()')" value="Select" data-dismiss="modal" />
                                    </td>
                                    <td>
                                        @dr("WarehouseCode").ToString()
                                    </td>
                                    <td>
                                        @dr("Name").ToString()
                                    </td>
                                </tr>
                            Next
                        End Code
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<div id="mdlProductType" class="modal fade">
    <div class="modal-dialog" role="dialog">
        <div class="modal-content">
            <div class="modal_header">
                Select Product Type
            </div>
            <div class="modal-body">
                <table class="table table-responsive" border="1">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Type Code</th>
                            <th>Type Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        @Code
                            Dim dp = obj.GetDataFromSQL("SELECT * FROM vMas_ProductType")
                            If dp.Rows.Count > 0 Then
                                For Each dr As Data.DataRow In dp.Rows
                                    @<tr>
                                        <td>
                                            <input type="button" class="btn btn-warning" onclick="SetDataProductType('@dr("ProductTypeCode").ToString()','@dr("ProductTypeName")','@dr("IsMaterial")','@dr("IsService")','@dr("RateVat")','@dr("RateWht")','@dr("VatType")')" value="Select" data-dismiss="modal" />
                                        </td>
                                        <td>
                                            @dr("ProductTypeCode").ToString()
                                        </td>
                                        <td>
                                            @dr("ProductTypeName").ToString()
                                        </td>
                                    </tr>
                                Next
                            End If
                        End Code
                    </tbody>
                </table>
            </div>
            <div class="modal-footer">
                <input type="button" class="btn btn-danger" data-dismiss="modal" value="Close" />
            </div>
        </div>
    </div>
</div>
<div class="modal fade" id="mdlAccCode">
    <div class="modal-dialog" role="dialog">
        <div class="modal-content">
            <div class="modal-header">
                Select Account Code
            </div>
            <div class="modal-body">
                <table class="table table-responsive" border="1">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Account Code</th>
                            <th>Account Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        @Code
                            Dim ds = obj.GetDataFromSQL("SELECT * FROM Mas_AccCode")
                            If ds.Rows.Count > 1 Then
                                For Each dr As Data.DataRow In ds.Rows
                                    @<tr>
                                        <td>
                                            <input type="button" class="btn btn-warning" onclick="SetData('@dr("AccCode").ToString()','@dr("AccName")')" value="Select" data-dismiss="modal" />
                                        </td>
                                        <td>
                                            @dr("AccCode").ToString()
                                        </td>
                                        <td>
                                            @dr("AccName").ToString()
                                        </td>
                                    </tr>
                                Next
                            End If
                        End Code
                    </tbody>
                </table>
            </div>
            <div class="modal-footer">
                <input type="button" class="btn btn-danger" data-dismiss="modal" value="Close" />
            </div>
        </div>
    </div>
</div>
<div class="modal fade" id="mdlService">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Select Products
            </div>
            <div class="modal-body">
                @Code
                    dt = obj.GetDataFromSQL("select * from vMas_Product where IsService=1")
                End Code
                <table border="1" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Code</th>
                            <th>Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        @If dt.Rows.Count > 0 Then
                            For Each dr As Data.DataRow In dt.Rows
                                @<tr>
                                    <td>
                                        <input type="button" data-dismiss="modal" class="btn btn-warning" value="Select" onclick="ShowProduct('@dr("ProductCode").ToString()')" />
                                    </td>
                                    <td>
                                        @dr("ProductCode").ToString()
                                    </td>
                                    <td>
                                        @dr("ProductName").ToString()
                                    </td>
                                </tr>
                            Next
                        End If
                    </tbody>
                </table>
            </div>
            <div class="modal-footer">
                <input type="button" class="btn btn-danger" data-dismiss="modal" value="X" />
            </div>
        </div>
    </div>
</div>
@Code
    Dim ProductID = 0
    Dim ProductCode = ""
    Dim ProductName = ""
    Dim ProductBrand = ""
    Dim ProductColor = ""
    Dim ProductSize = 0
    Dim ProductSizeUnit = ""
    Dim ProductVolume = 0
    Dim ProductVolumeUnit = ""
    Dim ProductUnitStock = ""
    Dim ProductTypeCode = ""
    Dim ProductTypeName = ""
    Dim IsService As Integer = 0
    Dim IsMaterial As Integer = 0
    Dim VatType As Integer = 1
    Dim VatRate As Double = 0
    Dim WhtRate As Double = 0
    Dim WarehouseCode As String = ""
    Dim WarehouseName As String = ""
    Dim AssetCode As String = ""
    Dim IncomeCode As String = ""
    Dim ExpenseCode As String = ""
    Dim LocationName As String = ""
    Dim WarehouseAddr As String = ""
    Dim AssetName As String = ""
    Dim IncomeName As String = ""
    Dim ExpenseName As String = ""
    If Not Request.Form("Submit") Is Nothing Then

        WarehouseCode = Request.Form("warehouseCode")
        WarehouseName = Request.Form("warehouseName")
        WarehouseAddr = Request.Form("warehouseAddress")
        LocationName = Request.Form("warehouseLocation")
        AssetCode = Request.Form("assetAccCode")
        IncomeCode = Request.Form("incomeAccCode")
        ExpenseCode = Request.Form("expenseAccCode")

        tsql = "
if not exists(select 1 from Mas_Warehouse where WarehouseCode='{0}')
begin
declare @@id int=(select isnull(MAX(WarehouseID),0)+1 from Mas_Warehouse);

insert into Mas_Warehouse(WarehouseID,WarehouseCode,[Name],[Location],[Address],AssetAccCode,IncomeAccCode,ExpenseAccCode)
select @@id,'{0}','{1}','{2}','{3}','{4}','{5}','{6}';
end
else
begin
update Mas_Warehouse
set [Name]='{1}',[Location]='{2}',Address='{3}',
AssetAccCode='{4}',IncomeAccCode='{5}',ExpenseAccCode='{6}'
where WarehouseCode='{0}';
end
"
        tsql = String.Format(tsql, WarehouseCode, WarehouseName, LocationName, WarehouseAddr, AssetCode, IncomeCode, ExpenseCode)
        msg = obj.ExecuteSQL(tsql)
        If msg.Equals("OK") = False Then
            @<span>@msg</span>
            @<p>
                @tsql
            </p>
        End If

        ProductTypeCode = Request.Form("productTypeCode")
        ProductTypeName = Request.Form("productTypeName")
        IsMaterial = Request.Form("isMaterial")
        IsService = Request.Form("isService")
        VatType = Request.Form("vatType")
        VatRate = Request.Form("rateVat")
        WhtRate = Request.Form("rateWht")

        tsql = "
if not exists(select 1 from Mas_ProductType Where ProductTypeCode='{0}')
begin
declare @@id int=(select isnull(MAX(ProductTypeID),0)+1 FROM Mas_ProductType);

insert into Mas_ProductType(ProductTypeID,ProductTypeCode,ProductTypeName,WarehouseCode,IsMaterial,IsService,RateVat,RateWht,VatType)
select @@id,'{0}','{1}','{2}',{3},{4},{5},{6},{7};
end
else
begin
update Mas_ProductType
set ProductTypeName='{1}',
WarehouseCode='{2}',
IsMaterial={3},IsService={4},RateVat={5},RateWht={6},VatType={7}
where ProductTypeCode='{0}'
end
"
        tsql = String.Format(tsql, ProductTypeCode, ProductTypeName, WarehouseCode, IsMaterial, IsService, VatRate, WhtRate, VatType)
        msg = obj.ExecuteSQL(tsql)
        If msg.Equals("OK") = False Then
            @<span>@msg</span>
            @<p>
                @tsql
            </p>
        End If

        ProductCode = Request.Form("productCode")
        ProductName = Request.Form("productName")
        ProductBrand = Request.Form("productBrand")
        ProductColor = Request.Form("productColor")
        ProductSize = Request.Form("productSize")
        ProductSizeUnit = Request.Form("productSizeUnit")
        ProductVolume = Request.Form("productVolume")
        ProductVolumeUnit = Request.Form("productVolumeUnit")
        ProductUnitStock = Request.Form("productUnitStock")

        tsql = "
if not exists(select 1 from Mas_Products where ProductCode='{0}')
begin
insert into Mas_Products(ProductCode,ProductName,Brand,[Color],[Size],SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode,
AssetAccCode,IncomeAccCode,ExpenseAccCode,WarehouseCode)
select '{0}','{1}','{2}','{3}',{4},'{5}',{6},'{7}','{8}','{9}','{10}','{11}','{12}','{13}';
end
else
begin
update Mas_Products
set ProductName='{1}',
Brand='{2}',[Color]='{3}',
[Size]={4},SizeUnit='{5}',
[Volume]={6},VolumeUnit='{7}',
UnitStock='{8}',
ProductTypeCode='{9}',
AssetAccCode='{10}',
IncomeAccCode='{11}',
ExpenseAccCode='{12}',
WarehouseCode='{13}'
where ProductCode='{0}'
end
"
        tsql = String.Format(tsql, ProductCode, ProductName, ProductBrand, ProductColor, ProductSize, ProductSizeUnit,
  ProductVolume, ProductVolumeUnit, ProductUnitStock, ProductTypeCode, AssetCode, IncomeCode, ExpenseCode, WarehouseCode)
        msg = obj.ExecuteSQL(tsql)
        If msg.Equals("OK") = False Then
            @<span>@msg</span>
            @<p>
                @tsql
            </p>
        Else
            postMessage = "Save Complete"
        End If
    End If

    If code <> "" Then
        dt = obj.GetDataFromSQL(String.Format("select * from vMas_Product where ProductCode='{0}'", code))
        If dt.Rows.Count > 0 Then
            Dim dr As Data.DataRow = dt.Rows(0)
            ProductID = dr("ProductID")
            ProductCode = dr("ProductCode")
            ProductName = dr("ProductName")
            ProductColor = dr("ProductColor")
            ProductSize = dr("ProductSize")
            ProductBrand = dr("ProductBrand")
            ProductSizeUnit = dr("ProductSizeUnit")
            ProductVolume = dr("ProductVolume")
            ProductVolumeUnit = dr("ProductVolumeUnit")
            ProductUnitStock = dr("UnitStock")
            IsService = dr("IsService")
            IsMaterial = dr("IsMaterial")
            VatType = dr("VatType")
            VatRate = dr("RateVat")
            WhtRate = dr("RateWht")
            ProductTypeCode = dr("ProductTypeCode")
            ProductTypeName = dr("ProductTypeName")
            WarehouseCode = dr("WarehouseCode")
            WarehouseName = dr("WarehouseName")
            WarehouseAddr = dr("WarehouseAddress")
            AssetCode = dr("AssetAccCode")
            IncomeCode = dr("IncomeAccCode")
            ExpenseCode = dr("ExpenseAccCode")
            LocationName = dr("WarehouseLocation")
            AssetName = dr("AssetAccName")
            IncomeName = dr("IncomeAccName")
            ExpenseName = dr("ExpenseAccName")
        End If
    End If
End Code
<div class="container">
    <form action="" method="post">
        <h4>General Setting</h4>
        <input type="hidden" id="txtProductID" name="productID" value="@ProductID" />
        <div class="row">
            <div class="col-sm-3">
                Code
                <br />
                <input type="text" id="txtProductCode" name="productCode" class="form-control" value="@ProductCode" />
            </div>
            <div class="col-sm-7">
                Name
                <br />
                <input type="text" id="txtProductName" class="form-control" name="productName" value="@ProductName" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                Brand
                <br />
                <input type="text" id="txtProductBrand" class="form-control" name="productBrand" value="@ProductBrand" />
            </div>
            <div class="col-sm-3">
                Color
                <br />
                <input type="text" id="txtProductColor" name="productColor" class="form-control" value="@ProductColor" />
            </div>

        </div>
        <div class="row">
            <div class="col-sm-2">
                Size
                <br />
                <input type="number" id="txtProductSize" class="form-control" name="productSize" value="@ProductSize" />
            </div>
            <div class="col-sm-2">
                Unit
                <br />
                <input type="text" id="txtProductSizeUnit" class="form-control" name="productSizeUnit" value="@ProductSizeUnit" />
            </div>
            <div class="col-sm-2">
                Volume (n)
                <br />
                <input type="number" id="txtProductVolume" class="form-control" name="productVolume" value="@ProductVolume" />
            </div>
            <div class="col-sm-2">
                Volume Unit
                <br />
                <input type="text" id="txtProductVolumeUnit" class="form-control" name="productVolumeUnit" value="@ProductVolumeUnit" />
            </div>
            <div class="col-sm-2">
                Store Unit
                <br />
                <input type="text" id="txtProductUnitStock" class="form-control" name="productUnitStock" value="@ProductUnitStock" />
            </div>
        </div>
        <h4>Inventory Setting</h4>
        <div class="row">
            <div class="col-sm-3">
                <a href="#txtProductTypeCode" data-toggle="modal" data-target="#mdlProductType" onclick="ShowModal('txtProductTypeCode')">Product Type</a>
                <br />
                <input type="text" id="txtProductTypeCode" class="form-control" name="productTypeCode" value="@ProductTypeCode" />
            </div>
            <div class="col-sm-7">
                Type Name
                <br />
                <input type="text" id="txtProductTypeName" class="form-control" name="productTypeName" value="@ProductTypeName" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                Sales Type<br />
                    <select id="cboIsService" name="isService" class="form-control dropdown">
                        <option value="1" @(If(IsService = 1, "selected", ""))>Services</option>
                        <option value="0" @(If(IsService = 0, "selected", ""))>Goods</option>
                    </select>
            </div>
            <div class="col-sm-3">
                Inventory Type<br />
                    <select id="cboIsMaterial" name="isMaterial" class="form-control dropdown">
                        <option value="1" @(If(IsMaterial = 1, "selected", ""))>Material</option>
                        <option value="0" @(If(IsMaterial = 0, "selected", ""))>Finished Goods</option>
                    </select>
            </div>
            <div class="col-sm-2">
                VAT
                <br />
                @If VatType <> 2 Then
                    @<select id="cboVatType" name="vatType" class="form-control dropdown">
                        <option value="1" selected>Exclude</option>
                        <option value="2">Include</option>
                    </select>
                Else
                    @<select id="cboVatType" name="vatType" class="form-control dropdown">
                        <option value="1">Exclude</option>
                        <option value="2" selected>Include</option>
                    </select>
                End If
            </div>
            <div class="col-sm-2">
                Rate<br />
                <input type="number" id="txtVatRate" name="rateVat" value="@VatRate" class="form-control" />
            </div>
            <div class="col-sm-2">
                WHT<br />
                <input type="number" id="txtWhtRate" name="rateWht" value="@WhtRate" class="form-control" />
            </div>
        </div>
        <h4>Store Setting</h4>
        <div class="row">
            <div class="col-sm-3">
                <a href="#txtWarehouseCode" data-toggle="modal" data-target="#mdlWarehouse" onclick="ShowModal('txtWarehouseCode')">Store Code</a>
                <br />
                <input type="text" id="txtWarehouseCode" class="form-control" value="@WarehouseCode" name="warehouseCode" />
            </div>
            <div class="col-sm-7">
                Store Name<br />
                <input type="text" id="txtWarehouseName" class="form-control" value="@WarehouseName" name="warehouseName" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Store Address
                <br />
                <textarea id="txtWarehouseAddr" name="warehouseAddress" class="form-control">@WarehouseAddr</textarea>
            </div>
            <div class="col-sm-4">
                Location/Place<br />
                <textarea id="txtWarehouseLocation" name="warehouseLocation" class="form-control">@LocationName</textarea>
            </div>
        </div>
        <h4>G/L Setup</h4>
        <div class="row">
            <div class="col-sm-4">
                <a href="#txtAssetCode" data-toggle="modal" data-target="#mdlAccCode" onclick="ShowModal('txtAssetCode')">Asset Code</a>
                <br />
                <input type="text" id="txtAssetCode" name="assetAccCode" class="form-control" value="@AssetCode" />
            </div>
            <div class="col-sm-6">
                Name<br />
                <input type="text" id="txtAssetName" name="assetAccName" class="form-control" value="@AssetName" readonly />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a href="#txtIncomeCode" data-toggle="modal" data-target="#mdlAccCode" onclick="ShowModal('txtIncomeCode')">Income Code</a>
                <br />
                <input type="text" id="txtIncomeCode" name="incomeAccCode" class="form-control" value="@IncomeCode" />
            </div>
            <div class="col-sm-6">
                Name<br />
                <input type="text" id="txtIncomeName" name="incomeAccName" class="form-control" value="@IncomeName" readonly />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <a href="#txtExpenseCode" data-toggle="modal" data-target="#mdlAccCode" onclick="ShowModal('txtExpenseCode')">Income Code</a>
                <br />
                <input type="text" id="txtExpenseCode" name="expenseAccCode" class="form-control" value="@ExpenseCode" />
            </div>
            <div class="col-sm-6">
                Name<br />
                <input type="text" id="txtExpenseName" name="expenseAccName" class="form-control" value="@ExpenseName" readonly />
            </div>
        </div>
        <input type="submit" name="Submit" value="Save" class="btn btn-success" />
    </form>
</div>
<script type="text/javascript">
    let msg = '@postMessage';
    let targetCtl = '';
    if (msg !== '') {
        alert(msg);
        window.location = window.location.href;
    }
    function ShowProduct(code) {
	    window.location = "?Form=ProductMas&DB=@dbName&SRC=@dbSource&Code=" + code;
    }
    function ShowModal(ctl) {
        targetCtl = ctl;
    }
    function SetData(code, name) {
        document.getElementById(targetCtl).value = code;
        document.getElementById(targetCtl.replace('Code', 'Name')).value = name;
    }
    function SetDataProductType(code, name, ism, isv, rv, rw, vt) {
        document.getElementById(targetCtl).value = code;
        document.getElementById(targetCtl.replace('Code', 'Name')).value = name;
        document.getElementById('cboIsMaterial').value = ism;
        document.getElementById('cboIsService').value = isv;
        document.getElementById('txtVatRate').value = rv;
        document.getElementById('txtWhtRate').value = rw;
        document.getElementById('cboVatType').value = vt;
    }
    function SetDataWarehouse(code,name,ast,icm,exp,astn,icmn,expn) {
        document.getElementById(targetCtl).value = code;
        document.getElementById(targetCtl.replace('Code', 'Name')).value = name;
        document.getElementById('txtAssetCode').value = ast;
        document.getElementById('txtIncomeCode').value = icm;
        document.getElementById('txtExpenseCode').value = exp;
        document.getElementById('txtAssetName').value = astn;
        document.getElementById('txtIncomeName').value = icmn;
        document.getElementById('txtExpenseName').value = expn;
    }
</script>