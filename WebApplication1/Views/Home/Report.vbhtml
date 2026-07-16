@Code
    ViewData("Title") = "Report"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim sql As String = "select * from (
	select b.AccMainCode,b.AccMainName,
	case when sum(a.Debit)>sum(a.credit) then sum(a.Debit)-sum(a.Credit) else 0 end as Debit,
	case when sum(a.Debit)<sum(a.credit) then sum(a.Credit)-sum(a.Debit) else 0 end as Credit
	from vSum_Balance a
	left join vMas_AccCode b on concat(substring(a.AccCode,1,4),'-00')=b.AccCode
	group by b.AccMainCode,b.AccMainName
) t where Debit+Credit<>0
order by 1"
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New System.Data.DataTable

    dt = obj.GetDataFromSQL(sql)
    Dim sumIncome As Decimal = 0
    Dim sumExpense As Decimal = 0
    Dim sumAsset As Decimal = 0
    Dim sumLiability As Decimal = 0
    Dim sumAR As Decimal = 0
    Dim sumAP As Decimal = 0
    For Each dr As Data.DataRow In dt.Rows
        If dr("AccMainCode").ToString().StartsWith("4") Then
            sumIncome += Convert.ToDecimal(dr("Credit")) - Convert.ToDecimal(dr("Debit"))
        End If
        If dr("AccMainCode").ToString().StartsWith("5") Then
            sumExpense += Convert.ToDecimal(dr("Debit")) - Convert.ToDecimal(dr("Credit"))
        End If
        If dr("AccMainCode").ToString().StartsWith("1") Then
            sumAsset += Convert.ToDecimal(dr("Debit")) - Convert.ToDecimal(dr("Credit"))
        End If
        If dr("AccMainCode").ToString().StartsWith("2") Then
            sumLiability += Convert.ToDecimal(dr("Credit")) - Convert.ToDecimal(dr("Debit"))
        End If
    Next
    sql = "select 
sum(case when AccCode like '1130%' then Debit else 0 end) as SumAR,
sum(case when AccCode like '2120%' then Credit else 0 end) as SumAP
from vSum_Balance 
where AccCode like '2120%' or AccCode like '1130%'"
    Dim dt2 As Data.DataTable = obj.GetDataFromSQL(sql)
    If dt2.Rows.Count > 0 Then
        sumAR = Convert.ToDecimal(dt2.Rows(0)("SumAR"))
        sumAP = Convert.ToDecimal(dt2.Rows(0)("SumAP"))
    End If
    sql = "select concat(Year(EntryDate),'/',FORMAT(Month(EntryDate),'00')) as Period,
sum(case when AccCode like '5%' then Debit-Credit else 0 end) as Cost,
sum(case when AccCode like '4%' then Credit-Debit else 0 end) as Revenue,
ABS(sum(case when AccCode like '4%' then Credit-Debit else 0 end)-sum(case when AccCode like '5%' then Debit-Credit else 0 end)) as ProfitLoss
from vJournal_All
where AccCode like '4%' or AccCode like '5%'
group by concat(Year(EntryDate),'/',FORMAT(Month(EntryDate),'00'))"
    Dim dt3 As Data.DataTable = obj.GetDataFromSQL(sql)
    Dim arr As New List(Of Object())
    For Each dr As Data.DataRow In dt3.Rows
        arr.Add(New Object() {dr("Period").ToString(), Convert.ToDecimal(dr("Cost")), Convert.ToDecimal(dr("Revenue")), Convert.ToDecimal(dr("ProfitLoss")), ""})
    Next
End Code
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
    google.charts.load("current", { packages: ["corechart"] });
    google.charts.setOnLoadCallback(drawChart1);
    google.charts.setOnLoadCallback(drawChart2);
    google.charts.setOnLoadCallback(drawChart3);
    google.charts.setOnLoadCallback(drawChart4);
    function drawChart1() {
        var data = google.visualization.arrayToDataTable([
            ['Name', 'Value'],
            ['Income', @sumIncome],
            ['Expense', @sumExpense],
            ['Profit', @(Math.Abs(sumIncome - sumExpense))]
        ]);

        var options = {
            title: 'Profit/Loss',
            is3D: true,
        };

        var chart = new google.visualization.PieChart(document.getElementById('piechart1'));
        chart.draw(data, options);
    }

    function drawChart2() {
        var data = google.visualization.arrayToDataTable([
            ['Name', 'Value'],
            ['Asset', @sumAsset],
            ['Liability', @sumLiability]
        ]);

        var options = {
            title: 'Stability',
            is3D: true,
        };

        var chart = new google.visualization.PieChart(document.getElementById('piechart2'));
        chart.draw(data, options);
    }
    function drawChart3() {
        var data = google.visualization.arrayToDataTable([
            ['Name', 'Value'],
            ['Account Receivable', @sumAR],
            ['Account Payable', @sumAP]
        ]);
        var options = {
            title: 'Receivable/Payable',
            is3D: true,
        };
        var chart = new google.visualization.PieChart(document.getElementById('piechart3'));
        chart.draw(data, options);
    }
    function drawChart4() {
        // Create the data table using an array
        var arr = JSON.parse('@Html.Raw(Json.Encode(arr))');
        arr.unshift(['Period', 'Cost', 'Revenue', 'Profit/Loss', { role: 'annotation' }]);
        var data = google.visualization.arrayToDataTable(arr);

        // Configure chart options
        var options = {
            title: 'Compare by Period',
            width: 600,
            height: 400,
            legend: { position: 'top', maxLines: 3 },
            bar: { groupWidth: '75%' },
            // CRITICAL: Activates the stacking behavior
            isStacked: true,
            hAxis: {
                title: 'Profit/loss',
                minValue: 0
            },
            vAxis: {
                title: 'Year'
            }
        };

        // Instantiate and draw the chart inside the targeted <div>
        var chart = new google.visualization.BarChart(document.getElementById('stackchart1'));
        chart.draw(data, options);
    }
</script>
<h2>Summary</h2>
<div class="row">
    <div class="col-sm-6">
        <table style="width:100%" class="table table-responsive table-bordered">
            <thead>
                <tr>
                    <th>Account Code</th>
                    <th>Account Name</th>
                    <th>Debit</th>
                    <th>Credit</th>
                </tr>
            </thead>
            @If dt.Rows.Count > 0 Then
                @For Each dr As System.Data.DataRow In dt.Rows
                    @<tr>
                        <td>@dr("AccMainCode")</td>
                        <td>@dr("AccMainName")</td>
                        <td style="text-align: right">@Convert.ToDecimal(dr("Debit")).ToString("N2")</td>
                        <td style="text-align: right">@Convert.ToDecimal(dr("Credit")).ToString("N2")</td>
                    </tr>
                Next
            End If
        </table>
    </div>
    <div class="col-sm-6">
        <div id="piechart1"></div>
        <div id="piechart2"></div>
    </div>
</div>
<div class="row">
    <div class="col-sm-4">
        <div id="piechart3"></div>
        
    </div>
    <div class="col-sm-8">
        <div id="stackchart1"></div>
    </div>
</div>
<div Class="row">
    <div Class="col-sm-4">
        Date From
        <br />
        <input type="date" id="txtDateFrom" Class="form-control" />
    </div>
    <div Class="col-sm-4">
        Date To
        <br />
        <input type="date" id="txtDateTo" Class="form-control" />
    </div>
    <div Class="col-sm-4">
        Status:
        <br />
        <input type="text" id="txtStatus" Class="form-control" />
    </div>
</div>
<div Class="row">
    <div Class="col-sm-6">
        Name:
        <br />
        <input type="text" id="txtPartyName" Class="form-control" />
    </div>
</div>
<div Class="row">
    <div Class="col-sm-6">
        Report:
        <br />
        <select id="cboReport" class="form-control dropdown">
            <option value="Purchase">Purchase Order Report</option>
            <option value="PI">Purchase Invoice Report</option>
            <option value="PC">Purchase Confirmation Report</option>
            <option value="AgingAP">Purchase Invoice Aging Report</option>
            <option value="Sale">Sale Order Report</option>
            <option value="SI">Sale Invoice Report</option>
            <option value="RC">Sale Receipt Report</option>
            <option value="AgingAR">Sale Invoice Aging Report</option>
            <option value="AR">Account Receiveable Report</option>
            <option value="AP">Account Payable Report</option>
            <option value="Payment">Payment Voucher Report</option>
            <option value="Receive">Receive Voucher Report</option>
            <option value="Journal">Journal Entries Report</option>
            <option value="VATSale">Output VAT Report</option>
            <option value="VATBuy">Input VAT Report</option>
            <option value="WHTax">Withholding Report (Detail)</option>
            <option value="WHTaxSum">Withholding Report (Summary)</option>
            <option value="PRD">PRD Tax Report</option>
        </select>
    </div>
</div>
<input type="button" value="Print" class="btn btn-success" onclick="PrintReport()" />
<script type="text/javascript">
    function PrintReport() {
        let reportName = document.getElementById('cboReport').value;
        let dateFrom = document.getElementById('txtDateFrom').value;
        let dateTo = document.getElementById('txtDateTo').value;
        let status = document.getElementById('txtStatus').value;
        let partyName = document.getElementById('txtPartyName').value;
        window.open('?DB=@dbname&SRC=@dbSource&Form=Report' + reportName + (dateFrom == '' ? '' : '&DateFrom=' + dateFrom) + (dateTo == '' ? '' : '&DateTo=' + dateTo) + (status == '' ? '' : '&Status=' + status) + (partyName == '' ? '' :'&Query='+partyName), '');
    }
</script>