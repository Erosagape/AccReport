@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report Receive"
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
    Dim dateTo = DateAdd("d",-1,DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        sqlW &= String.Format(" AND EntryDate<='{0}'", dateTo)
    End If
    Dim accCode = ""
    If Not Request.QueryString("Code") Is Nothing Then
        accCode = Request.QueryString("Code")
        accCode = "'" & accCode.Replace(",", "','") & "'"
        sqlW &= String.Format(" AND AccCode IN({0})", accCode)
    End If
    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND EXISTS(select 1 from Acc_JournalDT where EntryID=a.EntryID and AccName like '%{0}%')", qry)
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)

    Dim dh = obj.GetDataFromSQL(String.Format("SELECT * FROM vRV_All a WHERE AccCode<>'' {0} ORDER BY EntryID,Credit", sqlW))
    Dim tb As New Data.DataTable
    Dim id As String = ""
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
    <h4>Receive Daily Report</h4>
    <h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    @Code
        If accCode <> "" Then
            @<h4>Account Code :@accCode</h4>
        End If
        If qry <> "" Then
            @<h4>Filter :*@qry*</h4>
        End If
        @<table>
            <thead>
                <tr>
                    <th>RV#</th>
                    <th>Trans.Date</th>
                    <th>Remark</th>
                    <th>Ref#</th>
                    <th>Debit</th>
                    <th>Credit</th>
                </tr>
            </thead>
            <tbody>
                @For each rh As Data.DataRow In dh.Rows
                    If Not id.ToString().Equals(rh("JournalNo")) Then
                        id = rh("JournalNo")
                        @<tr style="font-weight:bold;">
                            <td>@rh("JournalNo")</td>
                            <td>
                                @Convert.ToDateTime(rh("EffectiveDate")).ToString("dd/MM/yyyy")
                            </td>
                            <td>@rh("Description")</td>
                            <td>@rh("EntryBy") @Convert.ToDateTime(rh("EntryDate")).ToString("dd/MM/yyyy")</td>
                            <td style="text-align:right">@Convert.ToDouble(rh("TotalCredit")).ToString("#,##0.00") </td>
                        </tr>
                    End If
                    If rh("Credit") > 0 Then
                        @<tr style="text-decoration:underline;">
                            <td>@rh("AccDesc")</td>
                            <td colspan="2">@rh("AccName")</td>
                            <td>@rh("AccCode")</td>
                            <td></td>
                            <td style="text-align:right">@Convert.ToDouble(rh("Credit")).ToString("#,##0.00") </td>
                        </tr>
                    End If
                    If rh("Debit") > 0 Then
                        @<tr style="font-style:italic;">
                            <td>@rh("AccDesc")</td>
                            <td colspan="2">@rh("AccName")</td>
                            <td>@rh("AccCode")</td>
                            <td style="text-align:right">@Convert.ToDouble(rh("Debit")).ToString("#,##0.00") </td>
                            <td></td>
                        </tr>
                    End If
                Next
            </tbody>
        </table>
    End Code
</div>

