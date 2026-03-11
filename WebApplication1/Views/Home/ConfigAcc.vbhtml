@Code
    ViewData("Title") = "Standard Entry"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim tsql As String = ""
    Dim dt As New System.Data.DataTable
    Dim configCode As String = ""
    If Not Request.Form("Code") Is Nothing Then
        configCode = Request.Form("Code")
    End If
    Dim configKey As String = ""
    If Not Request.Form("Key") Is Nothing Then
        configKey = Request.Form("Key")
    End If
    Dim configValue As String = ""
    If Not Request.Form("Val") Is Nothing Then
        configValue = Request.Form("Val")
    End If
    Dim postMessage As String = ""
    If configKey <> "" And configCode <> "" Then
        Dim sql As String = "IF EXISTS(select 1 from Mas_AccConfig WHERE ConfigCode='{0}' AND ConfigKey='{1}')
BEGIN
UPDATE Mas_AccConfig SET ConfigValue='{2}' WHERE ConfigCode='{0}' AND ConfigKey='{1}';
END
ELSE
BEGIN
INSERT INTO Mas_AccConfig SELECT '{0}','{1}','{2}';
END
"
        If obj.ExecuteSQL(String.Format(sql, configCode, configKey, configValue)) = "OK" Then
            postMessage = "Save Complete!"
        Else
            postMessage = obj.Message
        End If
    End If
    Dim msg As String = "Ready"
    Dim accName As String = ""
    Dim idVal As String = ""
    Dim idName As String = ""
    Dim idRow As Integer = 0
End Code
<h2>@ViewBag.Title</h2>
@msg
<div class="modal fade" id="mdlSelect">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Select Account Code
                <input type="hidden" id="txtRow" value="@idRow" />
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
                            dt = obj.GetDataFromSQL("SELECT * FROM Mas_AccCode")
                            If dt.Rows.Count > 1 Then
                                For Each dr As Data.DataRow In dt.Rows
                                    @<tr>
                                        <td>
                                            <input type="button" class="btn btn-warning" onclick="SetData('@dr("AccCode").ToString()','@dr("AccName").ToString()')" value="Select" data-dismiss="modal" />
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
                <input class="btn btn-danger" value="X" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal fade" id="mdlSelect2">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Select Product Code
                <input type="hidden" id="txtRow" value="@idRow" />
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
                            dt = obj.GetDataFromSQL("SELECT * FROM Mas_Products")
                            If dt.Rows.Count > 1 Then
                                For Each dr As Data.DataRow In dt.Rows
                                    @<tr>
                                        <td>
                                            <input type="button" class="btn btn-warning" onclick="SetData('@dr("ProductCode").ToString()','@dr("ProductName").ToString()')" value="Select" data-dismiss="modal" />
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
                        End Code
                    </tbody>
                </table>
            </div>
            <div class="modal-footer">
                <input class="btn btn-danger" value="X" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<h4>Setting for Advance Reimbursement</h4>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "ADV_CONFIG"
    configKey = "CashIn"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Debit (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "ADV_CONFIG"
    configKey = "CashOut"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Credit (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "ADV_CONFIG"
    configKey = "TaxCompany"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Credit (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "ADV_CONFIG"
    configKey = "TaxPerson"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Credit (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "ADV_CONFIG"
    configKey = "TaxEmployee"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Credit (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "ADV_CONFIG"
    configKey = "TaxCustomer"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Credit (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "ADV_CONFIG"
    configKey = "DefaultCost"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.ProductName from Mas_AccConfig a inner join Mas_Products b on a.ConfigValue=b.ProductCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("ProductName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect2" onclick="SetRowReturn(@idRow)">Code for Non-fix Advance</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
<h4>Setting for A/P</h4>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "AP_CONFIG"
    configKey = "Purchase"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Credit A/P (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "AP_CONFIG"
    configKey = "CashOut"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Cash/Transfer Payment (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "AP_CONFIG"
    configKey = "ChequeOut"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Cheque Payment (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
<h4>Setting for A/R</h4>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "AR_CONFIG"
    configKey = "Advance"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Customer Expenses (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "AR_CONFIG"
    configKey = "Sales"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Services Charge (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "AR_CONFIG"
    configKey = "CashIn"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Payment Received (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "AR_CONFIG"
    configKey = "Service73"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Income Vat 7/Tax 3 (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "AR_CONFIG"
    configKey = "Service01"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Income Non Vat/Tax 1 (@configKey)</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
<h4>Setting for VAT</h4>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "VAT_CONFIG"
    configKey = "Rate"
    configValue = ""
    accName = ""

    tsql = "select a.* from Mas_AccConfig a where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = ""
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" onclick="">VAT Rate</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="hidden" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "VAT_CONFIG"
    configKey = "UndueInputVat"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Undue Purchase VAT</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "VAT_CONFIG"
    configKey = "InputVat"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Purchase VAT</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "VAT_CONFIG"
    configKey = "UndueOutputVat"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Undue Sale VAT</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "VAT_CONFIG"
    configKey = "OutputVat"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Sale VAT</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
<h4>Setting for WHT</h4>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "RateBroker"
    configValue = ""
    accName = ""

    tsql = "select a.* from Mas_AccConfig a where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = ""
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#">Broker/Rental Tax Rate</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="hidden" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "RateServ"
    configValue = ""
    accName = ""

    tsql = "select a.* from Mas_AccConfig a where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = ""
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#">Services Tax Rate</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="hidden" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "RateTran"
    configValue = ""
    accName = ""

    tsql = "select a.* from Mas_AccConfig a where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = ""
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#">Transport Tax Rate</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="hidden" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "RateInsur"
    configValue = ""
    accName = ""

    tsql = "select a.* from Mas_AccConfig a where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = ""
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#">Dividend Tax Rate</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="hidden" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "RateAds"
    configValue = ""
    accName = ""

    tsql = "select a.* from Mas_AccConfig a where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = ""
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#">Advertisement Tax Rate</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="hidden" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "RateInterests"
    configValue = ""
    accName = ""

    tsql = "select a.* from Mas_AccConfig a where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = ""
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#">Interests Tax Rate</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="hidden" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "IncomeTax"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Invoice Withholding-Tax</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "InputTax"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Withholding Tax Payables</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "WHT_CONFIG"
    configKey = "OutputTax"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Withholding Tax Receivables</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
<h4>Setting for G/L</h4>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "GL_CONFIG"
    configKey = "DefaultProduct"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Product</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "GL_CONFIG"
    configKey = "DefaultSale"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Service</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "GL_CONFIG"
    configKey = "DefaultCost"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Cost</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "GL_CONFIG"
    configKey = "MiscPayment"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Misc.Expense</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "GL_CONFIG"
    configKey = "BankCharge"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Bank Charge/Fee</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "GL_CONFIG"
    configKey = "ProfitLoss"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Default Profit/Loss</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
@Code
    idRow += 1
    idVal = "txtVal" & idRow
    idName = "txtName" & idRow

    configCode = "GL_CONFIG"
    configKey = "WorkInProcess"
    configValue = ""
    accName = ""

    tsql = "select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='{0}' AND a.ConfigKey='{1}'"
    dt = obj.GetDataFromSQL(String.Format(tsql, configCode, configKey))
    If dt.Rows.Count > 0 Then
        configKey = dt.Rows(0)("ConfigKey").ToString()
        configValue = dt.Rows(0)("ConfigValue").ToString()
        accName = dt.Rows(0)("AccName").ToString()
    End If
End Code
<form action="" method="post">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlSelect" onclick="SetRowReturn(@idRow)">Work In Process</a>
            <input type="hidden" name="Key" value="@configKey" />
            <input type="hidden" name="Code" value="@configCode" />
        </div>
        <div class="col-sm-3">
            <input type="text" class="form-control" id="@idVal" name="Val" value="@configValue" />
        </div>
        <div class="col-sm-4">
            <input type="text" readonly class="form-control" id="@idName" name="Name" value="@accName" />
        </div>
        <div class="col-sm-2">
            <input type="submit" class="btn btn-success" name="Submit" value="Save" />
        </div>
    </div>
</form>
<script type="text/javascript">
    var msg = '@postMessage';
    if (msg !== '') {
        alert(msg);
        window.location = window.location.href;
    }
    function SetRowReturn(id) {
        document.getElementById('txtRow').value = id;
    }
    function SetData(code, name) {
        let rowid = document.getElementById('txtRow').value;
        document.getElementById("txtVal" + rowid).value = code;
        document.getElementById("txtName" + rowid).value = name;
    }
</script>