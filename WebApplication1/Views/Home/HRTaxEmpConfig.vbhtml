@Code
    ViewData("Title") = "HRTaxEmpConfig"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable

    Dim sql As String = ""
    Dim msg As String = ""

    Dim configCode As String = ""
    Dim configKey As String = ""
    Dim configValue As String = ""

    If Not Request.Form("Submit") Is Nothing Then
        configCode = Request.Form("ConfigCode")
        configKey = Request.Form("ConfigKey")
        configValue = Request.Form("ConfigValue")

        sql = "
DECLARE @@code varchar(20)='{0}'
IF '{0}'=''
BEGIN
    DECLARE @@maxval int=(SELECT isnull(CAST(MAX(REPLACE(ConfigCode,'SALARY_TAXRATE','')) as int),0)+1 FROM Mas_HRConfig WHERE ConfigCode Like 'SALARY_TAXRATE%')
    SET @@code=CONCAT('SALARY_TAXRATE',@@maxval)

    INSERT INTO Mas_HRConfig
    SELECT @@code,'{1}','{2}'
END
ELSE
BEGIN
    UPDATE Mas_HRConfig
    SET ConfigKey='{1}',ConfigValue='{2}'
    WHERE ConfigCode='{0}'
END
"
        sql = String.Format(sql, configCode, configKey, configValue)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If

    sql = "
select ConfigCode,ConfigKey as RangeOfSalary,ConfigValue as TaxRate from Mas_HRConfig where ConfigCode like 'SALARY_TAXRATE%'
"
    dt = obj.GetDataFromSQL(sql)
End Code

<h2>Employee Tax Config / กำหนดการคิดภาษีของพนักงาน</h2>
<input type="button" value="Add New" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-success" onclick="editData('','0-0','0')" />
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ช่วงเงินเดือน</th>
                <th>อัตราภาษี</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" value="Edit" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-primary"
                               onclick="editData('@dr("ConfigCode")','@dr("RangeOfSalary")','@dr("TaxRate")')" />
                    </td>
                    <td>@dr("RangeOfSalary")</td>
                    <td>@dr("TaxRate")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If
<div class="modal" role="document" id="mdlEdit">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-body">
                <form action="" method="post">                    
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Header</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtConfigCode" name="ConfigCode" value="@configCode" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Range of Salary</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtConfigKey" name="ConfigKey" value="@configKey" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Tax Rate (%)</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtConfigValue" name="ConfigValue" value="@configValue" step="any" inputmode="decimal" class="form-control" />
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
    if(msg !== '') {
        alert(msg);
    }
    function editData(c, k, v) {
        document.getElementById('txtConfigCode').value = c;
        document.getElementById('txtConfigKey').value = k;
        document.getElementById('txtConfigValue').value = v;
    }
</script>
