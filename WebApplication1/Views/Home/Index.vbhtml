@Code
    ViewData("Title") = "Home Page"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
End Code
<style>
    .banner-foot {
        background-color: darkblue;
        padding: 10px 5px 5px 5px;
    }

        .banner-foot b {
            color: yellow !important;
        }
</style>
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-4" style="padding: 5px 5px 5px 5px;">
            <b>ข้อมูลมาตรฐาน</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Profile&SRC=@dbSource">ข้อมูลกิจการ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ConfigAcc&SRC=@dbSource">กำหนดมาตรฐานการลงบัญชี</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ProductMas&SRC=@dbSource">ข้อมูลสินค้าและยริการ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Supplier&DB=@dbname&SRC=@dbSource">ข้อมูลผู้จำหน่าย/ผู้ให้บริการ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Customer&DB=@dbname&SRC=@dbSource">ข้อมูลลูกค้า</a>
                </div>
            </div>
            <b>เชื่อมต่อข้อมูลกับระบบ Job</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=LinkJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">เช็คยอดที่จะลงบันทึกบัญชีคร่าวๆ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=TransferJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">ดึงรายการไประบบบัญชีแยกประเภท</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportJob&DB=@dbname&SRC=@dbSource">เช็คยอดหลังจากดึงรายการไประบบบัญชี</a>
                </div>
            </div>
            <b>เอกสารทางบัญชี</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="~/Form?Form=Lists&DB=@dbname&SRC=@dbSource">รายการเอกสาร</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="~/Form?DB=@dbname&SRC=@dbSource">สมุดรายวันทั่วไป</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=StockCard&DB=@dbname&SRC=@dbSource">สต๊อกการ์ด</a>
                </div>
            </div>
            <b>รายงานสรุปทางบัญชี</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Report&DB=@dbname&SRC=@dbSource">รายงานซื้อขาย</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=StockOnhand&DB=@dbname&SRC=@dbSource">สินค้าคงเหลือ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportGL&DB=@dbname&SRC=@dbSource">รายงานแยกประเภททั่วไป</a>
                </div>
            </div>
            <b>กระดาษทำการ</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance&DB=@dbname&SRC=@dbSource">ยอดเคลื่อนไหวสิ้นเดือน</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance&DB=@dbname&Type=1&SRC=@dbSource">สรุปยอดคงเหลือสิ้นเดือน</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance&DB=@dbname&Type=2&SRC=@dbSource">สรุปยอดยกไปสิ้นเดือน</a>
                </div>
            </div>
            <b>งบการเงิน</b>
            ประจำปี(ค.ศ) : <input type="number" id="txtPeriod" value="@DateTime.Now.Year" />
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
        </div>
        <div class="col-sm-8" style="padding: 5px 5px 5px 5px; text-align: center;">
            <img src="~/OverView.png" style="width:100%;" />
        </div>
    </div>
</div>
<div class="container-fluid">
    <div class="row banner-foot">
        <div class="col-sm-8">
            @Code
                Dim logoName As String = ""
                Dim sql = "select * from Mas_AccConfig where ConfigCode='PROFILE_CONFIG' "
                Dim configSelector As String = "COMPANY_ADDRESS1,COMPANY_ADDRESS2,COMPANY_EMAIL,COMPANY_FAX,COMPANY_LOGO,COMPANY_NAME,COMPANY_TAXBRANCH,COMPANY_TAXNUMBER,COMPANY_TEL,"
                Dim dt = New AccReport.CUtil(".", dbSource).GetDataFromSQL(sql)
                If dt.Rows.Count > 0 Then
                    For Each dr As Data.DataRow In dt.Rows
                        If configSelector.IndexOf(dr("ConfigKey") & ",") >= 0 Then
                            If dr("ConfigKey").Equals("COMPANY_LOGO") Then
                                If dr("ConfigValue").ToString() <> "" Then
                                    logoName = dr("ConfigValue").ToString()
                                End If
                            End If
                            @<div class="row">
                                <div class="col-sm-12" style="color:white;">
                                    <b>@dr("ConfigKey").ToString().Replace("COMPANY_", "")</b> :
                                    @dr("ConfigValue")
                                </div>
                            </div>
                        End If
                    Next
                End If
            End Code
        </div>
        <div class="col-sm-4" style="text-align:center;">
            @If logoName <> "" Then
                @<img src="~/@logoName" style="width:200px;" />
            End If
        </div>
    </div>
</div>

<script type="text/javascript">
    function OpenForm(fname) {
        let period = document.getElementById('txtPeriod').value;
        window.open("?Form=" + fname + "&LANG=TH&DB=@dbname&SRC=@dbSource&Period=" + period,'_blank');
    }
</script>