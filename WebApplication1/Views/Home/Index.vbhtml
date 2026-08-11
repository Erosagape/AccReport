@Code
    ViewData("Title") = "Home Page"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim lang As String = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql As String = ""
    Dim dt = New Data.DataTable
    Dim sumCash As Decimal = 0
    Dim sumPayables As Decimal = 0
    Dim sumReceivables As Decimal = 0
    Dim sumProfit As Decimal = 0

    Dim sumPO As Decimal = 0
    Dim sumSO As Decimal = 0
    Dim sumPC As Decimal = 0
    Dim sumRC As Decimal = 0

    Dim cashGroup As String = "111%"
    Dim payablesGroup As String = "212%"
    Dim receivablesGroup As String = "113%"
    If ViewBag.User = "" Then
        If lang = "EN" Then
            Response.Redirect("~/Home/Login?LANG=EN&DB=" + dbname + "&SRC=" + dbSource)
        Else
            Response.Redirect("~/Home/Login?LANG=TH&DB=" + dbname + "&SRC=" + dbSource)
        End If

    End If
End Code
<style>
    .banner-foot {
        background-color: darkblue;
        padding: 10px 5px 5px 5px;
    }

        .banner-foot b {
            color: yellow !important;
        }

    .card {
        border: 1px solid #e0e0e0;
        border-radius: 8px; /* Smooth, modern rounding */
        box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); /* Subtle, downward soft shadow */
        font-weight: bolder;
        width: auto;
        margin: 5px 5px 5px 5px;
    }
</style>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
    google.charts.load('current', { packages: ['corechart'] });
</script>
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-12" style="padding: 5px 5px 5px 5px; text-align: center;margin-left:10px;margin-right:10px;margin-bottom:5px;">
            @*<img src="~/OverView.png" style="width:100%;" />*@
            <div class="col-sm-12">
                <h4>ภาพรวมการดำเนินงาน</h4>
            </div>
            <div class="row">
                <div class="col-sm-3">
                    @Code
                        sql = "select isnull(sum(a.TotalAmount+a.VatAmount-a.WhtAmount),0) as PendingPO
from vPR_D a
where a.DocStatus<>99
and not exists(select 1 from vPO_D where AccSourceDocNo=a.AccdocNo and AccSourceDocItem=a.AccItemNo)
"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumPO = dt.Rows(0).Item("PendingPO")
                        End If
                    End Code
                    <div class="card">
                        <div class="card-header bg-primary">
                            ยอดซื้อรออนุมัติ
                        </div>
                        <div class="card-body">
                            @sumPO.ToString("N2")
                        </div>
                    </div>
                </div>
                <div class="col-sm-3">
                    @Code
                        sql = "select isnull(sum(a.TotalNet),0) as TotalPO from vPO_H a where a.DocStatus<>99"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumPO = dt.Rows(0).Item("TotalPO")
                        End If
                    End Code
                    <div class="card">
                        <div class="card-header bg-primary">
                            ยอดซื้อรวม
                        </div>
                        <div class="card-body">
                            @sumPO.ToString("N2")
                        </div>
                    </div>
                </div>
                <div class="col-sm-3">
                    @Code
                        sql = "select isnull(sum(a.TotalAmount+a.VatAmount-a.WhtAmount),0) as TotalSR from vSR_D a where a.DocStatus<>99
and not exists(select 1 from vSO_D where AccSourceDocNo=a.AccdocNo and AccSourceDocItem=a.AccItemNo)"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumSO = dt.Rows(0).Item("TotalSR")
                        End If
                    End Code
                    <div class="card">
                        <div class="card-header bg-primary">
                            ยอดขายรออนุมัติ
                        </div>
                        <div class="card-body">
                            @sumSO.ToString("N2")
                        </div>
                    </div>
                </div>
                <div class="col-sm-3">
                    @Code
                        sql = "select isnull(sum(a.TotalNet),0) as TotalSO from vSO_H a where a.DocStatus<>99"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumSO = dt.Rows(0).Item("TotalSO")
                        End If
                    End Code
                    <div class="card">
                        <div class="card-header bg-primary">
                            ยอดขายรวม
                        </div>
                        <div class="card-body">
                            @sumSO.ToString("N2")
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    @Code
                        sql = "select TOP(5) PartyCode,sum(TotalNet) as TotalNet from vPC_H where DocStatus<>99 group by PartyCode order by 2 desc"
                        dt = obj.GetDataFromSQL(sql)
                        Dim chartData3 As String = "[['PartyCode', 'TotalNet'],"
                        For Each dr As Data.DataRow In dt.Rows
                            chartData3 &= "['" & dr("PartyCode") & "', " & dr("TotalNet") & "],"
                        Next
                        chartData3 = chartData3.TrimEnd(",") & "]"
                    End Code
                    <script type="text/javascript">
                        google.charts.setOnLoadCallback(drawTopSup);
                        function drawTopSup() {

                            var data = google.visualization.arrayToDataTable(@Html.Raw(chartData3));

                            var options = {
                                chartArea: { width: '50%' },
                                hAxis: {
                                    title: 'ผู้จำหน่าย',
                                    minValue: 0
                                },
                                vAxis: {
                                    title: 'ยอดซื้อ'
                                }
                            };
                            var chart = new google.visualization.BarChart(document.getElementById('chartdata3'));
                            chart.draw(data, options);
                        }
                    </script>
                    <div class="card">
                        <div class="card-header bg-primary">
                            5 อันดับยอดซื้อผู้จำหน่าย
                        </div>
                        <div class="card-body">
                            <div id="chartdata3"></div>
                        </div>
                    </div>

                </div>
                <div class="col-sm-6">
                    @Code
                        sql = "select TOP(5) PartyCode,sum(TotalNet) as TotalNet from vRC_H where DocStatus<>99 group by PartyCode order by 2 desc"
                        dt = obj.GetDataFromSQL(sql)
                        Dim chartData4 As String = "[['PartyCode', 'TotalNet'],"
                        For Each dr As Data.DataRow In dt.Rows
                            chartData4 &= "['" & dr("PartyCode") & "', " & dr("TotalNet") & "],"
                        Next
                        chartData4 = chartData4.TrimEnd(",") & "]"
                    End Code
                    <script type="text/javascript">
                        google.charts.setOnLoadCallback(drawTopCust);
                        function drawTopCust() {

                            var data = google.visualization.arrayToDataTable(@Html.Raw(chartData4));
                            var options = {
                                hAxis: {
                                    title: 'ลูกค้า',
                                    minValue: 0
                                },
                                vAxis: {
                                    title: 'ยอดขาย'
                                }
                            };
                            var chart = new google.visualization.BarChart(document.getElementById('chartdata4'));
                            chart.draw(data, options);
                        }
                    </script>
                    <div class="card">
                        <div class="card-header bg-primary">
                            5 อันดับยอดขายลูกค้า
                        </div>
                        <div class="card-body">
                            <div id="chartdata4"></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <h4>ภาพรวมทางการเงิน</h4>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-3">
                    @Code
                        sql = "select isnull(sum(debit-credit),0) as CashBalance from vSum_Balance where AccCode like '" & cashGroup & "'"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumCash = dt.Rows(0).Item("CashBalance")
                        End If
                    End Code
                    <div class="card">
                        <div class="card-header bg-primary">
                            เงินสดและเงินฝากธนาคาร
                        </div>
                        <div class="card-body">
                            @sumCash.ToString("N2")
                        </div>
                    </div>
                </div>
                <div class="col-sm-3">
                    @Code
                        sql = "select isnull(sum(credit-debit),0) as PayablesBalance from vSum_Balance where AccCode like '" & payablesGroup & "'"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumPayables = dt.Rows(0).Item("PayablesBalance")
                        End If
                    End Code
                    <div class="card">
                        <div class="card-header bg-primary">
                            ค่าใช้จ่ายค้างจ่าย
                        </div>
                        <div class="card-body">
                            @sumPayables.ToString("N2")
                        </div>
                    </div>
                </div>
                <div class="col-sm-3">
                    @Code
                        sql = "select isnull(sum(debit-credit),0) as ReceivablesBalance from vSum_Balance where AccCode like '" & receivablesGroup & "'"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumReceivables = dt.Rows(0).Item("ReceivablesBalance")
                        End If
                    End Code
                    <div class="card">
                        <div class="card-header bg-primary">
                            รายได้ค้างรับ
                        </div>
                        <div class="card-body">
                            @sumReceivables.ToString("N2")
                        </div>
                    </div>
                </div>
                <div class="col-sm-3">
                    @Code
                        sql = "select isnull(sum(Credit-Debit),0) as BaseProfit from vSum_Balance where substring(AccCode,1,1) in('4','5')"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumProfit = dt.Rows(0).Item("BaseProfit")
                        End If
                    End Code
                    <div class="card">
                        <div class="card-header bg-primary">
                            กำไรขั้นต้น
                        </div>
                        <div class="card-body">
                            @sumProfit.ToString("N2")
                        </div>
                    </div>
                </div>
            </div>
            @Code
                sql = "select TOP(12) concat(Year(EntryDate),'/',FORMAT(MONTH(Entrydate),'00')) as [Period],
sum(case when substring(AccCode,1,1)='4' then Credit-Debit else 0 end) as [Sales],
sum(case when substring(AccCode,1,1)='5' then Debit-Credit else 0 end) as [Expenses]
from vJournal_All
where substring(AccCode,1,1) in('4','5')
group by concat(Year(EntryDate),'/',FORMAT(MONTH(Entrydate),'00'))
order by [Period] DESC"
                dt = obj.GetDataFromSQL(sql)
                Dim chartData1 As String = "[['Period', 'Sales', 'Expenses'],"
                For Each dr As Data.DataRow In dt.Rows
                    chartData1 &= "['" & dr("Period") & "', " & dr("Sales") & ", " & dr("Expenses") & "],"
                Next
                chartData1 = chartData1.TrimEnd(",") & "]"
                sql = "select b.AccName as ExpenseType,
sum(case when substring(a.AccCode,1,1)='5' then Debit-Credit else 0 end) as [Expenses]
from vJournal_All a inner join Mas_AccCode b on concat(substring(a.[AccCode],1,2),'00-00')=b.AccCode
where substring(a.AccCode,1,1) ='5'
group by b.AccName"
                dt = obj.GetDataFromSQL(sql)
                Dim chartData2 As String = "[['ExpenseType', 'Expenses'],"
                For Each dr As Data.DataRow In dt.Rows
                    chartData2 &= "['" & dr("ExpenseType") & "', " & dr("Expenses") & "],"
                Next
                chartData2 = chartData2.TrimEnd(",") & "]"
            End Code

            <script type="text/javascript">
                google.charts.setOnLoadCallback(drawChart1);
                google.charts.setOnLoadCallback(drawChart2);
                function drawChart1() {
                    var data = google.visualization.arrayToDataTable(@Html.Raw(chartData1));
                    var options = {
                      hAxis: {title: 'ปี/เดือน',  titleTextStyle: {color: '#333'}},
                      vAxis: {minValue: 0}
                    };

                    var chart = new google.visualization.AreaChart(document.getElementById('areachart1'));
                    chart.draw(data, options);
                }
                function drawChart2() {
                    var data = google.visualization.arrayToDataTable(@Html.Raw(chartData2));
                    var options = {
                        pieHole: 0.4,
                    };

                    var chart = new google.visualization.PieChart(document.getElementById('donutchart1'));
                    chart.draw(data, options);
                }
            </script>
            <div class="row">
                <div class="col-sm-8">
                    <div class="card">
                        <div class="card-header bg-primary">
                            รายได้และค่าใช้จ่าย
                        </div>
                        <div class="card-body">
                            <div id="areachart1"></div>
                        </div>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="card">
                        <div class="card-header bg-primary">
                            ที่มาของค่าใช้จ่าย
                        </div>
                        <div class="card-body">
                            <div id="donutchart1"></div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
<div class="container-fluid">
    <div class="row banner-foot">
        <div class="col-sm-8">
            @Code
                Dim logoName As String = ""
                sql = "select * from Mas_AccConfig where ConfigCode='PROFILE_CONFIG' "
                Dim configSelector As String = "COMPANY_ADDRESS1,COMPANY_ADDRESS2,COMPANY_EMAIL,COMPANY_FAX,COMPANY_LOGO,COMPANY_NAME,COMPANY_TAXBRANCH,COMPANY_TAXNUMBER,COMPANY_TEL,"
                dt = New AccReport.CUtil(ViewBag.WebIP, dbSource).GetDataFromSQL(sql)
                If dt.Rows.Count > 0 Then
                    For Each dr As Data.DataRow In dt.Rows
                        If configSelector.IndexOf(dr("ConfigKey") & ",") >= 0 Then
                            If dr("ConfigKey").Equals("COMPANY_LOGO") Then
                                If dr("ConfigValue").ToString() <> "" Then
                                    logoName = dr("ConfigValue").ToString()
                                End If
                            End If
                @<div class="row">
                    <div class="col-sm-12" style="color:white;">
                        <b>@dr("ConfigKey").ToString().Replace("COMPANY_", "")</b> :
                        @dr("ConfigValue")
                    </div>
                </div>
                        End If
                    Next
                End If
            End Code
        </div>
        <div class="col-sm-4" style="text-align:center;">
            @If logoName <> "" Then
            @<img src="~/@logoName" style="width:200px;" />
            End If
        </div>
    </div>
</div>
<script type="text/javascript">
    function RedrawCharts() {
        drawChart1();
        drawChart2();
        drawTopSup();
        drawTopCust();
    }
    window.addEventListener('resize', function () {
        RedrawCharts();
    });
</script>