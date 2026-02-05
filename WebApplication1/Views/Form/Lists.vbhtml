@Code
    ViewData("Title") = "Trans"
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
    Dim docType As String = ""
    If Not Request.QueryString("Type") Is Nothing Then
        docType = Request.QueryString("Type")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim sqlw = String.Format(" where AccBatchDate>='{0}' and AccBatchDate<='{1}'", datefrom, dateto)
    If docType <> "" Then
        sqlw &= String.Format(" and AccDocType='{0}'", docType)
    End If
    Dim sql = String.Format("select AccDocType, AccDocNo,PartyName,DocRefNo,AccBatchDate,AccEffectiveDate,IssueBy from Acc_TransactionHD {0} order by AccDocNo", sqlw)
    Dim dt = obj.GetDataFromSQL(sql)
    Dim docTypes = obj.GetDataFromSQL("select distinct AccDocType from Acc_TransactionHD")
End Code
<div class="row">
    <div class="col-md-3">
	<h2>Transaction List</h2>
    </div>
    <div class="col-md-3">
        Date From : <input type="date" id="txtDateFrom" value="@datefrom" class="form-control" />
    </div>
    <div class="col-md-3">
        To : <input type="date" id="txtDateTo" value="@dateto" class="form-control" />
    </div>
    <div class="col-sm-3">
        Type : 
        <select id="txtDocType" class="form-control dropdown">
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
</div>
<input type = "button" onclick="RefreshPage()" class="btn btn-primary" value="Refresh" />
<br>
@If dt.Rows.Count > 0 Then
    @<table border="1"class="DataTable table table-border table-responsive" style="border-style:solid;border-collapse:collapse;border-width:thin;">
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
    <td><a class="btn btn-success" href="?Form=Form@(frmName)&SRC=@dbSource&DB=@dbName&Code=@dr("AccDocNo")">Print</a></td>
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
        window.location.href = "?Form=Lists&DateFrom=" + df + "&DateTo=" + dt + "&SRC=@dbSource&DB=@dbName&Type=" +typ;
    }
</script> 