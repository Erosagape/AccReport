@Code
    ViewData("Title") = "Approve Center"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim userid As String = ViewBag.User
    Dim sql As String = ""
    Dim msg As String = ""
    Dim result As String = "Ready"
    Dim dt As New Data.DataTable
    If Not Request.Form("btnCreatePO") Is Nothing Then
        Dim docDate As String = Request.Form("txtDocDate")
        Dim docNo As String = Request.Form("txtDocNo")
        Dim dueDate As String = Request.Form("txtDueDate")
        Dim refNo As String = Request.Form("txtRefNo")
        sql = String.Format("EXEC [dbo].[Insert_POFromPR] '{0}','{1}','{2}','{3}','{4}'", docNo, docDate, dueDate, refNo, userid)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            If dt.Rows.Count > 0 Then
                result = "<a href='" & Url.Content("~") & "Form?Form=FormPO&DB=" & dbName & "&SRC=" & dbSource & "&Code=" & dt.Rows(0)(0).ToString() & "' target='_blank'>View Document</a>"
                msg = "Create PO Complete"
            Else
                msg = "No Data To Save"
                result = msg
            End If
        Else
            msg = obj.Message
            result = msg
        End If
        Response.StatusCode = 200
        Response.SuppressFormsAuthenticationRedirect = True
    End If
End Code

<h2>Approve Center</h2>
<form action="" method="post">
    <h4>สร้างใบสั่งซื้อ (PO) จาก ใบขออนุมัติ (PR)</h4>
    <div class="row">
        <div class="col-sm-3">
            <label for="txtDocDate">Document Date</label>
            <input type="date" id="txtDocDate" name="txtDocDate" class="form-control" />
        </div>
        <div class="col-sm-3">
            <label for="txtDocNo">Document No</label>
            <input type="text" id="txtDocNo" name="txtDocNo" class="form-control" />
        </div>
        <div class="col-sm-3">
            <label for="txtDueDate">Due Date</label>
            <input type="date" id="txtDueDate" name="txtDueDate" class="form-control" />
        </div>
        <div class="col-sm-3">
            <label for="txtRefNo">Reference No</label>
            <input type="text" id="txtRefNo" name="txtRefNo" class="form-control" />
        </div>
    </div>
    <input type="submit" class="btn btn-primary" value="Create PO" name="btnCreatePO" />
    @Html.Raw(result)
</form>
<script type="text/javascript">
    var msg = '@msg';
    if(msg!=='') {
        alert(msg);
    }
</script>