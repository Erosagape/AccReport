
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <title>@ViewBag.Title</title>
    <!-- Load paper.css for happy printing -->
    <link rel="stylesheet" href="~/Content/paper.css">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Prompt:wght@300&display=swap" rel="stylesheet">
    <!-- Set page size here: A5, A4 or A3 -->
    <!-- Set also "landscape" if you need -->
    <style>
	* {
            font-size: 14px;
            font-family: 'Prompt', sans-serif;
        }
        @@page {
            size: A4
        }
        table {
            margin-top:5px;
            margin-bottom:5px;
        }
        th,td {
            padding:2px 2px 2px 2px;
        }
        th {
            background-color:darkblue;
            color:white;
        }
        b {
            color:darkblue;
        }
        h1,h2,h3,h4,h5 {
            color:darkblue;
            font-size:large;
        }
        .colnum {
            text-align:right;
        }
        .footer-title {
            background-color:darkblue;
            color:white;
        }
    </style>
</head>

<!-- Set "A5", "A4" or "A3" for class name -->
<!-- Set also "landscape" if you need -->
<body class="A4">
    <!-- Each sheet element should have the class "sheet" -->
    <!-- "padding-**mm" is optional: you can set 10, 15, 20 or 25 -->
    <div class="sheet padding-10mm">
        @Html.Partial("~/Views/Shared/ReportHeader.vbhtml")
        @RenderBody
    </div>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/jquery")
</body>
</html>