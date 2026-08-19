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
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim EntryId As Integer = 0
    Dim JournalNo As String = ""
    Dim DocType As String = ""
    Dim EntryDate As Date = DateTime.Now
    Dim EffectiveDate As Date = DateTime.MinValue
    Dim EntryBy As String = ViewBag.User
    Dim Description As String = ""
    Dim TotalDebit As Double = 0
    Dim TotalCredit As Double = 0

    Dim dt As New Data.DataTable

    Dim Seq As Integer = 0
    Dim AccCode As String = ""
    Dim AccName As String = ""
    Dim GLName As String = ""
    Dim AccDesc As String = ""
    Dim Debit As Double = 0
    Dim Credit As Double = 0

    Dim msg As String = ""
    Dim showDetail As Integer = 0

    If Not Request.QueryString("Type") Is Nothing Then
        DocType = Request.QueryString("Type")
    End If
    If Not Request.QueryString("Code") Is Nothing Then
        JournalNo = Request.QueryString("Code")
    End If
    If Not Request.QueryString("Item") Is Nothing Then
        Seq = Request.QueryString("Item")
        showDetail = 1
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
        If DocType = "" And JournalNo = "" Then
            msg = "Please Enter Document Type"
        Else
            If JournalNo = "" Then
                JournalNo = obj.GetDataFromSQL(String.Format("SELECT dbo.GetNewRunning('{0}','J','{1}');", DocType, EntryDate.ToString("yyyy-MM-dd"))).Rows(0)(0)
            Else
                DocType = "JV"
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
                                 Convert.ToDouble(Request.Form("TotalDebit")),
                                 Convert.ToDouble(Request.Form("TotalCredit"))
            )

            msg = obj.ExecuteSQL(sql)
        End If
    End If
    If JournalNo <> "" Then

        If Not Request.Form("submitDtl") Is Nothing Then
            Dim sqlD As String = "
IF {1}=0
BEGIN
DECLARE @@seq as int=0;
SET @@seq =(select isnull(MAX(Seq),0)+1 from Acc_JournalDT where EntryId={0});

INSERT INTO Acc_JournalDT (EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
SELECT {0},@@seq,'{2}','{3}','{4}',{5},{6};
END
ELSE
BEGIN
UPDATE Acc_JournalDT
SET AccCode='{2}',
AccName='{3}',AccDesc='{4}',Debit={5},Credit={6}
WHERE EntryId={0} AND Seq={1};
END

update h
set h.TotalCredit=d.Cr,h.TotalDebit=d.Dr
from (select EntryID,Sum(Debit) as Dr,sum(Credit) as Cr from Acc_JournalDT group by EntryID) d inner join Acc_JournalHD h
on d.EntryId=h.EntryID
where h.EntryId={0};
"
            sqlD = String.Format(sqlD,
                Request.Form("EntryId"),
                Seq,
                Request.Form("AccCode"),
                Request.Form("AccName"),
                Request.Form("AccDesc"),
                Request.Form("Debit"),
                Request.Form("Credit")
            )
            msg = obj.ExecuteSQL(sqlD)
            showDetail = 0
        End If

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

    If Seq > 0 Then
        Dim dtDetail As Data.DataTable = obj.GetDataFromSQL(String.Format("SELECT * FROM vJournal_D where EntryId={0} AND Seq={1}", EntryId, Seq))
        If dtDetail.Rows.Count > 0 Then
            AccCode = dtDetail.Rows(0)("AccCode")
            AccName = dtDetail.Rows(0)("GLDesc")
            GLName = dtDetail.Rows(0)("GLName")
            AccDesc ="" & dtDetail.Rows(0)("AccDesc")
            Debit = dtDetail.Rows(0)("Debit")
            Credit = dtDetail.Rows(0)("Credit")
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
                        <input type="date" id="txtEntryDate" name="EntryDate" class="form-control" value="@EntryDate.ToString("yyyy-MM-dd")" onchange="DataChanged()" />
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
                        <input type="date" id="txtEffectiveDate" name="EffectiveDate" onchange="DataChanged()" class="form-control" value="@EffectiveDate.ToString("yyyy-MM-dd")" />
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
                        <textarea class="form-control" onchange="DataChanged()" style="width:100%;" id="txtDescription" name="Description">@Description</textarea>
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
        <input type="button" id="btnAdd" class="btn btn-warning" onclick="ShowDialog()" value="Add Detail" />
        @If dt.Rows.Count > 0 Then
            Dim rs As Data.DataTable = obj.GetDataFromSQL(String.Format("SELECT * FROM vJournal_D where EntryId={0} ORDER BY Seq", EntryId))
            If rs.Rows.Count > 0 Then
                @<table class="table table-responsive" border="1" style="border-collapse:collapse;border-width:thin">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Account Code</th>
                            <th>Account Name</th>
                            <th>Debit</th>
                            <th>Credit</th>
                        </tr>
                    </thead>
                    <tbody>
                        @For Each dr As Data.DataRow In rs.Rows
                            @<tr>
                                <td>
                                    <input type="button" class="btn btn-primary" value="Edit" onclick="ShowDetail(@dr("Seq"))" />
                                </td>
                                <td>
                                    @dr("AccCode")
                                </td>
                                <td>
                                    @dr("GLName")
                                </td>
                                <td class="colnum">
                                    @Convert.ToDouble(dr("Debit")).ToString("#,##0.00")
                                </td>
                                <td class="colnum">
                                    @Convert.ToDouble(dr("Credit")).ToString("#,##0.00")
                                </td>
                            </tr>
                        Next
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan="5">
                                @If dt.Rows(0)("JournalNo").ToString().Substring(0, 2) = "RV" Then
                                    @<a Class="btn btn-primary" href="?Form=FormRV&SRC=@dbSource&DB=@dbName&Code=@dt.Rows(0)("JournalNo")">Print Voucher</a>
                                Else
                                    If dt.Rows(0)("JournalNo").ToString().Substring(0, 2) = "PV" Then
                                        @<a Class="btn btn-primary" href="?Form=FormPV&SRC=@dbSource&DB=@dbName&Code=@dt.Rows(0)("JournalNo")">Print Voucher</a>
                                    Else
                                        @<a Class="btn btn-primary" href="?Form=FormGL&SRC=@dbSource&DB=@dbName&Code=@dt.Rows(0)("JournalNo")">Print Voucher</a>
                                    End If
                                End If
                            </td>
                        </tr>
                    </tfoot>
                </table>
            End If
        End If
        <div Class="modal fade" id="frmDetail">
            <div Class="modal-dialog" role="document">
                <div Class="modal-content">
                    <div Class="modal-header">
                        <div class="row">
                            <div class="col-sm-3">
                                <label>Seq</label>
                            </div>
                            <div class="col-sm-7">
                                <input type="number" name="Seq" class="form-control" id="txtSeq" value="@Seq" />
                            </div>
                        </div>
                        <div class="row" id="dvAccCode" style="display:none;">
                            <div class="col-sm-12">
                                <table class="DataTable table" style="width:100%">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Code</th>
                                            <th>Name</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        @Code
                                            Dim ac As Data.DataTable = obj.GetDataFromSQL("SELECT * FROM Mas_AccCode")
                                            If ac.Rows.Count > 0 Then
                                                For Each dr As Data.DataRow In ac.Rows
                                                    @<tr>
                                                        <td><a href="#txtAccCode" onclick="SetAccount('@dr("AccCode")','@dr("AccName")')" class="btn btn-success">Select</a></td>
                                                        <td>@dr("AccCode")</td>
                                                        <td>@dr("AccName")</td>
                                                    </tr>
                                                Next
                                            End If
                                        End Code
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div Class="modal-body">
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="row">
                                    <div class="col-sm-3">
                                        <a href="#dvAccCode" onclick="ShowAccount()"><label>Account Code</label></a>
                                    </div>
                                    <div class="col-sm-7">
                                        <input type="text" class="form-control" name="AccCode" id="txtAccCode" value="@AccCode" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="row">
                                    <div class="col-sm-3">
                                        <label>Name</label>
                                    </div>
                                    <div class="col-sm-7">
                                        <input type="text" class="form-control" name="GLName" id="txtGLName" value="@GLName" readonly />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="row">
                                    <div class="col-sm-3">
                                        <label>Account Name</label>
                                    </div>
                                    <div class="col-sm-7">
                                        <input type="text" class="form-control" name="AccName" id="txtAccName" value="@AccName" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="row">
                                    <div class="col-sm-3">
                                        <label>Description</label>
                                    </div>
                                    <div class="col-sm-7">
                                        <input type="text" class="form-control" name="AccDesc" id="txtAccDesc" value="@AccDesc" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="row">
                                    <div class="col-sm-3">
                                        <label>Debit</label>
                                    </div>
                                    <div class="col-sm-7">
                                        <input type="number" class="form-control" step="any" inputmode="decimal" name="Debit" id="txtDebit" value="@Debit" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="row">
                                    <div class="col-sm-3">
                                        <label>Credit</label>
                                    </div>
                                    <div class="col-sm-7">
                                        <input type="number" class="form-control" step="any" inputmode="decimal" name="Credit" id="txtCredit" value="@Credit" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div Class="modal-footer">
                        <div style="float:left">
                            <input type="submit" class="btn btn-success" name="submitDtl" value="Save Detail" />
                        </div>
                        <div style="float:right">
                            <input type="button" class="btn btn-danger" data-dismiss="modal" value="Close" />
                        </div>
                    </div>
                </div>
            </div>
            <input type="button" data-toggle="modal" data-target="#frmDetail" value="" id="btnMdl" style="display:none;" />
        </div>
    </form>
End If
<script type="text/javascript">
    var datachanged = 0;
    var msg = '@msg';
    var docno = '@JournalNo';
    window.onload = function () {
        if (msg !== '') {
            alert(msg);
            if (window.location.href.indexOf(docno) < 0) {
                window.location = window.location.href + '&Code=' + docno;
            } else {
                window.location = window.location.pathname + '?DB=@dbName&SRC=@dbSource&Form=Journal&Code='+docno;
            }
        }
        if ('@showDetail' == '1') {
            document.getElementById('btnMdl').click();
        }
    }
    function ShowDialog() {
        if (document.getElementById('txtEntryId').value == 0) {
            alert('Please Save Document First');
            return;
        }
        window.location.href = window.location.pathname + '?DB=@dbName&SRC=@dbSource&Form=Journal&Code=@JournalNo&Item=0';
    }
    function ShowAccount() {
        document.getElementById('dvAccCode').style.display = 'inline';
    }
    function SetAccount(code, name) {
        document.getElementById('txtAccCode').value = code;
        document.getElementById('txtGLName').value = name;
        document.getElementById('txtAccName').value = name;
        document.getElementById('dvAccCode').style.display = 'none';
    }
    function ShowDetail(itemno) {
        if (datachanged == 1) {
            alert('Data has changed,Please save document before!');
            return;
        }
        window.location.href = window.location.pathname + '?DB=@dbName&SRC=@dbSource&Form=Journal&Code=@JournalNo&Item=' + itemno;
    }
    function DataChanged() {
        datachanged = 1;
    }
</script>