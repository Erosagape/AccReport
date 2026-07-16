@Code
    Layout = "~/Views/Shared/A4.vbhtml"
    ViewData("Title") = "FormRV"
    Dim docno As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        docno = Request.QueryString("Code")
    End If
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim rptSum As Boolean = False
    If Not Request.QueryString("Type") Is Nothing Then
        If Request.QueryString("Type") = "Sum" Then
            rptSum = True
        End If
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql = "
select * from vJournal_All where JournalNo='{0}' order by AccCode
"

    Dim dt = obj.GetDataFromSQL(String.Format(sql, docno))
    Dim voucherNo As String = ""
    Dim effectiveDate As String = ""
    Dim description As String = ""
    Dim entryBy As String = ""
    Dim totalDebit As Double = 0
    Dim totalCredit As Double = 0
    Dim totalRows As Integer = 10
    If dt.Rows.Count > 0 Then
        voucherNo = dt.Rows(0)("JournalNo").ToString()
        effectiveDate = Convert.ToDateTime(dt.Rows(0)("EffectiveDate")).ToString("dd/MM/yyyy")
        description = dt.Rows(0)("Description").ToString()
        entryBy = dt.Rows(0)("EntryBy").ToString()
        totalDebit = Convert.ToDouble(dt.Rows(0)("TotalDebit"))
        totalCredit = Convert.ToDouble(dt.Rows(0)("TotalCredit"))
    End If
End Code
<style>
    #topMenu {
        display: none;
    }
</style>
@If voucherNo <> "" Then
    @<h2>Receive Voucher / ใบสำคัญรับ</h2>
    @<div style="display:flex;flex-direction:row;">
        <div style="text-align: left;flex: 60%;">
            <table style="width:100%">
                <tr>
                    <td><b>Description<br />คำอธิบาย : </b></td>
                </tr>
                <tr>
                    <td>@Html.Raw(description)</td>
                </tr>
            </table>
        </div>
        <div style="text-align:right;flex:40%;">
            <table style="width:100%">
                <tr>
                    <td><b>Voucher No<br />เลขที่เอกสาร :</b></td>
                    <td><a href="?Form=Journal&SRC=@dbSource&DB=@dbName&Code=@voucherNo">@voucherNo</a></td>
                </tr>
                <tr>
                    <td><b>Effective Date<br />วันที่ลงบัญชี :</b></td>
                    <td>@effectiveDate</td>
                </tr>
            </table>
        </div>
    </div>
    sql = "select a.* from vTransaction_All a where exists(select 1 from vJournal_All where JournalNo='{0}' and Description=a.AccDocNo)"
    Dim dt1 = obj.GetDataFromSQL(String.Format(sql, voucherNo))
    If dt1.Rows.Count > 0 Then
        @<table style="width:100%;vertical-align:top;">
            <tr>
                <td><b>Pay From / ผู้จ่ายเงิน :</b>@dt1.Rows(0)("PartyName")</td>
            </tr>
            <tr>
                <td><b>Address / ที่อยู่ :</b>@dt1.Rows(0)("PartyAddress")</td>
            </tr>
            <tr>
                <td><b>Tax ID / เลขประจำตัวผู้เสียภาษี :</b>@dt1.Rows(0)("PartyTaxCode")</td>
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
                @If rptSum = False Then
                    @<th>Detail</th>
                End If
                <th>Debit</th>
                <th>Credit</th>
            </tr>
        </thead>
        <tbody>
            @If dt.Rows.Count > 0 Then
                Dim accname As String = ""
                Dim sumDr As Double = 0
                Dim sumCr As Double = 0
                For Each dr As Data.DataRow In dt.Rows
                    If accname <> dr("AccName") Then
                        If sumDr > 0 Or sumCr > 0 Then
                            @<tr style=@IIf(rptSum = False, "font-weight:bold;background-color:lightblue;color:darkblue", "")>
                                <td>SUM</td>
                                <td colspan=@IIf(rptSum = False, "2", "1")>@accname</td>
                                <td class="colnum">
                                    @sumDr.ToString("#,###,##0.00")
                                </td>
                                <td class="colnum">
                                    @sumCr.ToString("#,###,##0.00")
                                </td>
                            </tr>
                            sumDr = 0
                            sumCr = 0
                        End If
                        accname = dr("AccName")
                        If rptSum = False Then
                            @<tr style="font-weight:bold;color:darkred;background-color:lightyellow;">
                                <td colspan="5">@accname</td>
                            </tr>
                        End If
                    End If
                    sumDr += Convert.ToDouble(dr("Debit"))
                    sumCr += Convert.ToDouble(dr("Credit"))
                    If rptSum = False Then
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
                            <td class="colnum">
                                @Convert.ToDouble(dr("Debit")).ToString("#,###,##0.00")
                            </td>
                            <td class="colnum">
                                @Convert.ToDouble(dr("Credit")).ToString("#,###,##0.00")
                            </td>
                        </tr>
                    End If
                Next
                @<tr style=@IIf(rptSum = False, "font-weight:bold;background-color:lightblue;color:darkblue", "")>
                    <td>SUM</td>
                    <td colspan=@IIf(rptSum = False, "2", "1")>@accname</td>
                    <td class="colnum">
                        @sumDr.ToString("#,###,##0.00")
                    </td>
                    <td class="colnum">
                        @sumCr.ToString("#,###,##0.00")
                    </td>
                </tr>
            End If
            @For i As Integer = 1 To totalRows - dt.Rows.Count
                If rptSum = False Then
                    @<tr>
                        <td><br /></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                Else
                    @<tr>
                        <td><br /></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>

                End If
            Next
        </tbody>
        <tfoot>
            <tr style="background-color:lightyellow;font-weight:bold;">
                <td colspan=@IIf(rptSum = False, "3", "2")> TOTAL</td>
                <td Class="colnum">@totalDebit.ToString("#,###,##0.00")</td>
                <td Class="colnum">@totalCredit.ToString("#,###,##0.00")</td>
            </tr>
        </tfoot>
    </table>
    @If dt1.Rows.Count > 0 And rptSum Then
        @<table border="1" style="border-width:thin;border-collapse:collapse;width:100%;">
            <tr>
                <th>Description</th>
                <th>Qty</th>
                <th>Price</th>
                <th>Currency</th>
                <th>Amount</th>
            </tr>
            @For Each dr As Data.DataRow In dt1.Rows
                @<tr>
                    <td>@dr("SalesDescription").ToString</td>
                    <td>@dr("Qty").ToString @dr("UnitMea").ToString</td>
                    <td class="colnum">@Convert.ToDouble(dr("Price")).ToString("#,###,#0.00")</td>
                    <td>@dr("Currency").ToString = @dr("ExchangeRate")</td>
                    <td class="colnum">@Convert.ToDouble(dr("Amount")).ToString("#,###,#0.00")</td>
                </tr>
            Next
            <tr>
                <td colspan="2" rowspan="4"></td>
                <td colspan="2" style="background-color:lightyellow;">Total Amount</td>
                <td class="colnum">@Convert.ToDouble(dt1.Rows(0)("TotalAmount")).ToString("#,###,#0.00")</td>
            </tr>
            <tr>
                <td colspan="2" style="background-color:lightyellow;">Vat</td>
                <td class="colnum">@Convert.ToDouble(dt1.Rows(0)("TotalVat")).ToString("#,###,#0.00")</td>
            </tr>
            <tr>
                <td colspan="2" style="background-color:lightyellow;">With-holding Tax</td>
                <td class="colnum">@Convert.ToDouble(dt1.Rows(0)("TotalWht")).ToString("#,###,#0.00")</td>
            </tr>
            <tr>
                <td colspan="2" style="background-color:lightyellow;">Total Net</td>
                <td class="colnum">@Convert.ToDouble(dt1.Rows(0)("TotalNet")).ToString("#,###,#0.00")</td>
            </tr>
        </table>
    End If
    @<table border="1" style="border-width:thin;width:100%;border-collapse:collapse;text-align:center;">
        <tr>
            <th> ผู้รับเงิน / Receive By</th>
            <th> ผู้บันทึกบัญชี / Entry By</th>
            <th> ผู้อนุมัติ / Approve By</th>
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
End If