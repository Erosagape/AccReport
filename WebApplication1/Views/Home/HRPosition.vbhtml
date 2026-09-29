@Code
    ViewData("Title") = "HRPosition"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim showEmp As Boolean = True
    If Request.QueryString("ShowEmp") Is Nothing Then
        showEmp = False
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable
    Dim positionId As Integer = 0
    Dim positionName As String = ""
    Dim positionNameEN As String = ""
    Dim levelId As Integer = 0
    Dim departmentId As Integer = 0
    Dim msg As String = ""
    Dim sql As String = ""
    If Not Request.Form("Submit") Is Nothing Then
        positionId = Request.Form("PositionId")
        positionName = Request.Form("PositionName")
        positionNameEN = Request.Form("PositionNameEN")
        levelId = Request.Form("LevelId")
        departmentId = Request.Form("DepartmentId")
        sql = "
IF '0'='{0}'
BEGIN
    DECLARE @@id int=(SELECT isnull(MAX(PositionId),0)+1 FROM Mas_HRPosition)
    SET IDENTITY_INSERT Mas_HRPosition ON
    
    INSERT INTO Mas_HRPosition
    SELECT @@id,'{1}','{2}',{3},{4}

    SET IDENTITY_INSERT Mas_HRPosition OFF
END
ELSE
BEGIN
    UPDATE Mas_HRPosition
    SET PositionName='{1}',
        PositionNameEN='{2}',
        LevelId={3},
        DepartmentId={4}
    WHERE PositionId={0}
END
"
        msg = obj.ExecuteSQL(String.Format(sql, positionId, positionName, positionNameEN, levelId, departmentId))
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If
    sql = "
SELECT a.[PositionId]
      ,a.[PositionName]
      ,a.[PositionNameEN]
      ,a.[LevelId]
      ,b.LevelName
      ,a.[DepartmentId]
      ,c.DepartmentName
  FROM Mas_HRPosition a
  INNER JOIN Mas_HRLevel b on a.LevelId=b.LevelId 
  INNER JOIN Mas_HRDepartment c on a.DepartmentId=c.DepartmentId"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Employee Position / ตำแหน่งของพนักงาน</h2>
<input type="button" value="Add New Position" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-success" onclick="editPosition(0,'','',0,0)" />
@If dt.Rows.Count>0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ตำแหน่ง</th>
                <th>ตำแหน่ง (EN)</th>
                <th>ระดับ</th>
                <th>แผนก</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" value="Edit" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-primary" onclick="editPosition('@dr("PositionId")','@dr("PositionName")','@dr("PositionNameEN")','@dr("LevelId")','@dr("DepartmentId")')" />
                    </td>
                    <td>@dr("PositionName")</td>
                    <td>@dr("PositionNameEN")</td>
                    <td>@dr("LevelId") / @dr("LevelName")</td>
                    <td>@dr("DepartmentId") / @dr("DepartmentName")</td>
                </tr>
                If showEmp Then
                    Dim sqlTemp As String = "select c.PositionName,
concat(b.Title,' ',b.StaffName,' ',b.StaffLastName) as StaffFullName,
FORMAT(a.BeginDate,'dd/MM/yyyy') as BeginDate,
FORMAT(a.EndDate,'dd/MM/yyyy') as EndDate,
d.ContractType
from
Mas_HREmployment a
INNER JOIN Mas_HRStaff b
on a.StaffId=b.StaffId
INNER JOIN Mas_HRPosition c
on a.PositionId=c.PositionId
INNER JOIN Mas_HRContractType d
on a.ContractType=d.ContractTypeId
WHERE a.PositionId={0} "
                    Dim rs = obj.GetDataFromSQL(String.Format(sqlTemp, dr("PositionId")))
                    If rs.Rows.Count > 0 Then
                        @<tr>
                            <td colspan="5">
                                <table class="table table-bordered table-striped">
                                    <tbody>
                                        @For Each dr2 As Data.DataRow In rs.Rows
                                            @<tr>
                                                <td style="background-color:white;">ชื่อ : @dr2("StaffFullName")</td>
                                                <td style="background-color:white;">วันเริ่มต้น : @dr2("BeginDate")</td>
                                                <td style="background-color:white;">วันสิ้นสุด : @dr2("EndDate")</td>
                                                <td style="background-color:white;">ประเภทการจ้าง : @dr2("ContractType")</td>
                                            </tr>
                                        Next
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    End If
                End If
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning">No data found / ไม่พบข้อมูล</div>
End If
<div class="modal" role="document" id="mdlEdit">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Add/Edit Position
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Position Id</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtPositionId" name="PositionId" value="@positionId" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Position Name</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtPositionName" name="PositionName" value="@positionName" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Position Name (ENG)</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtPositionNameEN" name="PositionNameEN" value="@positionNameEN" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Level</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="txtLevelId" name="LevelId" class="form-control dropdown">
                                <option value=""></option>
                                @Code
                                    Dim dtLevel = obj.GetDataFromSQL("SELECT * FROM Mas_HRLevel")
                                    If dtLevel.Rows.Count > 0 Then
                                        For Each dr As Data.DataRow In dtLevel.Rows
                                            @<option value="@dr("LevelId")" @IIf(dr("LevelId").Equals(levelId), "selected", "")>@dr("LevelName")</option>
                                        Next
                                    End If
                                End Code
                            </select>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Department</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="txtDepartmentId" name="DepartmentId" class="form-control dropdown">
                                <option value=""></option>
                                @Code
                                    Dim dtDept = obj.GetDataFromSQL("SELECT * FROM Mas_HRDepartment")
                                    If dtDept.Rows.Count > 0 Then
                                        For Each dr As Data.DataRow In dtDept.Rows
                                            @<option value="@dr("DepartmentId")" @IIf(dr("DepartmentId").Equals(departmentId), "selected", "")>@dr("DepartmentName")</option>
                                        Next
                                    End If
                                End Code
                            </select>
                        </div>
                    </div>
                    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
                </form>
            </div>
            <div class="modal-footer">
                <div style="float:right">
                    <input type="button" class="btn btn-danger" value="X" data-dismiss="modal" />
                </div>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var msg = '@msg';
    if(msg !== '') {
        alert(msg);
    }
    function editPosition(Id, Name, NameEN, lvl, dept) {
        document.getElementById('txtPositionId').value = Id;
        document.getElementById('txtLevelId').value = lvl;
        document.getElementById('txtDepartmentId').value = dept;
        document.getElementById('txtPositionName').value = Name;
        document.getElementById('txtPositionNameEN').value = NameEN;
    }
</script>