@Code
    ViewData("Title") = "Login"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim defaultView As String = "Index?DB=" + dbName + "&SRC=" + dbSource
    If Not Request.QueryString("RedirectTo") Is Nothing Then
        defaultView = Request.QueryString("RedirectTo")
    End If
    Dim fromJob As Boolean = False
    If Not Request.QueryString("FromJob") Is Nothing Then
        fromJob = True
    End If
End Code
<style>
    .whitelabel {
        color: white !important;
    }
</style>
<h4>Please confirm your login</h4>
@If fromJob = False Then
    @<form action="~/Home/PostLogin?DB=@dbName&SRC=@dbSource" method="post">
        <div class="row">
            <div class="col-sm-4">
                User ID
            </div>
            <div class="col-sm-8">
                <input type="text" id="txtUserID" name="UserID" class="form-control" value="Test" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                Token
            </div>
            <div class="col-sm-8">
                <input type="password" id="txtUserPassword" name="UserPassword" value="A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=" class="form-control" />
            </div>
        </div>
        <input type="hidden" name="CustID" value="@ViewBag.JobDataBase.ToString().Replace("job_", "")" />
        <input type="hidden" name="Target" value="@defaultView" />
        <div class="row">
            <div class="col-sm-6">
                <div style="display:flex;flex-direction:row;">
                    <input type="submit" value="Submit" class="btn btn-success" />
                    <input type="button" value="Login From Job" class="btn btn-warning" onclick="LoginFromJob()" />
                </div>
            </div>
        </div>
    </form>

Else
    @<form method="post" action="~/Home/PostLoginFromJob">
        <div Class="row">
            <div Class="col-sm-6" style="background-color: darkblue; padding: 10px 10px 10px 10px; margin: 10px 10px 10px 10px;">
                <div Class="container-fluid rounded">
                    <input type="hidden" name="Target" value="@defaultView" />
                    <div Class="row">
                        <div Class="col-sm-4">
                            <Label Class="whitelabel">License ID</Label>
                        </div>
                        <div Class="col-sm-8">
                            <input type="text" Class="form-control" name="CustID" value="@dbName.ToString().Replace("job_", "")" />
                        </div>
                    </div>
                    <div Class="row">
                        <div Class="col-sm-4">
                            <Label Class="whitelabel">User ID</Label>
                        </div>
                        <div Class="col-sm-8">
                            <input type="text" Class="form-control" name="UserID" />
                        </div>
                    </div>
                    <div Class="row">
                        <div Class="col-sm-4">
                            <Label Class="whitelabel">User Password</Label>
                        </div>
                        <div Class="col-sm-8">
                            <input type="password" Class="form-control" name="UserPassword" />
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <input type="submit" value="Login" name="Submit" Class="btn btn-danger" />
    </form>
End If
<span>Login Using @dbName</span>
<script type="text/javascript">
    function LoginFromJob() {
        window.location.href = "?DB=@dbName&SRC=@dbSource&FromJob=Y&RedirectTo=@defaultView";
    }
</script>

