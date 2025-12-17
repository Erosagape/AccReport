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
<div style="display: flex; padding: 5px 5px 5px 5px">
    <div style="flex:1;background-color:lightyellow;">
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
                <a href="?Form=CheckJob&DB=@dbname&SRC=@dbSource">เช็คยอดหลังจากดึงรายการไประบบบัญชี</a>
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
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=MonthlyBalance&DB=@dbname&SRC=@dbSource">งบทดลองแบบแสดงยอดเคลื่อนไหวรายเดือน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=MonthlyBalance&DB=@dbname&Type=1&SRC=@dbSource">งบทดลองแบบสรุปยอดคงเหลือรายเดือน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=MonthlyBalance&DB=@dbname&Type=2&SRC=@dbSource">งบทดลองแบบสรุปยอดยกไป ณ วันสิ้นเดือน</a>
            </div>
        </div>
        <b>งบการเงิน</b>
        ประจำปี(ค.ศ) : <input type="number" id="txtPeriod" value="@DateTime.Now.Year" />
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
    <div style="flex:3">
        @Code
            Dim sql = "select * from Mas_AccConfig where ConfigCode='PROFILE_CONFIG'"
            Dim dt = New AccReport.CUtil(".", dbSource).GetDataFromSQL(sql)
            If dt.Rows.Count > 0 Then
                Dim logoName As String = ""
                @<div class="panel" style="background-color:lightcyan;">
                    @For each dr As Data.DataRow In dt.Rows
                        If dr("ConfigKey").Equals("COMPANY_LOGO") Then
                            If dr("ConfigValue").ToString() <> "" Then
                                logoName = dr("ConfigValue").ToString()
                            End If
                        End If
                        @<div class="row">
                            <div class="col-sm-4">
                                <b>@dr("ConfigKey")</b>
                            </div>
                            <div class="col-sm-8">
                                @dr("ConfigValue")
                            </div>
                        </div>
                    Next
                </div>
                If logoName <> "" Then
                    @<img src="~/@logoName" style="width:200px;"  />
                End If
            End If
        End Code
    </div>
</div>
<script type="text/javascript">
    function OpenForm(fname) {
        let period = document.getElementById('txtPeriod').value;
        window.open("?Form=" + fname + "&LANG=TH&DB=@dbname&SRC=@dbSource&Period=" + period,'_blank');
    }
</script>