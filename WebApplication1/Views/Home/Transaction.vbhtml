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
End Code
<h2>Transaction Center</h2>
<select id="cboDocType">
    @Code
        Dim dtDoc As Data.DataTable = obj.GetDataFromSQL("SELECT * FROM Mas_DocConfig order by TName")
        For Each dr As Data.DataRow In dtDoc.Rows
            @<option value="@dr("Category")">@dr("TName") - @dr("Category")</option>
        Next
    End Code
</select>
<input type="button" class="btn btn-warning" value="Add" onclick="AddNewDoc()" />
@*--Insert_POFromPR*@
<form action="" method="post">
    <b>Create Purchase Order from Purchase Requisition</b>
    @Code
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
    End Code
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
@*--Insert_PIFromPO*@
<form method="post" action="">
    <b>Create Bill of Expenses from Purchase Order</b>
    @Code
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
    End Code
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
@*--Insert_PIToJournal*@
<form method="post" action="">
    <b>Post Bill of Expenses to Journal Entries</b>
    @Code
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
    End Code
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="APUserID" id="txtAPUser" />
    <br />
    PI No : <input type="text" name="APNo" id="txtAPNo" />
    <br />
    Due Date* : <input type="date" name="APDueDate" id="txtAPDueDate" />
    <br />
    <input type="submit" name="submitPIToJournal" value="Create Data" />
</form>
@*--Insert_PVFromPI*@
<form method="post" action="">
    <b>Create Cash Payment for Bill of Expenses</b>
    @Code
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
@*--Insert_PCFromPI*@
<form method="post" action="">
    <b>Create Chq/Transfer Payment for Bill of Expenses</b>
    @Code
        If Not Request.Form("submitPCFromPI") Is Nothing Then
            Dim sql As String = "
DECLARE @@RC int
DECLARE @@userid varchar(10)='{0}'
DECLARE @@docno varchar(20)=''
DECLARE @@transtype varchar(3)='{1}'
DECLARE @@bankacc varchar(50)='{2}'
DECLARE @@bankname varchar(50)='{3}'
DECLARE @@rcpno varchar(50)='{4}'
DECLARE @@docdate date='{5}'
DECLARE @@duedate date='{6}'
DECLARE @@pino varchar(20)='{7}'
DECLARE @@itemno int=0
DECLARE @@transno varchar(20)='{8}'
DECLARE @@qty float=0

-- TODO: Set parameter values here.

EXECUTE @@RC = [dbo].[Insert_PCFromPI]
@@userid
,@@docno
,@@transtype
,@@bankacc
,@@bankname
,@@rcpno
,@@docdate
,@@duedate
,@@pino
,@@itemno
,@@transno
,@@qty"
            dtAP = obj.GetDataFromSQL(String.Format(sql,
                                                    Request.Form("APUserID"),
                                                    Request.Form("TransType"),
                                                    Request.Form("TransAcc"),
                                                    Request.Form("TransOwner"),
                                                    Request.Form("ReceiptNo"),
                                                    Convert.ToDateTime(Request.Form("TransDate")).ToString("yyyy-MM-dd"),
                                                    Convert.ToDateTime(Request.Form("DueDate")).ToString("yyyy-MM-dd"),
                                                    Request.Form("BillNo"),
                                                    Request.Form("TransNo")
    ))
            If dtAP.Rows.Count > 0 Then
                msg = "Create Number " & dtAP.Rows(0)("PCNo") & " Complete"
            Else
                msg = obj.Message
            End If
        End If
    End Code
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="APUserID" id="txtAPUser3" />
    <br />
    Invoice No : <input type="text" name="BillNo" id="txtBillNo" />
    <br />
    Receipt/Acknowledgement No : <input type="text" name="ReceiptNo" id="txtReceiptNo" />
    <br />
    Trans Type : <select name="TransType" id="txtTransType">
        <option value="TRF">Transfer</option>
        <option value="CHQ">Cheque</option>
        <option value="CRD">Credit Card</option>
    </select>
    Cheque no/Slip No/Card No : <input type="text" name="TransNo" id="txtTransNo" />
    <br />
    Transfer To Account/Cheque Owner ID/Card Issuer : <input type="text" name="TransAcc" id="txtTransAcc" />
    <br />
    Account Name/Cheque Owner Name/Card Ownder : <input type="text" name="TransOwner" id="txtTransOwner" />
    <br />
    Appr.Code/Bank Reference TR# : <input type="text" name="RcpNo" id="txtTransRcpNo" />
    <br />
    Trans Date : <input type="date" name="TransDate" id="txtTransDate" />
    <br />
    Due Payment Date : <input type="date" name="DueDate" id="txtDuePaymentDate" />
    <br />
    <input type="submit" name="submitPCFromPI" value="Create Data" />
</form>
@*--Insert_PVfromPC*@
<form method="post" action="">
    <b>Post Payment for Cheque/Transfer</b>
    <br />
    @Code
        If Not Request.Form("submitPVFromPC") Is Nothing Then
            Dim sql As String = "DECLARE @@RC int
DECLARE @@transno nvarchar(50)='{0}'
DECLARE @@userid nvarchar(50)='{1}'
DECLARE @@docdate date='{2}'
DECLARE @@acccode nvarchar(20)='{3}'
DECLARE @@bankchg float={4}
DECLARE @@pvno nvarchar(20)=''
DECLARE @@accdebit nvarchar(20)='{5}'

EXECUTE @@RC = [dbo].[Insert_PVFromPC]
@@transno
,@@userid
,@@docdate
,@@acccode
,@@bankchg
,@@pvno
,@@accdebit
"
            dtAP = obj.GetDataFromSQL(String.Format(sql,
                                                    Request.Form("PCNo"),
                                                    Request.Form("APUserID"),
                                                    Convert.ToDateTime(Request.Form("PayDate")).ToString("yyyy-MM-dd"),
                                                    Request.Form("AccCredit"),
                                                    Request.Form("BankCharge"),
                                                    Request.Form("AccDebit")
            ))
            If dtAP.Rows.Count > 0 Then
                msg = "Create Number " & dtAP.Rows(0)("JournalNo") & " Complete"
            Else
                msg = obj.Message
            End If
        End If
    End Code
    Approve By* : <input type="text" value="@ViewBag.User" name="APUserID" id="txtAPUser4" />
    <br />
    Document# : <input type="text" name="PCNo" id="txtPCNo" />
    <br />
    Payment Date : <input type="date" name="PayDate" id="txtPaymentDate" />
    <br />
    Account Credit* : <input type="text" name="AccCredit" id="txtAccCredit" />
    <br />
    Bank Charge* : <input type="number" name="BankCharge" id="txtBankCharge" />
    <br />
    Account Debit* : <input type="text" name="AccDebit" id="txtAccDebit" />
    <br />
    <input type="submit" name="submitPVFromPC" value="Create Data" />
</form>
@*--Insert_PVfromPO*@
<form action="" method="post">
    <b>Create Cash Payment From Purchase Order</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="APUserID" id="txtAPUser5" />
    <br />
    PO# : <input type="text" name="PONo" id="txtPONo1" />
    <br />
    Receipt/Tax# : <input type="text" name="RcpNo" id="txtTaxRcp" />
    <br />
    Payment Date : <input type="date" name="PayDate" id="txtPaymentDate2" />
    <br />
    Trans Type : <select name="TransType" id="txtTransType2">
        <option value="TRF">Transfer</option>
        <option value="CA">Cheque</option>
        <option value="DBC">Debit Card</option>
    </select>
    <br />
    Ref# : <input type="text" name="RefNo" id="txtRefNo" />
    <br />
    Remark : <input type="text" name="Remark" id="txtRemark" />
    <br />
    Purchase Type : <select name="ExpenseType" id="txtTransType3">
        <option value="0">Goods</option>
        <option value="1">Services</option>
    </select>
    <br />
    Acc.Payment# : <input type="text" name="AccCredit" id="txtCashCredit" />
    <br />
    Acc.Asset/Expense# : <input type="text" name="AccDebit" id="txtDebit2" />
    @Code
        If Not Request.Form("submitPVFromPO") Is Nothing Then
            Dim sql As String = "DECLARE @@RC int
DECLARE @@pono nvarchar(50)='{1}'
DECLARE @@userid nvarchar(50)='{0}'
DECLARE @@taxno nvarchar(50)='{2}'
DECLARE @@docdate date='{3}'
DECLARE @@trantype varchar(20)='{4}'
DECLARE @@tranno varchar(50)='{5}'
DECLARE @@trandatail varchar(255)='{6}'
DECLARE @@pvno nvarchar(20)=''
DECLARE @@acccode nvarchar(20)='{7}'
DECLARE @@doctype nvarchar(5)='PV'
DECLARE @@isexpense int={8}
DECLARE @@accdebit nvarchar(20)='{9}'

EXECUTE @@RC = [dbo].[Insert_PVFromPO]
@@pono
,@@userid
,@@taxno
,@@docdate
,@@trantype
,@@tranno
,@@trandatail
,@@pvno
,@@acccode
,@@doctype
,@@isexpense
,@@accdebit
"
            dtAP = obj.GetDataFromSQL(String.Format(sql,
                                                  Request.Form("APUserID"),
                                                  Request.Form("PONo"),
                                                  Request.Form("RcpNo"),
                                                  Convert.ToDateTime(Request.Form("PayDate")).ToString("yyyy-MM-dd"),
                                                  Request.Form("TransType"),
                                                  Request.Form("RefNo"),
                                                  Request.Form("Remark"),
                                                  Request.Form("AccCredit"),
                                                  Request.Form("ExpenseType"),
                                                  Request.Form("AccDebit")
            ))
            If dtAP.Rows.Count > 0 Then
                msg = "Create Number " & dtAP.Rows(0)("JournalNo") & " Complete"
            Else
                msg = obj.Message
            End If
        End If
    End Code
    <br />
    <input type="submit" name="submitPVFromPO" value="Create Data" />
</form>
@*--Insert_SOFromSR*@
<form method="post" action="">
    <b>Create Sale Order from Sales Requisition</b>
    @Code
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
    End Code
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
@*--Insert_DIFromPO*@
<form action="" method="post">
    <b>Create inventory data from PO</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="DOUserID" id="txtDOUser" />
    <br />
    PO No :  <input type="text" name="PONo" id="txtPONo3" />
    <br />
    Delivery Date* : <input type="date" name="DeliveryDate" id="txtDODate" />
    <br />
    Warranty Date* : <input type="date" name="DueDate" id="txtDueDate" />
    <br />
    Reference No :  <input type="text" name="RefNo" id="txtRefNo1" />
    <br />
    Warehouse Code :  <input type="text" name="WHCode" id="txtWarehouse" />
    @Code
        If Not Request.Form("submitDIFromPO") Is Nothing Then
            Dim sql As String = "DECLARE @@RC int
DECLARE @@pono nvarchar(10)='{0}'
DECLARE @@docdate date='{1}'
DECLARE @@duedate date='{2}'
DECLARE @@refno nvarchar(50)='{3}'
DECLARE @@userid nvarchar(50)='{4}'
DECLARE @@itemno int=0
DECLARE @@qty float=0
DECLARE @@dno nvarchar(20)=''
DECLARE @@whcode nvarchar(20)='{5}'

EXECUTE @@RC = [dbo].[Insert_DIFromPO]
@@pono
,@@docdate
,@@duedate
,@@refno
,@@userid
,@@itemno
,@@qty
,@@dno
,@@whcode"
            sql = String.Format(sql,
                                Request.Form("PONo"),
                                Convert.ToDateTime(Request.Form("DeliveryDate")).ToString("yyyy-MM-dd"),
                                Convert.ToDateTime(Request.Form("DueDate")).ToString("yyyy-MM-dd"),
                                Request.Form("RefNo"),
                                Request.Form("DOUserID"),
                                Request.Form("WHCode"))
            dtPO = obj.GetDataFromSQL(sql)
            If dtPO.Rows.Count > 0 Then
                msg = "Create Number " & dtPO.Rows(0)("AccDocNo") & " Complete"
            Else
                msg = obj.Message
            End If
        End If
    End Code
    <br />
    <input type="submit" name="submitDIFromPO" value="Create Data" />
</form>
@*--Insert_DIFromPI*@
<form action="" method="post">
    <b>Create inventory data from Supplier Invoice/Delivery</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="DOUserID" id="txtDOUser" />
    <br />
    Supplier Delivery/Invoice No :  <input type="text" name="PINo" id="txtPINo1" />
    <br />
    Delivery Date* : <input type="date" name="DeliveryDate" id="txtDODate" />
    <br />
    Reference No :  <input type="text" name="RefNo" id="txtRefNo1" />
    <br />
    Warehouse Code :  <input type="text" name="WHCode" id="txtWarehouse" />
    @Code
        If Not Request.Form("submitDIFromPI") Is Nothing Then
            Dim sql As String = "DECLARE @@RC int
DECLARE @@pino nvarchar(10)='{0}'
DECLARE @@docdate date='{1}'
DECLARE @@refno nvarchar(50)='{2}'
DECLARE @@userid nvarchar(50)='{3}'
DECLARE @@costtype int=0
DECLARE @@itemno int=0
DECLARE @@qty float=0
DECLARE @@dno nvarchar(20)=''
DECLARE @@whcode nvarchar(10)='{4}'

EXECUTE @@RC = [dbo].[Insert_DIFromPI] 
   @@pino
  ,@@docdate
  ,@@refno
  ,@@userid
  ,@@costtype
  ,@@itemno
  ,@@qty
  ,@@dno
  ,@@whcode
"
            sql = String.Format(sql,
                            Request.Form("PINo"),
                            Convert.ToDateTime(Request.Form("DeliveryDate")).ToString("yyyy-MM-dd"),
                            Request.Form("RefNo"),
                            Request.Form("DOUserID"),
                            Request.Form("WHCode"))
            dtPO = obj.GetDataFromSQL(sql)
            If dtPO.Rows.Count > 0 Then
                msg = "Create Number " & dtPO.Rows(0)("AccDocNo") & " Complete"
            Else
                msg = obj.Message
            End If
        End If
    End Code
    <br />
    <input type="submit" name="submitDIFromPI" value="Create Data" />
</form>
@*--Insert_DIFromPC*@
<form action="" method="post">
    <b>Create inventory data from Payment Confirmation</b>
    <br />
    Approve By* : <input type="text" value="@ViewBag.User" name="DOUserID" id="txtDOUser3" />
    <br />
    Payment Note No :  <input type="text" name="PINo" id="txtPINo3" />
    <br />
    Delivery Date* : <input type="date" name="DeliveryDate" id="txtDODate3" />
    <br />
    Warranty Date* : <input type="date" name="DueDate" id="txtDueDate2" />
    <br />
    Reference No :  <input type="text" name="RefNo" id="txtRefNo2" />
    <br />
    Warehouse Code :  <input type="text" name="WHCode" id="txtWarehouse2" />
    @Code
        If Not Request.Form("submitDIFromPC") Is Nothing Then
            Dim sql As String = "DECLARE @@RC int
DECLARE @@pcno nvarchar(10)='{0}'
DECLARE @@docdate date='{1}'
DECLARE @@duedate date='{2}'
DECLARE @@refno nvarchar(50)='{3}'
DECLARE @@userid nvarchar(50)='{4}'
DECLARE @@itemno int=0
DECLARE @@qty float=0
DECLARE @@dno nvarchar(20)=''
DECLARE @@whcode nvarchar(20)='{5}'

EXECUTE @@RC = [dbo].[Insert_DIFromPC] 
   @@pcno
  ,@@docdate
  ,@@duedate
  ,@@refno
  ,@@userid
  ,@@itemno
  ,@@qty
  ,@@dno
  ,@@whcode
"
            sql = String.Format(sql,
                            Request.Form("PINo"),
                            Convert.ToDateTime(Request.Form("DeliveryDate")).ToString("yyyy-MM-dd"),
                            Convert.ToDateTime(Request.Form("DueDate")).ToString("yyyy-MM-dd"),
                            Request.Form("RefNo"),
                            Request.Form("DOUserID"),
                            Request.Form("WHCode")
            )
            dtPO = obj.GetDataFromSQL(sql)
            If dtPO.Rows.Count > 0 Then
                msg = "Create Number " & dtPO.Rows(0)("AccDocNo") & " Complete"
            Else
                msg = obj.Message
            End If
        End If
    End Code
    <br />
    <input type="submit" name="submitDIFromPC" value="Create Data" />
</form>

<script type="text/javascript">
    var msg = '@msg';
    window.onload = function() {
        if (msg !== '') {
            alert(msg);
        }
    }
    function AddNewDoc() {
        var typ = document.getElementById('cboDocType').value;
        window.location.href=window.location.pathname + "/Form?Form=Transaction&SRC=@dbSource&DB=@dbName&Type=" + typ;
    }
</script>