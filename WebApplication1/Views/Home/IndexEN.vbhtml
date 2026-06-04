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
<style>
    .banner-foot {
        background-color: #f24544; 
        padding:10px 5px 5px 5px;
    }
    .banner-foot b {
        color:yellow !important;
    }
</style>
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-4" style="padding: 5px 5px 5px 5px;">
            <b>Master Files</b>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=Profile&DB=@dbname&SRC=@dbSource">Company Profile</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ConfigAcc&DB=@dbname&SRC=@dbSource">Standard Entry</a>
                </div>
            </div>
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
                    <a href="?Form=ConfigDepre&LANG=EN&DB=@dbname&SRC=@dbSource">Standard Depreciation</a>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="?Form=ProductMas&DB=@dbname&SRC=@dbSource">Products</a>
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
                    <a href="?Form=Report&DB=@dbname&SRC=@dbSource">Transaction Report</a>
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
        <div class="col-sm-8" style="padding:5px 5px 5px 5px;text-align:center;">
            <img src="~/OverView.png" style="width:100%;" />
        </div>
    </div>
</div>
<div class="container-fluid">
    <div class="row banner-foot">
        <div class="col-sm-8">
            @Code
                Dim logoName As String = ""
                Dim sql = "select * from Mas_AccConfig where ConfigCode='PROFILE_CONFIG'"
                Dim configSelector As String = "COMPANY_ADDRESS1_EN,COMPANY_ADDRESS2_EN,COMPANY_EMAIL,COMPANY_FAX,COMPANY_LOGO,COMPANY_NAME_EN,COMPANY_TAXBRANCH,COMPANY_TAXNUMBER,COMPANY_TEL,"
                Dim dt = New AccReport.CUtil(ViewBag.WebIP, dbSource).GetDataFromSQL(sql)
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
    function OpenForm(fname) {
        let period = document.getElementById('txtPeriod').value;
        window.open("?Form=" + fname + "&LANG=EN&DB=@dbname&SRC=@dbSource&Period=" + period,'_blank');
    }
</script>