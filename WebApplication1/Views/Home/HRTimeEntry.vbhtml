@Code
    ViewData("Title") = "HRTimeEntry"
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
    Dim sql As String = ""

    Dim dateFrom As String = ""
    Dim dateTo As String = ""

    Dim staffId As Integer = 0
    Dim checkinDate As String = ""
    Dim checkoutDate As String = ""
    Dim checkInType As Integer = 0
    Dim departmentId As Integer = 0
    Dim companyId As Integer = 0
    Dim workDate As String = ""
    If Not Request.QueryString("Staff") Is Nothing Then
        staffId = Convert.ToInt32(Request.QueryString("Staff"))
    End If
    If Not Request.QueryString("Company") Is Nothing Then
        companyId = Convert.ToInt32(Request.QueryString("Company"))
    End If
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If

    If Not Request.Form("Submit") Is Nothing Then
        staffId = Request.Form("StaffId")
        workDate = Request.Form("WorkDate")
        checkinDate = String.Concat(Request.Form("CheckInDate"), " ", Request.Form("CheckInTime")).Trim()
        checkoutDate = String.Concat(Request.Form("CheckOutDate"), " ", Request.Form("CheckOutTime")).Trim()
        checkInType = Request.Form("CheckInType")
        departmentId = Request.Form("Department").Split("/")(0)
        companyId = Request.Form("Department").Split("/")(1)
        Dim checkInTime As String = Request.Form("CheckInTime")
        sql = "IF NOT EXISTS(select 1 from Acc_HRTimeAttendance WHERE StaffId={0} AND CheckInDate='{1}')
BEGIN
    INSERT INTO Acc_HRTimeAttendance
    SELECT {0},'{2}','{3}',{4},{5},{6}    
END
ELSE
BEGIN
    UPDATE Acc_HRTimeAttendance
    SET CheckInDate='{2}'
        ,CheckOutDate='{3}'
        ,CheckInType={4}
        ,DepartmentId={5}
        ,CompanyId={6}
    WHERE StaffId={0} AND CheckInDate='{1}'
END
"
        sql = String.Format(sql, staffId, workDate, checkinDate, checkoutDate, checkInType, departmentId, companyId, checkInTime)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            msg = "Save Successfully"
        End If
        Response.StatusCode = 200
        Response.SuppressFormsAuthenticationRedirect = True
    End If

    sql = "select a.*,concat(b.StaffName,' ',b.StaffLastName) as StaffName,
c.ConfigValue as CheckinTypeName
from Acc_HRTimeAttendance a
inner join Mas_HRStaff b
on a.StaffId=b.StaffId
inner join (
select * from Mas_HRConfig
where ConfigCode='CHECKIN_TYPE'
) c
on a.CheckInType=c.ConfigKey
WHERE a.DepartmentId>0
"
    If dateFrom <> "" Then
        sql &= String.Format(" AND a.CheckInDate>='{0}'", dateFrom)
    End If
    If dateTo <> "" Then
        sql &= String.Format(" AND a.CheckInDate<='{0}'", dateTo)
    End If
    If staffId > 0 Then
        sql &= String.Format(" AND a.StaffId={0}", staffId)
    End If
    dt = obj.GetDataFromSQL(sql)

    Dim dtEmp = obj.GetDataFromSQL("SELECT * FROM Mas_HRStaff")
End Code
<h2>Time Entry / เวลาทำงาน</h2>
<dic class="row">
    <div class="col-sm-2">
        <label>Date From</label>
        <br />
        <input type="date" id="txtDateFrom" value="@dateFrom" class="form-control" />
    </div>
    <div class="col-sm-2">
        <label>To</label>
        <br />
        <input type="date" id="txtDateTo" value="@dateTo" class="form-control" />
    </div>
    <div class="col-sm-3">
        <label>Staff</label>
        <br />
        <select id="txtStaff" class="form-control dropdown">
            <option value="0">ALL</option>
            @For Each dr As Data.DataRow In dtEmp.Rows
                @<option value="@dr("StaffId")" @IIf(staffId.Equals(dr("StaffId")), "selected", "")>
                    @dr("StaffName")
                </option>
            Next
        </select>
    </div>
    <div class="col-sm-2">
        <br />
        <input type="button" class="btn btn-primary" value="Search" onclick="ShowData()" />
        <input type="button" value="Add New" data-target="#mdlEdit" data-toggle="modal" class="btn btn-success"
               onclick="editData('@staffId','@DateTime.Now.ToString("yyyy-MM-dd HH:mm")','@DateTime.Now.ToString("yyyy-MM-dd HH:mm")','0','0','@companyId')" />
    </div>
</dic>
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Name</th>
                <th>Check In</th>
                <th>Check Out</th>
                <th>Status</th>
            </tr>
        </thead>
        <tbody>
            @For each dr As Data.DataRow in dt.Rows
                @<tr>
                    <td>
                        <input type="button" value="Edit" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-primary" 
                               onclick="editData('@dr("StaffId")','@Convert.ToDateTime(dr("CheckInDate")).ToString("yyyy-MM-dd HH:mm")','@Convert.ToDateTime(dr("CheckOutDate")).ToString("yyyy-MM-dd HH:mm")','@dr("CheckInType")','@dr("DepartmentId")','@dr("CompanyId")')" />
                    </td>
                    <td>@dr("StaffName")</td>
                    <td>@Convert.ToDateTime(dr("CheckInDate")).ToString("dd/MM/yyyy HH:mm:ss")</td>
                    <td>@Convert.ToDateTime(dr("CheckOutDate")).ToString("dd/MM/yyyy HH:mm:ss")</td>
                    <td>@dr("CheckinTypeName")</td>
                </tr>
            Next
        </tbody>
    </table>
End If
<div class="modal" id="mdlEdit" role="document">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Add Edit Time Entry
            </div>
            <div class="modal-body">
                <form action="" method="POST">
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Staff</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="txtStaffId" name="StaffId" class="form-control dropdown">
                                <option value="0">ALL</option>
                                @For Each dr As Data.DataRow In dtEmp.Rows
                                    @<option value="@dr("StaffId")" @IIf(staffId.Equals(dr("StaffId")), "selected", "")>
                                        @dr("StaffName")
                                    </option>
                                Next
                            </select>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Check-In Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtCheckIn" class="form-control" name="CheckInDate" value="" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Check-In Time</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="time" id="txtCheckInTime" class="form-control" name="CheckInTime" value="" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Check-Out Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtCheckOut" class="form-control" name="CheckOutDate" value="" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Check-Out Time</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="time" id="txtCheckOutTime" class="form-control" name="CheckOutTime" value="" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Department</label>
                        </div>
                        <div class="col-sm-8">
                            @code
                                Dim rsDept = obj.GetDataFromSQL("select b.CompanyId,b.DivisionId,b.DivisionName,
a.DepartmentId,a.DepartmentName
from Mas_HRDepartment a
inner join Mas_HRDivision b
 on a.DivisionId=b.DivisionId")
                                @<select id="txtDepartment" class="form-control dropdown" name="Department" onchange="SetCombo()">
                                    <option value="0/0"></option>
                                    @For each dr As Data.DataRow in rsDept.Rows
                                        @<option value="@dr("DepartmentID")/@dr("CompanyId")" @IIf(String.Concat(dr("DepartmentID"), "/", dr("CompanyId")).Equals(String.Concat(departmentId, "/", companyId)), "selected", "")>
                                            @dr("DepartmentName")
                                        </option>
                                    Next
                                </select>
                            End Code
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Check-Type</label>
                        </div>
                        <div class="col-sm-8">
                            @Code
                                Dim rsType = obj.GetDataFromSQL("select * from Mas_HRConfig where ConfigCode='CHECKIN_TYPE'")
                                @<select id="txtCheckInType" class="form-control dropdown" name="CheckInType">
                                    @For each dr As Data.DataRow In rsType.Rows
                                        @<option value="@dr("ConfigKey")" @IIf(checkInType.ToString.Equals(dr("ConfigKey")), "selected", "")>
                                            @dr("ConfigValue")
                                        </option>
                                    Next
                                </select>
                            End Code
                        </div>
                    </div>
                    <input type="hidden" id="txtWorkDate" name="WorkDate" value="" />
                    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
                </form>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var msg = '@msg';
    if(msg !== '') {
        alert(msg);
    }
    function editData(staff, checkindate, checkoutdate, checkintype, deptid, compid) {
        document.getElementById("txtStaffId").value = staff;
        document.getElementById("txtWorkDate").value = checkindate;
        document.getElementById("txtCheckIn").value = checkindate.split(" ")[0];
        document.getElementById("txtCheckInTime").value = checkindate.split(" ")[1];
        document.getElementById("txtCheckOut").value = checkoutdate.split(" ")[0];
        document.getElementById("txtCheckOutTime").value = checkoutdate.split(" ")[1];
        document.getElementById("txtCheckInType").value = checkintype;
        document.getElementById("txtDepartment").value = (deptid+'/'+compid);
    }

    function ShowData() {
        var df = document.getElementById("txtDateFrom").value;
        var dt = document.getElementById("txtDateTo").value;
        var emp = document.getElementById("txtStaff").value;
        window.location.href = "?Form=HRTimeEntry&DB=@dbName&SRC=@dbSource&DateFrom=" + df + "&DateTo=" + dt + '&Staff=' + emp;
    }
</script>