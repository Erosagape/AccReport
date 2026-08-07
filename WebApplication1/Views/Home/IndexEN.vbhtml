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
        Response.Redirect("~/Home/Login?DB=" + dbname + "&SRC=" + dbSource)
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
        margin:5px 5px 5px 5px;
    }
</style>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
    google.charts.load('current', { packages: ['corechart'] });
    function openNav() {
        document.getElementById("mySideBar").style.display = "inline-block";
        document.getElementById("mySideBar").classList.remove("col-sm-3");
        document.getElementById("mySideBar").classList.add("col-sm-12");

        document.getElementById("myDashboard").classList.add("col-sm-9");
        document.getElementById("myDashboard").classList.remove("col-sm-12");
    }

    /* Set the width of the sidebar to 0 and the left margin of the page content to 0 */
    function closeNav() {
        document.getElementById("mySideBar").style.display = "none";
        document.getElementById("mySideBar").classList.remove("col-sm-12");
        document.getElementById("mySideBar").classList.add("col-sm-3");

        document.getElementById("myDashboard").classList.remove("col-sm-9");
        document.getElementById("myDashboard").classList.add("col-sm-12");
    }
    var isOpenMenu = false;
    function ToggleMenu() {
        if (isOpenMenu) {
            closeNav();
        } else {
            openNav();
        }
        isOpenMenu = !isOpenMenu;
        RedrawCharts();
    }
</script>
<div style="float:right">
    Date: @DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
</div>
<input type="button" class="openbtn" onclick="ToggleMenu()" value="☰"> Menu
<br />
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-3 card" id="mySideBar" style="padding: 5px 5px 5px 5px;display: none;">
            <b>General Master Files</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Profile&DB=@dbname&SRC=@dbSource">Company Profile</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ConfigAcc&DB=@dbname&SRC=@dbSource">Standard Account Entry</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=DocList&DB=@dbname&SRC=@dbSource">Standard Document Types</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Supplier&DB=@dbname&SRC=@dbSource">Suppliers/Venders</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Customer&DB=@dbname&SRC=@dbSource">Customer</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ConfigDepre&LANG=EN&DB=@dbname&SRC=@dbSource">Standard Depreciation</a>
                </div>
            </div>
            <b>Products Master Files</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Warehouse&DB=@dbname&SRC=@dbSource">Warehouse/Service Group</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ProductType&DB=@dbname&SRC=@dbSource">Product Type</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ProductMas&DB=@dbname&SRC=@dbSource">Products</a>
                </div>
            </div>
            <b>Job System Integrated</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=LinkJobEN&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource"> View current state of data</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=TransferJob_EN&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">Post Data to GL Account</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportJob&DB=@dbname&SRC=@dbSource">Check Data after posted</a>
                </div>
            </div>
            <b>Account Documents</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="~/Form?Form=Lists&DB=@dbname&SRC=@dbSource">List Documents</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="~/Form?DB=@dbname&SRC=@dbSource">Journal Entry</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Transaction&DB=@dbname&SRC=@dbSource">Posting Center</a>
                </div>
            </div>
            <b>Account Reports</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportEN&DB=@dbname&SRC=@dbSource">Summary</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=StockCard&DB=@dbname&SRC=@dbSource">Stock Card</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=StockOnhand&DB=@dbname&SRC=@dbSource">Stock Onhand</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportDepre&LANG=EN&DB=@dbname&SRC=@dbSource&Code=">Depreciation</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportGL&LANG=EN&DB=@dbname&SRC=@dbSource">General Ledger</a>
                </div>
            </div>
            <b>Working Sheet</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance_V2&LANG=EN&DB=@dbname&SRC=@dbSource">Draft Monthly Balance</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance_V2&LANG=EN&DB=@dbname&Type=1&SRC=@dbSource">Calculate Monthly Balance</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance_V2&LANG=EN&DB=@dbname&Type=2&SRC=@dbSource">Accumulate Monthly Balance</a>
                </div>
            </div>
            <b>Accounts Sheet</b>
            Period :
            <br />
            <input type="number" id="txtPeriod" value="@DateTime.Now.Year" />
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('TrialBalance')">Trial Balance</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('ProfitLoss')">Profit and Loss</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('BalanceSheet')">Balance Sheet</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('CashFlow')">Cash Flow</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('ReportCompare','&TYPE=Y')">TB Compare by Year</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('ReportCompare','&TYPE=Q')">TB Compare by Quarter</a>
                </div>
            </div>
        </div>
        <div class="col-sm-12" id="myDashboard" style="padding: 5px 5px 5px 5px; text-align: center;margin-left:10px;margin-right:10px;margin-bottom:5px;">
            @*<img src="~/OverView.png" style="width:100%;" />*@
            <div class="row">
                <div class="col-sm-12">
                    <h4>Operation Overview</h4>
                </div>
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
                            Pending Purchase
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
                            Purchase Total
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
                            Pending Sales
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
                            Sales Total
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
                                    title: 'Supplier',
                                    minValue: 0
                                },
                                vAxis: {
                                    title: 'Purchase Amount'
                                }
                            };
                            var chart = new google.visualization.BarChart(document.getElementById('chartdata3'));
                            chart.draw(data, options);
                        }
                    </script>
                    <div class="card">
                        <div class="card-header bg-primary">
                            TOP 5 - Supplier/Vender
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
                                    title: 'Customer',
                                    minValue: 0
                                },
                                vAxis: {
                                    title: 'Sales Amount'
                                }
                            };
                            var chart = new google.visualization.BarChart(document.getElementById('chartdata4'));
                            chart.draw(data, options);
                        }
                    </script>
                    <div class="card">
                        <div class="card-header bg-primary">
                            TOP 5 - Customer
                        </div>
                        <div class="card-body">                            
                            <div id="chartdata4"></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <h4>Financial Overview</h4>
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
                            Cash Onhand
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
                            Accrued Expenses
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
                            Accrued Revenue
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
                            Sales Profit
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
                      hAxis: {title: 'Year/Month',  titleTextStyle: {color: '#333'}},
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
                            Revenue and Cost
                        </div>
                        <div class="card-body">
                            <div id="areachart1"></div>
                        </div>
                    </div>                    
                </div>
                <div class="col-sm-4">
                    <div class="card">
                        <div class="card-header bg-primary">
                            Source of Cost
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
                sql = "select * from Mas_AccConfig where ConfigCode='PROFILE_CONFIG'"
                Dim configSelector As String = "COMPANY_ADDRESS1_EN,COMPANY_ADDRESS2_EN,COMPANY_EMAIL,COMPANY_FAX,COMPANY_LOGO,COMPANY_NAME_EN,COMPANY_TAXBRANCH,COMPANY_TAXNUMBER,COMPANY_TEL,"
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
    function OpenForm(fname,param='') {
        let period = document.getElementById('txtPeriod').value;
        window.open("?Form=" + fname + "&LANG=EN&DB=@dbname&SRC=@dbSource&Period=" + period + param,'_blank');
    }
</script>