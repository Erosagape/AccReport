@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "ReportTime"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New System.Data.DataTable
    Dim sql As String = "select a.StaffName,concat(h.Title,h.StaffName,' ',h.StaffLastName) as StaffFullName,
a.PositionName,a.DepartmentName,
a.CheckInDate,a.CheckOutDate,a.LateCheckInPay,a.LateCheckOutPay,
a.HolidayPay,a.CheckInTypeName,
a.HolidayPay+a.LateCheckOutPay as OvertimePay,
a.HolidayPay+a.LateCheckOutPay+a.LateCheckInpay as TotalAddDeduct
from vHR_WorkTimeDetail a inner join Mas_HRStaff h
on a.StaffId=h.StaffId
where a.IsCheckTime=1
"
    Dim sqlW As String = ""

    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
        sqlW &= String.Format(" AND a.CheckInDate>='{0}'", dateFrom)
    End If
    Dim dateTo = DateAdd("d", -1, DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        sqlW &= String.Format(" AND a.CheckInDate<='{0}'", dateTo)
    End If

    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND (CONCAT(h.Title,h.StaffName,h.StaffLastName) like '%{0}%' OR a.PositionName like '%{0}%' OR a.DepartmentName like '%{0}%')", qry)
    End If

    Dim state As String = ""
    If Not Request.QueryString("Status") Is Nothing Then
        qry = Request.QueryString("Status")
        sqlW &= String.Format(" AND a.CheckInTypeName like '%{0}%'", qry)
    End If
    sqlW &= " ORDER BY a.DepartmentName,a.StaffName"
    dt = obj.GetDataFromSQL(sql & sqlW)
End Code
<div id="reportArea">
    <h4>Report Work Time</h4>
    <h4>
        Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")
    </h4>
    @If dt.Rows.Count > 0 Then
        Dim deptName As String = ""
        Dim empName As String = ""
        Dim totalPay As Decimal = 0
        @<table>
            <thead>
                <tr>
                    <th>Staff Name</th>
                    <th>Position Name</th>
                    <th>CheckIn Date</th>
                    <th>CheckOut Date</th>
                    <th>Late Deduct</th>
                    <th>Overtime</th>
                </tr>
            </thead>
            <tbody>
                @For each dr As Data.DataRow In dt.Rows
                    If deptName <> dr("DepartmentName") Then
                        deptName = dr("DepartmentName")
                        @<tr style="background-color:lightgreen;">
                            <td colspan="6"><b>@deptName</b></td>
                        </tr>
                    End If
                    If empName <> dr("StaffFullName") Then
                        If totalPay > 0 Then
                            @<tr style="background-color:lightyellow;">
                                <td colspan="5"><b>@empName</b></td>
                                <td style="text-align:right">@totalPay.ToString("#,###,##0.00")</td>
                            </tr>
                        End If
                        empName = dr("StaffFullName")
                        totalPay = 0
                    End If
                    totalPay += dr("TotalAddDeduct")
                    @<tr>
                        <td>@dr("StaffFullName")</td>
                        <td>@dr("PositionName")</td>
                        <td>@Convert.ToDateTime(dr("CheckInDate")).ToString("dd/MM/yyyy HH:MM") (@dr("CheckInTypeName"))</td>
                        <td>@Convert.ToDateTime(dr("CheckOutDate")).ToString("dd/MM/yyyy HH:MM")</td>
                        <td style="text-align:right">@Convert.ToDecimal(dr("LateCheckInPay")).ToString("#,###,##0.00")</td>
                        <td style="text-align:right">@Convert.ToDecimal(dr("OvertimePay")).ToString("#,###,##0.00")</td>
                    </tr>
                Next
                @If totalPay > 0 Then
                    @<tr style="background-color:lightyellow;">
                        <td colspan="5"><b>@empName</b></td>
                        <td style="text-align:right">@totalPay.ToString("#,###,##0.00")</td>
                    </tr>
                End If
            </tbody>
        </table>
    End If
</div>
