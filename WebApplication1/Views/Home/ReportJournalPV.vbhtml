@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "ReportJournalPV"
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

    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND (EXISTS(select 1 from Acc_JournalDT where EntryID=a.EntryID and AccName like '%{0}%' OR AccDesc like '%{0}%') OR JournalNo like '%{0}%')", qry)
    End If

    Dim filter As String = ""
    If Not Request.QueryString("Status") Is Nothing Then
        filter = Request.QueryString("Status")
        sqlW &= String.Format(" AND Description like '%{0}%'", filter)
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql As String = ""
    Dim dt As New Data.DataTable
    Dim rs As New Data.DataTable

    sql = String.Format("SELECT a.* FROM vJournal_All a WHERE JournalNo like 'PV%' and ItemNo is not null {0} ORDER BY a.Description,a.JournalNo", sqlW)
    dt = obj.GetDataFromSQL(sql)

    Dim vatcodeundue As String = ""
    rs = obj.GetDataFromSQL("SELECT dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as t")
    If rs.Rows.Count > 0 Then
        vatcodeundue = rs.Rows(0).Item("t").ToString()
    End If

    Dim vatcodedue As String = ""
    rs = obj.GetDataFromSQL("SELECT dbo.GetAccConfig('VAT_CONFIG','InputVat') as t")
    If rs.Rows.Count > 0 Then
        vatcodedue = rs.Rows(0).Item("t").ToString()
    End If

    Dim taxcode As String = ""
    rs = obj.GetDataFromSQL("SELECT * FROM vMas_AccConfigCode WHERE ConfigKey like 'Tax%'")
    If rs.Rows.Count > 0 Then
        For Each c As Data.DataRow In rs.Rows
            taxcode &= c("ConfigValue").ToString() & "|"
        Next
    End If
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
    <h2>Report Journal - Cash Payment (สมุดรายวันจ่าย)</h2>
    @If dt.Rows.Count > 0 Then
        Dim desc As String = ""
        Dim sum1 As Decimal = 0
        Dim sum2 As Decimal = 0
        Dim sum3 As Decimal = 0
        Dim sum4 As Decimal = 0
        @<table>
            <thead>
                <tr>
                    <th>Entry Date</th>
                    <th>Journal No</th>
                    <th>Acc Code</th>
                    <th>Acc Name</th>
                    <th>Due Date</th>
                    <th>Debit</th>
                    <th>VAT</th>
                    <th>Credit</th>
                    <th>TAX</th>
                </tr>
            </thead>
            <tbody>
                @For Each r As Data.DataRow In dt.Rows
                    If desc <> r("Description").ToString() Then
                        desc = r("Description").ToString()
                        @<tr>
                            <td colspan="9" style="font-weight:bold;">@desc</td>
                        </tr>
                    End If
                    @<tr>
                        <td>@Convert.ToDateTime(r("EntryDate")).ToString("dd/MM/yyyy")</td>
                        <td>@r("JournalNo")</td>
                        <td>@r("AccCode") / @r("AccName")</td>
                        <td>@r("AccDesc") @r("AccRemark")</td>
                        <td>@Convert.ToDateTime(r("EffectiveDate")).ToString("dd/MM/yyyy")</td>
                        @if r("AccCode").ToString().Equals(vatcodeundue) Or r("AccCode").ToString().Equals(vatcodedue) Then
                            @<td></td>
                            @<td style="text-align:right">@String.Format("{0:n2}", r("Debit"))</td>
                            @<td></td>
                            @<td></td>
                            sum2 += Convert.ToDecimal(r("Debit"))
                        Else
                            If taxcode.IndexOf(r("AccCode").ToString() & "|") >= 0 Then
                                @<td></td>
                                @<td></td>
                                @<td></td>
                                @<td style="text-align:right">@String.Format("{0:n2}", r("Credit"))</td>
                                sum4 += Convert.ToDecimal(r("Credit"))
                            Else
                                sum1 += Convert.ToDecimal(r("Debit"))
                                @<td style="text-align:right">@String.Format("{0:n2}", r("Debit"))</td>
                                @<td></td>
                                sum3 += Convert.ToDecimal(r("Credit"))
                                @<td style="text-align:right">@String.Format("{0:n2}", r("Credit"))</td>
                                @<td></td>
                            End If
                        End If
                    </tr>
                Next
                <tr>
                    <td colspan="5" style="text-align:right; font-weight:bold;">Total:</td>
                    <td style="text-align:right; font-weight:bold;">@String.Format("{0:n2}", sum1)</td>
                    <td style="text-align:right; font-weight:bold;">@String.Format("{0:n2}", sum2)</td>
                    <td style="text-align:right; font-weight:bold;">@String.Format("{0:n2}", sum3)</td>
                    <td style="text-align:right; font-weight:bold;">@String.Format("{0:n2}", sum4)</td>
                </tr>
            </tbody>
        </table>
    Else
        @<h4>No data found.</h4>
    End If
</div>


