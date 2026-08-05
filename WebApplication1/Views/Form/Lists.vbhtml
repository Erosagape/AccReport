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
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sqlw = String.Format(" where AccBatchDate>='{0}' and AccBatchDate<='{1}'", datefrom, dateto)
    If docType <> "" Then
        sqlw &= String.Format(" and AccDocType='{0}'", docType)
    End If
    Dim sql = String.Format("select AccDocType, AccDocNo,PartyName,DocRefNo,AccBatchDate,AccEffectiveDate,IssueBy from Acc_TransactionHD {0} order by AccDocNo", sqlw)
    Dim dt = obj.GetDataFromSQL(sql)
    Dim docTypes = obj.GetDataFromSQL("select distinct a.AccDocType as AccDocType,isnull(b.TName,'N/A') as AccDocTypeName from Acc_TransactionHD a left join Mas_DocConfig b on a.AccDocType=b.Category ")
End Code
<h2>Transaction List</h2>
<div class="row">
    <div class="col-md-3">
        Date From : <input type="date" id="txtDateFrom" value="@datefrom" class="form-control" />
    </div>
    <div class="col-md-3">
        To : <input type="date" id="txtDateTo" value="@dateto" class="form-control" />
    </div>
    <div class="col-md-6">
        Type :
        <br />
        <div style="display:flex">
            <select id="txtDocType" class="form-control dropdown">
                <option value="">
                    ALL
                </option>
                @If docTypes.Rows.Count > 0 Then
                    For Each dr As Data.DataRow In docTypes.Rows
                        If docType.Equals(dr("AccDocType")) Then
                            @<option value="@dr("AccDocType")" selected>
                                @dr("AccDocTypeName") - @dr("AccDocType")
                            </option>
                        Else
                            @<option value="@dr("AccDocType")">
                                @dr("AccDocTypeName") - @dr("AccDocType")
                            </option>
                        End If
                    Next
                End If
            </select>
            <input type="button" onclick="RefreshPage()" class="btn btn-primary" value="Filter" />
            <input type="button" class="btn btn-warning" value="Add" onclick="AddNewDoc()" />
        </div>
    </div>
</div>
<br>
@If dt.Rows.Count > 0 Then
    @<div>
        <b>Total Records : @dt.Rows.Count</b>
    </div>
    @<table id="tbData" border="1" class="table" style="border-style:solid;border-collapse:collapse;border-width:thin;">
        <thead>
            <tr>
                <th rowspan="2">#</th>
                @For each dc As Data.DataColumn In dt.Columns
                    @<th onclick="sortTable('tbData', @dc.Ordinal)" class="d-table-cell">@dc.ColumnName</th>
                Next
            </tr>
            <tr>
                @For Each dc As Data.DataColumn In dt.Columns
                    Dim t = "txtCliteria" & dc.Ordinal
                    @<th>
                        <input type="text" id="@t" class="form-control" placeholder="Search @dc.ColumnName" onkeyup="searchTableByColumn('tbData','@t',@dc.Ordinal)" />
                    </th>
                Next
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                Dim frmName = dr("AccDocType").ToString()
                @<tr>
                    <td><a class="btn btn-success" href="?Form=Form@(frmName)&SRC=@dbSource&DB=@dbName&Code=@dr("AccDocNo")">Print</a></td>
                    @For Each dc As Data.DataColumn In dt.Columns
                        If dc.ColumnName = "AccDocNo" Then
                            @<td><a href="?Form=Transaction&SRC=@dbSource&DB=@dbName&Code=@dr("AccDocNo")">@dr(dc.ColumnName)</a></td>
                        Else
                            If dc.ColumnName.IndexOf("Date") > 0 Then
                                @<td>@Convert.ToDateTime(dr(dc.ColumnName)).ToString("dd/MM/yyyy")</td>
                            Else
                                @<td>@dr(dc.ColumnName)</td>
                            End If
                        End If
                    Next
                </tr>
            Next
        </tbody>
    </table>
Else
    @<b>@obj.Message</b>
End If
<script src="~/Scripts/util.js?@DateTime.Now.ToString("yyyyMMddHHMMss")"></script>
<script type="text/javascript">
    function AddNewDoc() {
        var typ = document.getElementById('txtDocType').value;
        window.open("?Form=Transaction&SRC=@dbSource&DB=@dbName&Type=" + typ, "_blank");
    }
    function RefreshPage() {
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        var typ= document.getElementById('txtDocType').value;
        window.location.href = "?Form=Lists&DateFrom=" + df + "&DateTo=" + dt + "&SRC=@dbSource&DB=@dbName&Type=" +typ;
    }
</script> 