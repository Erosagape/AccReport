@Code
    ViewData("Title") = "SetBalance"
    Dim dbName = ViewBag.AccDatabase
    Dim dbSource = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim postMessage As String = ""
    Dim obj = New AccReport.CUtil(".", dbName)
    Dim dtAccCode = obj.GetDataFromSQL("SELECT AccCode,AccName FROM vMas_AccCode ORDER BY AccCode")
    If Not Request.Form("Submit") Is Nothing Then
        Dim rowCount As Integer = Request.Form("rowCount")
        Dim dateEntry As Date = Request.Form("dateEntry")
        Dim sqlTemp As String = "
declare @@newdoc varchar(20)=dbo.GetNewRunning('BL','J','{3}');
if not exists(select 1 from Acc_JournalHD where JournalNo=@@newdoc)
begin
    EXEC [dbo].[SetJournalHeader]
    @@ip = N'{0}',
    @@dbname = N'{1}',
    @@doctype = N'BL',
    @@journalno=@@newdoc,
    @@entrydate = '{2}',
    @@docdate = '{2}',
    @@userid = N'{3}',
    @@note = N'Set Balance {2}',
    @@totaldebit = 0,
    @@totalcredit = 0
end
select * from Acc_JournalHD where JournalNo=@@newdoc;
"
        sqlTemp = String.Format(sqlTemp, Request.UserHostAddress, dbName, dateEntry, ViewBag.User)
        For i As Integer = 1 To rowCount

        Next
    End If
End Code
<h2>Setup Balance</h2>
<form action="" method="post">
    <input type="date" name="dateEntry" class="form-control" />
    <br />
    <div class="row">
        <div class="col-sm-6">
            <div style="display:flex">
                <div style="flex:2">
                    <label>Acc Code</label>
                </div>
                <div style="flex:8">
                    <label>Acc Name</label>
                </div>
            </div>
        </div>
        <div class="col-sm-3">
            <label>Debit</label>
        </div>
        <div class="col-sm-3">
            <label>Credit</label>
        </div>
    </div>
    @If dtAccCode.Rows.Count > 1 Then
        Dim i As Integer = 0
        For Each dr As Data.DataRow In dtAccCode.Rows
            i += 1
            Dim fldCode As String = "AccCode" & i
            Dim fldName As String = "AccName" & i
            Dim fldDr As String = "Debit" & i
            Dim fldCr As String = "Credit" & i
            @<div class="row">
                <div class="col-sm-6">
                    <div style="display:flex">
                        <div style="flex:2">
                            <input type="text" name="@fldCode" value="@dr("AccCode")" class="form-control" />
                        </div>
                        <div style="flex:8">
                            <input type="text" name="@fldName" value="@dr("AccName")" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="col-sm-3">
                    <input type="number" name="@fldDr" class="form-control" />
                </div>
                <div class="col-sm-3">
                    <input type="number" name="@fldCr" class="form-control" />
                </div>
            </div>
        Next
        @<input type="hidden" name="rowCount" value="@i" />
        @<input type="submit" name="Submit" value="Save Data" Class="btn btn-success" />
    End If
</form>

