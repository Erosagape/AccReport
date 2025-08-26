@Code
    Layout = Nothing
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil("", dbSource)
    Dim logoFileName = "logo-tawan.jpg"
    Dim companyName = "Tawan Technology Co.,ltd"
    Dim companyAddr1 = "507 SOI BANGNA-TRAD 56,BANGNA-TRAD ROAD"
    Dim companyAddr2 = "SOUTH BANGNA,BANGNA,BANGKOK THAILAND"
    Dim companyTaxNo = "1234567890123"
    Dim companyTaxBranch = "00000"
    Dim dt = obj.GetDataFromSQL("SELECT ConfigValue FROM Mas_AccConfig WHERE ConfigCode='PROFILE_CONFIG' AND ConfigKey='COMPANY_LOGO'")
    If dt.Rows.Count > 0 Then
        logoFileName = dt.Rows(0)(0).ToString()
    End If
    dt = obj.GetDataFromSQL("SELECT ConfigValue FROM Mas_AccConfig WHERE ConfigCode='PROFILE_CONFIG' AND ConfigKey='COMPANY_NAME'")
    If dt.Rows.Count > 0 Then
        companyName = dt.Rows(0)(0).ToString()
    End If

    dt = obj.GetDataFromSQL("SELECT ConfigValue FROM Mas_AccConfig WHERE ConfigCode='PROFILE_CONFIG' AND ConfigKey='COMPANY_ADDRESS1'")
    If dt.Rows.Count > 0 Then
        companyAddr1 = dt.Rows(0)(0).ToString()
    End If

    dt = obj.GetDataFromSQL("SELECT ConfigValue FROM Mas_AccConfig WHERE ConfigCode='PROFILE_CONFIG' AND ConfigKey='COMPANY_ADDRESS2'")
    If dt.Rows.Count > 0 Then
        companyAddr2 = dt.Rows(0)(0).ToString()
    End If

    dt = obj.GetDataFromSQL("SELECT ConfigValue FROM Mas_AccConfig WHERE ConfigCode='PROFILE_CONFIG' AND ConfigKey='COMPANY_TAXNUMBER'")
    If dt.Rows.Count > 0 Then
        companyTaxNo = dt.Rows(0)(0).ToString()
    End If

    dt = obj.GetDataFromSQL("SELECT ConfigValue FROM Mas_AccConfig WHERE ConfigCode='PROFILE_CONFIG' AND ConfigKey='COMPANY_TAXBRANCH'")
    If dt.Rows.Count > 0 Then
        companyTaxBranch = dt.Rows(0)(0).ToString()
    End If
End Code
<style>
    img {
        width: 200px;
    }
</style>
<div class="text-left">
    <div style="display:flex;">
        <div style="padding: 10px 10px 10px 10px;flex:10%">
            <img src="~/@logoFileName" style="width:150px;" />
        </div>
        <div style="padding :5px;flex:90%">
            <b style="font-size:14px">@companyName</b>
            <br />
            <b>@companyAddr1</b>
            <br />
            <b>@companyAddr2</b>
            <br />
            เลขประจำตัวผู้เสียภาษี @companyTaxNo สาขา @companyTaxBranch                           
        </div>
    </div>
</div>


