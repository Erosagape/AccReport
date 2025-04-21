@Code
    ViewData("Title") = "Trial Balance"
    Dim yy = DateTime.Now.Year
    If Not Request.QueryString("Period") Is Nothing Then
        yy = Request.QueryString("Period")
    End If
    Dim mm As String = ""
    If Not Request.QueryString("Month") Is Nothing Then
        mm = Request.QueryString("Month")
    End If
    Dim dbName = "job_demo"
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim sql = ""
    Dim pm As String = ""
    If mm = "" Then
        pm = "BalDr as PrevDr,BalCr as PrevCr,Dec_Dr-BalDr as Dr,Dec_Cr-BalCr as Cr"
        sql = String.Format("select AccCode,AccName,Dec_Dr as NextDr,Dec_Cr as NextCr," + pm + " from vSum_BalanceMonthlyCompare where Period={0} ORDER BY AccCode", yy)
    Else

        Select Case mm
            Case 1
                pm = "BalDr as PrevDr,BalCr as PrevCr,Dr_Jan as NextDr,Cr_Jan as NextCr"
            Case 2
                pm = "Dr_Jan as PrevDr,Cr_Jan as PrevCr,Dr_Feb as NextDr,Cr_Feb as NextCr"
            Case 3
                pm = "Dr_Feb as PrevDr,Cr_Feb as PrevCr,Dr_Mar as NextDr,Cr_Mar as NextCr"
            Case 4
                pm = "Dr_Mar as PrevDr,Cr_Mar as PrevCr,Dr_Apr as NextDr,Cr_Apr as NextCr"
            Case 5
                pm = "Dr_Apr as PrevDr,Cr_Apr as PrevCr,Dr_May as NextDr,Cr_May as NextCr"
            Case 6
                pm = "Dr_May as PrevDr,Cr_May as PrevCr,Dr_Jun as NextDr,Cr_Jun as NextCr"
            Case 7
                pm = "Dr_Jun as PrevDr,Cr_Jun as PrevCr,Dr_Jul as NextDr,Cr_Jul as NextCr"
            Case 8
                pm = "Dr_Jul as PrevDr,Cr_Jul as PrevCr,Dr_Aug as NextDr,Cr_Aug as NextCr"
            Case 9
                pm = "Dr_Aug as PrevDr,Cr_Aug as PrevCr,Dr_Sep as NextDr,Cr_Sep as NextCr"
            Case 10
                pm = "Dr_Sep as PrevDr,Cr_Sep as PrevCr,Dr_Oct as NextDr,Cr_Oct as NextCr"
            Case 11
                pm = "Dr_Oct as PrevDr,Cr_Oct as PrevCr,Dr_Nov as NextDr,Cr_Nov as NextCr"
            Case 12
                pm = "Dr_Nov as PrevDr,Cr_Nov as PrevCr,Dr_Dec as NextDr,Cr_Dec as NextCr"
        End Select
        sql = String.Format("select AccCode,AccName,Dr" + mm + " as Dr,Cr" + mm + " as Cr," + pm + " from vSum_BalanceMonthlyCompare where Period={0} ORDER BY AccCode", yy)
    End If
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
    Dim sumDebit = 0
    Dim sumCredit = 0
End Code
<h3>งบทดลอง</h3>
<div style="display:flex;">
    <h4>ประจำปีภาษี @(Convert.ToInt32(yy) + 543) </h4> &nbsp;&nbsp;
    <h4>ประจำงวด </h4> &nbsp;&nbsp;
    <select id="cboMonth" onchange="RefreshPage(this.value)">
        <option value="">ต้นงวด</option>
        <option value="1">มกราคม</option>
        <option value="2">กุมภาพันธ์</option>
        <option value="3">มีนาคม</option>
        <option value="4">เมษายน</option>
        <option value="5">พฤษภาคม</option>
        <option value="6">มิถุนายน</option>
        <option value="7">กรกฏาคม</option>
        <option value="8">สิงหาคม</option>
        <option value="9">กันยายน</option>
        <option value="10">ตุลาคม</option>
        <option value="11">พฤษจิกายน</option>
        <option value="12">ธันวาคม</option>
    </select>
</div>
<div>
    <table border="1" style="border-collapse:collapse;border-style:solid;">
        <thead>
            <tr>
                <th rowspan="2">Acc.Code</th>
                <th rowspan="2">Acc.Name</th>
                <th colspan="2">Previous</th>
                <th colspan="2">Change</th>
                <th colspan="2">Balance</th>
            </tr>
            <tr>
                <th>Debit</th>
                <th>Credit</th>
                <th>Debit</th>
                <th>Credit</th>
                <th>Debit</th>
                <th>Credit</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr In dt.Rows
                sumDebit += obj.GetDouble(dr("Dr"))
                sumCredit += obj.GetDouble(dr("Cr"))
                @<tr>
    <td><a href="?Form=GeneralLedger&DB=@dbName&Code=@dr("AccCode")&DateFrom=@dateFrom&DateTo=@dateTo">@dr("AccCode").ToString()</a></td>
    <td>@dr("AccName").ToString()</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("PrevDr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("PrevCr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("Dr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("Cr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("NextDr")).ToString("#,##0.00")</td>
    <td style="text-align:right;">@Convert.ToDouble(dr("NextCr")).ToString("#,##0.00")</td>
</tr>
            Next
        </tbody>
        <tfoot>
            <tr>
                <td colspan="2">TOTAL</td>
                <td></td>
                <td></td>
                <td style="text-align:right;">@sumDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumCredit.ToString("#,##0.00")</td>
                <td></td>
                <td></td>
            </tr>
        </tfoot>
    </table>
</div>
@msg
<script type="text/javascript">
    var mm = '@mm';
    document.getElementById("cboMonth").value = mm;
    function RefreshPage(val) {
        window.location.href = "?Form=TrialBalance&DB=@dbName&Period=@yy&Month="+val;
    }
</script>