@Code
    ViewData("Title") = "TransferJob_V3"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim bPost As Boolean = False
    Dim msg = "Ready"
    Dim sql = "
EXEC dbo.Insert_ProductsCodeFromJob

if '{2}'='ADV'
begin
--EXEC dbo.Insert_AdvanceFromJob_V2 '{0}','{1}'
--EXEC dbo.Insert_AdvanceToJournal_V2 '{0}','{1}'
EXEC dbo.Insert_AdvanceToJournal_V3 '{0}','{1}'
end

if '{2}'='CLR'
begin
--EXEC dbo.Insert_ClearFromJob '{0}','{1}','STAFF_ACC'
--EXEC dbo.Insert_PostClearToJournal  '{0}','{1}','STAFF_ACC'
EXEC dbo.Insert_ClearMoneyFromAdvance '{0}','{1}'
EXEC dbo.Insert_ClearMoneyFromNoAdvance '{0}','{1}'
end

if '{2}'='CAV'
begin
EXEC dbo.Insert_CostFromAdvance '{0}','{1}'
end

if '{2}'='PAY'
begin
--EXEC dbo.Insert_BillPayFromJob_V2 '{0}','{1}','STAFF_ACC'
--EXEC dbo.Insert_BillPayToJournal_V2 '{0}','{1}'
--EXEC dbo.Insert_PVFromBillPay_V2 '{0}','{1}'
EXEC dbo.Insert_BillPayToJournal_V3 '{0}','{1}'
EXEC dbo.Insert_PVFromBillPay_V3 '{0}','{1}'
end

if '{2}'='INV'
begin
--EXEC dbo.Insert_InvoiceFromJob '{0}','{1}','STAFF_ACC'
--EXEC dbo.Insert_PostInvoiceToJournal '{0}','{1}','STAFF_ACC'
EXEC dbo.Insert_InvoiceFromJob_V2 '{0}','{1}'
end

if '{2}'='CST'
begin
--EXEC dbo.Insert_CostToJournal_V2 '{0}','{1}','STAFF_ACC'
EXEC dbo.Insert_ClearExpenseFromAdvance '{0}','{1}'
EXEC dbo.Insert_ClearExpenseFromBillPay '{0}','{1}'
EXEC dbo.Insert_ClearExpenseFromManualEntry '{0}','{1}'
end

if '{2}'='RCP'
begin
--EXEC dbo.Insert_ReceiptFromJob '{0}','{1}',''
--EXEC dbo.Insert_PostReceiptToJournal '{0}','{1}',''
EXEC dbo.Insert_ReceiptFromJob_V2 '{0}','{1}'
EXEC dbo.Insert_RVFromJob_V2 '{0}','{1}'
end

if '{2}'='CN'
begin
--EXEC dbo.Insert_CNDNFromJob '{0}','{1}',''
--EXEC dbo.Insert_PostCNDNToJournal '{0}','{1}'
EXEC dbo.Insert_CNDNFromJob_V2 '{0}','{1}'
end

if '{2}'='WHT'
begin
EXEC dbo.Insert_WHTaxFromJob '{0}','{1}'
end
"
    Dim dateFrom
    Dim dateTo
    If Not Request.Form("Submit") Is Nothing Then
        Dim postType As String = Request.Form("PostType")
        bPost = True
        dateFrom = Request.Form("DateFrom")
        dateTo = Request.Form("DateTo")
        msg = "Process " & postType & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo, postType))
    End If
End Code
<h2>Transfer Job</h2>
<form method="post" action="">
    From Date : <input type="date" name="DateFrom" id="txtDateFrom" value="@dateFrom" />
    <br />
    To Date : <input type="date" name="DateTo" id="txtDateTo" value="@dateTo" />
    <br />
    <select name="PostType" id="cboPostType">
        <option value="ADV">Advance Payment</option>
        <option value="CLR">Clearing Money From Advance</option>
        <option value="CST">Clearing Expenses From Advance</option>
        <option value="CAV">Cost From Clearing</option>
        <option value="PAY">Account Payables</option>
        <option value="INV">Account Receivables (Setup)</option>
        <option value="RCP">Account Receivables (Payment)</option>
        <option value="CN">Credit & Debit Note</option>
        <option value="WHT">Withholding-Tax</option>
    </select>
    <input type="submit" name="Submit" value="Process" />
    <label>@msg</label>
</form>