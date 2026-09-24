@Code
    ViewData("Title") = "HRCompany"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim bConn = obj.IsConnect()
    Dim msg As String = ""

    Dim companyId As Integer = 0
    Dim companyTaxId As String = ""
    Dim companyTaxBranch As String = ""
    Dim companyName As String = ""
    Dim companyNameEN As String = ""
    Dim headCompanyId As Integer = 0
    Dim countryCode As String = ""
    Dim sql As String = "IF NOT EXISTS(SELECT 1 FROM [dbo].[Mas_Company] where [CompanyId]='{0}')
BEGIN
DECLARE @@MaxCompanyId INT=(SELECT ISNULL(MAX([CompanyId]),0)+1 FROM [dbo].[Mas_Company])
SET IDENTITY_INSERT [dbo].[Mas_Company] ON
INSERT INTO [dbo].[Mas_Company]
   ([CompanyId]
   ,[CompanyTaxId]
   ,[CompanyTaxBranch]
   ,[CompanyName]
   ,[CompanyNameEN]
   ,[HeadCompanyId]
   ,[CountryCode])
 VALUES(
    @@MaxCompanyId
    ,'{1}'
    ,'{2}'
    ,'{3}'
    ,'{4}'
    ,'{5}'
    ,'{6}'
    )
SET IDENTITY_INSERT [dbo].[Mas_Company] OFF
END
ELSE
BEGIN
UPDATE [dbo].[Mas_Company]
SET
[CompanyTaxId] = '{1}'
,[CompanyTaxBranch] = '{2}'
,[CompanyName] = '{3}'
,[CompanyNameEN] = '{4}'
,[HeadCompanyId] = {5}
,[CountryCode] = '{6}'
WHERE [CompanyId] = '{0}'
END
"
    If Not Request.Form("submit") Is Nothing Then
        companyId = Convert.ToInt32(Request.Form("companyId"))
        companyTaxId = Request.Form("companyTaxId")
        companyTaxBranch = Request.Form("companyTaxBranch")
        companyName = Request.Form("companyName")
        companyNameEN = Request.Form("companyNameEN")
        headCompanyId = Convert.ToInt32(Request.Form("headCompanyId"))
        countryCode = Request.Form("countryCode")
        sql = String.Format(sql, companyId, companyTaxId, companyTaxBranch, companyName, companyNameEN, headCompanyId, countryCode)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If
    Dim dt As New Data.DataTable
    dt = obj.GetDataFromSQL("SELECT [CompanyId]
,[CompanyTaxId]
,[CompanyTaxBranch]
,[CompanyName]
,[CompanyNameEN]
,[HeadCompanyId]
,[CountryCode] FROM [dbo].[Mas_Company]")
End Code
<h2>Company</h2>
<input type="button" value="Add New Company" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-success" onclick="editCompany(0,'','','','','','')" />
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Tax.Id</th>
                <th>Tax.Branch</th>
                <th>Name</th>
                <th>Name (EN)</th>
               <th>Country</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            @For Each row As Data.DataRow In dt.Rows
                @<tr>
                    <td><input type="button" value="Edit" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-primary" onclick="editCompany('@row("CompanyId")','@row("CompanyTaxId")','@row("CompanyTaxBranch")','@row("CompanyName")','@row("CompanyNameEN")','@row("HeadCompanyId")','@row("CountryCode")')" /></td>
                    <td>@row("CompanyTaxId")</td>
                    <td>@row("CompanyTaxBranch")</td>
                    <td>@row("CompanyName")</td>
                    <td>@row("CompanyNameEN")</td>
                    <td>@row("CountryCode")</td>
                    <td><a href="?Form=HRDivision&SRC=@dbSource&DB=@dbname&Company=@row("CompanyId")" class="btn btn-info">Division</a></td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning">No data found.</div>
End If
<div id="mdlEdit" class="modal" role="document">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Edit Company
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblCompanyId">Company ID / รหัสบริษัท</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" name="companyId" value="@companyId" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblCompanyTaxId">Tax ID / รหัสประจำตัวผู้เสียภาษี</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" name="companyTaxId" value="@companyTaxId" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblCompanyTaxBranch">Tax Branch / สาขา</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" name="companyTaxBranch" value="@companyTaxBranch" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblCompanyName">Name / ชื่อบริษัท</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" name="companyName" value="@companyName" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblCompanyNameEN">Name (EN) / ชื่อบริษัท (EN)</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" name="companyNameEN" value="@companyNameEN" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblHeadCompanyId">Head Company / บริษัทแม่</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" class="form-control" name="headCompanyId" value="@headCompanyId" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label id="lblCountryCode">Country / รหัสประเทศ</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" name="countryCode" value="@countryCode" />
                        </div>
                    </div>
                    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
                </form>
            </div>
            <div class="modal-footer">
                <div style="float:right">
                    <input type="button" class="btn btn-danger" value="X" data-dismiss="modal" />
                </div>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var msg = '@msg';
    if (msg !== '') {
            alert(msg);
    }
    function editCompany(Id, TaxId, TaxBranch, Name, NameEN, HeadId, Country) {
        document.getElementsByName('companyId')[0].value = Id;
        document.getElementsByName('companyTaxId')[0].value = TaxId;
        document.getElementsByName('companyTaxBranch')[0].value = TaxBranch;
        document.getElementsByName('companyName')[0].value = Name;
        document.getElementsByName('companyNameEN')[0].value = NameEN;
        document.getElementsByName('headCompanyId')[0].value = HeadId;
        document.getElementsByName('countryCode')[0].value = Country;
    }
</script>