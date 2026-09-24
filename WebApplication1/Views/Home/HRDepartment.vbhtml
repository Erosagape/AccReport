@Code
    ViewData("Title") = "HRDepartment"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim DepartmentId As Integer = 0
    Dim DivisionId As Integer = 0
    Dim HeadDepartmentId As Integer = 0
    Dim DepartmentName As String = ""
    Dim DepartmentNameEN As String = ""
    Dim DivisionName As String = ""

    If Not Request.QueryString("Division") Is Nothing Then
        DivisionId = Convert.ToInt32(Request.QueryString("Division"))
    End If
    If Not Request.QueryString("HeadDepartment") Is Nothing Then
        HeadDepartmentId = Convert.ToInt32(Request.QueryString("HeadDepartment"))
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim bConn = obj.IsConnect()
    Dim sql As String = ""
    Dim msg As String = ""
    If Not Request.Form("Submit") Is Nothing Then
        DepartmentId = Convert.ToInt32(Request.Form("DepartmentId"))
        DivisionId = Convert.ToInt32(Request.Form("DivisionId"))
        HeadDepartmentId = Convert.ToInt32(Request.Form("HeadDepartmentId"))
        DepartmentName = Request.Form("DepartmentName")
        DepartmentNameEN = Request.Form("DepartmentNameEN")
        sql = "IF NOT EXISTS(SELECT 1 FROM [dbo].[Mas_HRDepartment] where [DepartmentId]='{0}')
BEGIN
DECLARE @@MaxDepartmentId INT=(SELECT ISNULL(MAX([DepartmentId]),0)+1 FROM [dbo].[Mas_HRDepartment])
SET IDENTITY_INSERT [dbo].[Mas_HRDepartment] ON
INSERT INTO [dbo].[Mas_HRDepartment] (
[DepartmentId]
,[DepartmentName]
,[DepartmentNameEN]
,[DivisionId]
,[HeadDepartmentId]
) VALUES(
@@MaxDepartmentId
,'{1}'
,'{2}'
,{3}
,{4}
)
SET IDENTITY_INSERT [dbo].[Mas_HRDepartment] OFF
END
ELSE
BEGIN
UPDATE [dbo].[Mas_HRDepartment]
SET
[DepartmentName]='{1}'
,[DepartmentNameEN]='{2}'
,[DivisionId]={3}
,[HeadDepartmentId]={4}
WHERE [DepartmentId]={0}
END
"
        msg = obj.ExecuteSQL(String.Format(sql, DepartmentId, DepartmentName, DepartmentNameEN, DivisionId, HeadDepartmentId))
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If
    Dim dt As New Data.DataTable
    sql = "SELECT DepartmentId,DepartmentName,DepartmentNameEN,DivisionName,a.DivisionId,HeadDepartmentId
from Mas_HRDepartment a inner join Mas_HRDivision b
on a.DivisionId=b.DivisionId
WHERE a.DivisionId={0} AND a.HeadDepartmentId={1}"
    dt = obj.GetDataFromSQL(String.Format(sql, DivisionId, HeadDepartmentId))
End Code
<h2>Department</h2>
<input type="button" value="Add New Department" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-success" onclick="editDepartment('0','','','@DivisionId','@HeadDepartmentId','')" />
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Department Name</th>
                <th>Department Name (ENG)</th>
                <th>Division Name</th>
                <th>Sub Department</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" value="Edit" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-primary" onclick="editDepartment('@dr("DepartmentId")','@dr("DepartmentName")','@dr("DepartmentNameEN")','@dr("DivisionId")','@dr("HeadDepartmentId")','@dr("DivisionName")')" />
                    </td>
                    <td>@dr("DepartmentName")</td>
                    <td>@dr("DepartmentNameEN")</td>
                    <td>@dr("DivisionName")</td>
                    <td>
                        <a href="?Form=HRDepartment&DB=@dbname&SRC=@dbSource&Division=@dr("DivisionId")&HeadDepartment=@dr("HeadDepartmentId")" class="btn btn-info">Sub-Division</a>
                    </td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning">No data found.</div>
End If
<div id="mdlEdit" class="modal" role="document">
    <div clss="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Edit Department
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Division </label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" readonly id="txtDivisionName" name="DivisionName" value="@DivisionName" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Department Id</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" name="DepartmentId" id="txtDepartmentId" value="@DepartmentId" class="form-control" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Department Name</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" name="DepartmentName" id="txtDepartmentName" value="@DepartmentName" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Department Name (Eng)</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" name="DepartmentName" id="txtDepartmentNameEN" value="@DepartmentNameEN" class="form-control" />
                        </div>
                    </div>
                    <input type="hidden" id="txtDivisionId" name="DivisionId" value="@DivisionId" />
                    <input type="hidden" id="txtHeadDepartmentId" name="HeadDepartmentId" value="@HeadDepartmentId" />
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
if (msg !== '') {
        alert(msg);
}
function editDepartment(dpid, dpname, dpnameen, divid, headdpid, divname) {
    document.getElementById('txtDepartmentId').value = dpid;
    document.getElementById('txtDepartmentName').value = dpname;
    document.getElementById('txtDivisionName').value = divname;
    document.getElementById('txtDepartmentNameEN').value = dpnameen;
    document.getElementById('txtHeadDepartmentId').value = headdpid;
    document.getElementById('txtDivisionId').value = divid;
}
</script>