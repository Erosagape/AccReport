@Code
    ViewData("Title") = "Admin"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim msg As String = "Ready"
    Dim bConn = obj.IsConnect()
    Dim action As String = "None"
    Dim sql As String = ""
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    If Not Request.QueryString("Action") Is Nothing Then
        action = Request.QueryString("Action")
    End If
    Dim dateTimeProcess = DateTime.Now.ToString("yyyyMMddHHMMss")
    Select Case action
        Case "DeleteAll"
            sql = "
SELECT * INTO Acc_JournalHD_BK" + dateTimeProcess + " FROM Acc_JournalHD
SELECT * INTO Acc_JournalDT_BK" + dateTimeProcess + " FROM Acc_JournalDT
SELECT * INTO Acc_TransactionHD_BK" + dateTimeProcess + " FROM Acc_TransactionHD
SELECT * INTO Acc_TransactionDT_BK" + dateTimeProcess + " FROM Acc_TransactionDT

DELETE FROM Acc_JournalHD
DELETE FROM Acc_JournalDT
DELETE FROM Acc_TransactionHD
DELETE FROM Acc_TransactionDT
DELETE FROM Acc_AdditionData
"
            msg = obj.ExecuteSQL(sql)
    End Select
End Code
<h2>Admin Page</h2>
<div class="row">
    <div class="col-md-4">
        <input type="button" class="btn btn-default" onclick="CallDelete()" value="Delete All Transaction with Backup" />
    </div>
</div>
<p>
    Action : @action
    <br />
    Result : @msg
</p>
<script type="text/javascript">
    function CallDelete() {
        window.location.href = "?Form=Admin&DB=@dbname&action=DeleteAll";
    }
</script>