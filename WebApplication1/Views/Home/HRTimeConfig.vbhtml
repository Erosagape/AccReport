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

    Dim companyId As Integer = 0
    If Not Request.QueryString("Company") Is Nothing Then
        companyId = Convert.ToInt16(Request.QueryString("Company"))
    End If
    Dim shiftNo As Integer = 1
    If Not Request.QueryString("Shift") Is Nothing Then
        shiftNo = Convert.ToInt16(Request.QueryString("Shift"))
    End If
    Dim timeShiftId As Integer = 0
    Dim levelId As Integer = 0
    Dim timeStart As String = ""
    Dim timeEnd As String = ""
    Dim startDate As Date = DateTime.MinValue
    Dim endDate As Date = DateTime.MinValue
    Dim shiftStatus As Integer = 0
    Dim lateStart As String = ""
    Dim otStart As String = ""

    Dim sql As String = ""
    Dim msg As String = ""

    Dim dt As New Data.DataTable

    If Not Request.Form("Submit") Is Nothing Then
        timeShiftId = Request.Form("TimeShifTId")
        levelId = Request.Form("LevelId")
        shiftNo = Request.Form("ShiftNo")
        companyId = Request.Form("CompanyId")
        timeStart = Request.Form("TimeStart")
        timeEnd = Request.Form("TimeEnd")
        startDate = Request.Form("StartDate")
        endDate = Request.Form("EndDate")
        shiftStatus = Request.Form("ShiftStatus")
        lateStart = Request.Form("LateStart")
        otStart = Request.Form("OTStart")

        sql = "
DECLARE @@id int =0
IF NOT EXISTS(select 1 from Mas_HRTimeShift WHERE CompanyId={0} AND LevelId={1} AND ShiftNo={2} AND ShiftStatus=1 AND EndDate>=GETDATE() AND StartDate<=GETDATE())
BEGIN
    SET @@id=(select MAX(TimeShiftId)+1 from Mas_HRTimeShift)

    INSERT INTO Mas_HRTimeShift
    SELECT @@id,{0},{1},{2},'{3}','{4}','{5}','{6}',{7},'{8}','{9}'

END
ELSE    
BEGIN
    SET @@id=(select MAX(TimeShiftId) from Mas_HRTimeShift WHERE CompanyId={0} AND LevelId={1} AND ShiftNo={2} AND ShiftStatus=1 AND EndDate>=GETDATE() AND StartDate<=GETDATE())
    UPDATE Mas_HRTimeShift
    SET CompanyId={0}
        ,LevelId={1}
        ,ShiftNo={2}    
        ,TimeStart='{3}'
        ,TimeEnd='{4}'
        ,StartDate='{5}'
        ,EndDate='{6}'
        ,ShiftStatus={7}
        ,LateStart='{8}'
        ,OTStart='{9}'
    WHERE TimeShiftId=@@id
END
"
        sql = String.Format(sql,
              companyId, levelId, shiftNo,
              timeStart, timeEnd, startDate, endDate,
              shiftStatus, lateStart, otStart
        )
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            msg = "Save Successfully"
        End If
        Response.StatusCode = 200
        Response.SuppressFormsAuthenticationRedirect = True
    End If
    sql = "
select a.LevelId,
a.LevelName,b.ShiftNo,
b.TimeStart,b.TimeEnd,
b.LateStart,b.OTStart,
FORMAT(b.StartDate,'yyyy-MM-dd') as StartDate,
FORMAT(b.EndDate,'yyyy-MM-dd') as EndDate,
(case when b.ShiftStatus=1 then 1 else 0 end) as ShiftStatus,
isnull(b.TimeShiftId,0) as TimeShiftId
from 
Mas_HRLevel a
left join Mas_HRTimeShift b
on a.LevelId=b.LevelId
and b.CompanyId={0}
and b.ShiftNo={1}
and b.ShiftStatus=1
"
    dt = obj.GetDataFromSQL(String.Format(sql, companyId, shiftNo))
End Code
<h2>Time Shift Config / กำหนดเวลาทำงาน</h2>
<br />
ลำดับที่กะ : <input type="number" id="txtShift" value="@shiftNo" />
<input type="button" onclick="RefreshPage()" value="Refresh" class="btn btn-warning" />
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
                    <td>
                        <input type="button" value="Edit" class="btn btn-sm btn-primary" data-toggle="modal" data-target="#mdlEdit"
                               onclick="editData(
    '@dr("TimeShiftId")',
    '@companyId',
    '@dr("LevelId")',
    '@shiftNo',
    '@dr("TimeStart")',
    '@dr("TimeEnd")',
    '@dr("StartDate")',
    '@dr("EndDate")',
    '@dr("ShiftStatus")',
    '@dr("LateStart")',
    '@dr("OTStart")'
    )" />
                    </td>
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
<div class="modal" role="document" id="mdlEdit">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Add/Edit Working Time
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <input type="hidden" id="txtCompanyId" name="CompanyId" value="@companyId" />
                    <input type="hidden" id="txtTimeShiftId" name="TimeShiftId" value="@timeShiftId" />
                    <input type="hidden" id="txtLevelId" name="LevelId" value="@levelId" />
                    <input type="hidden" id="txtShiftNo" name="ShiftNo" value="@shiftNo" />
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Work Start</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtTimeStart" name="TimeStart" class="form-control" value="@timeStart" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Work Finish</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtTimeEnd" name="TimeEnd" class="form-control" value="@timeEnd" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Late Start</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtLateStart" name="LateStart" class="form-control" value="@lateStart" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Overtime Start</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtOTStart" name="OTStart" class="form-control" value="@otStart" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Start Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtStartDate" name="StartDate" class="form-control" value="@startDate.ToString("yyyy-MM-dd")" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>End Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtEndDate" name="EndDate" class="form-control" value="@endDate.ToString("yyyy-MM-dd")" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Status</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="txtShiftStatus" name="ShiftStatus" class="form-control dropdown">
                                <option value="1" @IIf(shiftStatus = 1, "selected", "")>Active</option>
                                <option value="0" @IIf(shiftStatus <> 1, "selected", "")>Not-Active</option>
                            </select>
                        </div>
                    </div>
                    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
                </form>
            </div>
            <div class="modal-footer">
                <div style="float:right">
                    <input type="button" class="btn btn-danger" value="X" data-dismiss="modal" />
                </div>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var msg = '@msg';
    if(msg !== '') {
        alert(msg);
    }
    function RefreshPage() {
        let shiftid = document.getElementById('txtShift').value;
        window.location.href= '?Form=HRTimeConfig&DB=@dbName&SRC=@dbSource&Company=@companyId&Shift=' + shiftid;
    }
    function editData(tsid, cpid, lvid, sno, ts, te, ds, de, st, ls, os) {
        document.getElementById('txtTimeShiftId').value = tsid;
        document.getElementById('txtCompanyId').value = cpid;
        document.getElementById('txtLevelId').value = lvid;
        document.getElementById('txtShiftNo').value = sno;
        document.getElementById('txtTimeStart').value = ts;
        document.getElementById('txtTimeEnd').value = te;
        document.getElementById('txtStartDate').value = ds;
        document.getElementById('txtEndDate').value = de;
        document.getElementById('txtShiftStatus').value = st;
        document.getElementById('txtLateStart').value = ls;
        document.getElementById('txtOTStart').value = os;
    }
</script>