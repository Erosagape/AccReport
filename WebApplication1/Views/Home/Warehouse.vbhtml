@Code
    ViewData("Title") = "Warehouse"
    Dim sql As String = "IF NOT EXISTS(SELECT 1 FROM [dbo].[Mas_Warehouse] WHERE WarehouseCode='{0}')
BEGIN
    INSERT INTO [dbo].[Mas_Warehouse]
       ([WarehouseCode]
       ,[Name]
       ,[Location]
       ,[Address]
       ,[AssetAccCode]
       ,[IncomeAccCode]
       ,[ExpenseAccCode])
    VALUES
       (
       '{0}'
       ,'{1}'
       ,'{2}'
       ,'{3}'
       ,'{4}'
       ,'{5}'
       ,'{6}'
       )
END
ELSE
BEGIN
    UPDATE [dbo].[Mas_Warehouse]
    SET
    [Name] = '{1}'
    ,[Location] = '{2}'
    ,[Address] = '{3}'
    ,[AssetAccCode] = '{4}'
    ,[IncomeAccCode] = '{5}'
    ,[ExpenseAccCode] = '{6}'
    WHERE [WarehouseCode] = '{0}'
END
"
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

    Dim WarehouseID As Integer = 0
    Dim WarehouseCode As String = ""
    Dim WarehouseName As String = ""
    Dim WarehouseLocation As String = ""
    Dim WarehouseAddress As String = ""
    Dim AssetAccCode As String = ""
    Dim IncomeAccCode As String = ""
    Dim ExpenseAccCode As String = ""
    Dim AssetAccName As String = ""
    Dim IncomeAccName As String = ""
    Dim ExpenseAccName As String = ""

    If Not Request.QueryString("Code") Is Nothing Then
        WarehouseCode = Request.QueryString("Code").ToString()
    End If

    If Not Request.Form("submitForm") Is Nothing Then
        bPost = True
        WarehouseCode = Request.Form("WarehouseCode").ToString()
        WarehouseName = Request.Form("WarehouseName").ToString()
        WarehouseLocation = Request.Form("WarehouseLocation").ToString()
        WarehouseAddress = Request.Form("WarehouseAddress").ToString()
        AssetAccCode = Request.Form("AssetAccCode").ToString()
        IncomeAccCode = Request.Form("IncomeAccCode").ToString()
        ExpenseAccCode = Request.Form("ExpenseAccCode").ToString()

        sql = String.Format(sql, WarehouseCode, WarehouseName, WarehouseLocation, WarehouseAddress, AssetAccCode, IncomeAccCode, ExpenseAccCode)
        msg = obj.ExecuteSQL(sql)
    End If

    Dim dt As Data.DataTable = obj.GetDataFromSQL("SELECT * FROM vMas_Warehouse ORDER BY WarehouseCode")
    Dim row = From dr As Data.DataRow In dt.Rows
              Where dr("WarehouseCode").ToString() = WarehouseCode
              Select dr
    If row.Count() > 0 Then
        bEditMode = True
        WarehouseID = Convert.ToInt32(row(0)("WarehouseID"))
        WarehouseName = row(0)("Name").ToString
        WarehouseLocation = row(0)("Location").ToString
        WarehouseAddress = row(0)("Address").ToString
        AssetAccCode = row(0)("AssetAccCode").ToString
        IncomeAccCode = row(0)("IncomeAccCode").ToString
        ExpenseAccCode = row(0)("ExpenseAccCode").ToString
        AssetAccName = row(0)("AssetAccName").ToString
        IncomeAccName = row(0)("IncomeAccName").ToString
        ExpenseAccName = row(0)("ExpenseAccName").ToString
    End If
End Code
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
                            <th>Code</th>
                            <th>Name</th>
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
    @<h4>Edit Warehouse/Service Group</h4>
Else
    @<h4>Add New Warehouse/Service Group</h4>
End If
<input type="button" value="Add New" Class="btn btn-warning" onclick="RefreshPage()" />
<form method="post" action="">
    <input type="hidden" name="WarehouseID" value="@WarehouseID" />
    <div class="form-group">
        <div class="row">
            <div class="col-sm-6">
                <div class="row">
                    <div class="col-sm-4">
                        <label for="WarehouseCode">Warehouse/Group Code</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" name="WarehouseCode" id="WarehouseCode" value="@WarehouseCode" @(If(bEditMode, "readonly", "")) required />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label for="WarehouseName">Name</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" name="WarehouseName" id="WarehouseName" value="@WarehouseName" required />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label for="WarehouseLocation">Location</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" name="WarehouseLocation" id="WarehouseLocation" value="@WarehouseLocation" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label for="WarehouseAddress">Address</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" name="WarehouseAddress" id="WarehouseAddress" value="@WarehouseAddress" />
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="row">
                    <div class="col-sm-4">
                        <label for="AssetAccCode"><a href="#mdlAccCode" onclick="ShowModal('AssetAccCode')" data-toggle="modal" data-target="#mdlAccCode">A/C Purchase</a></label>
                    </div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" name="AssetAccCode" id="AssetAccCode" value="@AssetAccCode" readonly />
                    </div>
                    <div class="col-sm-5">
                        <input type="text" class="form-control" name="AssetAccName" id="AssetAccName" value="@AssetAccName" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label for="IncomeAccCode"><a href="#mdlAccCode" onclick="ShowModal('IncomeAccCode')" data-toggle="modal" data-target="#mdlAccCode">A/C Sales</a></label>
                    </div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" name="IncomeAccCode" id="IncomeAccCode" value="@IncomeAccCode" readonly />
                    </div>
                    <div class="col-sm-5">
                        <input type="text" class="form-control" name="IncomeAccName" id="IncomeAccName" value="@IncomeAccName" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label for="ExpenseAccCode"><a href="#mdlAccCode" onclick="ShowModal('ExpenseAccCode')" data-toggle="modal" data-target="#mdlAccCode">A/C Cost</a></label>
                    </div>
                    <div class="col-sm-3">
                        <input type="text" class="form-control" name="ExpenseAccCode" id="ExpenseAccCode" value="@ExpenseAccCode" readonly />
                    </div>
                    <div class="col-sm-5">
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
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>Warehouse/Group Code</th>
                <th>Description</th>
                <th>Location</th>
                <th>Address</th>
                <th>A/C Purchase</th>
                <th>A/C Sale</th>
                <th>A/C Cost</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <a href="#" onclick="ShowData('@dr("WarehouseCode")')">@dr("WarehouseCode")</a>
                    </td>
                    <td>@dr("Name")</td>
                    <td>@dr("Location")</td>
                    <td>@dr("Address")</td>
                    <td>@dr("AssetAccCode") - @dr("AssetAccName")</td>
                    <td>@dr("IncomeAccCode") - @dr("IncomeAccName")</td>
                    <td>@dr("ExpenseAccCode") - @dr("ExpenseAccName")</td>
                    <td>
                        <a href="@Url.Action("Index", "Home", New With {.Form = "ProductType", .DB = dbname, .SRC = dbSource, .Group = dr("WarehouseCode")})" class="btn btn-primary">Set Product/Service</a>
                    </td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<p>No warehouse found.</p>
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
    function ShowData(code) {
        window.location.href = '@Url.Action("Index", "Home", New With {.Form = "Warehouse", .DB = dbname, .SRC = dbSource})&Code=' + code;
    }
    function SetData(code,name) {
        document.getElementById(targetAcc).value = code;
        document.getElementById(targetAcc.replace('Code','Name')).value = name;
    }
    function RefreshPage() {
        window.location.href = '@Url.Action("Index", "Home", New With {.Form = "Warehouse", .DB = dbname, .SRC = dbSource})';
    }
</script>    