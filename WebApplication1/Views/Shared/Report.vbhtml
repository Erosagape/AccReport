
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <title>@ViewBag.Title</title>
    <style>
        @@page {
            size: A4
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