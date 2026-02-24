@Code    
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report Sale"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If

    Dim sqlW As String = ""
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
        sqlW &= String.Format(" AND AccBatchDate>='{0}'", dateFrom)
    End If
    Dim dateTo = DateAdd("d",-1,DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        sqlW &= String.Format(" AND AccBatchDate<='{0}'", dateTo)
    End If
    Dim status = ""
    If Not Request.QueryString("STATUS") Is Nothing Then
        status = Request.QueryString("STATUS")
        status = "'" & status.Replace(",", "','") & "'"
        sqlW &= String.Format(" AND StatusName IN({0})", status)
    End If
    Dim partyName As String = ""
    If Not Request.QueryString("PartyName") Is Nothing Then
        partyName = Request.QueryString("PartyName")
        sqlW &= String.Format(" AND PartyName like '%{0}%'", partyName)
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim dh = obj.GetDataFromSQL(String.Format("SELECT * FROM vSO_H WHERE TotalNet>0 {0} ORDER BY PartyName,AccBatchDate,AccDocNo", sqlW))
    Dim tb As New Data.DataTable
End Code
<style>
    #reportArea {
        font-size:10px;
    }

    td {
        padding-left:2px;
    }
</style>
<div id="reportArea">
    <h4>Sale Daily Report</h4>
    <h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    @Code
        If status <> "" Then
            @<h4>Status :@status</h4>
        End If
        If partyName <> "" Then
            @<h4>Filter By Name :*@partyName*</h4>
        End If
        @<table>
            <thead>
                <tr>
                    <th>PO#</th>
                    <th>Date#</th>
                    <th>Status</th>
                    <th>Ref#</th>
                    <th>Issue By</th>
                    <th rowspan="2">Amount</th>
                    <th rowspan="2">Vat</th>
                    <th rowspan="2">Wht</th>
                    <th rowspan="2">Net</th>
                </tr>
            </thead>
            <tbody>
                @For each rh As Data.DataRow In dh.Rows
                    If partyName <> rh("PartyName").ToString() Then
                        @<tr style="font-weight:bold;font-style:italic;text-decoration:underline;background-color:lightgray;">
                            <td>@rh("PartyCode")</td>
                            <td>@rh("PartyTaxCode")</td>
                            <td colspan="7">@rh("PartyName")</td>
                        </tr>
                        partyName = rh("PartyName").ToString()
                    End If
                    @<tr style="font-weight:bold;">
                        <td>@rh("AccDocNo")</td>
                        <td>@Convert.ToDateTime(rh("AccBatchDate")).ToString("dd/MM/yyyy")</td>
                        <td>
                            @rh("StatusName")
                        </td>
                        <td>@rh("DocRefNo")</td>
                        <td>@rh("IssueBy")</td>
                        <td class="text-right">@Convert.ToDouble(rh("TotalAmount")).ToString("#,##0.00")</td>
                        <td class="text-right">@Convert.ToDouble(rh("TotalVat")).ToString("#,##0.00")</td>
                        <td class="text-right">@Convert.ToDouble(rh("TotalWht")).ToString("#,##0.00")</td>
                        <td class="text-right">@Convert.ToDouble(rh("TotalNet")).ToString("#,##0.00")</td>
                    </tr>

                    tb = obj.GetDataFromSQL(String.Format("select * from vSO_D where AccDocNo='{0}'", rh("AccDocNo").ToString()))
                    If tb.Rows.Count > 0 Then
                        @<tr style="text-decoration:underline;">
                            <td>#No</td>
                            <td>P/R Ref</td>
                            <td>Description</td>
                            <td>Qty/Unit</td>
                            <td>Price</td>
                            <td>Currency/Rate</td>
                            <td>Amount</td>
                            <td colspan="2">Account Code</td>
                        </tr>
                        For Each rd As Data.DataRow In tb.Rows
                            @<tr style="font-style:italic;">
                                <td>@rd("AccItemNo")</td>
                                <td>@rd("AccSourceDocNo")#@rd("AccSourceDocItem")</td>
                                <td>
                                    @rd("SalesDescription")
                                </td>
                                <td class="text-right">
                                    @rd("Qty") @rd("UnitMea")
                                </td>
                                <td class="text-right">@rd("Price")</td>
                                <td>
                                    @rd("Currency")=@rd("ExchangeRate")
                                </td>
                                <td class="text-right">
                                    @rd("Amount")
                                </td>
                                <td colspan="2">
                                    @rd("IncomeAccCode") / @rd("IncomeAccName")
                                </td>
                            </tr>
                        Next
                    End If
                    tb = obj.GetDataFromSQL(String.Format("SELECT * FROM vDO_D where AccSourceDocNo='{0}'", rh("AccDocNo")))
                    If tb.Rows.Count > 0 Then
                        @<tr><td colspan="9"> --Delivery Information--</td></tr>
                        For Each dr As Data.DataRow In tb.Rows
                            @<tr>
                                <td>Item #@dr("AccSourceDocItem")</td>
                                <td>Date Delivery #@Convert.ToDateTime(dr("AccBatchDate")).ToString("dd/MM/yyyy")</td>
                                <td>Delivery #@dr("AccDocNo")</td>
                                <td>Qty=@dr("Qty")</td>
                                <td>Input By=@dr("IssueBy")</td>
                                <td colspan="4"></td>
                            </tr>
                        Next
                    End If
                    Dim tsql = "
select d1.JournalNo,d1.EffectiveDate as JournalDate,d2.AccDocNo,d2.AccSourceDocNo,
d1.EntryBy,d1.Description,
sum(d2.TotalAmount+d2.VatAmount-d2.WhtAmount) as TotalPayment
from vJournal_All d1
inner join vAR_D d2
on d1.AccDesc=d2.AccDocNo
where d2.DocStatus<>99 and d2.AccSourceDocNo='{0}'
group by d1.JournalNo,d1.EffectiveDate,d2.AccDocNo,d2.AccSourceDocNo,d1.EntryBy,d1.Description
"
                    tb = obj.GetDataFromSQL(String.Format(tsql, rh("AccDocNo")))
                    If tb.Rows.Count > 0 Then
                        @<tr><td colspan="9"> --Payment Information--</td></tr>
                        For Each dr As Data.DataRow In tb.Rows
                            @<tr>
                                <td>RV #@dr("JournalNo")</td>
                                <td>Date #@Convert.ToDateTime(dr("JournalDate")).ToString("dd/MM/yyyy")</td>
                                <td>Invoice #@dr("AccDocNo")</td>
                                <td>Total=@dr("TotalPayment")</td>
                                <td>Input By=@dr("EntryBy")</td>
                                <td colspan="4">
                                    @dr("Description")
                                </td>
                            </tr>
                        Next
                    End If
                Next
            </tbody>
        </table>
    End Code
</div>
