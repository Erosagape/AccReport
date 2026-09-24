@Code
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim lang As String = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
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
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Prompt:wght@300&display=swap" rel="stylesheet">
    <style>
        * {
            font-size: 14px;
            font-family: 'Prompt', sans-serif;
        }

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
            background-color: darkblue; /* Or any other color value */
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

        .card {
            border: 1px solid #e0e0e0;
            border-radius: 8px; /* Smooth, modern rounding */
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); /* Subtle, downward soft shadow */
            font-weight: bolder;
            width: auto;
            margin: 5px 5px 5px 5px;
        }
    </style>
</head>
<body style="background-color:lightgray;">
    <script type="text/javascript">
        function OpenForm(fname, param = '') {
            let period = document.getElementById('txtPeriod').value;
            window.open("@Url.Content("~")?Form=" + fname + "&LANG=@lang&DB=@dbName&SRC=@dbSource&Period=" + period + param, '_self');
        }
        function openNav() {
            document.getElementById("myMenu").style.display = "inline-block";
            document.getElementById("myMenu").classList.remove("col-sm-3");
            document.getElementById("myMenu").classList.add("col-sm-12");

            document.getElementById("myContainer").classList.add("col-sm-9");
            document.getElementById("myContainer").classList.remove("col-sm-12");
        }

        /* Set the width of the sidebar to 0 and the left margin of the page content to 0 */
        function closeNav() {
            document.getElementById("myMenu").style.display = "none";
            document.getElementById("myMenu").classList.remove("col-sm-12");
            document.getElementById("myMenu").classList.add("col-sm-3");

            document.getElementById("myContainer").classList.remove("col-sm-9");
            document.getElementById("myContainer").classList.add("col-sm-12");
        }
        var isOpenMenu = false;
        function ToggleMenu() {
            if (isOpenMenu) {
                closeNav();
            } else {
                openNav();
            }
            isOpenMenu = !isOpenMenu;
        }
    </script>
    <div id="topMenu" class="navbar navbar-custom navbar-dark navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <div style="color:white;" class="navbar-brand navbar-left" onclick="ToggleMenu()">☰ @DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")</div>
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    @If ViewBag.User <> "" Then
                        @<b style="color:white;">Welcome @ViewBag.User</b>
                    Else
                        @<b style="color:white;">Welcome Guest</b>
                    End If
                </button>
            </div>
            <div class="navbar-collapse collapse navbar-right">
                <ul class="nav navbar-nav">
                    <li class="nav nav-item" style="margin-top:5px;">
                        <select class="form-control dropdown" onchange="window.open('@Url.Content("~")?Form=Index@(If(lang = "EN", "", "EN"))&DB=@dbName&SRC=@dbSource&LANG=@(If(lang = "EN", "TH", "EN"))')">
                            <option value="TH" @(If(lang = "TH", "selected", ""))>สรุปภาพรวม (ไทย)</option>
                            <option value="EN" @(If(lang = "EN", "selected", ""))>Dashboard (EN)</option>
                        </select>
                    </li>
                    <li>
                        @If ViewBag.User <> "" Then
                            @<a href="@Url.Content("~")?DB=@dbName&SRC=@dbSource&Form=Login">Log out @ViewBag.User <span class="glyphicon glyphicon-log-in"></span></a>
                        Else
                            @<a href="@Url.Content("~")?DB=@dbName&SRC=@dbSource&Form=Login">Log in <span class="glyphicon glyphicon-log-in"></span></a>
                        End If
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <div class="body-content">
        <div class="container-fluid" style="background-color:white;overflow:scroll;">
            <div class="row">
                @If lang = "TH" Then
                    @<div class="col-sm-3 card" id="myMenu" style="padding: 5px 5px 5px 5px;display:none;">
                        <b> ข้อมูลมาตรฐานทั่วไป</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Profile&DB=@dbName&SRC=@dbSource&lang=@lang"> ข้อมูลกิจการ</a>
                            </div>
                        </div>
                       <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=HRMenu&DB=@dbName&SRC=@dbSource&lang=@lang"> ข้อมูลระบบบริหารงานบุคคล</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=AccCode&DB=@dbname&SRC=@dbSource&lang=@lang"> ผังบัญชี</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ConfigAcc&DB=@dbname&SRC=@dbSource&lang=@lang"> กำหนดมาตรฐานการลงบัญชี</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=DocList&DB=@dbName&SRC=@dbSource&lang=@lang"> กำหนดมาตรฐานเอกสารต้นทาง</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Supplier&DB=@dbName&SRC=@dbSource&lang=@lang"> ข้อมูลผู้จำหน่าย / ผู้ให้บริการ</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Customer&DB=@dbName&SRC=@dbSource&lang=@lang"> ข้อมูลลูกค้า</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ConfigDepre&LANG=TH&DB=@dbName&SRC=@dbSource&lang=@lang"> มาตรฐานค่าเสื่อมราคา</a>
                            </div>
                        </div>
                        <b> ข้อมูลผลิตภัณฑ์และบริการ</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Warehouse&DB=@dbname&SRC=@dbSource&lang=@lang"> ข้อมูลคลังสินค้า / กลุ่มงานบริการ</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ProductType&DB=@dbname&SRC=@dbSource&lang=@lang"> ประเภทสินค้าและยริการ</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ProductMas&DB=@dbname&SRC=@dbSource&lang=@lang"> ข้อมูลสินค้าและยริการ</a>
                            </div>
                        </div>
                        <b> เชื่อมต่อข้อมูลกับระบบ Job</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=LinkJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource&lang=@lang"> เช็คยอดที่จะลงบันทึกบัญชีคร่าวๆ</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=TransferJob_TH&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource&lang=@lang"> ดึงรายการไประบบบัญชีแยกประเภท</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ReportJob&DB=@dbname&SRC=@dbSource&lang=@lang"> เช็คยอดหลังจากดึงรายการไประบบบัญชี</a>
                            </div>
                        </div>
                        <b> เอกสารทางบัญชี</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")Form?Form=Lists&DB=@dbName&SRC=@dbSource&lang=@lang"> รายการเอกสาร</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")Form?DB=@dbName&SRC=@dbSource&lang=@lang"> สมุดรายวันทั่วไป</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Transaction&DB=@dbname&SRC=@dbSource&lang=@lang"> ผ่านรายการไปสมุดรายวัน</a>
                            </div>
                        </div>
                        <b> รายงานสรุปทางบัญชี</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Report&DB=@dbname&SRC=@dbSource&lang=@lang"> ภาพรวม</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=StockCard&DB=@dbName&SRC=@dbSource&lang=@lang"> สต๊อกการ์ด</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=StockOnhand&DB=@dbname&SRC=@dbSource&lang=@lang"> สินค้าคงเหลือ</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ReportDepre&LANG=TH&DB=@dbName&SRC=@dbSource&Code=&lang=@lang"> สรุปค่าเสื่อมราคา</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ReportGL&DB=@dbName&SRC=@dbSource&lang=@lang"> รายงานแยกประเภททั่วไป</a>
                            </div>
                        </div>
                        <b> กระดาษทำการ</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=MonthlyBalance_V2&DB=@dbname&SRC=@dbSource&lang=@lang"> ยอดเคลื่อนไหวสิ้นเดือน</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=MonthlyBalance_V2&DB=@dbname&Type=1&SRC=@dbSource&lang=@lang"> สรุปยอดคงเหลือสิ้นเดือน</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=MonthlyBalance_V2&DB=@dbName&Type=2&SRC=@dbSource&lang=@lang"> สรุปยอดยกไปสิ้นเดือน</a>
                            </div>
                        </div>
                        <b> งบการเงิน</b>
                        ประจำปี(ค.ศ) <br /><input type="number" id="txtPeriod" value="@DateTime.Now.Year" />
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('TrialBalance')">งบทดลอง</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('ProfitLoss')">งบกำไรขาดทุน</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('ProfitLossDetail')">งบกำไรขาดทุน (รายละเอียด)</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('BalanceSheet')">งบแสดงสถานะทางการเงิน</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('CashFlow')">งบกระแสเงินสด</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('ReportCompare','&TYPE=Y')">งบเปรียบเทียบรายปี</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('ReportCompare','&TYPE=Q')">งบเปรียบเทียบตามไตรมาส</a>
                            </div>
                        </div>
                    </div>
                Else
                    @<div class="col-sm-3 card" id="myMenu" style="padding: 5px 5px 5px 5px;display: none;">
                        <b>General Master Files</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Profile&DB=@dbname&SRC=@dbSource&lang=@lang"> Company Profile</a>
                            </div>
                        </div>
                       <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=HRMenu&DB=@dbName&SRC=@dbSource&lang=@lang"> Human Resource Files</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=AccCode&DB=@dbname&SRC=@dbSource&lang=@lang"> Accounts</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ConfigAcc&DB=@dbName&SRC=@dbSource&lang=@lang"> Standard Account Entry</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=DocList&DB=@dbName&SRC=@dbSource&lang=@lang"> Standard Document Types</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Supplier&DB=@dbname&SRC=@dbSource&lang=@lang"> Suppliers / Venders</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Customer&DB=@dbname&SRC=@dbSource&lang=@lang"> Customer</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ConfigDepre&LANG=EN&DB=@dbName&SRC=@dbSource&lang=@lang"> Standard Depreciation</a>
                            </div>
                        </div>
                        <b> Products Master Files</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Warehouse&DB=@dbName&SRC=@dbSource&lang=@lang"> Warehouse / Service Group</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ProductType&DB=@dbname&SRC=@dbSource&lang=@lang"> Product Type</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ProductMas&DB=@dbName&SRC=@dbSource&lang=@lang"> Products</a>
                            </div>
                        </div>
                        <b> Job System Integrated</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=LinkJobEN&DB=@dbName&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource&lang=@lang"> View current state Of data</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=TransferJob_EN&DB=@dbName&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource&lang=@lang"> Post Data To GL Account</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ReportJob&DB=@dbName&SRC=@dbSource&lang=@lang"> Check Data after posted</a>
                            </div>
                        </div>
                        <b> Account Documents</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")Form?Form=Lists&DB=@dbName&SRC=@dbSource&lang=@lang"> List Documents</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")Form?DB=@dbName&SRC=@dbSource&lang=@lang"> Journal Entry</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=Transaction&DB=@dbName&SRC=@dbSource&lang=@lang"> Posting Center</a>
                            </div>
                        </div>
                        <b> Account Reports</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ReportEN&DB=@dbName&SRC=@dbSource&lang=@lang"> Summary</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=StockCard&DB=@dbName&SRC=@dbSource&lang=@lang"> Stock Card</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=StockOnhand&DB=@dbName&SRC=@dbSource&lang=@lang"> Stock Onhand</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ReportDepre&LANG=EN&DB=@dbName&SRC=@dbSource&lang=@lang&Code="> Depreciation</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=ReportGL&LANG=EN&DB=@dbName&SRC=@dbSource&lang=@lang"> General Ledger</a>
                            </div>
                        </div>
                        <b> Working Sheet</b>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=MonthlyBalance_V2&LANG=EN&DB=@dbName&SRC=@dbSource&lang=@lang"> Draft Monthly Balance</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=MonthlyBalance_V2&LANG=EN&DB=@dbName&Type=1&SRC=@dbSource&lang=@lang"> Calculate Monthly Balance</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="@Url.Content("~")?Form=MonthlyBalance_V2&LANG=EN&DB=@dbName&Type=2&SRC=@dbSource&lang=@lang"> Accumulate Monthly Balance</a>
                            </div>
                        </div>
                        <b> Accounts Sheet</b>
                        Period:
                        <br />
                        <input type="number" id="txtPeriod" value="@DateTime.Now.Year" />
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('TrialBalance')">Trial Balance</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('ProfitLoss')">Profit and Loss</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('ProfitLossDetail')">Profit and Loss (Detail)</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('BalanceSheet')">Balance Sheet</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('CashFlow')">Cash Flow</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('ReportCompare','&TYPE=Y')">TB Compare by Year</a>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" onclick="OpenForm('ReportCompare','&TYPE=Q')">TB Compare by Quarter</a>
                            </div>
                        </div>
                    </div>
                End If

                <div class="col-sm-12" id="myContainer" style="padding: 5px 5px 5px 5px;margin-left: 10px; margin-right: 10px; margin-bottom: 5px;">
                    <div class="col-sm-12">
                        @RenderBody()
                    </div>
                </div>
            </div>
            <div class="row">
                &copy; @DateTime.Now.Year - Database = @dbSource
            </div>
        </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
