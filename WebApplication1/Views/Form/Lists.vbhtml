@Code
    ViewData("Title") = "Trans"
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
    Dim docType As String = ""
    If Not Request.QueryString("Type") Is Nothing Then
        docType = Request.QueryString("Type")
    End If
    Dim obj = New AccReport.CUtil(".", dbName)
    Dim sqlw = String.Format(" where AccEffectiveDate>='{0}' and AccEffectiveDate<='{1}'", datefrom, dateto)
    If docType <> "" Then
        sqlw &= String.Format(" and AccDocType='{0}'", docType)
    End If
    Dim sql = String.Format("select * from Acc_TransactionHD {0} order by AccDocNo", sqlw)
    Dim dt = obj.GetDataFromSQL(sql)
    Dim docTypes = obj.GetDataFromSQL("select distinct AccDocType from Acc_TransactionHD")
End Code
<h2>Transaction List</h2>
<div class="row">
    <div class="col-md-3">
        Date From : <input type="date" id="txtDateFrom" value="@datefrom" />
    </div>
    <div class="col-md-3">
        To : <input type="date" id="txtDateTo" value="@dateto" />
    </div>
    <div class="col-sm-3">
        Type : 
        <select id="txtDocType">
            @If docTypes.Rows.Count > 0 Then
                For Each dr As Data.DataRow In docTypes.Rows
                    If docType.Equals(dr("AccDocType")) Then
                        @<option value="@dr("AccDocType")" selected>
                            @dr("AccDocType")
                        </option>
                    Else
                        @<option value="@dr("AccDocType")">
                            @dr("AccDocType")
                        </option>
                    End If
                Next
            End If
        </select>
    </div>
    <input type = "button" onclick="RefreshPage()" value="Refresh" />
</div>
@If dt.Rows.Count > 0 Then
    @<table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
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
                Dim frmName = dr("AccDocType").ToString()
                @<tr>
    <td><a href="?Form=Form@(frmName)&SRC=@dbName&DB=@dbName&Code=@dr("AccDocNo")">Print</a></td>
    @For each dc As Data.DataColumn In dt.Columns
        @<td>@dr(dc.ColumnName)</td>
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
        var typ= document.getElementById('txtDocType').value;
        window.location.href = "?Form=Lists&DateFrom=" + df + "&DateTo=" + dt + "&SRC=@dbName&DB=@dbName&Type=" +typ;
    }
</script> 