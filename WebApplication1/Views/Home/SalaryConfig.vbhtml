@Code
    ViewData("Title") = "SalaryConfig"
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
select a.SalaryTypeId,
a.SalaryType,
b.ContractTypeId,
c.ContractType,
b.Seq,b.ItemNo,b.SalaryName,
b.SalaryRate,
b.AccCode,d.AccName,
b.SalaryBase as StartValue,
b.SalaryEnd as MaxValue,
b.SalaryFix as FixValue,
(case when b.PayrollType =1 then 'ADD' else 'DEDUCT' end)
as PayRollType
from Mas_HRSalaryType a
inner join Mas_HRSalary b
on a.SalaryTypeId=b.SalaryTypeId
inner join Mas_HRContractType c
on b.ContractTypeId=c.ContractTypeId
left join Mas_AccCode d on b.AccCode=d.AccCode
"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Salary Config / กำหนดสูตรเงินเดือน</h2>
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ประเภทเงินเดือน</th>
                <th>ประเภทสัญญา</th>
                <th>ลำดับ</th>
                <th>รหัสรายการ</th>
                <th>ชื่อรายการ</th>
                <th>อัตราเงินเดือน</th>
                <th>รหัสบัญชี</th>
                <th>ชื่อบัญชี</th>
                <th>ค่าเริ่มต้น</th>
                <th>ค่าสูงสุด</th>
                <th>ค่าคงที่</th>
                <th>ประเภทการจ่ายเงินเดือน</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>@dr("SalaryTypeId")</td>
                    <td>@dr("SalaryType")</td>
                    <td>@dr("ContractType")</td>
                    <td>@dr("Seq")</td>
                    <td>@dr("ItemNo")</td>
                    <td>@dr("SalaryName")</td>
                    <td>@dr("SalaryRate")</td>
                    <td>@dr("AccCode")</td>
                    <td>@dr("AccName")</td>
                    <td>@dr("StartValue")</td>
                    <td>@dr("MaxValue")</td>
                    <td>@dr("FixValue")</td>
                    <td>@dr("PayRollType")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If 