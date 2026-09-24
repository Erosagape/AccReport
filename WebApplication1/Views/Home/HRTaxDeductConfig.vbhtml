@Code
    ViewData("Title") = "HRTaxDeductConfig"
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
    Dim sql As String = "select TaxYear,Seq,DeductDesc,DeductAmount,DeductMax from Mas_HRTaxDeduct"

    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Tax Deductable Config / กำหนดการลดหล่อนภาษี</h2>
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ปีภาษี</th>
                <th>ลำดับ</th>
                <th>รายการลดหย่อน</th>
                <th>จำนวนเงินลดหย่อน</th>
                <th>จำนวนเงินสูงสุด</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>@dr("Seq")</td>
                    <td>@dr("TaxYear")</td>
                    <td>@dr("Seq")</td>
                    <td>@dr("DeductDesc")</td>
                    <td>@dr("DeductAmount")</td>
                    <td>@dr("DeductMax")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If
