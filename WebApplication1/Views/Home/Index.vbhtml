@Code
    ViewData("Title") = "Home Page"
    Dim dbname = "job_demo"
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
End Code
<div class="container">
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=LinkJob&DB=@dbname">Link Job For Creating G/L</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=TransferJob&DB=@dbname">Transfer Job to G/L</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=CheckJob&DB=@dbname">Check Job Posted To G/L</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname">Trial Balance Monthly (Draft)</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname&Type=1">Trial Balance Monthly (Calculated)</a>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <a href="?Form=MonthlyBalance&DB=@dbname&Type=2">Trial Balance Monthly (Final)</a>
        </div>
    </div>
</div>
