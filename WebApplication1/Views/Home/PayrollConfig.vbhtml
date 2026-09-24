@Code
    ViewData("Title") = "PayrollConfig"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable

    Dim msg As String = ""
    Dim sql As String = "
select 
a.PositionId,b.PositionName,
a.ContractTypeId,c.ContractType,
a.SalaryPerMonth,
a.OtPerDay,
a.LatePerDay
from
Mas_HRPayRollConfig a
inner join Mas_HRPosition b
on a.PositionId=b.PositionId
inner join Mas_HRContractType c
on a.ContractTypeId=c.ContractTypeId
"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Payroll Config / กำหนดค่าเงินเดือน</h2>
@If dt.rows.Count > 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ตำแหน่ง</th>
                <th>ประเภทสัญญา</th>
                <th>เงินเดือนต่อเดือน</th>
                <th>ค่า OT ต่อวัน</th>
                <th>ค่าปรับสายต่อวัน</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>@dr("PositionId")</td>
                    <td>@dr("PositionName")</td>
                    <td>@dr("ContractType")</td>
                    <td>@dr("SalaryPerMonth")</td>
                    <td>@dr("OtPerDay")</td>
                    <td>@dr("LatePerDay")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If

