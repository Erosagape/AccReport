@Code
    ViewData("Title") = "Profit and Loss"
    Dim dbName = "job_demo"
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim yy As String = ""
    If Not Request.QueryString("Period") Is Nothing Then
        yy = Request.QueryString("Period")
    End If
    Dim sql = "
select AccCode,AccName,
(case when sum(Debit)>=sum(credit) then sum(Debit)-sum(Credit) else 0 end) as Dr,
(case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end) as Cr
from vProfitLoss {0}
group by AccCode,AccName order by AccCode
"
    Dim sqlw = ""
    If yy <> "" Then
        sqlw += " WHERE Period='{0}'"
    End If
    Dim sumDebit = 0
    Dim sumCredit = 0
    Dim obj = New AccReport.CUtil()
    Dim dt = obj.GetDataFromSQL(String.Format(sql, sqlw))
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
End Code
<h2>งบกำไรขาดทุน</h2>
@If yy<>"" Then
    @<b>ประจำปี @(Convert.ToInt32(yy) + 543)</b>
End If
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
            sumDebit += obj.GetDouble(dr("Dr"))
            sumCredit += obj.GetDouble(dr("Cr"))
            @<tr>
                <td>@dr("AccCode").ToString()</td>
                <td>@dr("AccName").ToString()</td>
                <td style="text-align:right;">@Convert.ToDouble(dr("Dr")).ToString("#,##0.00")</td>
                <td style="text-align:right;">@Convert.ToDouble(dr("Cr")).ToString("#,##0.00")</td>
            </tr>
        Next
    </tbody>
    <tfoot>
        <tr>
            <td colspan="2">TOTAL</td>
            <td style="text-align:right;">@sumDebit.ToString("#,##0.00")</td>
            <td style="text-align:right;">@sumCredit.ToString("#,##0.00")</td>
        </tr>
    </tfoot>
</table>