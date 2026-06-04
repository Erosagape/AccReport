@Code
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
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
    <link rel="stylesheet"
          href="https://cdn.jsdelivr.net/gh/lipis/flag-icons@7.3.2/css/flag-icons.min.css" />
    <style>
        .navbar a {
            color: white; /* Change link color to white */
        }

        .nav-link.active {
            color: darkblue;
        }

        .nav li:hover a {
            color: darkblue;
        }

        .icon-bar {
            background-color: white; /* Or any other color value */
        }

        .navbar-custom {
            background-color: #f24544; /* Or any other color value */
        }

        b {
            color: blue;
        }

        div {
            color: darkblue;
        }

        input {
            color: black;
        }

        input[type="number"][readonly] {
            background-color: palegreen;
        }

        input[type="date"][readonly], input[type="text"][readonly] {
            background-color: lightcyan;
        }

        input[type="text"], input[type="number"], input[type="date"], textarea {
            background-color: lightyellow;
        }

        h1, h2, h3, h4, h5, h6 {
            color: blue;
        }

        table {
            margin-top: 5px;
            margin-bottom: 5px;
        }

        th {
            text-align: center;
            color: white;
            background-color: red;
            padding: 5px 5px 5px 5px;
        }

        td {
            background-color: lightyellow;
            font-weight: bold;
        }
        .colnum {
            text-align: right;
        }
    </style>
</head>
<body style="background-color:lightgray;">
    <div id="topMenu" class="navbar navbar-custom navbar-dark navbar-fixed-top">
        <div class="container">
            <div class="navbar-brand navbar-right">
                @If ViewBag.User <> "" Then
                    @<a href="~/?DB=@dbName&SRC=@dbSource&Form=Login">@ViewBag.User<span Class="glyphicon glyphicon-log-in"></span></a>
                Else
                    @<a href="~/?DB=@dbName&SRC=@dbSource&Form=Login">Guest <span Class="glyphicon glyphicon-log-in"></span></a>
                End If

            </div>
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a href="~/?DB=@dbName&SRC=@dbSource"><span class="fi fi-th fis"></span>ไทย</a></li>
                    <li><a href="~/?Form=IndexEN&DB=@dbName&SRC=@dbSource"><span class="fi fi-gb fis"></span>English</a></li>
                </ul>
            </div>
        </div>

    </div>
    <div class="body-content">
        <div class="container" style="background-color:white;overflow:scroll;">
            @RenderBody()
            <hr />
            <p>
                &copy; @DateTime.Now.Year - Database = @dbSource
            </p>
        </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
