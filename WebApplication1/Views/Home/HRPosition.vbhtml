@Code
    ViewData("Title") = "HRPosition"
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
SELECT a.[PositionId]
      ,a.[PositionName]
      ,a.[PositionNameEN]
      ,a.[LevelId]
      ,b.LevelName
      ,a.[DepartmentId]
      ,c.DepartmentName
  FROM Mas_HRPosition a
  INNER JOIN Mas_HRLevel b on a.LevelId=b.LevelId 
  INNER JOIN Mas_HRDepartment c on a.DepartmentId=c.DepartmentId
"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Employee Position / ตำแหน่งของพนักงาน</h2>
@If dt.Rows.Count>0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ตำแหน่ง</th>
                <th>ตำแหน่ง (EN)</th>
                <th>ระดับ</th>
                <th>แผนก</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows

                Dim sqlTemp As String = "select c.PositionName,
concat(b.Title,' ',b.StaffName,' ',b.StaffLastName) as StaffFullName,
FORMAT(a.BeginDate,'dd/MM/yyyy') as BeginDate,
FORMAT(a.EndDate,'dd/MM/yyyy') as EndDate,
d.ContractType
from
Mas_HREmployment a
INNER JOIN Mas_HRStaff b
on a.StaffId=b.StaffId
INNER JOIN Mas_HRPosition c
on a.PositionId=c.PositionId
INNER JOIN Mas_HRContractType d
on a.ContractType=d.ContractTypeId
WHERE a.PositionId={0} "
                Dim rs = obj.GetDataFromSQL(String.Format(sqlTemp, dr("PositionId")))
                If rs.Rows.Count > 0 Then
                    @<tr>
                        <td>@dr("PositionId")</td>
                        <td>@dr("PositionName")</td>
                        <td>@dr("PositionNameEN")</td>
                        <td>@dr("LevelId") / @dr("LevelName")</td>
                        <td>@dr("DepartmentId") / @dr("DepartmentName")</td>
                    </tr>
                    @<tr>
                        <td colspan="5">
                            <table class="table table-bordered table-striped">
                                <tbody>
                                    @For Each dr2 As Data.DataRow In rs.Rows
                                        @<tr>
                                            <td style="background-color:white;">ชื่อ : @dr2("StaffFullName")</td>
                                            <td style="background-color:white;">วันเริ่มต้น : @dr2("BeginDate")</td>
                                            <td style="background-color:white;">วันสิ้นสุด : @dr2("EndDate")</td>
                                            <td style="background-color:white;">ประเภทการจ้าง : @dr2("ContractType")</td>
                                        </tr>
                                    Next
                                </tbody>
                            </table>
                        </td>
                    </tr>
                End If
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning">No data found / ไม่พบข้อมูล</div>
End If
