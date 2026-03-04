
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <title>@ViewBag.Title</title>
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Prompt:wght@300&display=swap" rel="stylesheet">
    <style>
	* {
            font-size: 14px;
            font-family: 'Prompt', sans-serif;
        }
        @@page {
            size: A4
        }
        table {
            width:100%;
        }
        h1,h2,h3,h4,h5 {
            color:darkblue;
            font-weight:bold;
            font-size:large;
        }
        th {
            background-color:darkblue;
            color:white;
        }
        .colnum {
            text-align:right;
        }
    </style>
</head>

<!-- Set "A5", "A4" or "A3" for class name -->
<!-- Set also "landscape" if you need -->
<body>
    <!-- Each sheet element should have the class "sheet" -->
    <!-- "padding-**mm" is optional: you can set 10, 15, 20 or 25 -->
    <div>
        @Html.Partial("~/Views/Shared/ReportHeader.vbhtml")
        @RenderBody
    </div>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/jquery")
</body>
</html>