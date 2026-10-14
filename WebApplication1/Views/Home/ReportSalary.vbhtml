@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "ReportSalary"

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

    Dim sql As String = "select a.PaymentDate,a.SlipNo,
b.AccCode,b.AccName,
a.StaffId,
concat(c.Title,c.StaffName,' ',c.StaffLastName) as StaffFullName,
d.ContractNo,d.PositionId,e.PositionName,
a.SalaryName,a.AmountPayment,a.AmountAdd,a.AmountDeduct
from Acc_HRPayRoll a
inner join Mas_AccCode b
on a.AccCodeDebit=b.AccCode
or a.AccCodeCredit=b.AccCode
inner join Mas_HRStaff c
on a.StaffId=c.StaffId,
Mas_HREmployment d,Mas_HRPosition e,
Mas_HRDepartment f
where d.BeginDate<=a.PaymentDate
and d.EndDate>=a.PaymentDate
and d.StaffId=a.StaffId
and d.PositionId=e.PositionId
and e.DepartmentId=f.DepartmentId
and a.SalaryStatus>0 {0}
order by b.AccCode,a.SalaryName,a.PaymentDate
"
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
        sqlW &= String.Format(" AND (CONCAT(c.Title,c.StaffName,c.StaffLastName) like '%{0}%' OR e.PositionName like '%{0}%' OR f.DepartmentName like '%{0}%')", qry)
    End If

    Dim state As String = ""
    If Not Request.QueryString("Status") Is Nothing Then
        qry = Request.QueryString("Status")
        sqlW &= String.Format(" AND a.SalaryName like '%{0}%'", qry)
    End If
    dt = obj.GetDataFromSQL(String.Format(sql, sqlW))
End Code
<div id="reportArea">
    <h4>Report Salary Monthly</h4>
    <h4>
        Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")
    </h4>
    @If dt.Rows.Count > 0 Then
        Dim deptName As String = ""
        Dim accName As String = ""
        Dim totalPay As Decimal = 0
        @<table>
            <thead>
                <tr>
                    <th>Staff Name</th>
                    <th>Position Name</th>
                    <th>Payment Date</th>
                    <th>Slip No / Details</th>
                    <th>Late Deduct</th>
                    <th>Overtime</th>
                </tr>
            </thead>
            <tbody>
                @For each dr As Data.DataRow In dt.Rows
                    If accName <> dr("AccName") Then
                        If totalPay <> 0 Then
                            @<tr style="background-color: lightgreen; font-weight: bold;">
                                <td colspan="5"><b>@accName</b></td>
                                <td style="text-align:right">@totalPay.ToString("#,###,##0.00")</td>
                            </tr>
                        Else

                        End If
                        accName = dr("AccName")
                        totalPay = 0
                    End If
                    totalPay += dr("AmountPayment")
                    @<tr>
                        <td>@dr("StaffFullName")</td>
                        <td>@dr("PositionName")</td>
                        <td>@Convert.ToDateTime(dr("PaymentDate")).ToString("dd/MM/yyyy")</td>
                        <td>@dr("SlipNo") @dr("SalaryName")</td>
                        <td style="text-align:right">@Convert.ToDecimal(dr("AmountAdd")).ToString("#,###,##0.00")</td>
                        <td style="text-align:right">@Convert.ToDecimal(dr("AmountDeduct")).ToString("#,###,##0.00")</td>
                    </tr>
                Next
                <tr style="background-color:lightgreen;font-weight:bold;">
                    <td colspan="5"><b>@accName</b></td>
                    <td style="text-align:right">@totalPay.ToString("#,###,##0.00")</td>
                </tr>
            </tbody>
        </table>
    End If
</div>

