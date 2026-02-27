@Code
    ViewData("Title") = "ProductType"
    Dim sql As String = "IF NOT EXISTS(select 1 from [dbo].[Mas_ProductType] WHERE [ProductTypeCode]='{0}')
BEGIN
    INSERT INTO [dbo].[Mas_ProductType]
    ([ProductTypeCode]
    ,[ProductTypeName]
    ,[WarehouseCode]
    ,[IsMaterial]
    ,[IsService]
    ,[RateVat]
    ,[RateWht]
    ,[VatType]
    ,[AssetAccCode]
    ,[IncomeAccCode]
    ,[ExpenseAccCode])
    VALUES
    (
    '{0}'
    ,'{1}'
    ,'{2}'
    ,{3}
    ,{4}
    ,{5}
    ,{6}
    ,{7}
    ,'{8}'
    ,'{9}'
    ,'{10}'
    )
END
ELSE
BEGIN
    UPDATE [dbo].[Mas_ProductType]
    SET [ProductTypeName] = '{1}'
    ,[WarehouseCode] = '{2}'
    ,[IsMaterial] = {3}
    ,[IsService] = {4}
    ,[RateVat] = {5}
    ,[RateWht] = {6}
    ,[VatType] = {7}
    ,[AssetAccCode] = '{8}'
    ,[IncomeAccCode] = '{9}'
    ,[ExpenseAccCode] = '{10}'
    WHERE [ProductTypeCode]='{0}'
END
"
    Dim ProductTypeID As Integer = 0
    Dim ProductTypeCode As String = ""
    Dim ProductTypeName As String = ""
    Dim WarehouseCode As String = ""
    Dim WarehouseName As String = ""
    Dim IsMaterial As Integer = 0
    Dim IsService As Integer = 0
    Dim RateVat As Double = 0
    Dim RateWht As Double = 0
    Dim VatType As Integer = 0
    Dim AssetAccCode As String = ""
    Dim IncomeAccCode As String = ""
    Dim ExpenseAccCode As String = ""
    Dim AssetAccName As String = ""
    Dim IncomeAccName As String = ""
    Dim ExpenseAccName As String = ""

    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC").ToString()
    End If

    Dim msg As String = ""

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim bPost As Boolean = False
    Dim bEditMode As Boolean = False

    Dim dw As Data.DataView = obj.GetDataFromSQL("SELECT * FROM vMas_Warehouse").DefaultView

    If Not Request.QueryString("Group") Is Nothing Then
        WarehouseCode = Request.QueryString("Group").ToString()
        WarehouseName = dw.ToTable().Select("WarehouseCode='" & WarehouseCode & "'")(0)("Name").ToString()
    End If

    If Not Request.QueryString("Code") Is Nothing Then
        ProductTypeCode = Request.QueryString("Code").ToString()
    End If

    If Not Request.Form("submitForm") Is Nothing Then
        bPost = True
        ProductTypeCode = Request.Form("ProductTypeCode").ToString()
        ProductTypeName = Request.Form("ProductTypeName").ToString()
        WarehouseCode = Request.Form("WarehouseCode").ToString()
        IsMaterial = Convert.ToInt32(Request.Form("IsMaterial").ToString())
        IsService = Convert.ToInt32(Request.Form("IsService").ToString())
        RateVat = Convert.ToDouble(Request.Form("RateVat").ToString())
        RateWht = Convert.ToDouble(Request.Form("RateWht").ToString())
        VatType = Convert.ToInt32(Request.Form("VatType").ToString())
        AssetAccCode = Request.Form("AssetAccCode").ToString()
        IncomeAccCode = Request.Form("IncomeAccCode").ToString()
        ExpenseAccCode = Request.Form("ExpenseAccCode").ToString()

        Dim sqlCmd As String = String.Format(sql, ProductTypeCode, ProductTypeName, WarehouseCode, IsMaterial, IsService, RateVat, RateWht, VatType, AssetAccCode, IncomeAccCode, ExpenseAccCode)
        msg = obj.ExecuteSQL(sqlCmd)
    End If

    Dim dt As Data.DataTable = obj.GetDataFromSQL("SELECT * FROM vMas_ProductType ORDER BY ProductTypeCode")

    Dim row = From dr As Data.DataRow In dt.Rows
              Where dr("ProductTypeCode").ToString() = ProductTypeCode
              Select dr

    If row.Count() > 0 Then
        bEditMode = True
        ProductTypeID = Convert.ToInt32(row(0)("ProductTypeID"))
        ProductTypeName = row(0)("ProductTypeName").ToString()
        ProductTypeCode = row(0)("ProductTypeCode").ToString()
        WarehouseCode = row(0)("WarehouseCode").ToString()
        WarehouseName = row(0)("WarehouseName").ToString()
        IsMaterial = Convert.ToInt32(row(0)("IsMaterial"))
        IsService = Convert.ToInt32(row(0)("IsService"))
        RateVat = Convert.ToDouble(row(0)("RateVat"))
        RateWht = Convert.ToDouble(row(0)("RateWht"))
        VatType = Convert.ToInt32(row(0)("VatType"))
        AssetAccCode = row(0)("AssetAccCode").ToString()
        AssetAccName = row(0)("AssetAccName").ToString()
        IncomeAccCode = row(0)("IncomeAccCode").ToString()
        IncomeAccName = row(0)("IncomeAccName").ToString()
        ExpenseAccCode = row(0)("ExpenseAccCode").ToString()
        ExpenseAccName = row(0)("ExpenseAccName").ToString()
    End If
End Code
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
                            For Each dr As Data.DataRow In dw.ToTable().Rows
                                @<tr>
                                    <td>
                                        <input type="button" class="btn btn-warning" onclick="SetData('@dr("WarehouseCode").ToString()','@dr("Name").ToString()')" value="Select" data-dismiss="modal" />
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
@If bEditMode Then
    @<h2>Edit Product Type</h2>
Else
    @<h2>Add New Product Type</h2>
End If
<input type="button" value="Add New" Class="btn btn-warning" onclick="RefreshPage()" />
<form acton="" method="post">
    <input type="hidden" name="ProductTypeID" value="@ProductTypeID" />
    <div class="form-group">
        <div class="row">
            <div class="col-sm-6">
                <div class="row">
                    <div class="col-sm-4">
                        <label>Product Type Code</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" name="ProductTypeCode" id="ProductTypeCode" value="@ProductTypeCode" class="form-control" @(If(bEditMode, "readonly", "")) required />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Product Type Name</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" name="ProductTypeName" id="ProductTypeName" value="@ProductTypeName" class="form-control" required />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label><a href="#mdlWarehouse" onclick="ShowModal('WarehouseCode')" data-toggle="modal" data-target="#mdlWarehouse">Warehouse/Service Group</a></label>
                    </div>
                    <div class="col-sm-8">
                        <div class="row">
                            <div class="col-sm-4">
                                <input type="text" name="WarehouseCode" id="WarehouseCode" value="@WarehouseCode" class="form-control" readonly />
                            </div>
                            <div class="col-sm-8">
                                <input type="text" name="WarehouseName" id="WarehouseName" value="@WarehouseName" class="form-control" disabled />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Finished Goods/Services</label>
                    </div>
                    <div class="col-sm-6">
                        <select class="form-control" name="IsService" id="IsService">
                            <option value="0" @(If(IsService = 0, "selected", ""))>Finished Goods</option>
                            <option value="1" @(If(IsService = 1, "selected", ""))>Services</option>
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Material/Cost</label>
                    </div>
                    <div class="col-sm-6">
                        <select class="form-control" name="IsMaterial" id="IsMaterial">
                            <option value="0" @(If(IsMaterial = 0, "selected", ""))>Not Material/Cost</option>
                            <option value="1" @(If(IsMaterial = 1, "selected", ""))>Material/Cost</option>
                        </select>
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="row">
                    <div class="col-sm-3">
                        <label>VAT Type</label>
                    </div>
                    <div class="col-sm-3">
                        <select name="VatType" id="VatType" class="form-control">
                            <option value="0" @(If(VatType = 0, "selected", ""))>No Vat</option>
                            <option value="1" @(If(VatType = 1, "selected", ""))>Vat Exclude</option>
                            <option value="2" @(If(VatType = 2, "selected", ""))>Vat Included</option>
                        </select>
                    </div>
                    <div class="col-sm-6">
                        <div class="row">
                            <div class="col-sm-4">
                                <label>Rate VAT</label>
                            </div>
                            <div class="col-sm-8">
                                <input type="text" id="RateVat" name="RateVat" value="@RateVat" class="form-control" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4">
                                <label>Rate WHT</label>
                            </div>
                            <div class="col-sm-8">
                                <input type="text" id="RateWht" name="RateWht" value="@RateWht" class="form-control" />
                            </div>
                        </div>
                    </div>
                </div>
                
                <div class="row">
                    <div class="col-sm-3">
                        <label for="AssetAccCode"><a href="#mdlAccCode" onclick="ShowModal('AssetAccCode')" data-toggle="modal" data-target="#mdlAccCode">A/C Purchase</a></label>
                    </div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" name="AssetAccCode" id="AssetAccCode" value="@AssetAccCode" readonly />
                    </div>
                    <div class="col-sm-6">
                        <input type="text" class="form-control" name="AssetAccName" id="AssetAccName" value="@AssetAccName" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        <label for="IncomeAccCode"><a href="#mdlAccCode" onclick="ShowModal('IncomeAccCode')" data-toggle="modal" data-target="#mdlAccCode">A/C Sales</a></label>
                    </div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" name="IncomeAccCode" id="IncomeAccCode" value="@IncomeAccCode" readonly />
                    </div>
                    <div class="col-sm-6">
                        <input type="text" class="form-control" name="IncomeAccName" id="IncomeAccName" value="@IncomeAccName" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        <label for="ExpenseAccCode"><a href="#mdlAccCode" onclick="ShowModal('ExpenseAccCode')" data-toggle="modal" data-target="#mdlAccCode">A/C Cost</a></label>
                    </div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" name="ExpenseAccCode" id="ExpenseAccCode" value="@ExpenseAccCode" readonly />
                    </div>
                    <div class="col-sm-6">
                        <input type="text" class="form-control" name="ExpenseAccName" id="ExpenseAccName" value="@ExpenseAccName" disabled />
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <input type="submit" name="submitForm" value="Save Data" class="btn btn-success" />
            </div>
        </div>
    </div>
</form>
@If dt.Rows.Count > 0 Then
    @<table class="table table-responsive" border="1">
        <thead>
            <tr>
                <th>#</th>
                <th>Product Type Code</th>
                <th>Product Type Name</th>
                <th>Warehouse/Service Group</th>
                <th>VAT Type</th>
                <th>Rate VAT</th>
                <th>Rate WHT</th>
                <th>Material/Cost</th>
                <th>Finished Goods/Services</th>
                <th>A/C Purchase</th>
                <th>A/C Sales</th>
                <th>A/C Cost</th>
            </tr>
        </thead>
        <tbody>
            @Code
                For Each dr As Data.DataRow In dt.Rows
                    @<tr onclick="ShowData('@dr("ProductTypeCode").ToString()')" style="cursor:pointer">
                        <td>@(dt.Rows.IndexOf(dr) + 1)</td>
                        <td>@dr("ProductTypeCode").ToString()</td>
                        <td>@dr("ProductTypeName").ToString()</td>
                        <td>@dr("WarehouseName").ToString()</td>
                        <td>@(If(Convert.ToInt32(dr("VatType")) = 0, "No Vat", If(Convert.ToInt32(dr("VatType")) = 1, "Vat Exclude", "Vat Included")))</td>
                        <td>@Convert.ToDouble(dr("RateVat"))</td>
                        <td>@Convert.ToDouble(dr("RateWht"))</td>
                        <td>@(If(Convert.ToInt32(dr("IsMaterial")) = 0, "Normal", "Material/Cost"))</td>
                        <td>@(If(Convert.ToInt32(dr("IsService")) = 0, "Finished Goods", "Services"))</td>
                        <td>@dr("AssetAccCode").ToString() - @dr("AssetAccName").ToString()</td>
                        <td>@dr("IncomeAccCode").ToString() - @dr("IncomeAccName").ToString()</td>
                        <td>@dr("ExpenseAccCode").ToString() - @dr("ExpenseAccName").ToString()</td>
                    </tr>
                Next
            End Code
        </tbody>
    </table>
Else
    @<div class="alert alert-warning">No data found.</div>
End If
<script type="text/javascript">
    let msg = '@msg';
    let targetAcc = '';
    if (msg != '') {
        alert(msg);
        RefreshPage();
    }
    function ShowModal(ctl) {
        targetAcc = ctl;
    }
    function ShowModal2(ctl) {
        targetAcc = ctl;
    }
    function ShowData(code) {
        window.location.href = '@Url.Action("Index", "Home", New With {.Form = "ProductType", .DB = dbname, .SRC = dbSource})&Code=' + code;
    }
    function SetData(code,name) {
        document.getElementById(targetAcc).value = code;
        document.getElementById(targetAcc.replace('Code','Name')).value = name;
    }
    function RefreshPage() {
        window.location.href = '@Url.Action("Index", "Home", New With {.Form = "ProductType", .DB = dbname, .SRC = dbSource})';
    }
</script>    