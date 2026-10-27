@Code
    Layout = "~/Views/Shared/Report.vbhtml"

    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    ViewData("Title") = "Employee Tax Calculation"

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New System.Data.DataTable
    Dim sql As String = "select
CONCAT(StaffName,' / ',PositionName) as EmployeeName,
SalaryPerMonth,SalaryPerYear,
DefaultDeduct,SocialDeduct,TotalDeduct,
TotalYearly,TotalTaxYear,TotalTaxMonth
from vHR_CalTaxEmp"

    dt = obj.GetDataFromSQL(sql)
End Code
<div id="reportArea">
    <h2>@ViewBag.Title</h2>
    @If dt.Rows.Count > 0 Then
        @<table class="table table-bordered">
            <thead>
                <tr>
                    <th>Employee Name / Position</th>
                    <th>Salary/MO</th>
                    <th>Sarary/YTD</th>
                    <th>Deduct (Default)</th>
                    <th>Social Security</th>
                    <th>Summary Deduct</th>
                    <th>Revenue (YTD)</th>
                    <th>Tax (YTD)</th>
                    <th>Tax (MO)</th>
                </tr>
            </thead>
            <tbody>
                @For each dr As Data.DataRow in dt.Rows
                    @<tr>
                        <td>
                            @dr("EmployeeName").ToString()
                        </td>
                        <td style="text-align:right;">
                            @Convert.ToDecimal(dr("SalaryPerMonth")).ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @Convert.ToDecimal(dr("SalaryPerYear")).ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @Convert.ToDecimal(dr("DefaultDeduct")).ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @Convert.ToDecimal(dr("SocialDeduct")).ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @Convert.ToDecimal(dr("TotalDeduct")).ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @Convert.ToDecimal(dr("TotalYearly")).ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @Convert.ToDecimal(dr("TotalTaxYear")).ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @Convert.ToDecimal(dr("TotalTaxMonth")).ToString("N2")
                        </td>
                    </tr>
                Next
            </tbody>
        </table>
    Else
        @<div>Not Found Data</div>
    End If
</div>
