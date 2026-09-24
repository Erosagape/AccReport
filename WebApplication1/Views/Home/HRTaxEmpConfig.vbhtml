@Code
    ViewData("Title") = "HRTaxEmpConfig"
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
select ConfigKey as RangeOfSalary,ConfigValue as TaxRate from Mas_HRConfig where ConfigCode like 'SALARY_TAXRATE%'
"
    dt = obj.GetDataFromSQL(sql)
End Code

<h2>Employee Tax Config / กำหนดการคิดภาษีของพนักงาน</h2>
@If dt.Rows.Count> 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ช่วงเงินเดือน</th>
                <th>อัตราภาษี</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>@dr("RangeOfSalary")</td>
                    <td>@dr("TaxRate")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If

