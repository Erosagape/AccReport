@Code
    Layout = Nothing
    ViewData("Title") = "Trial Balance"
    Dim yy = DateTime.Now.Year
    If Not Request.QueryString("Period") Is Nothing Then
        yy = Request.QueryString("Period")
    End If
    Dim sql = String.Format("select * from vTrial_Balance where Period={0}", yy)
    'Dim cnnStr = "Data Source=.;Initial Catalog=AccConcept;User id=sa;Password='9t;yogm851';Persist Security Info=False"
    'Dim obj = New AccReport.CUtil(cnnStr)
    Dim obj = New AccReport.CUtil()
    Dim dt = obj.GetDataFromSQL(sql)
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
    Dim dateFrom = New Date(yy, 1, 1).ToString("yyyy-MM-dd")
    Dim dateTo = DateAdd("d", -1, New Date(yy + 1, 1, 1)).ToString("yyyy-MM-dd")
End Code
<h3>งบทดลอง</h3>
<h4>ประจำปีภาษี @(Convert.ToInt32(yy) + 543)</h4>
<div>
    <table border="1" style="border-collapse:collapse;border-style:solid;">
        <thead>
            <tr>
                <th>Acc.Code</th>
                <th>Acc.Name</th>
                <th>Debit</th>
                <th>Credit</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr In dt.Rows
                @<tr>
    <td><a href="?Form=GeneralLedger&Code=@dr("AccCode")&DateFrom=@dateFrom&DateTo=@dateTo">@dr("AccCode").ToString()</a></td>
    <td>@dr("AccName").ToString()</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("Dr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("Cr")).ToString("#,##0.00")</td>
</tr>
            Next
        </tbody>
    </table>
</div>
@msg
