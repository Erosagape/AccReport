@Code
    ViewData("Title") = "General Ledger"
    Dim accCode As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        accCode = Request.QueryString("Code")
    End If
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    Dim dateTo = DateAdd("d", -1, New Date(DateTime.Now.Year, Now.Month + 1, 1))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If
    Dim sql As String = String.Format("EXEC dbo.Generate_ReportGL '{0}','{1}','{2}'", accCode, dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"))
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
    Dim i = 0
    Dim prevBal As Double = 0
    Dim nextBal As Double = 0
    Dim moveBal As Double = 0
End Code
<h3>แยกประเภททั่วไป</h3>
<h4>รหัสบัญชี @accCode ระหว่างวันที่ @DateAdd("yyyy", 543, dateFrom).ToString("dd/MM/yyyy") ถึงวันที่ @DateAdd("yyyy", 543, dateTo).ToString("dd/MM/yyyy") </h4>
<div>
    <table border="1" style="border-collapse:collapse;border-style:solid;">
        <thead>
            <tr>
                <th>#</th>
                <th>Date</th>
                <th>Ref#</th>
                <th>Description</th>
                <th>Debit</th>
                <th>Credit</th>
                <th>Balance</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr In dt.Rows
                If i = 0 Then
                    @<tr style="font-weight:bold;">
                        <td colspan="2">@dt.Rows(i)("AccCode").ToString()</td>
                        <td colspan="5">@dt.Rows(i)("AccName").ToString()</td>
                    </tr>
                    prevBal = obj.GetDouble(dr("Balance"))
                End If
                i += 1
                If i = dt.Rows.Count Then
                    nextBal = obj.GetDouble(dr("Balance"))
                    moveBal = nextBal - prevBal
                    @<tr style="font-weight:bold">
                        <td>@dr("ItemNo").ToString()</td>
                        <td>@Convert.ToDateTime(dr("EffectiveDate")).ToString("dd/MM/yyyy")</td>
                        <td>@dr("JournalNo").ToString()</td>
                        <td>@dr("AccDesc").ToString()</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Debit")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Credit")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@moveBal.ToString("#,##0.00")</td>
                    </tr>
                Else
                    @<tr>
                        <td>@dr("ItemNo").ToString()</td>
                        <td>@Convert.ToDateTime(dr("EffectiveDate")).ToString("dd/MM/yyyy")</td>
                        <td>@dr("JournalNo").ToString()</td>
                        <td>@dr("AccDesc").ToString()</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Debit")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Credit")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Balance")).ToString("#,##0.00")</td>
                    </tr>
                End If
            Next
        </tbody>
    </table>
</div>
@msg
