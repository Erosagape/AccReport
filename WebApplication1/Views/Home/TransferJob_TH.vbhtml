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
        procName = "Insert_ProductsCodeFromJob"
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
        procName = "Insert_AdvanceToJournal_V3"
        sql = "
if '" & Request.Form("chkPAdv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPAdv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearExpenseFromAdvance"
        sql = "
if '" & Request.Form("chkPExpAdv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPExpAdv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearExpenseFromManualEntry_V2"
        sql = "
if '" & Request.Form("chkPExpClr") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPExpClr") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_BillPayToJournal_V3"
        sql = "
if '" & Request.Form("chkPInv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkPInv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearExpenseFromBillPay"
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
        procName = "Insert_InvoiceToJournal_V3"
        sql = "
if '" & Request.Form("chkRInv") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkRInv") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ReceiptToJournal_V3"
        sql = "
if '" & Request.Form("chkRTax") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkRTax") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_RVFromJob_V2"
        sql = "
if '" & Request.Form("chkRPay") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkRPay") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_CNDNToJournal"
        sql = "
if '" & Request.Form("chkRCN") & "'='ON'
begin
EXEC dbo." & procName & " '{0}','{1}'
end
"
        If Not Request.Form("chkRCN") Is Nothing Then msg &= vbCrLf & "Process " & procName & "=" & obj.ExecuteSQL(String.Format(sql, dateFrom, dateTo))
        procName = "Insert_ClearMoneyFromAdvance"
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
    End If
End Code
<style>
    td {
        vertical-align: top;
        padding: 5px 5px 5px 5px;
    }
</style>
<h2>โอนข้อมูลจากระบบ Job Control</h2>
<form action="" method="post">
    ข้อมูลจากวันที่ : <input type="date" name="DateFrom" id="txtDateFrom" value="@dateFrom" />
    ถึงวันที่ : <input type="date" name="DateTo" id="txtDateTo" value="@dateTo" />
    <table style="vertical-align:top;">
        <tr>
            <td>
                <b>เอกสารต้นทาง</b>
            </td>
            <td>
                <b>บันทึกเอกสารบัญชี</b>
            </td>
        </tr>
        <tr>
            <td>
                1.1 ข้อมูลทั่วไป : <br />
                <input type="checkbox" id="chkProduct" name="chkProduct" /> ข้อมูลค่าบริการ <br />
                ระบบซื้อ : <br />
                1.2 <input type="checkbox" id="chkTAdv" name="chkTAdv" /> ใบเบิกค่าใช้จ่าย <br />
                1.3 <input type="checkbox" id="chkTPay" name="chkTPay" /> ใบรับวางบิลค่าใช้จ่าย <br />
                1.4 <input type="checkbox" id="chkTClr" name="chkTClr" /> ใบบันทึกค่าใช้จ่าย <br />
                ระบบขาย : <br />
                1.5 <input type="checkbox" id="chkTInv" name="chkTInv" /> ใบแจ้งหนี้ <br />
                1.6 <input type="checkbox" id="chkTRcv" name="chkTRcv" /> ใบเสร็จรับเงิน <br />
                1.7 <input type="checkbox" id="chkTCN" name="chkTCN" /> ใบเพิ่มหนี้/ลดหนี้ <br />
                เอกสารอื่นๆ : <br />
                1.8 <input type="checkbox" id="chkTWHT" name="chkTWHT" /> ภาษีหัก ณ ที่จ่าย <br />
            </td>
            <td>
                บัญชีจ่าย/ซิ้อเงินสด <br />
                2.1 <input type="checkbox" id="chkPAdv" name="chkPAdv" /> บันทึกบัญชีจ่ายเงินตามใบเบิกค่าใช้จ่าย <a href="#mdl21" data-toggle="modal" data-target="#mdl21">(PV-A)</a><br />
                2.2 <input type="checkbox" id="chkPExpAdv" name="chkPExpAdv" /> บันทึกบัญชีเคลียร์ปิดค่าใช้จ่ายใบเบิก <a href="#mdl22" data-toggle="modal" data-target="#mdl22">(AJ-A)</a><br />
                2.3 <input type="checkbox" id="chkPExpClr" name="chkPExpClr" /> บันทึกบัญชีค่าใช้จ่ายจากใบเคลียร์ <a href="#mdl23" data-toggle="modal" data-target="#mdl23">(AJ-C)</a><br />
                บัญชีเจ้าหนี้/ซื้อเงินเชื่อ <br />
                2.4 <input type="checkbox" id="chkPInv" name="chkPInv" /> บันทึกบัญชีตั้งเจ้าหนี้จากใบรับวางบิล <a href="#mdl25" data-toggle="modal" data-target="#mdl25">(PI)</a><br />
                2.5 <input type="checkbox" id="chkPExpBill" name="chkPExpBill" /> บันทึกบัญชีค่าใช้จ่ายจากใบรับวางบิล <a href="#mdl26" data-toggle="modal" data-target="#mdl26">(AJ-P)</a> <br />
                2.6 <input type="checkbox" id="chkPBill" name="chkPBill" /> บันทึกบัญชีจ่ายชำระหนี้จากใบรับวางบิล <a href="#mdl27" data-toggle="modal" data-target="#mdl27">(PV-P)</a><br />
                บัญชีรับ/ขายเงินสด <br />
                2.7 <input type="checkbox" id="chkRInv" name="chkRInv" /> บันทึกบัญชีรายได้จากใบแจ้งหนี้ <a href="#mdl28" data-toggle="modal" data-target="#mdl28">(SI)</a><br />
                2.8 <input type="checkbox" id="chkRTax" name="chkRTax" /> บันทึกบัญชีใบเสร็จรับเงิน/ใบกำกับภาษี <a href="#mdl29" data-toggle="modal" data-target="#mdl29">(RC)</a> <br />
                2.9 <input type="checkbox" id="chkRPay" name="chkRPay" /> บันทึกบัญชีรับชำระหนี้จากลูกค้า <a href="#mdl210" data-toggle="modal" data-target="#mdl210">(RV-R)</a><br />
                2.10 <input type="checkbox" id="chkRCN" name="chkRCN" /> บันทึกบัญชีปรับปรุงลูกหนี้จากใบเพิ่มหนี้/ลดหนี้ <a href="#mdl211" data-toggle="modal" data-target="#mdl211">(AJ-R)</a><br />
                บัญชีอื่นๆ <br />
                2.11 <input type="checkbox" id="chkPClrAdv" name="chkPClrAdv" /> เคลียร์เงินทดรองคงค้างจากการเบิกค่าใช้จ่าย <a href="#mdl212" data-toggle="modal" data-target="#mdl212">(PV-A/RV-A)</a><br />
                2.12 <input type="checkbox" id="chkPClrOth" name="chkPClrOth" /> เคลียร์เงินทดรองคงค้างจากใบเคลียร์ <a href="#mdl213" data-toggle="modal" data-target="#mdl213">(PV-C/RV-C)</a><br />
            </td>
        </tr>
    </table>
    <input type="submit" name="Submit" value="Process" />
    <label>@msg</label>
</form>
<div class="modal" role="dialog" id="mdl213">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                เคลียร์เงินทดรองคงค้างจากใบเคลียร์
            </div>
            <div class="modal-body">
                <p>                    
                    Dr. ค่าใช้จ่ายค้างจ่าย
                    <br />&nbsp;&nbsp;Cr. เงินสด/เงินฝากธนาคาร

                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl212">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                เคลียร์เงินทดรองคงค้างจากการเบิกค่าใช้จ่าย
            </div>
            <div class="modal-body">
                <p>
                    1.รับคืน
                    <br />Dr. เงินสด/เงินฝากธนาคาร
                    <br />&nbsp;&nbsp;Cr. เงินทดรองจ่ายพนักงาน
                    <br />1.จ่ายคืน
                    <br />Dr. เงินทดรองจ่ายพนักงาน
                    <br />&nbsp;&nbsp;Cr. เงินสด/เงินฝากธนาคาร

                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl211">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีปรับปรุงลูกหนี้จากใบเพิ่มหนี้/ลดหนี้
            </div>
            <div class="modal-body">
                <p>
                    1. เพิ่มหนี้
                    <br />Dr. ลูกหนี้การค้า
                    <br />Dr. ภาษีเงินได้ถูกหัก ณ ที่จ่าย
                    <br />&nbsp;&nbsp;Cr. รายได้
                    <br />&nbsp;&nbsp;Cr. ภาษีขาย
                    <br />2. ลดหนี้
                    <br />Dr. รายได้
                    <br />Dr. ภาษีขาย
                    <br />&nbsp;&nbsp;Cr. ลูกหนี้การค้า
                    <br />&nbsp;&nbsp;Cr. ภาษีเงินได้ถูกหัก ณ ที่จ่าย
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl210">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีรับชำระหนี้จากลูกค้า
            </div>
            <div class="modal-body">
                <p>
                    Dr. เงินสด/เงินฝากธนาคาร
                    <br /> &nbsp;&nbsp;Cr. ลูกหนี้การค้า
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl29">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีใบเสร็จรับเงิน/ใบกำกับภาษี
            </div>
            <div class="modal-body">
                <p>
                    Dr. ลูกหนี้การค้า
                    <br />Dr. ภาษีเงินได้ถูกหัก ณ ที่จ่าย
                    <br />Dr. ภาษีขายไม่ถึงกำหนด
                    <br />&nbsp;&nbsp;Cr. รายได้ค้างรับ
                    <br />&nbsp;&nbsp;Cr. ภาษีขาย
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl27">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีจ่ายชำระหนี้จากใบรับวางบิล
            </div>
            <div class="modal-body">
                <p>
                    Dr. เจ้าหนี้การค้า
                    <br />Dr. ภาษีซื้อ
                    <br />&nbsp;&nbsp;Cr. เงินสด/เงินฝากธนาคาร
                    <br />&nbsp;&nbsp;Cr. หัก ณ ที่จ่าย ภงด3/53
                    <br />&nbsp;&nbsp;Cr. ภาษีซื้อไม่ถึงกำหนด
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl28">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีรายได้จากใบแจ้งหนี้
            </div>
            <div class="modal-body">
                <p>
                    Dr. รายได้ค้างรับ
                    <br />&nbsp;&nbsp;Cr. รายได้
                    <br />&nbsp;&nbsp;Cr. ภาษีขายไม่ถึงกำหนด
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl26">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีค่าใช้จ่ายจากใบรับวางบิล
            </div>
            <div class="modal-body">
                <p>
                    Dr. ซื้อทรัพย์สิน/ค่าใช้จ่าย
                    <br />Dr. ภาษีซื้อไม่ถึงกำหนด
                    <br />&nbsp;&nbsp;Cr. ค่าใช้จ่ายค้างจ่าย
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl25">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีตั้งเจ้าหนี้จากใบรับวางบิล
            </div>
            <div class="modal-body">
                <p>
                    Dr. ค่าใช้จ่ายค้างจ่าย
                    <br />&nbsp;&nbsp;Cr. เจ้าหนี้การค้า
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<div class="modal" role="dialog" id="mdl23">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีค่าใช้จ่ายจากใบเคลียร์
            </div>
            <div class="modal-body">
                <p>
                    Dr. ค่าใช้จ่าย
                    <br />Dr. งานระหว่างทำ
                    <br />Dr. ภาษีซื้อไม่ถึงกำหนด
                    <br />&nbsp;&nbsp;Cr. ค่าใช้จ่ายค้างจ่าย
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>

<div class="modal" role="dialog" id="mdl21">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีจ่ายเงินตามใบเบิกค่าใช้จ่าย
            </div>
            <div class="modal-body">
                <p>
                    Dr. เงินทดรองจ่ายพนักงาน
                    <br />&nbsp;&nbsp;Cr. เงินฝากธนาคาร/เงินสดย่อย
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>

<div class="modal" role="dialog" id="mdl22">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                บันทึกบัญชีเคลียร์ปิดค่าใช้จ่ายใบเบิก
            </div>
            <div class="modal-body">
                <p>
                    Dr. งานระหว่างทำ/ค่าใช้จ่าย
                    <br />Dr. ภาษีซื้อไม่ถึงกำหนด
                    <br />&nbsp;&nbsp;Cr. เงินทดรองจ่ายพนักงาน
                </p>
            </div>
            <div class="modal-footer">
                <input type="button" value="X" class="btn btn-danger" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
