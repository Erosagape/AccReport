@Code
    ViewData("Title") = "ReportPRD"
    Dim yy As Integer = Now.Year
    Dim mm As Integer = Now.Month
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
End Code
<h2>Report PRD Witholding-Tax</h2>
<div class="container">
    <div class="row">
        <div class="col-sm-6">
            <b>Year</b>
            <br />
            <input type="number" id="txtYear" value="@yy" />
        </div>
<div class="col-sm-6">
    <b>Month</b>
    <select id="txtMonth">
        <option value="1">1</option>
        <option value="2">2</option>
        <option value="3">3</option>
        <option value="4">4</option>
        <option value="5">5</option>
        <option value="6">6</option>
        <option value="7">7</option>
        <option value="8">8</option>
        <option value="9">9</option>
        <option value="10">10</option>
        <option value="11">11</option>
        <option value="12">12</option>
    </select>
</div>
    </div>
    <div class="row">
        <div class="col-sm-6">
            <b>Law Code No#</b>
            <br />
            <select id="txtLawNo">
                <option value="1">3 เตรส</option>
                <option value="2">65 จัดวา</option>
                <option value="3">69 ทวิ</option>
                <option value="4">48 ทวิ</option>
                <option value="5">50 ทวิ</option>
            </select>
        </div>
        <div class="col-sm-6">
            <b>Tax Number</b>
            <br />
            <input type="text" id="txtTaxNo" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <b>Select Report</b>
            <select id="cboReport">
                <option value="WHTax3">PRD 3 - Cover</option>
                <option value="WHTax3D">PRD 3 - Detail</option>
                <option value="WHTax53">PRD 53 - Cover</option>
                <option value="WHTax53D">PRD 53 - Detail</option>
            </select>
        </div>
    </div>
    <input type="button" class="btn btn-success" value="Print" onclick="PrintReport()" />
    <input type="button" class="btn btn-primary" value="Export Flat File" onclick="ExportData()" />
</div>
<script>
    function PrintReport() {
        let reportName = document.getElementById('cboReport').value;
        let yy = document.getElementById('txtYear').value;
        let mm = document.getElementById('txtMonth').value;
        let lno = document.getElementById('txtLawNo').value;
        let tno = document.getElementById('txtTaxNo').value;
        window.open('~/Form?DB=@dbname&SRC=@dbSource&Form=Report' + reportName + '&Year=' + yy +'&Month='+mm +'&LawNo=' + lno + '&TaxNo=' + tno, '');
    }
    function ExportData() {
        window.open('?Form=WHTaxExp&DB=@dbname&SRC=@dbSource', '');
    }
</script>