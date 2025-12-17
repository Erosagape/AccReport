@Code
    Layout = Nothing
End Code
<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="~/Content/form.css">
</head>

<body>

    <div class="page-header" style="text-align: center">
        @Html.Partial("~/Views/Shared/ReportHeader.vbhtml")
    </div>
    <div class="page-footer">
        Print Date @DateTime.Now.ToString()
    </div>
    <table>
        <thead>
            <tr>
                <td>
                    <!--place holder for the fixed-position header-->
                    <div class="page-header-space"></div>
                </td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <!--*** CONTENT GOES HERE ***-->
                    <div class="page">
                        <table border="1" style="border-collapse:collapse;width:100%;">
                            <thead>
                                <tr>
                                    <th>Row</th>
                                    <th>Data</th>
                                </tr>
                            </thead>
                            <tbody>
                                @For i As Integer = 1 To 50
                                    @<tr>
                                    <td>@i</td>
                                    <td>0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789</td>
                                </tr>
                                Next
                            </tbody>
                        </table>
                    </div>
                </td>
            </tr>
        </tbody>
        <tfoot>
            <tr>
                <td>
                    <!--place holder for the fixed-position footer-->
                    <div Class="page-footer-space"></div>
                </td>
            </tr>
        </tfoot>

    </table>

</body>

</html>