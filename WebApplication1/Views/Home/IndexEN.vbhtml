@Code
    ViewData("Title") = "Home Page"
    Dim dbname = "job_demo"
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = "AccConcept"
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
End Code
<div class="container">
    <b>Job System Integrated</b>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=LinkJobEN&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert"> View current state of data</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=TransferJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert">Post Data to GL Account</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=CheckJobEN&DB=@dbname">Check Data after posted</a>
        </div>
    </div>
    <b>Account Reports</b>
    <div class="row">
        <div class="col-md-4">
            <a href="AccReport/Form">Journal Entry</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=ReportGL&LANG=EN&DB=@dbname">General Ledger</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname">Trial Balance (Draft)</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname&Type=1">Trial Balance (Calculated)</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname&Type=2">Trial Balance (Final)</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=ProfitLoss&LANG=EN&DB=@dbname">Profit and Loss</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=BalanceSheet&LANG=EN&DB=@dbname">Balance Sheet</a>
        </div>
    </div>
</div>
