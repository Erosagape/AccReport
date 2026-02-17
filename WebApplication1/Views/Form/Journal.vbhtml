@Code
    ViewData("Title") = "Journal"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)

    Dim EntryId As Integer = 0
    Dim JournalNo As String = ""
    Dim EntryDate As Date = DateTime.Now
    Dim EffectiveDate As Date = DateTime.MinValue
    Dim EntryBy As String = ViewBag.User
    Dim Description As String = ""
    Dim TotalDebit As Double = 0
    Dim TotalCredit As Double = 0
    Dim DocType As String = "JV"
    Dim dt As New Data.DataTable

    Dim msg As String = ""

    If Not Request.QueryString("Type") Is Nothing Then
        DocType = Request.QueryString("Type")
    End If
    If Not Request.QueryString("Code") Is Nothing Then
        JournalNo = Request.QueryString("Code")
    End If
    If Not Request.Form("submitHeader") Is Nothing Then
        EntryId = Request.Form("EntryId")
        JournalNo = Request.Form("JournalNo")
        EntryDate = Request.Form("EntryDate")
        EffectiveDate = Request.Form("EffectiveDate")
        EntryBy = Request.Form("EntryBy")
        Description = Request.Form("Description")
        TotalDebit = Request.Form("TotalDebit")
        TotalCredit = Request.Form("TotalCredit")
        If JournalNo = "" Then
            JournalNo = obj.GetDataFromSQL(String.Format("SELECT dbo.GetNewRunning('{0}','J','{1}');", DocType, EntryDate)).Rows(0)(0)
        End If
        Dim sql As String = "
DECLARE @@RC int
DECLARE @@ip varchar(50)='{0}'
DECLARE @@dbname varchar(10)='{1}'
DECLARE @@doctype varchar(10)='{2}'
DECLARE @@journalno varchar(50)='{3}'
DECLARE @@entrydate date='{4}'
DECLARE @@docdate date='{5}'
DECLARE @@userid varchar(50)='{6}'
DECLARE @@note varchar(max)='{7}'
DECLARE @@totaldebit float={8}
DECLARE @@totalcredit float={9}

EXECUTE @@RC = [dbo].[SetJournalHeader]
@@ip
,@@dbname
,@@doctype
,@@journalno
,@@entrydate
,@@docdate
,@@userid
,@@note
,@@totaldebit
,@@totalcredit
"
        sql = String.Format(sql,
                             Request.UserHostAddress,
                             ViewBag.AccDatabase,
                             DocType,
                             JournalNo,
                             Convert.ToDateTime(Request.Form("EntryDate")).ToString("yyyy-MM-dd"),
                             Convert.ToDateTime(Request.Form("EffectiveDate")).ToString("yyyy-MM-dd"),
                             Request.Form("EntryBy"),
                             Request.Form("Description"),
                             Request.Form("TotalDebit"),
                             Request.Form("TotalCredit")
        )
        msg = obj.ExecuteSQL(sql)
    End If
    If JournalNo <> "" Then
        dt = obj.GetDataFromSQL(String.Format("SELECT * FROM Acc_JournalHD where Journalno='{0}'", JournalNo))
        If dt.Rows.Count > 0 Then
            Dim dr As Data.DataRow = dt.Rows(0)
            EntryId = dr("EntryId")
            JournalNo = dr("JournalNo")
            EntryDate = dr("EntryDate")
            EffectiveDate = dr("EffectiveDate")
            EntryBy = dr("EntryBy")
            Description = dr("Description")
            TotalDebit = dr("TotalDebit")
            TotalCredit = dr("TotalCredit")
        End If
    End If
End Code
<h2>Journal</h2>
@If obj.IsConnect Then
    @<form action="" method="post">
        <div Class="row">
            <div Class="col-md-6">
                <input type="hidden" id="txtEntryId" name="EntryId" value="@EntryId" />
                <div class="row">
                    <div class="col-sm-4">
                        <label>Journal No</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" id="txtJournalNo" name="JournalNo" class="form-control" readonly value="@JournalNo" />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-sm-4">
                        <label>Entry Date</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="date" id="txtEntryDate" name="EntryDate" class="form-control" value="@EntryDate.ToString("yyyy-MM-dd")" />
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-sm-4">
                        <label>Effective Date</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="date" id="txtEffectiveDate" name="EffectiveDate" class="form-control" value="@EffectiveDate.ToString("yyyy-MM-dd")" />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-sm-4">
                        <label>Entry by</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" id="txtEntryBy" name="EntryBy" class="form-control" readonly value="@EntryBy" />
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <div class="row">
                    <div class="col-sm-4">
                        <label>Description</label>
                    </div>
                    <div class="col-sm-8">
                        <textarea class="form-control" style="width:100%;" id="txtDescription" name="Description">@Description</textarea>
                    </div>
                </div>
            </div>
            <div class="col-sm-6">
                <div class="row">
                    <div class="col-sm-4">
                        <label>Total Debit</label>
                    </div>
                    <div class="col-sm-8" style="font-weight:bold">
                        <input type="text" id="txtTotalDebit" name="TotalDebit" class="form-control text-right" readonly value="@TotalDebit.ToString("#,##0.00#")" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Total Credit</label>
                    </div>
                    <div class="col-sm-8" style="font-weight:bold">
                        <input type="text" id="txtTotalCredit" name="TotalCredit" class="form-control text-right" readonly value="@TotalCredit.ToString("#,##0.00#")" />
                    </div>
                </div>
            </div>
        </div>
        <input type="submit" value="Save Journal" class="btn btn-success" name="submitHeader" id="submitHeader" />
    </form>
End If

<script type="text/javascript">
    var msg = '@msg';
    var docno = '@JournalNo';
    window.onload = function () {
        if (msg !== '') {
            alert(msg);
            if (window.location.href.indexOf(docno) < 0) {
                window.location = window.location.href + '&Code=' + docno;
            }
        }
    }
</script>