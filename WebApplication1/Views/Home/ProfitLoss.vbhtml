<style>
    #topMenu {
        display: none;
    }
</style>
@Code
    Layout = "~/Views/Shared/A4.vbhtml"
    ViewData("Title") = "Profit and Loss"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim lang = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
    End If
    Dim yy As String = DateTime.Now.Year().ToString()
    If Not Request.QueryString("Period") Is Nothing Then
        yy = Request.QueryString("Period")
    End If
    Dim mm As Integer = 0
    If Not Request.QueryString("Month") Is Nothing Then
        mm = Request.QueryString("Month")
    End If
    Dim dateFrom = New Date(yy, 1, 1).ToString("yyyy-MM-dd")
    If mm > 0 Then
        dateFrom = New Date(yy, mm, 1).ToString("yyyy-MM-dd")
    End If
    Dim dateTo = DateAdd("d", -1, New Date(yy + 1, 1, 1)).ToString("yyyy-MM-dd")
    If mm > 0 Then
        dateTo = DateAdd("d", -1, New Date(yy, mm + 1, 1)).ToString("yyyy-MM-dd")
    End If
    Dim sql = "select * from (
select 0 as Lvl,Period,AccMainCode as AccCode,AccMainName as AccName,
(case when sum(Debit)>=sum(credit) then sum(Debit)-sum(Credit) else 0 end) as Dr,
(case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end) as Cr
from vProfitLoss where AccCode not like '3%' {0}
group by Period,AccMainCode,AccMainName
union all
select 1 as Lvl,Period,AccCode,AccName,
(case when sum(Debit)>=sum(credit) then sum(Debit)-sum(Credit) else 0 end) as Dr,
(case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end) as Cr
from vProfitLoss where AccCode like '3%' {0}
group by Period,AccCode,AccName
) t
ORDER BY Lvl,AccCode
"
    Dim sqlw = ""
    If yy <> "" Then
        sqlw += String.Format(" AND Period='{0}'", yy)
    End If
    If mm > 0 Then
        sqlw += String.Format(" AND AccMonth={0}", mm)
    End If
    Dim sumDebit As Double = 0
    Dim sumCredit As Double = 0

    Dim dt = obj.GetDataFromSQL(String.Format(sql, sqlw))
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
End Code
@If lang = "EN" Then
    @<h2 onclick="ShowMonth()">Profit and Loss</h2>
    @If yy <> "" Then
        @<b>Fiscal Year @(If(mm > 0, mm & "/", ""))@(Convert.ToInt32(yy)) </b>
    End If
Else
    @<h2 onclick="ShowMonth()">งบกำไรขาดทุน</h2>
    @If yy <> "" Then
        @<b>ประจำปี @(Convert.ToInt32(yy) + 543) @(If(mm > 0, "เดือน " & mm, ""))</b>
    End If
End If
<div id="dvMonth" style="display:none;">
    Select Month :
    <select id="cboMonth" onchange="SetMonthPeriod(this.value)">
        <option value="">ALL</option>
        <option value="1" @IIf(mm = "1", "selected", "")>1</option>
        <option value="2" @IIf(mm = "2", "selected", "")>2</option>
        <option value="3" @IIf(mm = "3", "selected", "")>3</option>
        <option value="4" @IIf(mm = "4", "selected", "")>4</option>
        <option value="5" @IIf(mm = "5", "selected", "")>5</option>
        <option value="6" @IIf(mm = "6", "selected", "")>6</option>
        <option value="7" @IIf(mm = "7", "selected", "")>7</option>
        <option value="8" @IIf(mm = "8", "selected", "")>8</option>
        <option value="9" @IIf(mm = "9", "selected", "")>9</option>
        <option value="10" @IIf(mm = "10", "selected", "")>10</option>
        <option value="11" @IIf(mm = "11", "selected", "")>11</option>
        <option value="12" @IIf(mm = "12", "selected", "")>12</option>
    </select>
</div>
<table border="1" style="border-collapse:collapse;border-style:solid;">
    <thead>
        <tr>
            <th>Acc.Code</th>
            <th>Acc.Name</th>
            <th>Debit</th>
            <th>Credit</th>
        </tr>
    </thead>
    <tbody>
        @For Each dr In dt.Rows
            If dr("lvl") = 0 Then
                sumDebit += obj.GetDouble(dr("Dr"))
                sumCredit += obj.GetDouble(dr("Cr"))
                @<tr>
                    <td>
                        <a href="#" onclick="PrintGL('@dr("AccCode").ToString()')">@dr("AccCode").ToString()</a>
                    </td>
                    <td>@dr("AccName").ToString()</td>
                    <td style="text-align:right;">@Convert.ToDouble(dr("Dr")).ToString("#,##0.00")</td>
                    <td style="text-align:right;">@Convert.ToDouble(dr("Cr")).ToString("#,##0.00")</td>
                </tr>
            Else
                @<tr>
                    <td colspan="2" style="text-align:right;">TOTAL</td>
                    <td style="text-align:right;">@sumDebit.ToString("#,##0.00")</td>
                    <td style="text-align:right;">@sumCredit.ToString("#,##0.00")</td>
                </tr>
                @<tr>
                    <td>
                        <a href="#">@dr("AccCode").ToString()</a>
                    </td>
                    <td>@dr("AccName").ToString()</td>
                    <td style="text-align:right;">@Convert.ToDouble(dr("Dr")).ToString("#,##0.00")</td>
                    <td style="text-align:right;">@Convert.ToDouble(dr("Cr")).ToString("#,##0.00")</td>
                </tr>
            End If
        Next
    </tbody>
</table>
@msg
<script type="text/javascript">
    function ShowMonth() {
        document.getElementById("dvMonth").style.display = "inline";
    }
    function SetMonthPeriod(m) {
        window.location.href = "?Form=ProfitLoss&SRC=@dbSource&DB=@dbName&Period=@yy&Month="+m+"&LANG=@lang";
    }
    function PrintGL(accCode) {
        window.location.href = "?Form=GeneralLedger&SRC=@dbSource&DB=@dbName&Code=" + accCode + "&DateFrom=@dateFrom&DateTo=@dateTo";
    }
</script>