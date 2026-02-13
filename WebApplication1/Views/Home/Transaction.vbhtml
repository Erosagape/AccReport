@Code
    ViewData("Title") = "Transaction"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim dtAP As New Data.DataTable
    Dim dtPI As New Data.DataTable
    Dim dtPO As New Data.DataTable
    Dim dtSO As New Data.DataTable
    Dim msg As String = ""
    If Not Request.Form("submitPIFromPO") Is Nothing Then
        Dim sql As String = "
DECLARE @@RC int
DECLARE @@userid varchar(10)='{0}'
DECLARE @@docdate date='{1}'
DECLARE @@pono varchar(10)='{2}'
DECLARE @@invno varchar(50)='{3}'
DECLARE @@itemno int=0
DECLARE @@qty float=0
DECLARE @@docno varchar(20)='{4}'

EXECUTE @@RC = [dbo].[Insert_PIFromPO] 
   @@userid
  ,@@docdate
  ,@@pono
  ,@@invno
  ,@@itemno
  ,@@qty
  ,@@docno
"
        sql = String.Format(sql, Request.Form("PIUserID"),
                   Convert.ToDateTime(Request.Form("PIDocDate")).ToString("yyyy-MM-dd"),
                   Request.Form("PONo2"),
                   Request.Form("PIRefNo"),
                   Request.Form("PINo")
)
        dtPI = obj.GetDataFromSQL(sql)
        If dtPI.Rows.Count > 0 Then
            msg = "Create Number " & dtPI.Rows(0)("PINo") & " Complete"
        Else
            msg = obj.Message
        End If
    End If
    If Not Request.Form("submitSOFromSR") Is Nothing Then
        Dim sql As String = "
DECLARE @@RC int
DECLARE @@srno nvarchar(10)='{0}'
DECLARE @@docdate date='{1}'
DECLARE @@duedate date='{2}'
DECLARE @@refno nvarchar(50)='{3}'
DECLARE @@userid nvarchar(50)='{4}'
DECLARE @@itemno int=0
DECLARE @@sono varchar(20)='{5}'

EXECUTE @@RC = [dbo].[Insert_SOFromSR] 
   @@srno
  ,@@docdate
  ,@@duedate
  ,@@refno
  ,@@userid
  ,@@itemno
  ,@@sono
"
        sql = String.Format(sql, Request.Form("SRNo"),
                    Convert.ToDateTime(Request.Form("SODocDate")).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(Request.Form("SODueDate")).ToString("yyyy-MM-dd"),
                    Request.Form("SORefNo"),
                    Request.Form("SOUserID"),
                    Request.Form("SONo")
)
        dtSO = obj.GetDataFromSQL(sql)
        If dtSO.Rows.Count > 0 Then
            msg = "Create Number " & dtSO.Rows(0)("SONo") & " Complete"
        Else
            msg = obj.Message
        End If
    End If
    If Not Request.Form("submitPOFromPR") Is Nothing Then
        Dim sql As String = "DECLARE @@RC int
DECLARE @@prno nvarchar(10)='{0}'
DECLARE @@docdate date='{1}'
DECLARE @@duedate date='{2}'
DECLARE @@refno nvarchar(50)='{3}'
DECLARE @@userid nvarchar(50)='{4}'
DECLARE @@itemno int=0
DECLARE @@pono varchar(20)='{5}'
DECLARE @@closedoc int={6}

EXECUTE @@RC = [dbo].[Insert_POFromPR]
@@prno
  ,@@docdate
  ,@@duedate
  ,@@refno
  ,@@userid
  ,@@itemno
  ,@@pono
  ,@@closedoc
"
        sql = String.Format(sql, Request.Form("PRNo"),
                    Convert.ToDateTime(Request.Form("PODocDate")).ToString("yyyy-MM-dd"),
                    Convert.ToDateTime(Request.Form("PODueDate")).ToString("yyyy-MM-dd"),
                    Request.Form("PORefNo"),
                    Request.Form("POUserID"),
                    Request.Form("PONo"),
                    Request.Form("ClosePR")
)
        dtPO = obj.GetDataFromSQL(sql)
        If dtPO.Rows.Count > 0 Then
            msg = "Create Number " & dtPO.Rows(0)("PoNo") & " Complete"
        Else
            msg = obj.Message
        End If
    End If
    If Not Request.Form("submitPIToJournal") Is Nothing Then
        Dim sql As String = "
DECLARE @@RC int
DECLARE @@pino nvarchar(50)='{2}'
DECLARE @@duedate date='{1}'
DECLARE @@userid nvarchar(50)='{0}'

EXECUTE @@RC = [dbo].[Insert_PIToJournal] 
   @@pino
  ,@@duedate
  ,@@userid
"
        sql = String.Format(sql, Request.Form("APUserID"),
            Convert.ToDateTime(Request.Form("APDueDate")).ToString("yyyy-MM-dd"),
            Request.Form("APNo")
)
        dtAP = obj.GetDataFromSQL(sql)
        If dtAP.Rows.Count > 0 Then
            msg = "Create Number " & dtAP.Rows(0)("JournalNo") & " Complete"
        Else
            msg = obj.Message
        End If
    End If
    If Not Request.Form("submitPVFromPI") Is Nothing Then
        Dim sql As String = "DECLARE @@RC int
DECLARE @@invno nvarchar(50)='{0}'
DECLARE @@userid nvarchar(50)='{1}'
DECLARE @@taxno nvarchar(50)='{2}'
DECLARE @@docdate date='{3}'
DECLARE @@pvno nvarchar(20)='{4}'
DECLARE @@accdebit nvarchar(20)='{5}'
DECLARE @@acccredit nvarchar(20)='{6}'

EXECUTE @@RC = [dbo].[Insert_PVFromPI] 
   @@invno
  ,@@userid
  ,@@taxno
  ,@@docdate
  ,@@pvno
  ,@@accdebit
  ,@@acccredit
"
        sql = String.Format(sql,
                          Request.Form("APNo"),
                          Request.Form("APUserID"),
                          Request.Form("RCVNo"),
                          Convert.ToDateTime(Request.Form("APPayDate")).ToString("yyyy-MM-dd"),
                          Request.Form("PVNo"),
                          Request.Form("DebitCode"),
                          Request.Form("CreditCode")
        )
        dtAP = obj.GetDataFromSQL(sql)
        If dtAP.Rows.Count > 0 Then
            msg = "Create Number " & dtAP.Rows(0)("JournalNo") & " Complete"
        Else
            msg = obj.Message
        End If
    End If
End Code
<h2>Transaction Center</h2>
<form action="" method="post">
    <b>Create Purchase Order from Purchase Requisition</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="POUserID" id="txtPOUser" />
    <br />
    Document Date* : <input type="date" name="PODocDate" id="txtPODate" />
    <br />
    Supplier Quotation No :  <input type="text" name="PORefNo" id="txtPORefNo" />
    <br />
    Expire Date* :  <input type="date" name="PODueDate" id="txtPOExpireDate" />
    <br />
    PR No : <input type="text" name="PRNo" id="txtPRNo" />
    <br />
    Close PR : <select name="ClosePR" id="txtPRStatus">
        <option value="1">Y</option>
        <option value="0">N</option>
    </select>
    <br />
    Add to Existing PO : <input type="text" name="PONo" id="txtPONo" />
    <br />
    <input type="submit" name="submitPOFromPR" value="Create Data" />
</form>
<form method="post" action="">
    <b>Create Sale Order from Sales Requisition</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="SOUserID" id="txtSOUser" />
    <br />
    Document Date* : <input type="date" name="SODocDate" id="txtSODate" />
    <br />
    Customer PO No :  <input type="text" name="SORefNo" id="txtSORefNo" />
    <br />
    Expected Date* :  <input type="date" name="SODueDate" id="txtSOExpireDate" />
    <br />
    SR No : <input type="text" name="SRNo" id="txtSRNo" />
    <br />
    Add to Existing SO : <input type="text" name="SONo" id="txtSONo" />
    <br />
    <input type="submit" name="submitSOFromSR" value="Create Data" />
</form>
<form method="post" action="">
    <b>Create Bill of Expenses from Purchase Order</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="PIUserID" id="txtPIUser" />
    <br />
    Billing Date* : <input type="date" name="PIDocDate" id="txtPIDate" />
    <br />
    Supplier Billing No :  <input type="text" name="PIRefNo" id="txtPIRefNo" />
    <br />
    PO No : <input type="text" name="PONo2" id="txtPONo2" />
    <br />
    Add to Existing No : <input type="text" name="PINo" id="txtPINo" />
    <br />
    <input type="submit" name="submitPIFromPO" value="Create Data" />
</form>
<form method="post" action="">
    <b>Post Bill of Expenses to Journal Entries</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="APUserID" id="txtAPUser" />
    <br />
    PI No : <input type="text" name="APNo" id="txtAPNo" />
    <br />
    Due Date* : <input type="date" name="APDueDate" id="txtAPDueDate" />
    <br />
    <input type="submit" name="submitPIToJournal" value="Create Data" />
</form>
<form method="post" action="">
    <b>Create Cash Payment for Bill of Expenses</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="APUserID" id="txtAPUser2" />
    <br />
    PI No : <input type="text" name="APNo" id="txtAPNO2" />
    <br />
    Payment Date* : <input type="date" name="APPayDate" id="txtAPPayDate" />
    <br />
    Receipt No : <input type="text" name="RCVNo" id="txtRCVNo" />
    <br />
    A/C Cash : <input type="text" name="CreditCode" id="txtCredit" />
    <br />
    A/C Expense : <input type="text" name="DebitCode" id="txtDebit" />
    <br />
    Add to Existing No : <input type="text" name="PVNo" id="txtPVNo" />
    <br />
    <input type="submit" name="submitPVFromPI" value="Create Data" />
</form>
<script type="text/javascript">
    var msg = '@msg';
    window.onload = function() {
        if (msg !== '') {
            alert(msg);
        }
    }
</script>
