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
        <div class="container-fluid" style="background-color:white;overflow:scroll;">
            <div class="row">
                <div class="col-sm-3">
                    <b>ข้อมูลมาตรฐานทั่วไป</b>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=Profile&DB=@dbName&SRC=@dbSource">ข้อมูลกิจการ</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=ConfigAcc&DB=@dbName&SRC=@dbSource">กำหนดมาตรฐานการลงบัญชี</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=DocList&DB=@dbName&SRC=@dbSource">กำหนดมาตรฐานเอกสารต้นทาง</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=Supplier&DB=@dbName&SRC=@dbSource">ข้อมูลผู้จำหน่าย/ผู้ให้บริการ</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=Customer&DB=@dbName&SRC=@dbSource">ข้อมูลลูกค้า</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=ConfigDepre&LANG=TH&DB=@dbName&SRC=@dbSource">มาตรฐานค่าเสื่อมราคา</a>
                        </div>
                    </div>
                    <b>ข้อมูลผลิตภัณฑ์และบริการ</b>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=Warehouse&DB=@dbName&SRC=@dbSource">ข้อมูลคลังสินค้า/กลุ่มงานบริการ</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=ProductType&DB=@dbName&SRC=@dbSource">ประเภทสินค้าและยริการ</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=ProductMas&DB=@dbName&SRC=@dbSource">ข้อมูลสินค้าและยริการ</a>
                        </div>
                    </div>
                    <b>เชื่อมต่อข้อมูลกับระบบ Job</b>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=LinkJob&DB=@dbName&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">เช็คยอดที่จะลงบันทึกบัญชีคร่าวๆ</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=TransferJob_TH&DB=@dbName&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">ดึงรายการไประบบบัญชีแยกประเภท</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=ReportJob&DB=@dbName&SRC=@dbSource">เช็คยอดหลังจากดึงรายการไประบบบัญชี</a>
                        </div>
                    </div>
                    <b>เอกสารทางบัญชี</b>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="~/Form?Form=Lists&DB=@dbName&SRC=@dbSource">รายการเอกสาร</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="~/Form?DB=@dbName&SRC=@dbSource">สมุดรายวันทั่วไป</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=Transaction&DB=@dbName&SRC=@dbSource">ผ่านรายการไปสมุดรายวัน</a>
                        </div>
                    </div>
                    <b>รายงานสรุปทางบัญชี</b>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=Report&DB=@dbName&SRC=@dbSource">ภาพรวม</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=StockCard&DB=@dbName&SRC=@dbSource">สต๊อกการ์ด</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=StockOnhand&DB=@dbName&SRC=@dbSource">สินค้าคงเหลือ</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=ReportDepre&LANG=TH&DB=@dbName&SRC=@dbSource&Code=">สรุปค่าเสื่อมราคา</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=ReportGL&DB=@dbName&SRC=@dbSource">รายงานแยกประเภททั่วไป</a>
                        </div>
                    </div>
                    <b>กระดาษทำการ</b>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=MonthlyBalance_V2&DB=@dbName&SRC=@dbSource">ยอดเคลื่อนไหวสิ้นเดือน</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=MonthlyBalance_V2&DB=@dbName&Type=1&SRC=@dbSource">สรุปยอดคงเหลือสิ้นเดือน</a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <a href="?Form=MonthlyBalance_V2&DB=@dbName&Type=2&SRC=@dbSource">สรุปยอดยกไปสิ้นเดือน</a>
                        </div>
                    </div>
                    <b>งบการเงิน</b>
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
                <div class="col-sm-9">
                    @RenderBody()
                </div>

            </div>
            
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
