@Code
    ViewData("Title") = "Login"
    Dim defaultView As String = "Index"
    If Not Request.QueryString("RedirectTo") Is Nothing Then
        defaultView = Request.QueryString("RedirectTo")
    End If
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
End Code
<style>
    .whitelabel {
       color:white !important;
    }
</style>
<h2>Login</h2>
<form method="post" action="~/Home/PostLoginFromJob">
    <div class="row">
        <div class="col-sm-6" style="background-color: darkblue; padding: 10px 10px 10px 10px; margin: 10px 10px 10px 10px;">
            <div class="container-fluid rounded">
                <input type="hidden" name="Target" value="@defaultView" />
                <div class="row">
                    <div class="col-sm-4">
                        <label class="whitelabel">License ID</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" name="CustID" value="@dbName.ToString().Replace("job_", "")" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label class="whitelabel">User ID</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" name="UserID" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label class="whitelabel">User Password</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="password" class="form-control" name="UserPassword" />
                    </div>
                </div>
            </div>

        </div>
    </div>
    <input type="submit" value="Login" name="Submit" class="btn btn-danger" />
</form>
    


