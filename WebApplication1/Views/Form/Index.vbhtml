@Code
    ViewData("Title") = "Index"
    Dim dbName = "AccConcept"
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim datefrom = New Date(Today.Year, Today.Month, 1).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateFrom") Is Nothing Then
        datefrom = Request.QueryString("DateFrom")
    End If
    Dim dateto = New Date(Today.Year, Today.Month, Today.Day).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateto = Request.QueryString("DateTo")
    End If
    Dim obj = New AccReport.CUtil(".", dbName)
    Dim sqlw = String.Format(" where EffectiveDate>='{0}' and EffectiveDate<='{1}'", datefrom, dateto)
    Dim sql = String.Format("select * from Acc_JournalHD {0} order by JournalNo", sqlw)
    Dim dt = obj.GetDataFromSQL(sql)
End Code
<h2>Journal List</h2>
<div class="row">
    <div class="col-md-3">
        Date From : <input type="date" id="txtDateFrom" value="@datefrom" />
    </div>
    <div class="col-md-3">
        To : <input type="date" id="txtDateTo" value="@dateto" />
    </div>
    <input type="button" onclick="RefreshPage()" value="Refresh" />
</div>
@If dt.Rows.Count > 0 Then
    @<table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
        <thead>
            <tr>
                @For each dc As Data.DataColumn In dt.Columns
                    @<th>@dc.ColumnName</th>
                Next
                <th>#</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<td>@dr(dc.ColumnName)</td>
                    Next
                    <td><a href="?Form=FormGL&Code=@dr("JournalNo")">Print</a></td>
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
        window.location.href = "?DateFrom=" + df + "&DateTo=" + dt + "&DB=@dbName";
    }
</script> 