@Code
    ViewData("Title") = "Transfer Job"
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
    Dim sql = ""
    Dim dateFrom = ""
    Dim dateTo = ""
    Dim procName = ""
    If Not Request.Form("Submit") Is Nothing Then
        bPost = True
        dateFrom = Request.Form("DateFrom")
        dateTo = Request.Form("DateTo")
        msg = ""
        procName = "Insert_ProductsCodeFromJob_V2"
        sql = "
if '" & Request.Form("chkProduct") & "'='ON'
begin
EXEC dbo." & procName & "
end
"
        If Not Request.Form("chkProduct") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_AdvanceFromJob_V2"
        sql = "
if '" & Request.Form("chkTAdv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkTAdv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_BillPayFromJob_V2"
        sql = "
if '" & Request.Form("chkTPay") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}','" & ViewBag.User & "'
end
"
        If Not Request.Form("chkTPay") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearFromJob_V2"
        sql = "
if '" & Request.Form("chkTClr") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}','" & ViewBag.User & "'
end
"
        If Not Request.Form("chkTClr") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_InvoiceFromJob"
        sql = "
if '" & Request.Form("chkTInv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}','" & ViewBag.User & "'
end
"
        If Not Request.Form("chkTInv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ReceiptFromJob"
        sql = "
if '" & Request.Form("chkTRcv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}',''
end
"
        If Not Request.Form("chkTRcv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_CNDNFromJob"
        sql = "
if '" & Request.Form("chkTCN") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}',''
end
"
        If Not Request.Form("chkTCN") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_WHTaxFromJob"
        sql = "
if '" & Request.Form("chkTWHT") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkTWHT") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_AdvanceToJournal_V4"
        sql = "
if '" & Request.Form("chkPAdv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPAdv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearExpenseFromAdvance_V2"
        sql = "
if '" & Request.Form("chkPExpAdv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPExpAdv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearExpenseFromManualEntry_V3"
        sql = "
if '" & Request.Form("chkPExpClr") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPExpClr") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_BillPayToJournal_V4"
        sql = "
if '" & Request.Form("chkPInv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPInv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearExpenseFromBillPay_V2"
        sql = "
if '" & Request.Form("chkPExpBill") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPExpBill") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_PVFromBillPay_V3"
        sql = "
IF '" & Request.Form("chkPBill") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPBill") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_InvoiceToJournal_V4"
        sql = "
if '" & Request.Form("chkRInv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkRInv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ReceiptToJournal_V4"
        sql = "
if '" & Request.Form("chkRTax") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkRTax") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_RVFromJob_V3"
        sql = "
if '" & Request.Form("chkRPay") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkRPay") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_CNDNToJournal_V2"
        sql = "
if '" & Request.Form("chkRCN") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkRCN") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearMoneyFromAdvance_V2"
        sql = "
if '" & Request.Form("chkPClrAdv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPClrAdv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearMoneyFromNoAdvance"
        sql = "
if '" & Request.Form("chkPClrOth") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPClrOth") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))

        procName = "Insert_CustAdvanceToJournal"
        sql = "
if '" & Request.Form("chkCustAdv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkCustAdv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "DELETE_JOB_JOURNAL"
        sql = "
if '" & Request.Form("chkTDel") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkTDel") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
    End If
End Code
<style>
    td {
        vertical-align: top;
        padding: 5px 5px 5px 5px;
    }
</style>
<h2>Transfer Job Control Data</h2>
<form action="" method="post">
    From Date : <input type="date" name="DateFrom" id="txtDateFrom" value="@dateFrom" />
    To Date : <input type="date" name="DateTo" id="txtDateTo" value="@dateTo" />
    <table style="vertical-align:top;">
        <tr>
            <td>
                <b>Source Documents</b>
            </td>
            <td>
                <b>Account Documents</b>
            </td>
        </tr>
        <tr>
            <td>
                1.1 Master File : <br />
                <input type="checkbox" id="chkProduct" name="chkProduct" /> Products & Services/Sub Accounts <br />
                Purchase : <br />
                1.2 <input type="checkbox" id="chkTAdv" name="chkTAdv" /> Advance Request <br />
                1.3 <input type="checkbox" id="chkTPay" name="chkTPay" /> Payment Invoice <br />
                1.4 <input type="checkbox" id="chkTClr" name="chkTClr" /> Expense Clearing <br />
                Sale : <br />
                1.5 <input type="checkbox" id="chkTInv" name="chkTInv" /> Invoice <br />
                1.6 <input type="checkbox" id="chkTRcv" name="chkTRcv" /> Receipt/Tax Receipt <br />
                1.7 <input type="checkbox" id="chkTCN" name="chkTCN" /> Credit/Debit Note <br />
                Other : <br />
                1.8 <input type="checkbox" id="chkTWHT" name="chkTWHT" /> With-holding Tax <br />
                <div style="border-style:solid;background-color:lightgoldenrodyellow;color:red;margin:5px 5px 5px 5px;padding:5px 5px 5px 5px;">
                    **DANGER ZONE** <br />
                    1.9 <input type="checkbox" id="chkTDel" name="chkTDel" /> Delete All Job Control Data <br />
                </div>
            </td>
            <td>
                Payment <br />
                2.1 <input type="checkbox" id="chkPAdv" name="chkPAdv" /> Advance Payment (PV-A)<br />
                2.2 <input type="checkbox" id="chkPExpAdv" name="chkPExpAdv" /> Clear Advance Entry (AJ-A)<br />
                2.3 <input type="checkbox" id="chkPExpClr" name="chkPExpClr" /> Expense From Clearing (AJ-C) <br />
                Payables <br />
                2.4 <input type="checkbox" id="chkPInv" name="chkPInv" /> A/P Setup (PI)<br />
                2.5 <input type="checkbox" id="chkPExpBill" name="chkPExpBill" /> Expense From Bill (AJ-P)<br />
                2.6 <input type="checkbox" id="chkPBill" name="chkPBill" /> A/P Payment (PV-P)<br />
                Receivables <br />
                2.7 <input type="checkbox" id="chkRInv" name="chkRInv" /> A/R Invoice (SI)<br />
                2.8 <input type="checkbox" id="chkRTax" name="chkRTax" /> A/R Tax Receipt (RC)<br />
                2.9 <input type="checkbox" id="chkRPay" name="chkRPay" /> A/R Payment (RV-R)<br />
                2.10 <input type="checkbox" id="chkRCN" name="chkRCN" /> A/R Adjust From CN/DN (AJ-R)<br />
                Other <br />
                2.11 <input type="checkbox" id="chkPClrAdv" name="chkPClrAdv" /> Return/Payment From Advance (RV-A/PV-A)<br />
                2.12 <input type="checkbox" id="chkPClrOth" name="chkPClrOth" /> Payment To Staff From Clearing (RV-C/PV-C)<br />
                2.13 <input type="checkbox" id="chkCustAdv" name="chkCustAdv" /> Customer Advance Payment (PV-R)<br />
            </td>
        </tr>
    </table>
    <input type="submit" name="Submit" value="Process" />
    <label>@msg</label>
</form>
