@Code
    ViewData("Title") = "HRTimeConfig"
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
select a.LevelId,
a.LevelName,b.ShiftNo,
b.TimeStart,b.TimeEnd,
b.LateStart,b.OTStart
from 
Mas_HRLevel a
left join Mas_HRTimeShift b
on a.LevelId=b.LevelId
"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Time Shift Config / กำหนดเวลาทำงาน</h2>
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ระดับ</th>
                <th>รหัสกะ</th>
                <th>เวลาเริ่มงาน</th>
                <th>เวลาเลิกงาน</th>
                <th>เวลาเริ่มสาย</th>
                <th>เวลาเริ่ม OT</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>@dr("LevelId")</td>
                    <td>@dr("LevelName")</td>
                    <td>@dr("ShiftNo")</td>
                    <td>@dr("TimeStart")</td>
                    <td>@dr("TimeEnd")</td>
                    <td>@dr("LateStart")</td>
                    <td>@dr("OTStart")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If
