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
EXEC dbo.Insert_AdvanceFromJob_V2 '{0}','{1}'
EXEC dbo.Insert_AdvanceToJournal_V2 '{0}','{1}'
end

if '{2}'='CLR'
begin
EXEC dbo.Insert_ClearFromJob '{0}','{1}','STAFF_ACC'
EXEC dbo.Insert_PostClearToJournal  '{0}','{1}','STAFF_ACC'
end

if '{2}'='PAY'
begin
EXEC dbo.Insert_BillPayFromJob_V2 '{0}','{1}','STAFF_ACC'
EXEC dbo.Insert_BillPayToJournal_V2 '{0}','{1}'
--EXEC dbo.Insert_PVFromBillPay_V2 '{0}','{1}'
end

if '{2}'='INV'
begin
EXEC dbo.Insert_InvoiceFromJob '{0}','{1}','STAFF_ACC'
EXEC dbo.Insert_PostInvoiceToJournal '{0}','{1}','STAFF_ACC'
--EXEC dbo.Insert_CostToJournal_V2 '{0}','{1}','STAFF_ACC'
end

if '{2}'='RCP'
begin
EXEC dbo.Insert_ReceiptFromJob '{0}','{1}',''
EXEC dbo.Insert_PostReceiptToJournal '{0}','{1}',''
end

if '{2}'='WHT'
begin
EXEC dbo.Insert_WHTaxFromJob '{0}','{1}'
end
"
    Dim dateFrom As Date = DateTime.MinValue
    Dim dateTo As Date = DateTime.MinValue
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
        <option value="ADV">Advance Expenses</option>
        <option value="CLR">Clearing Expenses</option>
        <option value="PAY">Billed Payment</option>
        <option value="INV">Customer Billing and Costing</option>
        <option value="RCP">Customer Payment</option>
        <option value="WHT">Withholding-Tax</option>
    </select>
    <input type="submit" name="Submit" value="Process" />
    <label>@msg</label>
</form>