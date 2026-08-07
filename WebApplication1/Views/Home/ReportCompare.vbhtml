@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Balance Comparison"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim lang = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
    End If
    Dim dt As New Data.DataTable
    Dim reportType As String = "D"
    If Not Request.QueryString("TYPE") Is Nothing Then
        reportType = Request.QueryString("TYPE")
    End If
    Dim quarter As Integer = 0
    Dim fiscalYear As Integer = 0
    If Not Request.QueryString("Period") Is Nothing Then
        fiscalYear = Convert.ToInt32(Request.QueryString("Period"))
    End If
    Dim cliteria As String = ""
    Dim sql As String = ""
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    If Request.Form("SubmitDate") IsNot Nothing Then
        Dim dateBegin As String = Convert.ToDateTime(Request.Form("DateBegin")).ToString("yyyy-MM-dd")
        Dim dateEnd As String = Convert.ToDateTime(Request.Form("DateEnd")).ToString("yyyy-MM-dd")
        Dim dateStart As String = Convert.ToDateTime(Request.Form("DateStart")).ToString("yyyy-MM-dd")
        sql = String.Format("EXEC dbo.GetBalance_DateCompare '{2}','{0}','{1}'", dateBegin, dateEnd, dateStart)
        dt = obj.GetDataFromSQL(sql)
        If lang = "TH" Then
            cliteria = "จากวันที่ " & dateBegin & " ถึงวันที่ " & dateEnd & " เริ่มคำนวณยอดคงเหลือ ณ วันที่ " & dateStart
        Else
            cliteria = "From Date " & dateBegin & " To Date " & dateEnd & " Start Calculate At " & dateStart
        End If
    End If
    If Request.Form("SubmitYear") IsNot Nothing Or (fiscalYear > 0 And reportType = "Y") Then
        If Request.Form("FiscalYear") IsNot Nothing Then
            fiscalYear = Request.Form("FiscalYear")
        End If
        sql = String.Format("EXEC dbo.GetBalance_YearCompare {0}", fiscalYear)
        dt = obj.GetDataFromSQL(sql)
        If lang = "TH" Then
            cliteria = "ปีงบประมาณ " & fiscalYear + 543
        Else
            cliteria = "Fiscal Year " & fiscalYear
        End If
    End If
    If Request.Form("SubmitQuarter") IsNot Nothing Or (fiscalYear > 0 And reportType = "Q") Then
        If Request.Form("FiscalYear") IsNot Nothing Then
            fiscalYear = Request.Form("FiscalYear")
        End If
        If Request.Form("Quarter") IsNot Nothing Then
            quarter = Request.Form("Quarter")
        End If
        sql = String.Format("EXEC dbo.GetBalance_QuarterCompare {0}", fiscalYear)
        dt = obj.GetDataFromSQL(sql)
        If lang = "TH" Then
            cliteria = "ปีงบประมาณ " & fiscalYear + 543
            If quarter > 0 Then
                cliteria &= " ไตรมาสที่ " & quarter
            End If
        Else
            cliteria = "Fiscal Year " & fiscalYear
            If quarter > 0 Then
                cliteria &= " Q" & quarter
            End If
        End If

    End If
End Code
<style>
    .container {
        width: 100%;
    }

    #topMenu {
        display: none;
    }
</style>
@If reportType = "D" Then
    @<a href="#form1" onclick="OpenForm()"><h2>@(IIf(lang = "TH", "เปรียบเทียบยอดคงเหลือทางบัญชี-ตามช่วงวันที่", "Account Balance Comparison By Date"))</h2></a>
    @<form id="form1" method="post" action="" style="display:none;">
        <div class="row">
            <div class="col-sm-4">
                <label>Begin Date</label>
                <br />
                <input type="date" name="DateBegin" class="form-control" />
            </div>
            <div class="col-sm-4">
                <label>End Date</label>
                <br />
                <input type="date" name="DateEnd" class="form-control" />
            </div>
            <div class="col-sm-4">
                <label>Start Date</label>
                <br />
                <input type="date" name="DateStart" class="form-control" />
            </div>
        </div>
        <input type="submit" value="Generate Report" name="SubmitDate" class="btn btn-primary" />
    </form>
    If dt.Rows.Count > 0 Then
        Dim dateFrom = Request.Form("DateBegin")
        Dim dateTo = Request.Form("DateEnd")
        @<h2>@cliteria</h2>
        @<table class="table table-bordered table-striped">
            <thead>
                <tr>
                    <th rowspan="2">@IIf(lang = "TH", "รหัสบัญชี", "Account Code")</th>
                    <th rowspan="2">@IIf(lang = "TH", "ชื่อบัญชี", "Account Name")</th>
                    <th colspan="2">@IIf(lang = "TH", "ยอดยกมา", "Beginning Balance")</th>
                    <th colspan="2">@IIf(lang = "TH", "ยอดเคลื่อนไหว", "Movement")</th>
                    <th colspan="2">@IIf(lang = "TH", "ยอดคงเหลือ", "Balance")</th>
                    <th colspan="2">@IIf(lang = "TH", "ยอดยกไป", "Forwarding Balance")</th>
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
                </tr>
            </thead>
            <tbody>
                @For Each row As Data.DataRow In dt.Rows
                    @<tr>
                         <td>
                             <a href="?Form=GeneralLedger&SRC=@dbSource&DB=@dbname&Code=@row("AccCode")&DateFrom=@dateFrom&DateTo=@dateTo">@row("AccCode").ToString()</a>
                         </td>
                        <td>@row("AccName").ToString()</td>
                        <td class="colnum">@obj.GetDouble(Convert.ToDecimal(row("Dr_Before"))).ToString("N2")</td>
                        <td class="colnum">@obj.GetDouble(Convert.ToDecimal(row("Cr_Before"))).ToString("N2")</td>
                        <td class="colnum">@obj.GetDouble(Convert.ToDecimal(row("Dr_Current"))).ToString("N2")</td>
                        <td class="colnum">@obj.GetDouble(Convert.ToDecimal(row("Cr_Current"))).ToString("N2")</td>
                        <td class="colnum">@obj.GetDouble(Convert.ToDecimal(row("Dr_Balance"))).ToString("N2")</td>
                        <td class="colnum">@obj.GetDouble(Convert.ToDecimal(row("Cr_Balance"))).ToString("N2")</td>
                        <td Class="colnum">@obj.GetDouble(Convert.ToDecimal(row("Dr_Forward"))).ToString("N2")</td>
                        <td Class="colnum">@obj.GetDouble(Convert.ToDecimal(row("Cr_Forward"))).ToString("N2")</td>
                    </tr>
                Next
            </tbody>
        </table>
    End If
                            End If
@If reportType = "Y" Then
    @<a href="#form1" onclick="OpenForm()"><h2>@(IIf(lang = "TH", "เปรียบเทียบยอดคงเหลือทางบัญชี-รายปี", "Account Balance Comparison By Year"))</h2></a>
    @<form id="form1" method="post" action="" style="display:none;">
        <div class="row">
            <div class="col-sm-4">
                <label>Year</label>
                <br />
                <input type="number" name="FiscalYear" class="form-control" value="@fiscalYear" />
            </div>
        </div>
        <input type="submit" value="Generate Report" name="SubmitYear" class="btn btn-primary" />
    </form>
    If dt.Rows.Count > 0 Then
                                    Dim dateFrom = New Date(fiscalYear, 1, 1).ToString("yyyy-MM-dd")
                                    Dim dateTo = New Date(fiscalYear, 12, 31).ToString("yyyy-MM-dd")
        @<h2>@cliteria</h2>
        @<table class="table table-bordered table-striped">
            <thead>
                                    <tr>
                                    <th rowspan="2">@IIf(lang = "TH", "รหัสบัญชี", "Account Code")</th>
                    <th rowspan="2">@IIf(lang = "TH", "ชื่อบัญชี", "Account Name")</th>
                    <th colspan="2">@IIf(lang = "TH", (fiscalYear - 1) + 543, fiscalYear - 1)</th>
                    <th colspan="2">@IIf(lang = "TH", "ยอดเคลื่อนไหว", "Movement")</th>
                    <th colspan="2">@IIf(lang = "TH", "ยอดคงเหลือ", "Balance")</th>
                    <th colspan="2">@IIf(lang = "TH", fiscalYear + 543, fiscalYear)</th>
                    <th rowspan="2">@IIf(lang = "TH", "เปลี่ยนแปลง", "Change")</th>
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
                </tr>
            </thead>
            <tbody>
                @For Each row As Data.DataRow In dt.Rows
                    @<tr>
                        <td>
                                    <a href="?Form=GeneralLedger&SRC=@dbSource&DB=@dbname&Code=@row("AccCode")&DateFrom=@dateFrom&DateTo=@dateTo">@row("AccCode").ToString()</a>
                        </td>
                        <td>@row("AccName").ToString()</td>
                        <td class="colnum">@Convert.ToDecimal(row("Dr_LastYear")).ToString("N2")</td>
                        <td class="colnum">@Convert.ToDecimal(row("Cr_LastYear")).ToString("N2")</td>
                        <td class="colnum">@Convert.ToDecimal(row("Dr_Current")).ToString("N2")</td>
                        <td class="colnum">@Convert.ToDecimal(row("Cr_Current")).ToString("N2")</td>
                        <td class="colnum">@Convert.ToDecimal(row("Dr_Balance")).ToString("N2")</td>
                        <td class="colnum">@Convert.ToDecimal(row("Cr_Balance")).ToString("N2")</td>
                        <td class="colnum">@Convert.ToDecimal(row("Dr_Forward")).ToString("N2")</td>
                        <td class="colnum">@Convert.ToDecimal(row("Cr_Forward")).ToString("N2")</td>
                        <td class="colnum">@Convert.ToDecimal(row("ChangeAmt")).ToString("N2") (@Convert.ToDecimal(row("ChangeRatio")).ToString("N2")%)</td>
                    </tr>
                Next
            </tbody>
        </table>
    End If
                                                                        End If
@If reportType = "Q" Then
    @<a href="#form1" onclick="OpenForm()"><h2>@(IIf(lang = "TH", "เปรียบเทียบยอดคงเหลือทางบัญชี-ตามไตรมาส", "Account Balance Comparison By Quarter"))</h2></a>
    @<form id="form1" method="post" action="" style="display:none;">
        <div class="row">
            <div class="col-sm-4">
                <label>Year</label>
                <br />
                <input type="number" name="FiscalYear" class="form-control" value="@fiscalYear" />
            </div>
            <div class="col-sm-4">
                <label>Quarter</label>
                <br />
                <input type="number" name="Quarter" class="form-control" value="@quarter" />
            </div>
        </div>
        <input type="submit" value="Generate Report" name="SubmitQuarter" class="btn btn-primary" />
    </form>
    If dt.Rows.Count > 0 Then
        @<h2>@cliteria</h2>
        @<table class="table table-bordered table-striped">
            <thead>
                                                                                    <tr>
                                                                                    <th>@IIf(lang = "TH", "รหัสบัญชี", "Account Code")</th>
                    <th>@IIf(lang = "TH", "ชื่อบัญชี", "Account Name")</th>
                    @If quarter > 0 Then
                        @<th>@IIf(lang = "TH", quarter & "/" & (fiscalYear - 1) + 543, "Q" & quarter & "/" & fiscalYear - 1)</th>
                        @<th>@IIf(lang = "TH", quarter & "/" & fiscalYear + 543, "Q" & quarter & "/" & fiscalYear)</th>
                        @<th>@IIf(lang = "TH", "เปลี่ยนแปลง", "Change")</th>
                    Else
                        @<th>@IIf(lang = "TH", "1/" & (fiscalYear - 1) + 543, "Q1/" & fiscalYear - 1)</th>
                        @<th>@IIf(lang = "TH", "1/" & fiscalYear + 543, "Q1/" & fiscalYear)</th>
                        @<th>@IIf(lang = "TH", "เปลี่ยนแปลง", "Change")</th>
                        @<th>@IIf(lang = "TH", "2/" & (fiscalYear - 1) + 543, "Q2/" & fiscalYear - 1)</th>
                        @<th>@IIf(lang = "TH", "2/" & fiscalYear + 543, "Q2/" & fiscalYear)</th>
                        @<th>@IIf(lang = "TH", "เปลี่ยนแปลง", "Change")</th>
                        @<th>@IIf(lang = "TH", "3/" & (fiscalYear - 1) + 543, "Q3/" & fiscalYear - 1)</th>
                        @<th>@IIf(lang = "TH", "3/" & fiscalYear + 543, "Q3/" & fiscalYear)</th>
                        @<th>@IIf(lang = "TH", "เปลี่ยนแปลง", "Change")</th>
                        @<th>@IIf(lang = "TH", "4/" & (fiscalYear - 1) + 543, "Q4/" & fiscalYear - 1)</th>
                        @<th>@IIf(lang = "TH", "4/" & fiscalYear + 543, "Q4/" & fiscalYear)</th>
                        @<th>@IIf(lang = "TH", "เปลี่ยนแปลง", "Change")</th>
                    End If
                </tr>
            </thead>
            <tbody>
                @For Each row As Data.DataRow In dt.Rows
                    If quarter > 0 Then
                        @<tr>
                            <td>
                                @row("AccCode").ToString()
                            </td>
                            <td>@row("AccName").ToString()</td>
                            @If "1,5".Contains(row("AccCode").ToString().Substring(0, 1)) Then
                                If Convert.ToDecimal(row("Dr_LQ" & quarter)) > 0.0 Then
                                    @<td class="colnum">@Convert.ToDecimal(row("Dr_LQ" & quarter)).ToString("N2")</td>
                                Else
                                    @<td class="colnum">-@Convert.ToDecimal(row("Cr_LQ" & quarter)).ToString("N2")</td>
                                End If
                                                                                    If Convert.ToDecimal(row("Dr_Q" & quarter)) > 0.0 Then
                                    @<td class="colnum">@Convert.ToDecimal(row("Dr_Q" & quarter)).ToString("N2")</td>
                                Else
                                    @<td class="colnum">-@Convert.ToDecimal(row("Cr_Q" & quarter)).ToString("N2")</td>
                                End If
                                                                                    Else
                                                                                    If Convert.ToDecimal(row("Cr_LQ" & quarter)) > 0.0 Then
                                    @<td class="colnum">@Convert.ToDecimal(row("Cr_LQ" & quarter)).ToString("N2")</td>
                                Else
                                    @<td class="colnum">-@Convert.ToDecimal(row("Dr_LQ" & quarter)).ToString("N2")</td>
                                End If
                                                                                    If Convert.ToDecimal(row("Cr_Q" & quarter)) > 0.0 Then
                                    @<td class="colnum">@Convert.ToDecimal(row("Cr_Q" & quarter)).ToString("N2")</td>
                                Else
                                    @<td class="colnum">-@Convert.ToDecimal(row("Dr_Q" & quarter)).ToString("N2")</td>
                                End If
                                                                                    End If
                            @If Convert.ToDecimal(row("Change_Q" & quarter)) > 0.0 Then
                                @<td class="colnum">
                                    +@Convert.ToDecimal(row("Change_Q" & quarter)).ToString("N2") (@Convert.ToDecimal(row("Ratio_Q" & quarter)).ToString("N2")%)
                                </td>
                            Else
                                @<td class="colnum">
                                    @Convert.ToDecimal(row("Change_Q" & quarter)).ToString("N2") (@Convert.ToDecimal(row("Ratio_Q" & quarter)).ToString("N2")%)
                                </td>
                            End If
                        </tr>
                    Else
                        @<tr>
                            <td>
                                @row("AccCode").ToString()
                            </td>
                            <td>@row("AccName").ToString()</td>
                            @For i As Integer = 1 To 4
                                If "1,5".Contains(row("AccCode").ToString().Substring(0, 1)) Then
                                                                                    If Convert.ToDecimal(row("Dr_LQ" & i)) > 0.0 Then
                                        @<td class="colnum">@Convert.ToDecimal(row("Dr_LQ" & i)).ToString("N2")</td>
                                    Else
                                        @<td class="colnum">-@Convert.ToDecimal(row("Cr_LQ" & i)).ToString("N2")</td>
                                    End If
                                                                                    If Convert.ToDecimal(row("Dr_Q" & i)) > 0.0 Then
                                        @<td class="colnum">@Convert.ToDecimal(row("Dr_Q" & i)).ToString("N2")</td>
                                    Else
                                        @<td class="colnum">-@Convert.ToDecimal(row("Cr_Q" & i)).ToString("N2")</td>
                                    End If
                                                                                    Else
                                                                                    If Convert.ToDecimal(row("Cr_LQ" & i)) > 0.0 Then
                                        @<td class="colnum">@Convert.ToDecimal(row("Cr_LQ" & i)).ToString("N2")</td>
                                    Else
                                        @<td class="colnum">-@Convert.ToDecimal(row("Dr_LQ" & i)).ToString("N2")</td>
                                    End If
                                                                                    If Convert.ToDecimal(row("Cr_Q" & i)) > 0.0 Then
                                        @<td class="colnum">@Convert.ToDecimal(row("Cr_Q" & i)).ToString("N2")</td>
                                    Else
                                        @<td class="colnum">-@Convert.ToDecimal(row("Dr_Q" & i)).ToString("N2")</td>
                                    End If
                                                                                    End If
                                                                                    If Convert.ToDecimal(row("Change_Q" & i)) > 0.0 Then
                                    @<td class="colnum">
                                        +@Convert.ToDecimal(row("Change_Q" & i)).ToString("N2") (@Convert.ToDecimal(row("Ratio_Q" & i)).ToString("N2")%)
                                    </td>
                                Else
                                    @<td class="colnum">
                                        @Convert.ToDecimal(row("Change_Q" & i)).ToString("N2") (@Convert.ToDecimal(row("Ratio_Q" & i)).ToString("N2")%)
                                    </td>
                                End If
                                                                                    Next
                        </tr>
                    End If
                                                                                    Next
            </tbody>
        </table>
    End If
                                                                                    End If
                                                                                    <script type="text/javascript">
                                                                                        function OpenForm() {
        $("#form1").css("display", "block");
    }
</script>