@Code
    ViewData("Title") = "HRMenu"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
End Code
<h2>Human Resource Menu / ระบบบริหารงานบุคคล</h2>
<div class="row">
    <div class="col-sm-3">
        <b>Organization Data / ข้อมูลองค์กร</b>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRCompany&SRC=@dbSource&DB=@dbname">Company Data / ข้อมูลบริษัท</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRDivision&SRC=@dbSource&DB=@dbname">Division Data / ข้อมูลฝ่าย</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRLevel&SRC=@dbSource&DB=@dbname">Staff Level / ระดับพนักงาน</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <b>Employee Data / ข้อมูลพนักงาน</b>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRContract&SRC=@dbSource&DB=@dbname">Contract Configuration / กำหนดสัญญาจ้าง</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRPosition&SRC=@dbSource&DB=@dbname">Position Configuration / กำหนดตำแหน่งงาน</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRStaff&SRC=@dbSource&DB=@dbname">Staff Configuration / กำหนดข้อมูลพนักงาน</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <b>Payroll Data / ข้อมูลการคิดค่าแรง</b>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRTimeConfig&SRC=@dbSource&DB=@dbname">Shift Configuration / กะเวลาทำงาน</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRTaxEmpConfig&SRC=@dbSource&DB=@dbname">Tax-Rate Configuration / กำหนดอัตราภาษีเงินได้บุคคลธรรมดา</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=HRTaxDeductConfig&SRC=@dbSource&DB=@dbname">Tax-Deduct Configuration / กำหนดค่าลดหย่อน</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=SalaryConfig&SRC=@dbSource&DB=@dbname">Salary Configuration / กำหนดค่าเงินเดือน</a>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <a href="?Form=PayrollConfig&SRC=@dbSource&DB=@dbname">Payroll Configuration / กำหนดรายรับ-รายจ่ายพนักงาน</a>
    </div>
</div>
