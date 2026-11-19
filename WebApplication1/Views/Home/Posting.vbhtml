@Code
    ViewData("Title") = "Posting Data Checker"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim bConn = obj.IsConnect()
    Dim dt As Data.DataTable
    Dim sql As String = ""
    Dim groupField As String = ""
End Code
<h2>ตรวจสอบเอกสารรอการดำเนินการ / Posting Data Checker</h2>
<div class="page">
    <h4><u>ระบบซื้อ / Purchase</u></h4>
    <div class="container-fluid">
        <b>ใบขอซื้อที่ยังไม่ได้อนุมัติ / PR Not Approved</b>
        @code
            sql = "select a.* from vTransaction_All a where a.AccItemNo is not null AND a.AccDocType='PR' and not exists(select 1 from vPO_D WHERE AccSourceDocNo = a.AccDocNo) and a.DocStatus<>99 ORDER BY a.PartyName"
            dt = obj.GetDataFromSQL(sql)
            groupField = ""
        End Code
        @If dt.Rows.Count > 0 Then
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DocNo</th>
                        <th>DocDate</th>
                        <th>DueDate</th>
                        <th>ItemNo</th>
                        <th>Product/Service</th>
                        <th>Qty/Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each row As Data.DataRow In dt.Rows
                        If groupField <> row("PartyName") Then
                            groupField = row("PartyName")
                            @<tr>
                                <td style="background-color:white;font-weight:bold" colspan="7">@row("PartyName")</td>
                            </tr>
                        End If
                        @<tr>
                            <td>@row("AccDocNo")</td>
                            <td>@Convert.ToDateTime(row("AccBatchDate")).ToString("yyyy-MM-dd")</td>
                            <td>@Convert.ToDateTime(row("AccEffectiveDate")).ToString("yyyy-MM-dd")</td>
                            <td>@row("AccItemNo")</td>
                            <td>@row("SaleProductCode") - @row("ProductName").ToString() / @row("SalesDescription")</td>
                            <td>@row("Qty") @row("UnitMea") x @Convert.ToDecimal(row("Price")).ToString("N2") @row("Currency")/@row("ExchangeRate") </td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<p>Data Not Found</p>
        End If
    </div>
    <div class="container-fluid">
        <b>ใบสั่งซื้อที่ยังไม่ได้จัดส่งของ / PO Not Delivered</b>
        @code
            sql = "select a.* from vTransaction_All a where a.AccItemNo is not null AND a.AccDocType='PO' and a.IsService=0 and not exists(select 1 from vDI_D WHERE AccSourceDocNo = a.AccDocNo and AccSourceDocItem=a.AccItemNo) and a.DocStatus<>99 ORDER BY a.PartyName"
            dt = obj.GetDataFromSQL(sql)
            groupField = ""
        End Code
        @If dt.Rows.Count > 0 Then
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DocNo</th>
                        <th>DocDate</th>
                        <th>DueDate</th>
                        <th>ItemNo</th>
                        <th>Product/Service</th>
                        <th>Qty/Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each row As Data.DataRow In dt.Rows
                        If groupField <> row("PartyName") Then
                            groupField = row("PartyName")
                            @<tr>
                                <td style="background-color:white;font-weight:bold" colspan="7">@row("PartyName")</td>
                            </tr>
                        End If
                        @<tr>
                            <td>@row("AccDocNo")</td>
                            <td>@Convert.ToDateTime(row("AccBatchDate")).ToString("yyyy-MM-dd")</td>
                            <td>@Convert.ToDateTime(row("AccEffectiveDate")).ToString("yyyy-MM-dd")</td>
                            <td>@row("AccItemNo")</td>
                            <td>@row("SaleProductCode") - @row("ProductName").ToString() / @row("SalesDescription")</td>
                            <td>@row("Qty") @row("UnitMea") x @Convert.ToDecimal(row("Price")).ToString("N2") @row("Currency")/@row("ExchangeRate") </td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<p>Data Not Found</p>
        End If
    </div>
    <div class="container-fluid">
        <b>ใบสั่งซื้อที่ยังไม่ได้ชำระเงิน / PO Not Paymented</b>
        @code
            sql = "select a.* from vTransaction_All a where a.AccItemNo is not null AND a.AccDocType='PO' and not exists(select 1 from vPC_D WHERE AccSourceDocNo = a.AccDocNo and AccSourceDocItem=a.AccItemNo) and a.DocStatus<>99 ORDER BY a.PartyName"
            dt = obj.GetDataFromSQL(sql)
            groupField = ""
        End Code
        @If dt.Rows.Count > 0 Then
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DocNo</th>
                        <th>DocDate</th>
                        <th>DueDate</th>
                        <th>ItemNo</th>
                        <th>Product/Service</th>
                        <th>Qty/Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each row As Data.DataRow In dt.Rows
                        If groupField <> row("PartyName") Then
                            groupField = row("PartyName")
                            @<tr>
                                <td style="background-color:white;font-weight:bold" colspan="7">@row("PartyName")</td>
                            </tr>
                        End If
                        @<tr>
                            <td>@row("AccDocNo")</td>
                            <td>@Convert.ToDateTime(row("AccBatchDate")).ToString("yyyy-MM-dd")</td>
                            <td>@Convert.ToDateTime(row("AccEffectiveDate")).ToString("yyyy-MM-dd")</td>
                            <td>@row("AccItemNo")</td>
                            <td>@row("SaleProductCode") - @row("ProductName").ToString() / @row("SalesDescription")</td>
                            <td>@row("Qty") @row("UnitMea") x @Convert.ToDecimal(row("Price")).ToString("N2") @row("Currency")/@row("ExchangeRate") </td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<p>Data Not Found</p>
        End If
    </div>
    <div class="container-fluid">
        <b>ใบแจ้งหนี้ที่ยังไม่ได้ลงบัญชีเจ้าหนี้ / PI Not Posted</b>
        @code
            sql = "select a.* from vTransaction_All a where a.AccItemNo is not null AND a.AccDocType='PI' and not exists(select 1 from vJournal_H WHERE JournalNo = a.AccDocNo) and a.DocStatus<>99 ORDER BY a.PartyName"
            dt = obj.GetDataFromSQL(sql)
            groupField = ""
        End Code
        @If dt.Rows.Count > 0 Then
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DocNo</th>
                        <th>DocDate</th>
                        <th>DueDate</th>
                        <th>ItemNo</th>
                        <th>Product/Service</th>
                        <th>Qty/Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each row As Data.DataRow In dt.Rows
                        If groupField <> row("PartyName") Then
                            groupField = row("PartyName")
                            @<tr>
                                <td style="background-color:white;font-weight:bold" colspan="7">@row("PartyName")</td>
                            </tr>
                        End If
                        @<tr>
                            <td>@row("AccDocNo")</td>
                            <td>@Convert.ToDateTime(row("AccBatchDate")).ToString("yyyy-MM-dd")</td>
                            <td>@Convert.ToDateTime(row("AccEffectiveDate")).ToString("yyyy-MM-dd")</td>
                            <td>@row("AccItemNo")</td>
                            <td>@row("SaleProductCode") - @row("ProductName").ToString() / @row("SalesDescription")</td>
                            <td>@row("Qty") @row("UnitMea") x @Convert.ToDecimal(row("Price")).ToString("N2") @row("Currency")/@row("ExchangeRate") </td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<p>Data Not Found</p>
        End If
    </div>
    <div class="container-fluid">
        <b>ใบแจ้งหนี้ที่ยังไม่ได้รับของ / PI Not Delivered</b>
        @code
            sql = "select a.* from vTransaction_All a where a.AccItemNo is not null AND a.AccDocType='PI' and a.IsService=0 and not exists(select 1 from vDI_D WHERE AccSourceDocNo = a.AccDocNo and AccSourceDocItem=a.AccItemNo) and a.DocStatus<>99 ORDER BY a.PartyName"
            dt = obj.GetDataFromSQL(sql)
            groupField = ""
        End Code
        @If dt.Rows.Count > 0 Then
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DocNo</th>
                        <th>DocDate</th>
                        <th>DueDate</th>
                        <th>ItemNo</th>
                        <th>Product/Service</th>
                        <th>Qty/Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each row As Data.DataRow In dt.Rows
                        If groupField <> row("PartyName") Then
                            groupField = row("PartyName")
                            @<tr>
                                <td style="background-color:white;font-weight:bold" colspan="7">@row("PartyName")</td>
                            </tr>
                        End If
                        @<tr>
                            <td>@row("AccDocNo")</td>
                            <td>@Convert.ToDateTime(row("AccBatchDate")).ToString("yyyy-MM-dd")</td>
                            <td>@Convert.ToDateTime(row("AccEffectiveDate")).ToString("yyyy-MM-dd")</td>
                            <td>@row("AccItemNo")</td>
                            <td>@row("SaleProductCode") - @row("ProductName").ToString() / @row("SalesDescription")</td>
                            <td>@row("Qty") @row("UnitMea") x @Convert.ToDecimal(row("Price")).ToString("N2") @row("Currency")/@row("ExchangeRate") </td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<p>Data Not Found</p>
        End If
    </div>
    <div class="container-fluid">
        <b>ใบแจ้งหนี้ที่ยังไม่ได้ชำระเงิน / PI Not Paymented</b>
        @code
            sql = "select a.* from vTransaction_All a where a.AccItemNo is not null AND a.AccDocType='PI' and not exists(select 1 from vJournal_All WHERE JournalNo like 'PV%' and AccDesc=a.AccDocNo)
and exists(select 1 from vJournal_All WHERE JournalNo like 'PI%' and JournalNo=a.AccDocNo)
and a.DocStatus<>99 ORDER BY a.PartyName"
            dt = obj.GetDataFromSQL(sql)
            groupField = ""
        End Code
        @If dt.Rows.Count > 0 Then
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DocNo</th>
                        <th>DocDate</th>
                        <th>DueDate</th>
                        <th>ItemNo</th>
                        <th>Product/Service</th>
                        <th>Qty/Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each row As Data.DataRow In dt.Rows
                        If groupField <> row("PartyName") Then
                            groupField = row("PartyName")
                            @<tr>
                                <td style="background-color:white;font-weight:bold" colspan="7">@row("PartyName")</td>
                            </tr>
                        End If
                        @<tr>
                            <td>@row("AccDocNo")</td>
                            <td>@Convert.ToDateTime(row("AccBatchDate")).ToString("yyyy-MM-dd")</td>
                            <td>@Convert.ToDateTime(row("AccEffectiveDate")).ToString("yyyy-MM-dd")</td>
                            <td>@row("AccItemNo")</td>
                            <td>@row("SaleProductCode") - @row("ProductName").ToString() / @row("SalesDescription")</td>
                            <td>@row("Qty") @row("UnitMea") x @Convert.ToDecimal(row("Price")).ToString("N2") @row("Currency")/@row("ExchangeRate") </td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<p>Data Not Found</p>
        End If
    </div>
    <div class="container-fluid">
        <b>ใบค่าใช้จ่ายที่ยังไม่ได้รับสินค้าหรือบริการ / PC Not Delivered</b>
        @code
            sql = "select a.* from vTransaction_All a where a.AccItemNo is not null AND a.AccDocType='PC' and a.IsService=0 and not exists(select 1 from vDI_D WHERE AccSourceDocNo = a.AccDocNo and AccSourceDocItem=a.AccItemNo) and a.DocStatus<>99 ORDER BY a.PartyName"
            dt = obj.GetDataFromSQL(sql)
            groupField = ""
        End Code
        @If dt.Rows.Count > 0 Then
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DocNo</th>
                        <th>DocDate</th>
                        <th>DueDate</th>
                        <th>ItemNo</th>
                        <th>Product/Service</th>
                        <th>Qty/Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each row As Data.DataRow In dt.Rows
                        If groupField <> row("PartyName") Then
                            groupField = row("PartyName")
                            @<tr>
                                <td style="background-color:white;font-weight:bold" colspan="7">@row("PartyName")</td>
                            </tr>
                        End If
                        @<tr>
                            <td>@row("AccDocNo")</td>
                            <td>@Convert.ToDateTime(row("AccBatchDate")).ToString("yyyy-MM-dd")</td>
                            <td>@Convert.ToDateTime(row("AccEffectiveDate")).ToString("yyyy-MM-dd")</td>
                            <td>@row("AccItemNo")</td>
                            <td>@row("SaleProductCode") - @row("ProductName").ToString() / @row("SalesDescription")</td>
                            <td>@row("Qty") @row("UnitMea") x @Convert.ToDecimal(row("Price")).ToString("N2") @row("Currency")/@row("ExchangeRate") </td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<p>Data Not Found</p>
        End If
    </div>
    <div class="container-fluid">
        <b>ใบค่าใช้จ่ายที่ยังไม่ได้ชำระเงิน / PC Not Paymented</b>
        @code
            sql = "select a.* from vTransaction_All a where a.AccItemNo is not null AND a.AccDocType='PC' and not exists(select 1 from vJournal_All WHERE JournalNo like 'PV%' AND AccDesc= a.AccDocNo) and a.DocStatus<>99 ORDER BY a.PartyName"
            dt = obj.GetDataFromSQL(sql)
            groupField = ""
        End Code
        @If dt.Rows.Count > 0 Then
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DocNo</th>
                        <th>DocDate</th>
                        <th>DueDate</th>
                        <th>ItemNo</th>
                        <th>Product/Service</th>
                        <th>Qty/Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each row As Data.DataRow In dt.Rows
                        If groupField <> row("PartyName") Then
                            groupField = row("PartyName")
                            @<tr>
                                <td style="background-color:white;font-weight:bold" colspan="7">@row("PartyName")</td>
                            </tr>
                        End If
                        @<tr>
                            <td>@row("AccDocNo")</td>
                            <td>@Convert.ToDateTime(row("AccBatchDate")).ToString("yyyy-MM-dd")</td>
                            <td>@Convert.ToDateTime(row("AccEffectiveDate")).ToString("yyyy-MM-dd")</td>
                            <td>@row("AccItemNo")</td>
                            <td>@row("SaleProductCode") - @row("ProductName").ToString() / @row("SalesDescription")</td>
                            <td>@row("Qty") @row("UnitMea") x @Convert.ToDecimal(row("Price")).ToString("N2") @row("Currency")/@row("ExchangeRate") </td>
                            <td>@Convert.ToDecimal(row("Amount")).ToString("N2")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<p>Data Not Found</p>
        End If
    </div>
</div>
