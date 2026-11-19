@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report Payment"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim sqlW As String = ""
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
        sqlW &= String.Format(" AND EntryDate>='{0}'", dateFrom)
    End If
    Dim dateTo = DateAdd("d", -1, DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        sqlW &= String.Format(" AND EntryDate<='{0}'", dateTo)
    End If
    Dim strCode = ""
    If Not Request.QueryString("Code") Is Nothing Then
        strCode = Request.QueryString("Code")
        sqlW &= String.Format(" AND JournalNo LIKE '%{0}%'", strCode)
    End If
    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND CONCAT(AccCode,AccName,AccDesc) like '%{0}%')", qry)
    End If
    Dim bSum As Boolean = False
    If Not Request.QueryString("Sum") Is Nothing Then
        bSum = If(Request.QueryString("Sum") = "Y", True, False)
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql As String = "SELECT JournalNo,FORMAT(EntryDate,'dd/MM/yyyy') as EntryDate,Description,
AccCode,AccName,sum(Debit+Credit) as Amount
FROM vJournal_All a WHERE JournalNo like 'PV%'
{0}
GROUP BY JournalNo,EntryDate,Description,AccCode,AccName
ORDER BY AccName,JournalNo"
    Dim dt = obj.GetDataFromSQL(String.Format(sql, sqlW))
End Code
<style>
    #reportArea {
        font-size: 10px;
    }

    td {
        padding-left: 2px;
    }
</style>
<div id="reportArea">
    <h2>Payment Voucher Report</h2>
    <b>Date From = @dateFrom.ToString("dd/MM/yyyy") Date To = @dateTo.ToString("dd/MM/yyyy")</b>
    <b>Select Voucher= @strCode With Cliteria= @qry </b>
    <table>
        <thead>
            <tr>
                <th>Journal No</th>
                <th>Entry Date</th>
                <th>Description</th>
                <th>Amount</th>
            </tr>
        </thead>
        @If dt.Rows.Count = 0 Then
            @<tr>
                <td colspan="5">No data found</td>
            </tr>
        Else
            Dim totalAmount As Decimal = 0
            Dim tGroupDesc As String = ""
            Dim tGroup As String = ""
            @<tbody>
                @For Each row In dt.Rows
                    If tGroup <> "" AndAlso tGroup <> row("AccCode") Then
                        @<tr style="background-color:lightyellow">
                            <td colspan="3" style="text-align:right;"><b>@tGroupDesc</b></td>
                            <td>@totalAmount.ToString("N2")</td>
                        </tr>
                        totalAmount = 0
                    End If
                    If tGroup <> row("AccCode") Then
                        tGroup = row("AccCode")
                        tGroupDesc = row("AccCode") & " / " & row("AccName")
                        If bSum = False Then
                            @<tr style="background-color:lightblue">
                                <td colspan="4" style="text-align:left;font-weight:bold;"><b>@tGroupDesc</b></td>
                            </tr>
                        End If
                    End If
                    totalAmount += Convert.ToDecimal(row("Amount"))
                    If bSum = False Then
                        @<tr>
                            <td><a class="btn btn-success" href="~/Form?Form=FormGL&SRC=@dbSource&DB=@dbname&Code=@row("JournalNo")">@row("JournalNo")</a></td>
                            <td>@row("EntryDate")</td>
                            <td>@row("Description")</td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    End If
                Next
            </tbody>
            If totalAmount > 0 Then
                @<tr style="background-color:lightyellow">
                    <td colspan="3" style="text-align:right;"><b>@tGroupDesc</b></td>
                    <td>@totalAmount.ToString("N2")</td>
                </tr>
            End If
        End If
    </table>
</div>

