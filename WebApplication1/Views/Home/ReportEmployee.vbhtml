@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "ReportEmployee"
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

    Dim sql As String = "
SELECT a.StaffId,concat(h.Title,h.StaffName,' ',h.StaffLastName) as StaffFullName,
a.ContractNo,a.SignDate,i.ContractType,
b.AssignmentDate,
b.PositionId,c.PositionName,j.SalaryPerDay,j.SalaryPerMonth,
c.DepartmentId,d.DepartmentName,
c.LevelId,e.LevelName,
d.DivisionId,f.DivisionName,
f.CompanyId,g.CompanyName
FROM
Acc_HRContract a
inner join Mas_HREmployment b
on b.ContractNo=a.ContractNo
and a.StaffId=b.StaffId
inner join Mas_HRPosition c
on b.PositionId=c.PositionId
inner join Mas_HRDepartment d
on c.DepartmentId=d.DepartmentId
inner join Mas_HRLevel e
on c.LevelId=e.LevelId
inner join Mas_HRDivision f
on d.DivisionId=f.DivisionId
inner join Mas_Company g
on f.CompanyId=g.CompanyId
inner join Mas_HRStaff h
on b.StaffId=h.StaffId
inner join Mas_HRContractType i
on a.ContractTypeId=i.ContractTypeId
inner join Mas_HRPayRollConfig j
on b.PositionId=j.PositionId
and a.ContractTypeId=j.ContractTypeId
WHERE a.ContractStatus<>99
"
    Dim sqlW As String = ""

    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
        sqlW &= String.Format(" AND b.AssignmentDate>='{0}'", dateFrom)
    End If
    Dim dateTo = DateAdd("d", -1, DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        sqlW &= String.Format(" AND b.AssignmentDate<='{0}'", dateTo)
    End If

    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND (CONCAT(h.Title,h.StaffName,h.StaffLastName) like '%{0}%' OR c.PositionName like '%{0}%' OR d.DepartmentName like '%{0}%')", qry)
    End If

    Dim state As String = ""
    If Not Request.QueryString("Status") Is Nothing Then
        qry = Request.QueryString("Status")
        sqlW &= String.Format(" AND (EXISTS(select 1 from Acc_HRContract where ContractNo=a.ContractNo and ContractNote like '%{0}%') OR ContractNo like '%{0}%')", qry)
    End If
    sqlW &= " ORDER BY f.DivisionId,d.DepartmentName,e.LevelId"
    dt = obj.GetDataFromSQL(sql & sqlW)
End Code
<div id="reportArea">
    <h4>Report Employee</h4>
    <h4>Assignment Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    @If dt.Rows.Count > 0 Then
        Dim deptName As String = ""
        @<table>
            <thead>
                <tr>
                    <th>Staff Name</th>
                    <th>Position Name</th>
                    <th>Assignment Date</th>
                    <th>Department Name</th>
                    <th>Level Name</th>
                    <th>Monthly Salary</th>
                </tr>
            </thead>
            <tbody>
                @For each dr As Data.DataRow In dt.Rows
                    If deptName <> dr("DivisionName") Then
                        deptName = dr("DivisionName")
                        @<tr style="background-color:lightgreen;">
                            <td colspan="6"><b>@deptName</b></td>
                        </tr>
                    End If
                    @<tr>
                        <td>@dr("StaffFullName")</td>
                        <td>@dr("PositionName")</td>
                        <td>@Convert.ToDateTime(dr("AssignmentDate")).ToString("dd/MM/yyyy")</td>
                        <td>@dr("DepartmentName")</td>
                        <td>@dr("LevelName")</td>
                        <td style="text-align:right">@Convert.ToDecimal(dr("SalaryPerMonth")).ToString("#,###,##0.00")</td>
                    </tr>
                Next
            </tbody>
        </table>
    End If
</div>


