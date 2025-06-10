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
            <a href="?Form=LinkJobEN&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource"> View current state of data</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=TransferJob&DB=@dbname&IDEN=@ViewBag.SetIdentityInsert&SRC=@dbSource">Post Data to GL Account</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=CheckJobEN&DB=@dbname&SRC=@dbSource">Check Data after posted</a>
        </div>
    </div>
    <b>Account Documents</b>
    <div class="row">
        <div class="col-md-4">
            <a href="AccReport/Form?Form=Lists&DB=@dbSource&SRC=@dbSource">List Documents</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="AccReport/Form?DB=@dbSource&SRC=@dbSource">Journal Entry</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="AccReport/?Form=StockCard&SRC=@dbSource">Stock Card</a>
        </div>
    </div>
    <b>Account Reports</b>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=ReportGL&LANG=EN&DB=@dbname&SRC=@dbSource">General Ledger</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname&SRC=@dbSource">Trial Balance (Draft)</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname&Type=1&SRC=@dbSource">Trial Balance (Calculated)</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&LANG=EN&DB=@dbname&Type=2&SRC=@dbSource">Trial Balance (Final)</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=ProfitLoss&LANG=EN&DB=@dbname&SRC=@dbSource">Profit and Loss</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=BalanceSheet&LANG=EN&DB=@dbname&SRC=@dbSource">Balance Sheet</a>
        </div>
    </div>
</div>
