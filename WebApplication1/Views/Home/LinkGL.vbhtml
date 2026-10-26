@Code
    ViewData("Title") = "LinkGL"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim LANG = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        LANG = Request.QueryString("LANG")
    End If
    Dim filter = ""
    If Not Request.QueryString("FILTER") Is Nothing Then
        filter = Request.QueryString("FILTER")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim msg As String = ""
    Dim sql As String = ""
    Dim checkParam As Integer = 0
    Dim datefrom = New Date(DateTime.Now.Year, 1, 1).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateFrom") Is Nothing Then
        datefrom = Request.QueryString("DateFrom")
        checkParam += 1
    End If
    Dim dateto = DateAdd("d", -1, New Date(DateTime.Now.Year + 1, 1, 1)).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateto = Request.QueryString("DateTo")
        checkParam += 1
    End If
    If filter <> "" Then
        checkParam = 0
    End If
    Dim sumDebit As Decimal = 0
    Dim sumCredit As Decimal = 0
End Code
<div class="container">
    <h4>@IIf(LANG = "TH", "ตรวจสอบข้อมูลก่อนลงบัญชี", "Check Pre-Process G/L Data")</h4>
    <div class="row">
        <div class="col-md-3">
            Date From : <br /><input type="date" id="txtDateFrom" class="form-control" value="@datefrom" />
        </div>
        <div class="col-md-3">
            To : <br /> <input type="date" id="txtDateTo" class="form-control" value="@dateto" />
        </div>
        <div class="col-md-3">
            Filter :<br />
            <select id="txtFilter" class="form-control dropdown">
                <option value="">ALL</option>
                <option value="1" @IIf(filter = "1", "selected", "")>PV-A / Advance Payment</option>
                <option value="2" @IIf(filter = "2", "selected", "")>AJ-A / Advance Clearing</option>
                <option value="3" @IIf(filter = "3", "selected", "")>AJ-C / Non-Advance Clearing</option>
                <option value="4" @IIf(filter = "4", "selected", "")>PI / Billing Vender</option>
                <option value="5" @IIf(filter = "5", "selected", "")>PV-P / Billing Payment</option>
                <option value="6" @IIf(filter = "6", "selected", "")>SI / Billing Customer</option>
                <option value="7" @IIf(filter = "7", "selected", "")>RC- / Billing Receipt</option>
                <option value="8" @IIf(filter = "8", "selected", "")>RV-R  / Receive Payment</option>
                <option value="9" @IIf(filter = "9", "selected", "")>AJ-R / CN/DN Customer</option>
                <option value="10" @IIf(filter = "10", "selected", "")>RV-A / Advance Return</option>
                <option value="11" @IIf(filter = "11", "selected", "")>PV-C / Clearing Payment</option>
                <option value="12" @IIf(filter = "12", "selected", "")>PV-R / Customer Advance</option>
            </select>
        </div>
    </div>
    <input type="button" class="btn btn-success" onclick="RefreshPage()" value="Show Pre-Process Data" />
</div>
@Code
    If checkParam = 2 Or filter = "1" Then
        Dim dt1 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_AdvanceToJournal '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "PV-A / จ่ายเงินตามใบเบิก", "PV-A / Advance Payment")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt1.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>

    End If
End Code
@Code
    If checkParam = 2 Or filter = "2" Then

        Dim dt2 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_ClearExpenseFromAdvance '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "AJ-A / ปิดค่าใช้จ่ายจากใบเบิก", "AJ-A / Advance Clearing")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt2.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If

End Code
@Code
    If checkParam = 2 Or filter = "3" Then
        Dim dt3 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_ClearExpenseFromManualEntry '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "AJ-C / ปิดค่าใช้จ่ายจากใบเคลียร์", "AJ-C / Clearing From No-Advance")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt3.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If

End Code
@Code
    If checkParam = 2 Or filter = "4" Then
        Dim dt4 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_BillPayToJournal '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "PI / ตั้งเจ้าหนี้", "PI / Payable Invoice")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt4.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If
End Code
@Code
    If checkParam = 2 Or filter = "5" Then
        Dim dt5 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_PVFromBillPay '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "PV-P / จ่ายชำระเจ้าหนี้", "PV-P / Payment Invoice")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt5.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If
End Code
@Code
    If checkParam = 2 Or filter = "6" Then
        Dim dt6 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_InvoiceToJournal '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "SI / ตั้งลูกหนี้", "SI / Receivable Invoice")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt6.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If
End Code
@Code
    If checkParam = 2 Or filter = "7" Then
        Dim dt7 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_ReceiptToJournal '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "RC / ใบเสร็จ-ใบกำกับภาษี", "RC / Receipt-Tax Invoice")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt7.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>

    End If
End Code
@Code
    If checkParam = 2 Or filter = "8" Then
        Dim dt8 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_RVFromJob '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "RV-R / รับชำระหนี้", "RV-R / Receive Voucher")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt8.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If

End Code
@Code
    If checkParam = 2 Or filter = "9" Then
        Dim dt9 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_CNDNToJournal '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "AJ-R / ใบเพิ่ม-ลดหนี้", "AJ-R / Credit-Debit Note")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt9.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If

End Code
@Code
    If checkParam = 2 Or filter = "10" Then
        Dim dt10 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_ClearMoneyFromAdvance '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "RV-A / เคลียร์เงินจากใบเบิก", "RV-A / Advance Refund")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt10.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If
End Code
@Code
    If checkParam = 2 Or filter = "11" Then
        Dim dt11 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_ClearMoneyFromNoAdvance '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "PV-C / จ่ายเงินจากใบเคลียร์", "PV-C / Clearing Payment")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt11.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If
End Code
@Code
    If checkParam = 2 Or filter = "12" Then
        Dim dt12 = obj.GetDataFromSQL(String.Format("EXEC dbo.Process_CustAdvanceToJournal '{0}','{1}'", datefrom, dateto))
        msg = IIf(LANG = "TH", "RV-C / รับล่วงหน้าจากลูกค้า", "RV-C / Customer Advance")
        sumDebit = 0
        sumCredit = 0
        @<div class="container">
            <b>@msg</b>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Acc.Code</th>
                        <th>Acc.Name</th>
                        <th>Debit</th>
                        <th>Credit</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt12.Rows
                        sumDebit += dr("Debit")
                        sumCredit += dr("Credit")
                        @<tr>
                            <td>@dr("AccCode")</td>
                            <td>@dr("AccName")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                            <td style="text-align:right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="2">TOTAL</td>
                        <td style="text-align:right;">
                            @sumDebit.ToString("N2")
                        </td>
                        <td style="text-align:right;">
                            @sumCredit.ToString("N2")
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
    End If
End Code
<script type="text/javascript">
    function RefreshPage() {
        var df = document.getElementById('txtDateFrom').value;
        var dt = document.getElementById('txtDateTo').value;
        var filter = document.getElementById('txtFilter').value;
        window.location.href = "?Form=LinkGL&SRC=@dbSource&DB=@dbName&DateFrom=" + df + "&DateTo=" + dt + "&Filter="+filter;
    }
</script>