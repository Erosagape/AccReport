<style>
    #topMenu {
        display: none;
    }
</style>
@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Trial Balance"
    Dim yy = DateTime.Now.Year
    If Not Request.QueryString("Period") Is Nothing Then
        yy = Request.QueryString("Period")
    End If
    Dim mm As String = "12"
    If Not Request.QueryString("Month") Is Nothing Then
        mm = Request.QueryString("Month")
    End If
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
    Dim sql = ""
    Dim pm As String = ""
    Dim dateFrom = New Date(yy, 1, 1).ToString("yyyy-MM-dd")
    Dim dateTo = DateAdd("d", -1, New Date(yy + 1, 1, 1)).ToString("yyyy-MM-dd")
    Dim sourceTable = "vSum_BalanceMonthlyCompare"
    Dim reportType As String = ""
    If Not Request.QueryString("Sum") Is Nothing Then
        reportType = Request.QueryString("Sum")
    End If
    If reportType = "Y" Then
        sourceTable = "(
            select Period,AccMainCode as AccCode,AccMainName as AccName,
            sum(BalDr) as BalDr,sum(BalCr) as BalCr,
            sum(Dr1) as Dr1,sum(Cr1) as Cr1,
            sum(Dr_Jan) as Dr_Jan,sum(Cr_Jan) as Cr_Jan,
            sum(Dr2) as Dr2,sum(Cr2) as Cr2,
            sum(Dr_Feb) as Dr_Feb,sum(Cr_Feb) as Cr_Feb,
            sum(Dr3) as Dr3,sum(Cr3) as Cr3,
            sum(Dr_Mar) as Dr_Mar,sum(Cr_Mar) as Cr_Mar,
            sum(Dr4) as Dr4,sum(Cr4) as Cr4,
            sum(Dr_Apr) as Dr_Apr,sum(Cr_Apr) as Cr_Apr,
            sum(Dr5) as Dr5,sum(Cr5) as Cr5,
            sum(Dr_May) as Dr_May,sum(Cr_May) as Cr_May,
            sum(Dr6) as Dr6,sum(Cr6) as Cr6,
            sum(Dr_Jun) as Dr_Jun,sum(Cr_Jun) as Cr_Jun,
            sum(Dr7) as Dr7,sum(Cr7) as Cr7,
            sum(Dr_Jul) as Dr_Jul,sum(Cr_Jul) as Cr_Jul,
            sum(Dr8) as Dr8,sum(Cr8) as Cr8,
            sum(Dr_Aug) as Dr_Aug,sum(Cr_Aug) as Cr_Aug,
            sum(Dr9) as Dr9,sum(Cr9) as Cr9,
            sum(Dr_Sep) as Dr_Sep,sum(Cr_Sep) as Cr_Sep,
            sum(Dr10) as Dr10,sum(Cr10) as Cr10,
            sum(Dr_Oct) as Dr_Oct,sum(Cr_Oct) as Cr_Oct,
            sum(Dr11) as Dr11,sum(Cr11) as Cr11,
            sum(Dr_Nov) as Dr_Nov,sum(Cr_Nov) as Cr_Nov,
            sum(Dr12) as Dr12,sum(Cr12) as Cr12,
            sum(Dr_Dec) as Dr_Dec,sum(Cr_Dec) as Cr_Dec
            from (
	            select b.AccMainCode,b.AccMainName,
	            a.*
	            from vSum_BalanceMonthlyCompare a 
	            inner join vMas_AccCode b on a.AccCode=b.AccCode    
            ) src
            group by Period,AccMainCode,AccMainName        
        ) t "
    End If
    If mm = "" Then
        pm = "BalDr as PrevDr,BalCr as PrevCr,Dec_Dr-BalDr as Dr,Dec_Cr-BalCr as Cr"
        sql = String.Format("select AccCode,AccName,Dec_Dr as NextDr,Dec_Cr as NextCr," + pm + " from " & sourceTable & " where Period={0} ORDER BY AccCode", yy)
    Else

        Select Case mm
            Case 1
                dateFrom = New Date(yy, 1, 1).ToString("yyyy-MM-dd")
                dateTo = New Date(yy, 1, 31).ToString("yyyy-MM-dd")
                pm = "BalDr as PrevDr,BalCr as PrevCr,Dr_Jan as NextDr,Cr_Jan as NextCr"
            Case 2
                dateFrom = New Date(yy, 2, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 3, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Jan as PrevDr,Cr_Jan as PrevCr,Dr_Feb as NextDr,Cr_Feb as NextCr"
            Case 3
                dateFrom = New Date(yy, 3, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 4, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Feb as PrevDr,Cr_Feb as PrevCr,Dr_Mar as NextDr,Cr_Mar as NextCr"
            Case 4
                dateFrom = New Date(yy, 4, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 5, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Mar as PrevDr,Cr_Mar as PrevCr,Dr_Apr as NextDr,Cr_Apr as NextCr"
            Case 5
                dateFrom = New Date(yy, 5, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 6, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Apr as PrevDr,Cr_Apr as PrevCr,Dr_May as NextDr,Cr_May as NextCr"
            Case 6
                dateFrom = New Date(yy, 6, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 7, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_May as PrevDr,Cr_May as PrevCr,Dr_Jun as NextDr,Cr_Jun as NextCr"
            Case 7
                dateFrom = New Date(yy, 7, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 8, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Jun as PrevDr,Cr_Jun as PrevCr,Dr_Jul as NextDr,Cr_Jul as NextCr"
            Case 8
                dateFrom = New Date(yy, 8, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 9, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Jul as PrevDr,Cr_Jul as PrevCr,Dr_Aug as NextDr,Cr_Aug as NextCr"
            Case 9
                dateFrom = New Date(yy, 9, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 10, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Aug as PrevDr,Cr_Aug as PrevCr,Dr_Sep as NextDr,Cr_Sep as NextCr"
            Case 10
                dateFrom = New Date(yy, 10, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 11, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Sep as PrevDr,Cr_Sep as PrevCr,Dr_Oct as NextDr,Cr_Oct as NextCr"
            Case 11
                dateFrom = New Date(yy, 11, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy, 12, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Oct as PrevDr,Cr_Oct as PrevCr,Dr_Nov as NextDr,Cr_Nov as NextCr"
            Case 12
                dateFrom = New Date(yy, 12, 1).ToString("yyyy-MM-dd")
                dateTo = DateAdd("d", -1, New Date(yy + 1, 1, 1)).ToString("yyyy-MM-dd")
                pm = "Dr_Nov as PrevDr,Cr_Nov as PrevCr,Dr_Dec as NextDr,Cr_Dec as NextCr"
        End Select
        sql = String.Format("select AccCode,AccName,Dr" + mm + " as Dr,Cr" + mm + " as Cr," + pm + " from " & sourceTable & " where Period={0} ORDER BY AccCode", yy)
    End If
    'Dim cnnStr = "Data Source=.;Initial Catalog=AccConcept;User id=sa;Password='9t;yogm851';Persist Security Info=False"
    'Dim obj = New AccReport.CUtil(cnnStr)

    Dim dt = obj.GetDataFromSQL(sql)
    Dim msg As String = "Ready"
    If obj.Message = "" Then
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
    Dim sumDebit As Double = 0
    Dim sumCredit As Double = 0
    Dim sumPDebit As Double = 0
    Dim sumPCredit As Double = 0
    Dim sumNDebit As Double = 0
    Dim sumNCredit As Double = 0
    Dim sumBSDebit As Double = 0
    Dim sumBSCredit As Double = 0
    Dim sumPLDebit As Double = 0
    Dim sumPLCredit As Double = 0
End Code
@If lang = "EN" Then
    @<h3>Trial Balance</h3>
Else
    @<h3>งบทดลอง</h3>
End If
<div style="display:flex;">
    @If lang = "EN" Then
        @<h4>Fiscal Year @(Convert.ToInt32(yy)) &nbsp;&nbsp;</h4>
        @<h4>Period &nbsp;&nbsp;</h4>
        @<select id="cboMonth" onchange="RefreshPage(this.value)">
            <option value="1"> January</option>
            <option value="2"> February</option>
            <option value="3"> March</option>
            <option value="4"> April</option>
            <option value="5"> May</option>
            <option value="6"> June</option>
            <option value="7"> July</option>
            <option value="8"> August</option>
            <option value="9"> September</option>
            <option value="10"> October</option>
            <option value="11"> November</option>
            <option value="12"> December</option>
        </select>
    Else
        @<h4>ประจำปีภาษี@(Convert.ToInt32(yy) + 543)&nbsp;&nbsp; </h4>
        @<h4>ประจำงวด  &nbsp;&nbsp;</h4>
        @<select id="cboMonth" onchange="RefreshPage(this.value)">
            <option value="1"> มกราคม</option>
            <option value="2"> กุมภาพันธ์</option>
            <option value="3"> มีนาคม</option>
            <option value="4"> เมษายน</option>
            <option value="5"> พฤษภาคม</option>
            <option value="6"> มิถุนายน</option>
            <option value="7"> กรกฏาคม</option>
            <option value="8"> สิงหาคม</option>
            <option value="9"> กันยายน</option>
            <option value="10"> ตุลาคม</option>
            <option value="11"> พฤษจิกายน</option>
            <option value="12"> ธันวาคม</option>
        </select>
    End If

</div>
<div>
    <table border="1" style="border-collapse:collapse;border-style:solid;">
        @If lang = "TH" Then
            @<thead>
                <tr>
                    <th rowspan="2"> รหัสบัญชี</th>
                    <th rowspan="2"> ชื่อบัญชี</th>
                    <th colspan="2"> ยกมา</th>
                    <th colspan="2"> เปลี่ยนแปลง</th>
                    <th colspan="2"> ยกไป</th>
                    <th colspan="2"> งบดุล</th>
                    <th colspan="2"> งบกำไรขาดทุน</th>
                </tr>
                <tr>
                    <th>เดบิค</th>
                    <th>เครดิต</th>
                    <th>เดบิค</th>
                    <th>เครดิต</th>
                    <th>เดบิค</th>
                    <th>เครดิต</th>
                    <th>เดบิค</th>
                    <th>เครดิต</th>
                    <th>เดบิค</th>
                    <th>เครดิต</th>
                </tr>
            </thead>
        Else
            @<thead>
                <tr>
                    <th rowspan="2"> Acc.Code</th>
                    <th rowspan="2"> Acc.Name</th>
                    <th colspan="2"> Previous</th>
                    <th colspan="2"> Change</th>
                    <th colspan="2"> Forward</th>
                    <th colspan="2"> Balance Sheet</th>
                    <th colspan="2"> Profit Loss</th>
                </tr>
                <tr>
                    <th>Debit</th>
                    <th>Credit</th>
                    <th>Debit</th>
                    <th>Credit</th>
                    <th>Debit</th>
                    <th>Credit</th>
                    <th>Debit</th>
                    <th>Credit</th>
                    <th>Debit</th>
                    <th>Credit</th>
                </tr>
            </thead>

        End If
        <tbody>
            @For Each dr In dt.Rows
                sumDebit += obj.GetDouble(dr("Dr"))
                sumCredit += obj.GetDouble(dr("Cr"))
                sumPDebit += obj.GetDouble(dr("PrevDr"))
                sumPCredit += obj.GetDouble(dr("PrevCr"))
                sumNDebit += obj.GetDouble(dr("NextDr"))
                sumNCredit += obj.GetDouble(dr("NextCr"))
                If obj.GetDouble(dr("PrevDr")) > 0 Or obj.GetDouble(dr("PrevCr")) > 0 Or obj.GetDouble(dr("NextDr")) > 0 Or obj.GetDouble(dr("NextCr")) > 0 Or obj.GetDouble(dr("Dr")) > 0 Or obj.GetDouble(dr("Cr")) > 0 Then
                    @<tr>
                        <td><a href="?Form=GeneralLedger&SRC=@dbSource&DB=@dbName&Code=@dr("AccCode")&DateFrom=@dateFrom&DateTo=@dateTo">@dr("AccCode").ToString()</a></td>
                        <td>@dr("AccName").ToString()</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("PrevDr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("PrevCr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Dr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("Cr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("NextDr")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@Convert.ToDouble(dr("NextCr")).ToString("#,##0.00")</td>
                        @If dr("AccCode").ToString().Substring(0, 1) = "4" Or dr("AccCode").ToString().Substring(0, 1) = "5" Then
                            @<td style="text-align:right;"></td>
                            @<td style="text-align:right;"></td>
                            @<td style="text-align:right;">@Convert.ToDouble(dr("NextDr")).ToString("#,##0.00")</td>
                            @<td style="text-align:right;">@Convert.ToDouble(dr("NextCr")).ToString("#,##0.00")</td>
                            sumPLDebit += obj.GetDouble(dr("NextDr"))
                            sumPLCredit += obj.GetDouble(dr("NextCr"))
                        Else
                            @<td style="text-align:right;">@Convert.ToDouble(dr("NextDr")).ToString("#,##0.00")</td>
                            @<td style="text-align:right;">@Convert.ToDouble(dr("NextCr")).ToString("#,##0.00")</td>
                            @<td style="text-align:right;"></td>
                            @<td style="text-align:right;"></td>
                            sumBSDebit += obj.GetDouble(dr("NextDr"))
                            sumBSCredit += obj.GetDouble(dr("NextCr"))
                        End If
                    </tr>
                End If
            Next
        </tbody>
        <tfoot>
            <tr>
                <td colspan="2">TOTAL/ยอดรวม</td>
                <td style="text-align:right;">@sumPDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumPCredit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumCredit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumNDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumNCredit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumBSDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumBSCredit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumPLDebit.ToString("#,##0.00")</td>
                <td style="text-align:right;">@sumPLCredit.ToString("#,##0.00")</td>
            </tr>
            <tr>
                <td colspan="2">PROFIT(LOSS) / กำไร(ขาดทุน)</td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                <td style="text-align:right;"></td>
                @If sumBSDebit > sumBSCredit Then
                    @<td style="text-align:right;"></td>
                    @<td style="text-align:right;">@Convert.ToDouble(sumBSDebit - sumBSCredit).ToString("#,##0.00")</td>
                Else
                    @<td style="text-align:right;">@Convert.ToDouble(sumBSCredit - sumBSDebit).ToString("#,##0.00")</td>
                    @<td style="text-align:right;"></td>
                End If
                @If sumPLDebit > sumPLCredit Then
                    @<td style="text-align:right;"></td>
                    @<td style="text-align:right;">@Convert.ToDouble(sumPLDebit - sumPLCredit).ToString("#,##0.00")</td>
                Else
                    @<td style="text-align:right;">@Convert.ToDouble(sumPLCredit - sumPLDebit).ToString("#,##0.00")</td>
                    @<td style="text-align:right;"></td>
                End If
            </tr>
        </tfoot>
    </table>
</div>
@msg
<script type="text/javascript">
    var mm = '@mm';
    document.getElementById("cboMonth").value = mm;
    function RefreshPage(val) {
        window.location.href = "?Form=TrialBalance&SRC=@dbSource&DB=@dbName&Period=@yy&Month="+val;
    }
</script>