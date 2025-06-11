@Code
    ViewData("Title") = "Home Page"
    Dim dbname = "job_demo"
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = "AccConcept"
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
End Code
<div class="container">
    <b>เชื่อมต่อข้อมูลกับระบบ Job</b>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=LinkJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">เช็คยอดที่จะลงบันทึกบัญชีคร่าวๆ</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=TransferJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">ดึงรายการไประบบบัญชีแยกประเภท</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=CheckJob&DB=@dbname&SRC=@dbSource">เช็คยอดหลังจากดึงรายการไประบบบัญชี</a>
        </div>
    </div>
    <b>เอกสารทางบัญชี</b>
    <div class="row">
        <div class="col-md-4">
            <a href="AccReport/Form?Form=Lists&DB=@dbSource">รายการเอกสาร</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="AccReport/Form?DB=@dbSource">สมุดรายวันทั่วไป</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="AccReport?Form=StockCard&SRC=@dbSource">สต๊อกการ์ด</a>
        </div>
    </div>
    <b>รายงานสรุปทางบัญชี</b>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=StockOnhand&DB=@dbname&SRC=@dbSource">สินค้าคงเหลือ</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=ReportGL&DB=@dbname&SRC=@dbSource">รายงานแยกประเภททั่วไป</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname&SRC=@dbSource">งบทดลองแบบแสดงยอดเคลื่อนไหวรายเดือน</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname&Type=1&SRC=@dbSource">งบทดลองแบบสรุปยอดคงเหลือรายเดือน</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname&Type=2&SRC=@dbSource">งบทดลองแบบสรุปยอดยกไป ณ วันสิ้นเดือน</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=ProfitLoss&DB=@dbname&SRC=@dbSource">งบกำไรขาดทุน</a>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <a href="?Form=BalanceSheet&DB=@dbname&SRC=@dbSource">งบแสดงสถานะทางการเงิน</a>
        </div>
    </div>
</div>
