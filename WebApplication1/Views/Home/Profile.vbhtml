@Code
    ViewData("Title") = "Company Profile"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim sql As String = ""
    Dim msg As String = "Ready"
    Dim obj = New AccReport.CUtil(".", dbSource)
    If Not Request.Form("Submit") Is Nothing Then
        Dim cfgCode = Request.Form("ConfigCode")
        Dim cfgKey = Request.Form("ConfigKey")
        Dim cfgValue = Request.Form("ConfigValue")
        sql = String.Format("UPDATE Mas_AccConfig SET ConfigValue='{2}' WHERE ConfigCode='{0}' And ConfigKey='{1}'", cfgCode, cfgKey, cfgValue)
        msg = obj.ExecuteSQL(sql)
        Response.SetStatus(HttpStatusCode.ResetContent)
    End If
    sql = "Select * FROM Mas_AccConfig WHERE ConfigCode Like 'PROFILE_CONFIG'"
    Dim dt = obj.GetDataFromSQL(sql)
End Code
<h2>@ViewBag.Title</h2>
@If dt.Rows.Count > 0 Then
    For Each dr As Data.DataRow In dt.Rows
        @<form method="post" action="">
    <input type="hidden" id="txtConfigCode" name="ConfigCode" value="@dr("ConfigCode")" />
    <input type="hidden" id="txtConfigKey" name="ConfigKey" value="@dr("ConfigKey")" />
    <div class="row">
        <div class="col-sm-4">
            @dr("ConfigKey")
        </div>
        <div class="col-sm-6">
            <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue">@dr("ConfigValue")</textarea>
        </div>
        <div class="col-sm-2">
            <input type="submit" name="Submit" value="Save" class="btn btn-success" />
        </div>
    </div>
</form>
    Next
    @msg
Else
    @<span>Profile Configuration not found!</span>
End If