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
<div class="row">
    <div class="col-sm-6">
        <h2>Human Resource Menu / ระบบบริหารงานบุคคล</h2>
        <div class="row">
            <div class="col-sm-12">
                <b>General Data / ข้อมูลทั่วไป</b>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRCompany&SRC=@dbSource&DB=@dbname">Organization Data / ข้อมูลองค์กร</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRLevel&SRC=@dbSource&DB=@dbname">Staff Level / ระดับพนักงาน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRPosition&SRC=@dbSource&DB=@dbname">Position Configuration / ตำแหน่งงาน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRContractType&SRC=@dbSource&DB=@dbname">Contract Type / ประเภทสัญญาจ้าง</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <b>Employee Data / ข้อมูลพนักงาน</b>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRStaff&SRC=@dbSource&DB=@dbname">Employee Data / กำหนดข้อมูลพนักงาน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRContract&SRC=@dbSource&DB=@dbname">Employee Contract / สัญญาจ้าง</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=PayrollConfig&SRC=@dbSource&DB=@dbname">Salary Rate / กำหนดอัตราเงินเดือน </a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <b>Payroll Data / ข้อมูลการคิดค่าแรง</b>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRTaxEmpConfig&SRC=@dbSource&DB=@dbname">Tax-Rate Configuration / กำหนดอัตราภาษีเงินได้บุคคลธรรมดา</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRTaxDeductConfig&SRC=@dbSource&DB=@dbname">Tax-Deduct Configuration / กำหนดค่าลดหย่อน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=SalaryConfig&SRC=@dbSource&DB=@dbname">Salary Monthly / กำหนดรายการประจำเดือน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=ReportTaxEmp&SRC=@dbSource&DB=@dbname">Tax-Calculation Summary / สรุปภาษีเงินได้ของพนักงาน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <b>Transaction Data / ข้อมูลการทำรายการ</b>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRTimeEntry&SRC=@dbSource&DB=@dbname">Work Time Entry / บันทักเวลาทำงาน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRTaxDeduct&SRC=@dbSource&DB=@dbname">Employee Tax-Deduction / บันทึกการลดหย่อนพนักงาน</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=HRPayroll&SRC=@dbSource&DB=@dbname">Payroll Slip / บันทึกสลิปเงินเดือน</a>
            </div>
        </div>
    </div>
    <div class="col-sm-6">
        <img src="/../Resource/payroll.png" style="width:100%" />
    </div>
</div>