@Code
    ViewData("Title") = "Index"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim datefrom = New Date(Today.Year, Today.Month, 1).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateFrom") Is Nothing Then
        datefrom = Request.QueryString("DateFrom")
    End If
    Dim dateto = New Date(Today.Year, 12, 31).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateto = Request.QueryString("DateTo")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim sqlw = String.Format(" where EntryDate>='{0}' and EntryDate<='{1}'", datefrom, dateto)
    Dim sql = String.Format("select * from Acc_JournalHD {0} order by EntryId DESC", sqlw)
    Dim dt = obj.GetDataFromSQL(sql)
End Code
<h2>Journal List</h2>
<div class="row">
    <div class="col-md-3">
        Date From : <input type="date" id="txtDateFrom" value="@datefrom" class="form-control" />
    </div>
    <div class="col-md-3">
        To : <input type="date" id="txtDateTo" value="@dateto" class="form-control" />
    </div>
    <div class="col-md-3">
        <br />
        <input type="button" onclick="RefreshPage()" value="Refresh" class="btn btn-primary" />
    </div>
</div>
<br>
@If dt.Rows.Count > 0 Then
    @<table border="1" class="DataTable table table-responsive table-border" style="border-style:solid;border-collapse:collapse;border-width:thin;">
        <thead>
            <tr>
                <th>#</th>
                @For each dc As Data.DataColumn In dt.Columns
                    @<th>@dc.ColumnName</th>
                Next

            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        @If dr("JournalNo").ToString().Substring(0, 2) = "RV" Then
                            @<a Class="btn btn-success" href="?Form=FormRV&SRC=@dbSource&DB=@dbName&Code=@dr("JournalNo")">Print</a>
                        Else
                            If dr("JournalNo").ToString().Substring(0, 2) = "PV" Then
                                @<a Class="btn btn-success" href="?Form=FormPV&SRC=@dbSource&DB=@dbName&Code=@dr("JournalNo")">Print</a>
                            Else
                                @<a Class="btn btn-success" href="?Form=FormGL&SRC=@dbSource&DB=@dbName&Code=@dr("JournalNo")">Print</a>
                            End If
                        End If
                    </td>
                    @For Each dc As Data.DataColumn In dt.Columns
                        If dc.ColumnName.Equals("JournalNo") Then
                            @<td>
                                <a href="?Form=Journal&SRC=@dbSource&DB=@dbName&Code=@dr("JournalNo")">@dr(dc.ColumnName)</a>
                             </td>
                        Else
                            @<td>@dr(dc.ColumnName)</td>
                        End If

                    Next
                </tr>
            Next
        </tbody>
    </table>
Else
    @<b>@obj.Message</b>
End If
<script type="text/javascript">
    function RefreshPage() {
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        window.location.href = "?DateFrom=" + df + "&DateTo=" + dt + "&DB=@dbName&SRC=@dbSource";
    }
</script> 