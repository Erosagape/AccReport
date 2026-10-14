@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report Payroll"
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

    Dim sql As String = "select a.SlipNo,a.PaymentDate,
a.PaymentType,a.PaymentToAcc,a.PaymentFromAcc,
a.SalaryStatus,a.ApproveDate,a.ApproveBy,
a.CancelDate,a.CancelBy,
a.CreateDate,a.CreateBy,
a.TotalPayment,a.TotalRevenue,a.TotalExpense,
a.StaffId,b.StaffName,
e.LevelId,e.LevelName,
b.PositionId,b.PositionName,
d.DepartmentId,d.DepartmentName,
d.DivisionId,d.DivisionName
from vHR_PayrollSlip a
inner join vHR_PayRoll b
on a.StaffId=b.StaffId
inner join Mas_HRPosition c
on b.PositionId=c.PositionId
inner join vMas_HROrgChart d
on c.DepartmentId=d.DepartmentId
inner join Mas_HRLevel e
on c.LevelId=e.LevelId
WHERE a.CancelBy='' "
    Dim sqlW As String = ""

    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
        sqlW &= String.Format(" AND a.PaymentDate>='{0}'", dateFrom)
    End If
    Dim dateTo = DateAdd("d", -1, DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        sqlW &= String.Format(" AND a.PaymentDate<='{0}'", dateTo)
    End If

    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND (b.StaffName like '%{0}%' OR b.PositionName like '%{0}%' OR d.DepartmentName like '%{0}%')", qry)
    End If

    Dim state As String = ""
    If Not Request.QueryString("Status") Is Nothing Then
        qry = Request.QueryString("Status")
        sqlW &= String.Format(" AND (EXISTS(select 1 from Acc_HRPayroll where SlipNo=a.SlipNo and SalaryName like '%{0}%') OR SlipNo like '%{0}%')", qry)
    End If
    sqlW &= " ORDER BY d.DepartmentName,a.PaymentDate,c.LevelId"
    dt = obj.GetDataFromSQL(sql & sqlW)

End Code
<div id="reportArea">
    <h4>Report Payroll</h4>
    <h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    @If dt.Rows.Count > 0 Then
        Dim deptName As String = ""
        Dim sumR As Decimal = 0
        Dim sumE As Decimal = 0
        Dim sumP As Decimal = 0
        @<table>
            <thead>
                <tr>
                    <th>Slip No</th>
                    <th>Payment Date</th>
                    <th>Name / Position</th>
                    <th>Revenue</th>
                    <th>Expense</th>
                    <th>Payment</th>
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
                    sumR += dr("TotalRevenue")
                    sumE += dr("TotalExpense")
                    sumP += dr("TotalPayment")
                    @<tr>
                        <td>@dr("SlipNo")</td>
                        <td>@Convert.ToDateTime(dr("PaymentDate")).ToString("dd/MM/yyyy")</td>
                        <td>@dr("StaffName") / @dr("PositionName")</td>
                        <td style="text-align:right">@Convert.ToDecimal(dr("TotalRevenue")).ToString("#,###,##0.00")</td>
                        <td style="text-align:right">@Convert.ToDecimal(dr("TotalExpense")).ToString("#,###,##0.00")</td>
                        <td style="text-align:right">@Convert.ToDecimal(dr("TotalPayment")).ToString("#,###,##0.00")</td>
                    </tr>
                Next
            </tbody>
            <tfoot>
                <tr style="background-color:lightyellow;">
                    <td colspan="3">Total</td>
                    <td style="text-align:right;font-weight:bold;">@sumR.ToString("#,###,##0.00")</td>
                    <td style="text-align:right;font-weight:bold;">@sumE.ToString("#,###,##0.00")</td>
                    <td style="text-align:right;font-weight:bold;">@sumP.ToString("#,###,##0.00")</td>
                </tr>
            </tfoot>
        </table>
    End If
</div>
