@Code
    ViewData("Title") = "Login"
End Code
<h2>Login</h2>
<form method="post" action="/home/PostLogin">
    <div class="row">
        <div class="col-sm-2">
            <label>Database</label>
        </div>
        <div class="col-sm-4">
            <input type="text" name="CustID" value="@ViewBag.AccDatabase"/>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-2">
            <label>User ID</label>
        </div>
        <div class="col-sm-4">
            <input type="text" name="UserID" value="@ViewBag.User" />
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
    <input type="text" name="Target" value="@ViewBag.Target"/>
    <input type="submit" value="Login" name="Submit" class="btn btn-success" />    
</form>
