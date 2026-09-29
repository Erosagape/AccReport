@Code
    ViewData("Title") = "HREmployment"
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
    Dim sql As String = ""
    Dim dt As New Data.DataTable

    Dim companyId As Integer = 0
    If Not Request.QueryString("Company") Is Nothing Then
        companyId = Convert.ToInt16(Request.QueryString("Company"))
    End If
    Dim staffId As Integer = 0
    Dim positionId As Integer = 0
    Dim assignMentDate As DateTime = DateTime.MinValue
    Dim probationDays As Integer = 0
    Dim beginDate As DateTime = DateTime.MinValue
    Dim endDate As DateTime = DateTime.MinValue
    Dim contractType As Integer = 0
    Dim contractNo As String = ""
    Dim contractDays As Integer = 0

    If Not Request.Form("submit") Is Nothing Then
        companyId = Request.Form("CompanyId")
        staffId = Request.Form("StaffId")
        positionId = Request.Form("PositionId")
        assignMentDate = Request.Form("AssignmentDate")
        probationDays = Request.Form("ProbationDays")
        beginDate = Request.Form("BeginDate")
        endDate = Request.Form("EndDate")
        contractType = Request.Form("ContractType")
        contractNo = Request.Form("ContractNo")
        contractDays = Request.Form("ContractDays")
        sql = "
IF NOT EXISTS(select 1 from Mas_HREmployment WHERE CompanyId={0} AND StafFId={1} AND PositionId={2})
BEGIN
INSERT INTO Mas_HREmployment
SELECT {0},{2},{1},'{3}',{4},'{5}','{6}',{7},'{8}',{9}
END
ELSE
BEGIN
UPDATE Mas_HREmployment
SET AssignmentDate='{3}'
,Probationdays={4}
,BeginDate='{5}'
,EndDate='{6}'
,ContractType={7}
,ContractNo='{8}'
,ContractDays={9}
WHERE CompanyId={0} AND StaffId={1} AND PositionId={2}
END
"
        msg = obj.ExecuteSQL(String.Format(sql, companyId, staffId, positionId,
                            assignMentDate, probationDays, beginDate, endDate, contractType, contractNo, contractDays))
        If msg = "OK" Then
            msg = "Save Successfully"
        End If
        Response.StatusCode = 200
        Response.SuppressFormsAuthenticationRedirect = True
    End If

    sql = "SELECT a.[CompanyId]
,a.[PositionId]
,b.[PositionName]
,a.[StaffId]
,concat(c.[StaffName],' ',c.[StaffLastName]) as StaffFullName
,a.[AssignmentDate]
,a.[Probationdays]
,a.[BeginDate]
,a.[EndDate]
,a.[ContractType]
,a.[ContractNo]
,a.[ContractDays]
FROM [Mas_HREmployment] a
inner join [Mas_HRPosition] b
on a.PositionId=b.PositionId
inner join [Mas_HRStaff] c
on a.StaffId=c.StaffId
WHERE a.CompanyId={0}
"
    dt = obj.GetDataFromSQL(String.Format(sql, companyId))
End Code
<h2>Position Employment / บันทึกตำแหน่งงาน</h2>
<input type="button" value="Add New Data" class="btn btn-sm btn-primary" data-toggle="modal" data-target="#mdlEdit"
       onclick="editData('@companyId', '0', '0', '', '0', '', '', '0', '','0')" />
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Position</th>
                <th>Staff Name</th>
                <th>Begin Date</th>
                <th>End Date</th>
                <th>Contract No</th>
            </tr>
        </thead>
        <tbody>
            @For each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" value="Edit" class="btn btn-sm btn-primary" data-toggle="modal" data-target="#mdlEdit"
                               onclick="editData('@dr("CompanyId")', '@dr("StaffId")', '@dr("PositionId")'
    , '@Convert.ToDateTime(dr("AssignmentDate")).ToString("yyyy-MM-dd")',
    '@dr("ProbationDays")',
    '@Convert.ToDateTime(dr("BeginDate")).ToString("yyyy-MM-dd")',
    '@Convert.ToDateTime(dr("EndDate")).ToString("yyyy-MM-dd")',
    '@dr("ContractType")', '@dr("ContractNo")'
    ,'@dr("ContractDays")')" />
                    </td>
                    <td>@dr("PositionName")</td>
                    <td>@dr("StaffFullName")</td>
                    <td>@Convert.ToDateTime(dr("BeginDate")).ToString("dd/MM/yyyy")</td>
                    <td>@Convert.ToDateTime(dr("EndDate")).ToString("dd/MM/yyyy")</td>
                    <td>@dr("ContractNo")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<p>No data available.</p>
End If
<div class="modal" role="document" id="mdlEdit">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Add/Edit Employment Data
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <input type="hidden" id="txtCompanyId" name="CompanyId" value="@companyId" />
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Staff</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="txtStaffId" name="StaffId" class="form-control dropdown">
                                <option value=""></option>
                                @Code
                                    Dim dtStaff = obj.GetDataFromSQL("SELECT * FROM Mas_HRStaff")
                                    If dtStaff.Rows.Count > 0 Then
                                        For Each dr As System.Data.DataRow In dtStaff.Rows
                                            @<option value="@dr("StaffID")" @IIf(dr("StaffId").ToString.Equals(staffId.ToString), "selected", "")>
                                                @dr("Title")@dr("StaffName") @dr("StaffLastName")
                                            </option>
                                        Next
                                    End If
                                End Code
                            </select>
                        </div>
                    </div>
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
                            <label>Assignment Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtAssignmentDate" name="AssignmentDate" value="@assignMentDate" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Probation Days</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtProbationDays" name="ProbationDays" value="@probationDays" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Begin Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtBeginDate" name="BeginDate" value="@beginDate" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>End Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtEndDate" name="EndDate" value="@endDate" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Contract Type</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="txtContractType" name="ContractType" class="form-control dropdown">
                                <option value=""></option>
                                @Code
                                    Dim dtContract = obj.GetDataFromSQL("SELECT * FROM Mas_HRContractType")
                                    If dtContract.Rows.Count > 0 Then
                                        For Each dr As System.Data.DataRow In dtContract.Rows
                                            @<option value="@dr("ContractTypeId")" @IIf(dr("ContractTypeID").ToString().Equals(contractType.ToString), "selected", "")>@dr("ContractType")</option>
                                        Next
                                    End If
                                End Code
                            </select>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Contract No</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtContractNo" name="ContractNo" value="@contractNo" class="form-control" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Contract Days</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtContractDays" name="ContractDays" value="@contractDays" class="form-control" />
                        </div>
                    </div>
                    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
                </form>
            </div>
            <div class="modal-footer">
                <input type="button" class="btn btn-danger" value="X" data-dismiss="modal" />
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var msg = '@msg';
    if(msg !== '') {
        alert(msg);
    }
    function editData(CompId,StaffId,PosId,AsgnDate,ProbDays,BgnDate,EndDate,CtType,CtNo,CtDays) {
        document.getElementById('txtCompanyId').value = CompId;
        document.getElementById('txtStaffId').value = StaffId;
        document.getElementById('txtPositionId').value = PosId;
        document.getElementById('txtAssignmentDate').value = AsgnDate;
        document.getElementById('txtProbationDays').value = ProbDays;
        document.getElementById('txtBeginDate').value = BgnDate;
        document.getElementById('txtEndDate').value = EndDate;
        document.getElementById('txtContractType').value = CtType;
        document.getElementById('txtContractNo').value = CtNo;
        document.getElementById('txtContractDays').value = CtDays;
    }
</script>