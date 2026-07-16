@Code
    ViewData("Title") = "Documents List"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim msg As String = ""
    Dim sql As String = "select a.*,b.DocTypeCode,c.DocTypeName,b.AccDocType,b.JournalType from Mas_DocConfig a left join Mas_DocTypeConfig b
on a.DocConfigID=b.DocConfigId
left join Mas_DocType c on b.DocTypeCode=c.DocTypeCode
order by a.TName"
    Dim dt As Data.DataTable = obj.GetDataFromSQL(sql)
    Dim dc As Data.DataTable = obj.GetDataFromSQL("select * from Mas_DocType")
    If Request.Form("DocConfigID") IsNot Nothing Then
        Dim docConfigId = Request.Form("DocConfigID")
        Dim category = Request.Form("Category")
        Dim docTypeCode = Request.Form("DocTypeCode")
        Dim accDocType = Request.Form("AccDocType")
        Dim journalType = Request.Form("JournalType")
        sql = "IF NOT EXISTS(SELECT 1 FROM Mas_DocTypeConfig where DocConfigID='{0}')
BEGIN
INSERT INTO Mas_DocTypeConfig (DocConfigID,DocTypeCode,AccDocType,JournalType)
VALUES ('{0}','{1}','{2}','{3}')
END
ELSE
BEGIN
UPDATE Mas_DocTypeConfig
SET DocTypeCode='{1}',AccDocType='{2}',JournalType='{3}'
WHERE DocConfigID='{0}'
END"
        msg = obj.ExecuteSQL(String.Format(sql, docConfigId, docTypeCode, accDocType, journalType))
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
        End If
    End If
End Code
<h2>Documents List</h2>
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Document Name</th>
                <th>Document Code</th>
                <th style="display:none">Account Group</th>
                <th style="display:none">Transaction Type</th>
                <th style="display:none">Journal Type</th>
                <th>Account Book</th>
                <th colspan="2">Function</th>
            </tr>
        </thead>
        <tbody>
            @For i As Integer = 0 To dt.Rows.Count - 1
                Dim dr As Data.DataRow = dt.Rows(i)
                @<tr data-doc-config-id="@dr("DocConfigID")">
                    <td>@(i + 1)</td>
                    <td>@dr("TName")</td>
                    <td>@dr("Category")</td>
                    <td style="display:none">@dr("DocTypeCode")</td>
                    <td style="display:none">@dr("AccDocType")</td>
                    <td style="display:none">@dr("JournalType")</td>
                    <td>@dr("DocTypeName")</td>
                    @If dr("AccDocType").ToString() = "" Then
                        @<td><a href="Form?Form=Journal&DB=@dbname&SRC=@dbSource&Type=@dr("JournalType")">Add</a></td>
                    Else
                        @<td><a href="Form?Form=Transaction&DB=@dbname&SRC=@dbSource&Type=@dr("AccDocType")">Add</a></td>
                    End If
                    <td><a href="#" data-toggle="modal" data-target="#documentModal" onclick="editDocument('@dr("DocConfigID")')">Config</a></td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<p>No documents found.</p>
End If
<div class="modal" id="documentModal" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Document Config <input type="text" id="txtTName" name="TName" class="form-control" readonly />
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <input type="hidden" id="txtDocConfigId" class="form-control" name="DocConfigID" />
                    <br />Document Code
                    <input type="text" id="txtCategory" class="form-control" name="Category" readonly />
                    <br />Account Group
                    <select id="txtDocTypeCode" class="form-control dropdown" name="DocTypeCode">
                        @For each dr As Data.DataRow in dc.Rows
                            @<option value="@dr("DocTypeCode")">@dr("DocTypeName")</option>
                        Next
                    </select>
                    <br />Transaction Type
                    <input type="text" id="txtAccDocType" class="form-control" name="AccDocType" />
                    <br />Journal Type
                    <input type="text" id="txtJournalType" class="form-control" name="JournalType" />
                    <br />
                    <input type="submit" value="Save" class="btn btn-success" />
                </form>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    let msg="@msg";
    if(msg!="") {
        alert(msg);
        if (window.history.replaceState) {
            window.history.replaceState(null, null, window.location.href);
        }
        window.location.reload();
    }
    function editDocument(docConfigId) {
        var row = document.querySelector('tr[data-doc-config-id="' + docConfigId + '"]');
        if (row) {
            document.getElementById('txtDocConfigId').value = docConfigId;
            document.getElementById('txtTName').value = row.cells[1].innerText;
            document.getElementById('txtCategory').value = row.cells[2].innerText;
            document.getElementById('txtDocTypeCode').value = row.cells[3].innerText;
            document.getElementById('txtAccDocType').value = row.cells[4].innerText;
            document.getElementById('txtJournalType').value = row.cells[5].innerText;
        }
    }
</script>