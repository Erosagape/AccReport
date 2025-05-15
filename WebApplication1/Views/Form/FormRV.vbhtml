@Code
    ViewData("Title") = "FormRV"
    Dim docno As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        docno = Request.QueryString("Code")
    End If
    Dim dbName = "AccConcept"
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim sql = "
select * from vJournal_All where JournalNo='{0}' order by ItemNo
"

    Dim cnnStr = "Data Source=203.154.140.51;Initial Catalog=AccTest2;User id=sa;Password='9t;yogm851';Persist Security Info=False"
    Dim obj = New AccReport.CUtil(cnnStr)
    Dim dt = obj.GetDataFromSQL(String.Format(sql, docno))
    Dim voucherNo As String = ""
    Dim effectiveDate As String = ""
    Dim description As String = ""
    Dim entryBy As String = ""
    Dim totalDebit As Double = 0
    Dim totalCredit As Double = 0
    Dim totalRows As Integer = 20
    If dt.Rows.Count > 0 Then
        voucherNo = dt.Rows(0)("JournalNo").ToString()
        effectiveDate = Convert.ToDateTime(dt.Rows(0)("EffectiveDate")).ToString("dd/MM/yyyy")
        description = dt.Rows(0)("Description").ToString()
        entryBy = dt.Rows(0)("EntryBy").ToString()
        totalDebit = Convert.ToDouble(dt.Rows(0)("TotalDebit"))
        totalCredit = Convert.ToDouble(dt.Rows(0)("TotalCredit"))
    End If
End Code
<h2>Receive Voucher / ใบสำคัญรับ</h2>
<div style="display:flex;flex-direction:row;">
    <div style="text-align: left;flex: 60%;">
        <table style="width:100%">
            <tr>
                <td>Description / คำอธิบาย : </td>
            </tr>
            <tr>
                <td>@description</td>
            </tr>
        </table>
    </div>
    <div style="text-align:right;flex:40%;">
        <table style="width:100%">
            <tr>
                <td>Voucher No / เลขที่เอกสาร :</td>
                <td>@voucherNo</td>
            </tr>
            <tr>
                <td>Effective Date / วันที่ลงบัญชี :</td>
                <td>@effectiveDate</td>
            </tr>
        </table>
    </div>
</div>
@If voucherNo <> "" Then
    sql = "select a.* from vTransaction_All a where exists(select 1 from vJournal_All where JournalNo='{0}' and AccDesc=a.AccDocNo)"
    Dim dt1 = obj.GetDataFromSQL(String.Format(sql, voucherNo))
    If dt1.Rows.Count > 0 Then
        @<table style="width:100%;vertical-align:top;">
            <tr>
                <td>Pay From / ผู้จ่ายเงิน :</td>
                <td>@dt1.Rows(0)("PartyName")</td>
            </tr>
            <tr>
                <td>Address / ที่อยู่ :</td>
                <td>@dt1.Rows(0)("PartyAddress")</td>
            </tr>
            <tr>
                <td>Tax ID / เลขประจำตัวผู้เสียภาษี :</td>
                <td>@dt1.Rows(0)("PartyTaxCode")</td>
            </tr>
        </table>
    Else
        @obj.Message
    End If
    @<table border="1" style="border-width:thin;border-collapse:collapse;width:100%;">
        <thead>
            <tr>
                <th>Account Code</th>
                <th>Account Name</th>
                <th>Detail</th>
                <th>Debit</th>
                <th>Credit</th>
            </tr>
        </thead>
        <tbody>
            @If dt.Rows.Count > 0 Then
                For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        <td>
                            @dr("AccCode").ToString()
                        </td>
                        <td>
                            @dr("AccRemark").ToString()
                        </td>
                        <td>
                            @dr("AccDesc").ToString()
                        </td>
                        <td class="text-right">
                            @Convert.ToDouble(dr("Debit")).ToString("#,###,##0.00")
                        </td>
                        <td class="text-right">
                            @Convert.ToDouble(dr("Credit")).ToString("#,###,##0.00")
                        </td>
                    </tr>Next
            End If
            @For i As Integer = 1 To totalRows - dt.Rows.Count
                @<tr>
                    <td><br /></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            Next
        </tbody>
        <tfoot>
            <tr>
                <td colspan="3"> TOTAL</td>
                <td Class="text-right">@totalDebit.ToString("#,###,##0.00")</td>
                <td Class="text-right">@totalCredit.ToString("#,###,##0.00")</td>
            </tr>
        </tfoot>
    </table>
    @<table border="1" style="border-width:thin;border-collapse:collapse;width:100%;">
    <tr>
        <td>Description</td>
        <td>Qty</td>
        <td>Price</td>
        <td>Currency</td>
        <td>Amount</td>
    </tr>
    @If dt1.Rows.Count > 0 Then
        For Each dr As Data.DataRow In dt1.Rows
            @<tr>
                <td>@dr("SalesDescription").ToString</td>
                <td>@dr("Qty").ToString @dr("UnitMea").ToString</td>
                <td class="text-right">@Convert.ToDouble(dr("Price")).ToString("#,###,#0.00")</td>
                <td>@dr("Currency").ToString = @dr("ExchangeRate")</td>
                <td class="text-right">@Convert.ToDouble(dr("Amount")).ToString("#,###,#0.00")</td>
            </tr>
        Next
        @<tr>
            <td colspan="2" rowspan="4"></td>
            <td colspan="2">Total Amount</td>
            <td class="text-right">@Convert.ToDouble(dt1.Rows(0)("TotalAmount")).ToString("#,###,#0.00")</td>
        </tr>
        @<tr>
            <td colspan="2">Vat</td>
            <td class="text-right">@Convert.ToDouble(dt1.Rows(0)("TotalVat")).ToString("#,###,#0.00")</td>
        </tr>
        @<tr>
            <td colspan="2">With-holding Tax</td>
            <td class="text-right">@Convert.ToDouble(dt1.Rows(0)("TotalWht")).ToString("#,###,#0.00")</td>
        </tr>
        @<tr>
            <td colspan="2">Total Net</td>
            <td class="text-right">@Convert.ToDouble(dt1.Rows(0)("TotalNet")).ToString("#,###,#0.00")</td>
        </tr>
    End If
</table>
    @<table border="1" style="border-width:thin;width:100%;border-collapse:collapse;text-align:center;">
        <tr>
            <td> ผู้รับเงิน / Receive By</td>
            <td> ผู้บันทึกบัญชี / Entry By</td>
            <td> ผู้อนุมัติ / Approve By</td>
        </tr>
        <tr>
            <td> <br /><br /><br /></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>@entryBy</td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td> พนักงานบัญชี / Accountant</td>
            <td> ผู้จัดการฝ่ายบัญชี / Account Manager</td>
        </tr>
    </table>
end if