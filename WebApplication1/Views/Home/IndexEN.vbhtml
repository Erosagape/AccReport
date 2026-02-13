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
End Code
<div style="display:flex;padding:5px 5px 5px 5px;">
    <div style="flex:1;background-color:lightyellow;">
        <b>Master Files</b>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=Profile&SRC=@dbSource">Company Profile</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=ConfigAcc&SRC=@dbSource">Standard Entry</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=ProductMas&SRC=@dbSource">Products</a>
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
        <b>Job System Integrated</b>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=LinkJobEN&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource"> View current state of data</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=TransferJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">Post Data to GL Account</a>
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
                <a href="?Form=StockCard&SRC=@dbSource">Stock Card</a>
            </div>
        </div>
        <b>Account Reports</b>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=Report&DB=@dbname&SRC=@dbSource">Transaction Report</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=StockOnhand&DB=@dbname&SRC=@dbSource">Stock Onhand</a>
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
                <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname&SRC=@dbSource">Draft Monthly Balance</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname&Type=1&SRC=@dbSource">Calculate Monthly Balance</a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname&Type=2&SRC=@dbSource">Accumulate Monthly Balance</a>
            </div>
        </div>
        <b>Account Sheet</b>
        Period : <input type="number" id="txtPeriod" value="@DateTime.Now.Year" />
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
    </div>
    <div style="flex:3">
        @Code
            Dim sql = "select * from Mas_AccConfig where ConfigCode='PROFILE_CONFIG'"
            Dim dt = New AccReport.CUtil(".", dbSource).GetDataFromSQL(sql)
            If dt.Rows.Count > 0 Then
                Dim logoName As String = ""
                @<div class="panel" style="background-color:lightcyan;">
                    @For each dr As Data.DataRow In dt.Rows
                        If dr("ConfigKey").Equals("COMPANY_LOGO") Then
                            If dr("ConfigValue").ToString() <> "" Then
                                logoName = dr("ConfigValue").ToString()
                            End If
                        End If
                        @<div class="row">
                            <div class="col-sm-4">
                                <b>@dr("ConfigKey")</b>
                            </div>
                            <div class="col-sm-8">
                                @dr("ConfigValue")
                            </div>
                        </div>
                    Next
                </div>
                If logoName <> "" Then
                    @<img src="~/@logoName" style="width:200px;" />
                End If
            End If
        End Code
    </div>
</div>
<script type="text/javascript">
    function OpenForm(fname) {
        let period = document.getElementById('txtPeriod').value;
        window.open("?Form=" + fname + "&LANG=EN&DB=@dbname&SRC=@dbSource&Period=" + period,'_blank');
    }
</script>