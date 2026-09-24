@Code
    ViewData("Title") = "HRContract"
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

    Dim msg As String = "
select a.ContractNo,
a.ContractId,
concat(c.StaffName,' ',c.StaffLastName) as StaffFullName,
a.StaffId,
b.ContractType,
a.ContractTypeId,
FORMAT(a.DateStart,'dd/MM/yyyy') as DateStart,
FORMAT(a.DateEnd,'dd/MM/yyyy') as DateEnd,
a.ContractNote,
a.ContractStatus,
FORMAT(a.StatusDate,'dd/MM/yyyy') as StatusDate
from 
Acc_HRContract a 
inner join Mas_HRContractType b
on a.ContractTypeId=b.ContractTypeId
inner join Mas_HRStaff c
on a.StaffId=c.StaffId
"
    dt = obj.GetDataFromSQL(msg)
End Code

<h2>Employee Contract / สัญญาจ้างพนักงาน</h2>
@If dt.Rows.Count>0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>เลขที่สัญญา</th>
                <th>ชื่อ-นามสกุล</th>
                <th>ประเภทสัญญา</th>
                <th>วันที่เริ่มสัญญา</th>
                <th>วันที่สิ้นสุดสัญญา</th>
                <th>หมายเหตุ</th>
                <th>สถานะสัญญา</th>
                <th>วันที่เปลี่ยนสถานะ</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>@dr("ContractId")</td>
                    <td>@dr("ContractNo")</td>
                    <td>@dr("StaffFullName")</td>
                    <td>@dr("ContractType")</td>
                    <td>@dr("DateStart")</td>
                    <td>@dr("DateEnd")</td>
                    <td>@dr("ContractNote")</td>
                    <td>@dr("ContractStatus")</td>
                    <td>@dr("StatusDate")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found / ไม่พบข้อมูล
    </div>
End If

