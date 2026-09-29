@Code
    ViewData("Title") = "PayrollConfig"
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

    Dim positionId As Integer = 0
    Dim contractTypeId As Integer = 0
    Dim salaryPerHour As Double = 0
    Dim salaryPerDay As Double = 0
    Dim salaryPerMonth As Double = 0
    Dim otPerHour As Double = 0
    Dim otPerDay As Double = 0
    Dim latePerHour As Double = 0
    Dim latePerDay As Double = 0
    Dim bonusRate As Double = 0
    Dim bonusCalType As Integer = 0
    Dim promoteRateType As Integer = 0
    Dim promoteValue As Double = 0
    Dim positionIncomeFix As Double = 0

    Dim sql As String = ""
    Dim msg As String = ""

    If Not Request.Form("Submit") Is Nothing Then
        positionId = Request.Form("PositionId")
        contractTypeId = Request.Form("ContractTypeId")
        salaryPerHour = Request.Form("SalaryPerHour")
        salaryPerDay = Request.Form("SalaryPerDay")
        salaryPerMonth = Request.Form("SalaryPerMonth")
        otPerHour = Request.Form("OtPerHour")
        otPerDay = Request.Form("OtPerDay")
        latePerHour = Request.Form("LatePerHour")
        latePerDay = Request.Form("LatePerDay")
        bonusRate = Request.Form("BonusRate")
        bonusCalType = Request.Form("BonusCalType")
        promoteRateType = Request.Form("PromoteRateType")
        promoteValue = Request.Form("PromoteValue")
        positionIncomeFix = Request.Form("PositionIncomeFix")

        sql = "
IF NOT EXISTS(select 1 from Mas_HRPayrollConfig WHERE PositionId={0} AND ContractTypeId={1})
BEGIN
    INSERT INTO Mas_HRPayrollConfig
    SELECT {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}
END
ELSE
BEGIN
    UPDATE Mas_HRPayrollConfig
    SET 
        SalaryPerHour={2}
        ,SalaryPerDay={3}
        ,SalaryPerMonth={4}
        ,OtPerHour={5}
        ,OtPerDay={6}
        ,LatePerHour={7}
        ,LatePerDay={8}
        ,BonusRate={9}
        ,BonusCalType={10}
        ,PromoteRateType={11}
        ,PromoteValue={12}
        ,PositionIncomeFix={13}
    WHERE PositionId={0} AND ContractTypeId={1}
END
"
        sql = String.Format(sql,
            positionId,
            contractTypeId,
            salaryPerHour,
            salaryPerDay,
            salaryPerMonth,
            otPerHour,
            otPerDay,
            latePerHour,
            latePerDay,
            bonusRate,
            bonusCalType,
            promoteRateType,
            promoteValue,
            positionIncomeFix
        )
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            msg = "Save Successfully"
        End If
        Response.StatusCode = 200
        Response.SuppressFormsAuthenticationRedirect = True
    End If

    sql = "
select
a.*,b.PositionName,
c.ContractType
from
Mas_HRPayRollConfig a
inner join Mas_HRPosition b
on a.PositionId=b.PositionId
inner join Mas_HRContractType c
on a.ContractTypeId=c.ContractTypeId
"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Payroll Config / กำหนดค่าเงินเดือน</h2>
@If dt.Rows.Count > 0 Then
    @<div class="row">
        <div class="col-sm-6">
            <table class="table table-bordered table-striped">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>ตำแหน่ง</th>
                        <th>ประเภทสัญญา</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt.Rows
                        @<tr>
                            <td>
                                <input type="button" value="Edit" class="btn btn-sm btn-primary" 
                                       onclick="editData(
    '@dr("PositionId")', '@dr("ContractTypeId")',
    '@dr("SalaryPerHour")', '@dr("SalaryPerDay")', '@dr("SalaryPerMonth")',
    '@dr("OtPerHour")', '@dr("OtPerDay")',
    '@dr("LatePerHour")', '@dr("LatePerDay")',
    '@dr("BonusRate")', '@dr("BonusCalType")',
    '@dr("PromoteRateType")', '@dr("PromoteValue")',
    '@dr("PositionIncomeFix")'
    )"
                                       />
                            </td>
                            <td>@dr("PositionName")</td>
                            <td>@dr("ContractType")</td>
                        </tr>
                    Next
                </tbody>
            </table>
        </div>
        <div class="col-sm-6">
            <form action="" method="post">
                <div class="row">
                    <div class="col-sm-4">
                        <label>Position</label>
                    </div>
                    <div class="col-sm-8">
                        <select id="txtPositionId" name="PositionId" class="form-control dropdown">
                            <option value=""></option>
                            @Code
                                Dim dtPos = obj.GetDataFromSQL("SELECT * FROM Mas_HRPosition")
                                If dtPos.Rows.Count > 0 Then
                                    For Each dr As System.Data.DataRow In dtPos.Rows
                                        @<option value="@dr("PositionId")" @IIf(dr("PositionId").ToString.Equals(positionId.ToString), "selected", "")>
                                            @dr("PositionName")
                                        </option>
                                    Next
                                End If
                            End Code
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Contract Type</label>
                    </div>
                    <div class="col-sm-8">
                        <select id="txtContractTypeId" name="ContractTypeId" class="form-control dropdown">
                            <option value=""></option>
                            @Code
                                Dim dtContract = obj.GetDataFromSQL("SELECT * FROM Mas_HRContractType")
                                If dtContract.Rows.Count > 0 Then
                                    For Each dr As System.Data.DataRow In dtContract.Rows
                                        @<option value="@dr("ContractTypeId")" @IIf(dr("ContractTypeID").ToString().Equals(contractTypeId.ToString), "selected", "")>@dr("ContractType")</option>
                                    Next
                                End If
                            End Code
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Salary/Hour</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtSalaryPerHour" name="SalaryPerHour" value="@salaryPerHour" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Salary/Day</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtSalaryPerDay" name="SalaryPerDay" value="@salaryPerDay" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Salary/Month</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtSalaryPerMonth" name="SalaryPerMonth" value="@salaryPerMonth" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Overtime/Hour</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtOtPerHour" name="OtPerHour" value="@otPerHour" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Overtime/Day</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtOtPerDay" name="OtPerDay" value="@otPerDay" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Late/Hour</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtLatePerHour" name="LatePerHour" value="@latePerHour" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Late/Day</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtLatePerDay" name="LatePerDay" value="@latePerDay" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Bonus Calculation</label>
                    </div>
                    <div class="col-sm-8">
                        <select id="txtBonusCalType" name="BonusCalType" class="form-control dropdown">
                            @Code
                                Dim dtCalType = obj.GetDataFromSQL("SELECT ConfigKey as CalType,ConfigValue as ConfigName FROM Mas_HRConfig WHERE ConfigCode='BONUS_TYPE'")
                                For Each dr As Data.DataRow In dtCalType.Rows
                                    @<option value="@dr("CalType")" @IIf(bonusCalType.ToString.Equals(dr("CalType")), "selected", "")>@dr("ConfigName")</option>
                                Next
                            End Code
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Bonus Rate</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtBonusRate" name="BonusRate" value="@BonusRate" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Promotion Period</label>
                    </div>
                    <div class="col-sm-8">
                        <select id="txtPromoteRateType" name="PromoteRateType" class="form-control dropdown">
                            @Code
                                Dim dtPromType = obj.GetDataFromSQL("SELECT ConfigKey as CalType,ConfigValue as ConfigName FROM Mas_HRConfig WHERE ConfigCode='PROMOTE_TYPE'")
                                For Each dr As Data.DataRow In dtPromType.Rows
                                    @<option value="@dr("CalType")" @IIf(promoteRateType.ToString.Equals(dr("CalType")), "selected", "")>@dr("ConfigName")</option>
                                Next
                            End Code
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Promote Amount</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtPromoteValue" name="PromoteValue" value="@promoteValue" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Position Fix Income</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" class="form-control" id="txtPositionIncomeFix" name="PositionIncomeFix" value="@positionIncomeFix" step="any" inputmode="decimal"  />
                    </div>
                </div>
                <input type="submit" name="submit" value="Save" class="btn btn-primary" />
            </form>
        </div>
    </div>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If
<script type="text/javascript">
    var msg = "@msg";
    if (msg !== '') {
        alert(msg);
    }
    function editData(pid, cid, sh, sd, sm, oh, od, lh, ld, br, bc, pr, pv, pi) {
        document.getElementById('txtPositionId').value = pid;
        document.getElementById('txtContractTypeId').value = cid;
        document.getElementById('txtSalaryPerHour').value = sh;
        document.getElementById('txtSalaryPerDay').value = sd;
        document.getElementById('txtSalaryPerMonth').value = sm;
        document.getElementById('txtOtPerHour').value = oh;
        document.getElementById('txtOtPerDay').value = od;
        document.getElementById('txtLatePerHour').value = lh;
        document.getElementById('txtLatePerDay').value = ld;
        document.getElementById('txtBonusRate').value = br;
        document.getElementById('txtBonusCalType').value = bc;
        document.getElementById('txtPromoteRateType').value = pr;
        document.getElementById('txtPromoteValue').value = pv;
        document.getElementById('txtPositionIncomeFix').value = pi;
    }
</script>
