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
End Code
<h2>Report</h2>
<div class="row">
    <div class="col-sm-4">
        Date From:
        <br />
        <input type="date" id="txtDateFrom" class="form-control" />
    </div>
    <div class="col-sm-4">
        Date To:
        <br />
        <input type="date" id="txtDateTo" class="form-control" />
    </div>
    <div class="col-sm-4">
        Status:
        <br />
        <input type="text" id="txtStatus" class="form-control" />
    </div>
</div>
<div class="row">
    <div class="col-sm-6">
        Name:
        <br />
        <input type="text" id="txtPartyName" class="form-control" />
    </div>
</div>
<div class="row">
    <div class="col-sm-6">
        Report:
        <br />
        <select id="cboReport" class="form-control dropdown">
            <option value="Purchase">Purchase Report</option>
            <option value="Sale">Sale Report</option>
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
        window.open('?DB=@dbname&SRC=@dbSource&Form=Report' + reportName + (dateFrom == '' ? '' : '&DateFrom=' + dateFrom) + (dateTo == '' ? '' : '&DateTo=' + dateTo) + (status == '' ? '' : '&Status=' + status) + (partyName == '' ? '' :'&PartyName='+partyName), '');
    }
</script>