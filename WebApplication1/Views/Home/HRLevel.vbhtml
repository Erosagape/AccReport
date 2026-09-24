@Code
    ViewData("Title") = "Level"
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
    Dim levelId As Integer = 0
    Dim levelName As String = ""
    Dim levelNameEN As String = ""
    Dim sql As String = "IF NOT EXISTS(SELECT 1 FROM [dbo].[Mas_HRLevel] where [LevelId]='{0}')
BEGIN
DECLARE @@MaxLevelId INT=(SELECT ISNULL(MAX([LevelId]),0)+1 FROM [dbo].[Mas_HRLevel])
SET IDENTITY_INSERT [dbo].[Mas_HRLevel] ON
INSERT INTO [dbo].[Mas_HRLevel]
   ([LevelId]
   ,[LevelName]
   ,[LevelNameEN])
VALUES(
   @@MaxLevelId
   ,'{1}'
   ,'{2}'
   )
SET IDENTITY_INSERT [dbo].[Mas_HRLevel] OFF
END
ELSE
BEGIN
UPDATE [dbo].[Mas_HRLevel]
SET
[LevelName] = '{1}'
,[LevelNameEN] = '{2}'
WHERE [LevelId] = '{0}'
END
"
    If Request.Form("submit") IsNot Nothing Then
        levelId = Convert.ToInt32(Request.Form("levelId"))
        levelName = Request.Form("levelName")
        levelNameEN = Request.Form("levelNameEN")
        sql = String.Format(sql, levelId, levelName, levelNameEN)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If
    Dim dt As New Data.DataTable
    dt = obj.GetDataFromSQL("SELECT LevelId,LevelName,LevelNameEN FROM [dbo].[Mas_HRLevel]")
End Code
<h2>Level / ระดับพนักงาน</h2>
<input type="button" value="Add New Level" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-success" onclick="editLevel(0,'','')" />
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>ID</th>
                <th>Level Name / ระดับ</th>
                <th>Level Name (ENG) / ชื่อระดับ (ENG)</th>
            </tr>
        </thead>
        <tbody>
            @For Each row As Data.DataRow In dt.Rows
                @<tr>
                    <td><input type="button" value="Edit" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-primary" onclick="editLevel('@row("LevelId")','@row("LevelName")','@row("LevelNameEN")')" /></td>
                    <td>@row("LevelId")</td>
                    <td>@row("LevelName")</td>
                    <td>@row("LevelNameEN")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<p>No data available.</p>
End If
<div id="mdlEdit" class="modal" role="document">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Edit Level
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblLevelId">Level ID / ID ระดับ</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtLevelId" value="@levelId" name="levelId" readonly class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblLevelName">Level Name / ชื่อระดับ</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtLevelName" value="@levelName" name="levelName" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblLevelNameEN">Level Name (ENG) / ชื่อระดับ (ENG)</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtLevelNameEN" value="@levelNameEN" name="levelNameEN" class="form-control" />
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
    function editLevel(Id, Name, NameEN) {
        document.getElementById('txtLevelId').value = Id;
        document.getElementById('txtLevelName').value = Name;
        document.getElementById('txtLevelNameEN').value = NameEN;
    }
</script>