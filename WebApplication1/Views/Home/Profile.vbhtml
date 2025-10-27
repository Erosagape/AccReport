@Code
    ViewData("Title") = "Company Profile"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim sql As String = ""
    Dim msg As String = "Ready"
    If Not Request.Form("Submit") Is Nothing Then
        Dim cfgCode = Request.Form("ConfigCode")
        Dim cfgKey = Request.Form("ConfigKey")
        Dim cfgValue = Request.Form("ConfigValue")
        If Request.Files.Count > 0 Then
            Dim file = Request.Files.Item(0)
            file.SaveAs(file.FileName)
            cfgValue = file.FileName
        End If
        sql = String.Format("UPDATE Mas_AccConfig SET ConfigValue='{2}' WHERE ConfigCode='{0}' And ConfigKey='{1}'", cfgCode, cfgKey, cfgValue)
        msg = obj.ExecuteSQL(sql)

        Response.SetStatus(HttpStatusCode.ResetContent)
    End If
    sql = "Select * FROM Mas_AccConfig WHERE ConfigCode='PROFILE_CONFIG'"
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
                    <textarea id="txtConfigValue" Class="form-group-lg" style="width:100%" name="ConfigValue">@dr("ConfigValue")</textarea>
                    @If dr("ConfigKey").Equals("COMPANY_LOGO") Then
                        @<input type="file" name="CompanyLogo" />
                    End If
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
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_LOGO" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_LOGO
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                    <input type="file" name="CompanyLogo" />
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_NAME" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_NAME
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_NAME_EN" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_NAME_EN
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_ADDRESS1" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_ADDRESS1
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_ADDRESS2" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_ADDRESS2
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_ADDRESS1_EN" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_ADDRESS1_EN
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_ADDRESS2_EN" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_ADDRESS2_EN
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_TEL" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_TEL
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_FAX" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_FAX
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_EMAIL" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_EMAIL
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_TAXNUMBER" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_TAXNUMBER
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
    @<form action="" method="post">
        <div class="row">
            <input type="hidden" id="txtConfigCode" name="ConfigCode" value="PROFILE_CONFIG" />
            <input type="hidden" id="txtConfigKey" name="ConfigKey" value="COMPANY_TAXBRANCH" />
            <div class="row">
                <div class="col-sm-4">
                    COMPANY_TAXBRANCH
                </div>
                <div class="col-sm-6">
                    <textarea id="txtConfigValue" class="form-group-lg" style="width:100%" name="ConfigValue"></textarea>
                </div>
                <div class="col-sm-2">
                    <input type="submit" name="Submit" value="Save" class="btn btn-success" />
                </div>
            </div>
        </div>
    </form>
End If