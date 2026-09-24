@Code
    ViewData("Title") = "HRDivision"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim bConn = obj.IsConnect()
    Dim msg As String = ""
    Dim sql As String = "IF NOT EXISTS(SELECT 1 FROM [dbo].[Mas_HRDivision] where [DivisionId]='{0}')
BEGIN
    DECLARE @@MaxDivisionId INT=(SELECT ISNULL(MAX([DivisionId]),0)+1 FROM [dbo].[Mas_HRDivision])
    SET IDENTITY_INSERT [dbo].[Mas_HRDivision] ON
    INSERT INTO [dbo].[Mas_HRDivision] (
        [DivisionId]
        ,[DivisionName]
        ,[DivisionNameEN]
        ,[CompanyId]
    ) VALUES(
        @@MaxDivisionId
        ,'{1}'
        ,'{2}'
        ,{3}
    )
    SET IDENTITY_INSERT [dbo].[Mas_HRDivision] OFF
END
ELSE
BEGIN
    UPDATE [dbo].[Mas_HRDivision] 
SET
    [DivisionName]='{1}'
    ,[DivisionNameEN]='{2}'
    ,[CompanyId]={3}
WHERE [DivisionId]={0}
ENd
"

    Dim divisionId As Integer = 0
    Dim divisionName As String = ""
    Dim divisionNameEN As String = ""
    Dim companyId As Integer = 0
    If Not Request.QueryString("Company") Is Nothing Then
        companyId = Convert.ToInt32(Request.QueryString("Company"))
    End If

    If Not Request.Form("submit") Is Nothing Then
        divisionId = Convert.ToInt32(Request.Form("DivisionId"))
        divisionName = Request.Form("DivisionName")
        divisionNameEN = Request.Form("DivisionNameEN")
        companyId = Convert.ToInt32(Request.Form("CompanyId"))
        sql = String.Format(sql, divisionId, divisionName, divisionNameEN, companyId)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If

    Dim dt As New Data.DataTable
    sql = "SELECT [DivisionId]
,[DivisionName]
,[DivisionNameEN]
,[CompanyId] FROM [dbo].[Mas_HRDivision]
WHERE [CompanyId] = " & companyId & "
ORDER BY [DivisionId] ASC"

    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Division</h2>
<input type="button" value="Add New Division" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-success" onclick="editDivision('0','','','@companyId')" />
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th style="width: 10%;">#</th>
                <th style="width: 10%;">Division ID</th>
                <th style="width: 30%;">Division Name</th>
                <th style="width: 30%;">Division Name EN</th>
                <th style="width: 20%;">Departments</th>
            </tr>
        </thead>
        <tbody>
            @For Each row As Data.DataRow In dt.Rows
                @<tr>
                    <td><input type="button" value="Edit" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-primary" onclick="editDivision('@row("DivisionId")','@row("DivisionName")','@row("DivisionNameEN")','@row("CompanyId")')" /></td>
                    <td>@row("DivisionId")</td>
                    <td>@row("DivisionName")</td>
                    <td>@row("DivisionNameEN")</td>
                    <td>
                        <a href="?Form=HRDepartment&DB=@dbname&SRC=@dbSource&Division=@row("DivisionId")&HeadDepartment=0" class="btn btn-info">Departments</a>
                    </td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning">No data found.</div>
End If
<div id="mdlEdit" class="modal" role="document">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h4 class="modal-title">Edit Division</h4>
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblCompanyId" name="CompanyId">Company ID</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtCompanyId" name="CompanyId" class="form-control" value="@companyId" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblDivisionId" name="DivisionId">Division ID</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtDivisionId" name="DivisionId" class="form-control" value="@divisionId" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblDivisionName" name="DivisionName">Division Name</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtDivisionName" name="DivisionName" class="form-control" value="@divisionName" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblDivisionNameEN" name="DivisionNameEN">Division Name (EN)</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtDivisionNameEN" name="DivisionNameEN" class="form-control" value="@divisionNameEN" />
                        </div>
                    </div>
                    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-danger" data-dismiss="modal">X</button>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var msg = '@msg';
    if(msg !== '') {
        alert(msg);
    }
    function editDivision(DivisionId, DivisionName, DivisionNameEN, CompanyId) {
        document.getElementById('txtDivisionId').value = DivisionId;
        document.getElementById('txtDivisionName').value = DivisionName;
        document.getElementById('txtDivisionNameEN').value = DivisionNameEN;
        document.getElementById('txtCompanyId').value = CompanyId;
    }
</script>