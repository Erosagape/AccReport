@Code
    ViewData("Title") = "Home Page"
    Dim dbname = "job_demo"
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
End Code
<div class="container">
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=LinkJob&DB=@dbname">เช็คยอดที่จะลงบันทึกบัญชีคร่าวๆ</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=TransferJob&DB=@dbname">ดึงรายการไประบบบัญชีแยกประเภท</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=CheckJob&DB=@dbname">เช็คยอดหลังจากดึงรายการไประบบบัญชี</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname">งบทดลองแบบแสดงยอดเคลื่อนไหวรายเดือน</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname&Type=1">งบทดลองแบบสรุปยอดคงเหลือรายเดือน</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname&Type=2">งบทดลองแบบสรุปยอดยกไป ณ วันสิ้นเดือน</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=ProfitLoss&DB=@dbname">งบกำไรขาดทุน</a>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <a href="?Form=BalanceSheet&DB=@dbname">งบแสดงสถานะทางการเงิน</a>
        </div>
    </div>
</div>
