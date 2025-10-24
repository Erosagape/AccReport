@Code
    ViewData("Title") = "Login"
    Dim defaultView As String = "Test"
    If Not Request.QueryString("RedirectTo") Is Nothing Then
        defaultView = Request.QueryString("RedirectTo")
    End If
    Dim dbName = ViewBag.AccDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.JobDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dataLogin As String = ""
    If Not Request.Form("Submit") Is Nothing Then
        Dim userId As String = Request.Form("UserID")
        Dim hashPassword As String = Request.Form("UserPassword")
        Dim custId As String = Request.Form("CustID")
        dataLogin = "{
    ""userId"":""" + userId + """,
    ""hashPassword"":""" + hashPassword + """,
    ""dbAlias"":""" + dbName + """,
    ""custId"":""" + custId + """
}"
    End If
End Code
<h2>Login</h2>
<form method="post" action="">
    <div class="row">
        <div class="col-sm-2">
            <label>License ID</label>
        </div>
        <div class="col-sm-4">
            <input type="text" name="CustID" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label>User ID</label>
        </div>
        <div class="col-sm-4">
            <input type="text" name="UserID" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label>User Password</label>
        </div>
        <div class="col-sm-4">
            <input type="password" name="UserPassword" />
        </div>
    </div>
    <input type="submit" value="Login" name="Submit" class="btn btn-success" />
</form>
<script type="text/javascript">
    var data = '@dataLogin';
    var url = '@defaultView';
    if (data !== '') {
        var obj = JSON.parse(data);
        var json = JSON.stringify(obj);
        $.post(window.location.pathname+'/PostLogin', json, function () {
            window.location.href = url;
        });
    }
</script>
