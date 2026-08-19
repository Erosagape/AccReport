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
isnull(sum(case when AccCode like '1130%' then Debit else 0 end),0) as SumAR,
isnull(sum(case when AccCode like '2120%' then Credit else 0 end),0) as SumAP
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
group by concat(Year(EntryDate),'/',FORMAT(Month(EntryDate),'00'))
order by 1"
    Dim dt3 As Data.DataTable = obj.GetDataFromSQL(sql)
    Dim arr As New List(Of Object())
    For Each dr As Data.DataRow In dt3.Rows
        arr.Add(New Object() {dr("Period").ToString(), Convert.ToDecimal(dr("Cost")), Convert.ToDecimal(dr("Revenue")), Convert.ToDecimal(dr("ProfitLoss")), ""})
    Next
End Code
<style>
    .card {
        border: 1px solid #e0e0e0;
        border-radius: 8px; /* Smooth, modern rounding */
        box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); /* Subtle, downward soft shadow */
        font-weight: bolder;
        width: auto;
        margin: 5px 5px 5px 5px;
        padding: 5px 5px 5px 5px;
    }
</style>
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
            ['รายได้', @sumIncome],
            ['ค่าใช้จ่าย', @sumExpense],
            ['กำไรขาดทุน', @(Math.Abs(sumIncome - sumExpense))]
        ]);

        var options = {
            is3D: true,
        };

        var chart = new google.visualization.PieChart(document.getElementById('piechart1'));
        chart.draw(data, options);
    }

    function drawChart2() {
        var data = google.visualization.arrayToDataTable([
            ['Name', 'Value'],
            ['สินทรัพย์', @sumAsset],
            ['หนี้สิน', @sumLiability]
        ]);

        var options = {
            is3D: true,
        };

        var chart = new google.visualization.ColumnChart(document.getElementById('piechart2'));
        chart.draw(data, options);
    }
    function drawChart3() {
        var data = google.visualization.arrayToDataTable([
            ['Name', 'Value'],
            ['ลูกหนี้', @sumAR],
            ['เจ้าหนี้', @sumAP]
        ]);
        var options = {
            is3D: true,
        };
        var chart = new google.visualization.PieChart(document.getElementById('piechart3'));
        chart.draw(data, options);
    }
    function drawChart4() {
        // Create the data table using an array
        var arr = JSON.parse('@Html.Raw(Json.Encode(arr))');
        arr.unshift(['Period', 'ค่าใช้จ่าย', 'รายได้', 'กำไรขาดทุน', { role: 'annotation' }]);
        var data = google.visualization.arrayToDataTable(arr);

        // Configure chart options
        var options = {
            width: 600,
            height: 400,
            legend: { position: 'top', maxLines: 3 },
            bar: { groupWidth: '75%' },
            // CRITICAL: Activates the stacking behavior
            isStacked: true,
            hAxis: {
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
<div class="row">
    <div class="col-sm-6">
        <table style="width:100%" class="table table-responsive table-bordered">
            <thead>
                <tr>
                    <th>รหัสบัญชี</th>
                    <th>ชื่อบัญชี</th>
                    <th>เดบิต</th>
                    <th>เครดิต</th>
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
        <div class="card">
            <div class="card-header">
                ผลการดำเนินงานแต่ละเดือน
            </div>
            <div class="card-body" id="stackchart1"></div>
        </div>        
    </div>
</div>
<div class="row">
    <div class="col-sm-4">        
        <div class="card">
            <div class="card-header">
                กำไรขาดทุน
            </div>
            <div class="card-body" id="piechart1"></div>
        </div>        
    </div>
    <div class="col-sm-4">        
        <div class="card">
            <div class="card-header">
                สินทรัพย์/หนี้สิน
            </div>
            <div class="card-body" id="piechart2"></div>
        </div>
    </div>
    <div class="col-sm-4">
        <div class="card">
            <div class="card-header">
                ลูกหนี้/เจ้าหนี้
            </div>
            <div class="card-body" id="piechart3"></div>
        </div>
    </div>
</div>
<div Class="row">
    <div Class="col-sm-4">
        จากวันที่
        <br />
        <input type="date" id="txtDateFrom" Class="form-control" />
    </div>
    <div Class="col-sm-4">
        ถึงวันที่
        <br />
        <input type="date" id="txtDateTo" Class="form-control" />
    </div>
    <div Class="col-sm-4">
        สถานะ:
        <br />
        <input type="text" id="txtStatus" Class="form-control" />
    </div>
</div>
<div Class="row">
    <div Class="col-sm-6">
        คำค้นชื่อ:
        <br />
        <input type="text" id="txtPartyName" Class="form-control" />
    </div>
</div>
<div Class="row">
    <div Class="col-sm-6">
        รายงาน:
        <br />
        <select id="cboReport" class="form-control dropdown">
            <optgroup label="Purchase Report">
                <option value="Purchase">รายงานใบสั่งซื้อ</option>
                <option value="PI">รายงานใบแจ้งหนี้ค่าใช้จ่าย</option>
            </optgroup>
            <optgroup label="Sale Report">
                <option value="Sale">รายงานใบสั่งขาย</option>
                <option value="SI">รายงานใบแจ้งหนี้ค่าบริการลูกค้า</option>
            </optgroup>
            <optgroup label="Payment Report">
                <option value="PC">รายงานใบเตรียมจ่าย</option>
                <option value="Payment">รายงานใบสำคัญจ่าย</option>
            </optgroup>
            <optgroup label="Payables Report">
                <option value="AgingAP">รายงานอายุเจ้าหนี้</option>
                <option value="AP">รายงานเจ้าหนี้</option>                
            </optgroup>
            <optgroup label="Receive Report">
                <option value="RC">รายงานใบเสร็จรับเงิน</option>
                <option value="Receive">รายงาานใบสำคัญรับ</option>
            </optgroup>
            <optgroup label="Receivables Report">
                <option value="AgingAR">รายงานอายุลูกหนี้</option>
                <option value="AR">รายงานลูกหนี้</option>                
            </optgroup>
            <optgroup label="Journal Report">
                <option value="Journal">รายงานสมุดรายวัน</option>
                <option value="VATSale">รายงานภาษีขาย</option>
                <option value="VATBuy">รายงานภาษีซื้อ</option>
            </optgroup>
            <optgroup label="Tax Report">
                <option value="WHTax">รายงานการหัก ณ ที่จ่าย</option>
                <option value="WHTaxSum">รายงานสรุปการหัก ณ ที่จ่าย</option>
                <option value="PRD">รายงานนำส่งภาษี</option>
            </optgroup>
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