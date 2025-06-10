@Code
    Dim dbName = "job_demo"
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = "AccConcept"
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div id="topMenu" class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a href="/AccReport?DB=@dbName&SRC=@dbSource">Home</a></li>
                    <li><a href="/AccReport?Form=IndexEN&DB=@dbName&SRC=@dbSource">English</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Database = @dbSource</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
