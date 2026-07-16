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
End Code
<style>
    .banner-foot {
        background-color: #f24544;
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
    }
</style>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
<script type="text/javascript">
    google.charts.load('current', { packages: ['corechart'] });
</script>
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-4" style="padding: 5px 5px 5px 5px;">
            <b>ข้อมูลมาตรฐาน</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Profile&DB=@dbname&SRC=@dbSource">ข้อมูลกิจการ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ConfigAcc&DB=@dbname&SRC=@dbSource">กำหนดมาตรฐานการลงบัญชี</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=DocList&DB=@dbname&SRC=@dbSource">กำหนดมาตรฐานเอกสารต้นทาง</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Warehouse&DB=@dbname&SRC=@dbSource">ข้อมูลคลังสินค้า/กลุ่มงานบริการ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ProductType&DB=@dbname&SRC=@dbSource">ประเภทสินค้าและยริการ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ConfigDepre&LANG=TH&DB=@dbname&SRC=@dbSource">มาตรฐานค่าเสื่อมราคา</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ProductMas&DB=@dbname&SRC=@dbSource">ข้อมูลสินค้าและยริการ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Supplier&DB=@dbname&SRC=@dbSource">ข้อมูลผู้จำหน่าย/ผู้ให้บริการ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Customer&DB=@dbname&SRC=@dbSource">ข้อมูลลูกค้า</a>
                </div>
            </div>
            <b>เชื่อมต่อข้อมูลกับระบบ Job</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=LinkJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">เช็คยอดที่จะลงบันทึกบัญชีคร่าวๆ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=TransferJob_TH&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">ดึงรายการไประบบบัญชีแยกประเภท</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportJob&DB=@dbname&SRC=@dbSource">เช็คยอดหลังจากดึงรายการไประบบบัญชี</a>
                </div>
            </div>
            <b>เอกสารทางบัญชี</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="~/Form?Form=Lists&DB=@dbname&SRC=@dbSource">รายการเอกสาร</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="~/Form?DB=@dbname&SRC=@dbSource">สมุดรายวันทั่วไป</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Transaction&DB=@dbname&SRC=@dbSource">ผ่านรายการไปสมุดรายวัน</a>
                </div>
            </div>
            <b>รายงานสรุปทางบัญชี</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Report&DB=@dbname&SRC=@dbSource">ภาพรวม</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=StockCard&DB=@dbname&SRC=@dbSource">สต๊อกการ์ด</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=StockOnhand&DB=@dbname&SRC=@dbSource">สินค้าคงเหลือ</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportDepre&LANG=TH&DB=@dbname&SRC=@dbSource&Code=">สรุปค่าเสื่อมราคา</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ReportGL&DB=@dbname&SRC=@dbSource">รายงานแยกประเภททั่วไป</a>
                </div>
            </div>
            <b>กระดาษทำการ</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance_V2&DB=@dbname&SRC=@dbSource">ยอดเคลื่อนไหวสิ้นเดือน</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance_V2&DB=@dbname&Type=1&SRC=@dbSource">สรุปยอดคงเหลือสิ้นเดือน</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=MonthlyBalance_V2&DB=@dbname&Type=2&SRC=@dbSource">สรุปยอดยกไปสิ้นเดือน</a>
                </div>
            </div>
            <b>งบการเงิน</b>
            ประจำปี(ค.ศ) : <input type="number" id="txtPeriod" value="@DateTime.Now.Year" />
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('TrialBalance')">งบทดลอง</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('ProfitLoss')">งบกำไรขาดทุน</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('BalanceSheet')">งบแสดงสถานะทางการเงิน</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('CashFlow')">งบกระแสเงินสด</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('ReportCompare','&TYPE=Y')">งบเปรียบเทียบรายปี</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="#" onclick="OpenForm('ReportCompare','&TYPE=Q')">งบเปรียบเทียบตามไตรมาส</a>
                </div>
            </div>
        </div>
        <div class="col-sm-8" style="padding: 5px 5px 5px 5px; text-align: center;">
            @*<img src="~/OverView.png" style="width:100%;" />*@
            <h4>ภาพรวมการดำเนินงาน</h4>
            <div class="row">
                <div class="col-sm-3 card">
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
                    <b>ใบสั่งซื้อคงค้าง</b>
                    <br />
                    @sumPO.ToString("N2")
                </div>
                <div class="col-sm-3 card">
                    @Code
                        sql = "select isnull(sum(a.TotalNet),0) as TotalPO from vPO_H a where a.DocStatus<>99"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumPO = dt.Rows(0).Item("TotalPO")
                        End If
                    End Code
                    <b>ยอดซื้อ</b>
                    <br />
                    @sumPO.ToString("N2")
                </div>
                <div class="col-sm-3 card">
                    @Code
                        sql = "select isnull(sum(a.TotalAmount+a.VatAmount-a.WhtAmount),0) as TotalSR from vSR_D a where a.DocStatus<>99
and not exists(select 1 from vSO_D where AccSourceDocNo=a.AccdocNo and AccSourceDocItem=a.AccItemNo)"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumSO = dt.Rows(0).Item("TotalSR")
                        End If
                    End Code
                    <b>ใบสั่งขายคงค้าง</b>
                    <br />
                    @sumSO.ToString("N2")
                </div>
                <div class="col-sm-3 card">
                    @Code
                        sql = "select isnull(sum(a.TotalNet),0) as TotalSO from vSO_H a where a.DocStatus<>99"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumSO = dt.Rows(0).Item("TotalSO")
                        End If
                    End Code
                    <b>ยอดขาย</b>
                    <br />
                    @sumSO.ToString("N2")
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6 card">
                    <b>TOP 5 - ผู้จำหน่าย</b>
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
                                title: '5 อันดับยอดสั่งซื้อ',
                                chartArea: { width: '50%' },
                                hAxis: {
                                    title: 'ผู้จำหน่าย',
                                    minValue: 0
                                },
                                vAxis: {
                                    title: 'ยอดสั่งซื้อ'
                                }
                            };
                            var chart = new google.visualization.BarChart(document.getElementById('chartdata3'));
                            chart.draw(data, options);
                        }
                    </script>
                    <div id="chartdata3" style="width:100%"></div>
                </div>
                <div class="col-sm-6 card">
                    <b>TOP 5 - ลูกค้า</b>
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
                                title: '5 อันดับยอดขาย',
                                chartArea: { width: '50%' },
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
                    <div id="chartdata4" style="width:100%"></div>
                </div>
            </div>
            <h4>ภาพรวมทางการเงิน</h4>
            <div class="row">
                <div class="col-sm-3 card">
                    @Code
                        sql = "select sum(debit-credit) as CashBalance from vSum_Balance where AccCode like '" & cashGroup & "'"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumCash = dt.Rows(0).Item("CashBalance")
                        End If
                    End Code
                    <b>เงินสดคงเหลือ</b>
                    <br />
                    @sumCash.ToString("N2")
                </div>
                <div class="col-sm-3 card">
                    @Code
                        sql = "select sum(credit-debit) as PayablesBalance from vSum_Balance where AccCode like '" & payablesGroup & "'"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumPayables = dt.Rows(0).Item("PayablesBalance")
                        End If
                    End Code
                    <b>ค่าใช้จ่ายค้างจ่าย</b>
                    <br />
                    @sumPayables.ToString("N2")
                </div>
                <div class="col-sm-3 card">
                    @Code
                        sql = "select sum(debit-credit) as ReceivablesBalance from vSum_Balance where AccCode like '" & receivablesGroup & "'"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumReceivables = dt.Rows(0).Item("ReceivablesBalance")
                        End If
                    End Code
                    <b>รายได้ค้างรับ</b>
                    <br />
                    @sumReceivables.ToString("N2")
                </div>
                <div class="col-sm-3 card">
                    @Code
                        sql = "select sum(Credit-Debit) as BaseProfit from vSum_Balance where substring(AccCode,1,1) in('4','5')"
                        dt = obj.GetDataFromSQL(sql)
                        If dt.Rows.Count > 0 Then
                            sumProfit = dt.Rows(0).Item("BaseProfit")
                        End If
                    End Code
                    <b>กำไรจากการดำเนินงาน</b>
                    <br />
                    @sumProfit.ToString("N2")
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
                      title: 'ภาพรวมรายรับ-รายจ่าย',
                      hAxis: {title: 'ปี/เดือน',  titleTextStyle: {color: '#333'}},
                      vAxis: {minValue: 0}
                    };

                    var chart = new google.visualization.AreaChart(document.getElementById('areachart1'));
                    chart.draw(data, options);
                }
                function drawChart2() {
                    var data = google.visualization.arrayToDataTable(@Html.Raw(chartData2));
                    var options = {
                        title: 'สัดส่วนค่าใช้จ่าย',
                        pieHole: 0.4,
                    };

                    var chart = new google.visualization.PieChart(document.getElementById('donutchart1'));
                    chart.draw(data, options);
                }
            </script>
            <div class="row">
                <div class="col-sm-8 card">
                    <div id="areachart1" style="width: 100%;"></div>
                </div>
                <div class="col-sm-4 card">
                    <div id="donutchart1" style="width: 100%;"></div>
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
    function OpenForm(fname,param='') {
        let period = document.getElementById('txtPeriod').value;
        window.open("?Form=" + fname + "&LANG=TH&DB=@dbname&SRC=@dbSource&Period=" + period + param,'_blank');
    }
</script>
