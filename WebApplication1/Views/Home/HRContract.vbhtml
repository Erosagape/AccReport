@Code
    ViewData("Title") = "HRContract"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql As String = ""
    Dim msg As String = ""

    Dim dt As New Data.DataTable

    Dim contractNo As String = ""
    Dim contractId As Integer = 0
    Dim staffId As Integer = 0
    Dim contractTypeId As Integer = 0
    Dim dateStart As String = ""
    Dim dateEnd As String = DateTime.Now.ToString("yyyy-MM-dd")
    Dim approveBy As String = ""
    Dim cancelBy As String = ""
    Dim createBy As String = ViewBag.User
    Dim approveDate As String = ""
    Dim cancelDate As String = ""
    Dim createDate As String = ""
    Dim signDate As String = ""
    Dim contractStatus As Integer = 0
    Dim statusDate As String = DateTime.Now.ToString("yyyy-MM-dd")
    Dim contractNote As String = ""
    Dim mdl As String = ""
    If Not Request.Form("submit") Is Nothing Then
        contractId = Request.Form("ContractId")
        contractNo = Request.Form("ContractNo")
        staffId = Request.Form("StaffId")
        contractTypeId = Request.Form("ContractTypeId")
        dateStart = Request.Form("DateStart")
        dateEnd = Request.Form("DateEnd")
        approveBy = Request.Form("ApproveBy")
        approveDate = Request.Form("ApproveDate")
        cancelBy = Request.Form("CancelBy")
        cancelDate = Request.Form("CancelDate")
        createBy = Request.Form("CreateBy")
        createDate = Request.Form("CreateDate")
        signDate = Request.Form("SignDate")
        contractStatus = Request.Form("ContractStatus")
        statusDate = Request.Form("StatusDate")
        contractNote = Request.Form("ContractNote")
        sql = "
IF '0'='{0}'
BEGIN
    DECLARE @@id int=(SELECT ISNULL(MAX(ContractId),0)+1 FROM Acc_HRContract)
    DECLARE @@contractno varchar(50)='{1}'
    if @@contractno=''
    begin
        declare @@tmp varchar(20)=concat('CE-',FORMAT(convert(datetime,'{12}'),'yy'),'/____')
        declare @@running varchar(50)=(select isnull(max(ContractNo),REPLACE(@@tmp,'_','0')) from Acc_HRContract  
	    where ContractNo like @@tmp)

	    SET @@contractno= dbo.GetMaxRunning(@@running,@@tmp)
    end
    INSERT INTO Acc_HRContract
    SELECT @@contractno,{2},{3},'{4}','{5}','{6}','{8}','{10}','{7}','{9}','{11}','{12}',{13},'{14}','{15}',@@id
END
ELSE
BEGIN
    UPDATE Acc_HRContract 
    SET 
        ContractNo='{1}'
        ,StaffId={2}
        ,ContractTypeId={3}
        ,DateStart='{4}'
        ,DateEnd='{5}'
        ,ApproveBy='{6}'
        ,ApproveDate='{7}'
        ,CancelBy='{8}'
        ,CancelDate='{9}'
        ,CreateBy='{10}'
        ,CreateDate='{11}'
        ,SignDate='{12}'
        ,ContractStatus={13}
        ,StatusDate='{14}'
        ,ContractNote='{15}'
    WHERE ContractId={0}
END
"
        msg = obj.ExecuteSQL(String.Format(sql,
                contractId, contractNo, staffId, contractTypeId, dateStart, dateEnd, approveBy, approveDate,
                cancelBy, cancelDate, createBy, createDate, signDate, contractStatus, statusDate, contractNote))
        If msg = "OK" Then
            msg = "Save Successfully"
            mdl = ""
        End If
        Response.StatusCode = 200
        Response.SuppressFormsAuthenticationRedirect = True
    End If
    sql = "
select a.ContractNo,
a.ContractId,
concat(c.StaffName,' ',c.StaffLastName) as StaffFullName,
a.StaffId,
b.ContractType,
a.ContractTypeId,
FORMAT(a.DateStart,'dd/MM/yyyy') as DateStart,
FORMAT(a.DateEnd,'dd/MM/yyyy') as DateEnd,
a.ApproveBy,
FORMAT(a.ApproveDate,'dd/MM/yyyy') as ApproveDate,
a.CancelBy,
FORMAT(a.CancelDate,'dd/MM/yyyy') as CancelDate,
a.CreateBy,
FORMAT(a.CreateDate,'dd/MM/yyyy') as CreateDate,
a.ContractNote,
FORMAT(a.SignDate,'dd/MM/yyyy') as SignDate,
a.ContractStatus,
FORMAT(a.StatusDate,'dd/MM/yyyy') as StatusDate
from 
Acc_HRContract a 
inner join Mas_HRContractType b
on a.ContractTypeId=b.ContractTypeId
inner join Mas_HRStaff c
on a.StaffId=c.StaffId
"
    dt = obj.GetDataFromSQL(sql)
    If Not Request.QueryString("Id") Is Nothing Then
        Dim rs = obj.GetDataFromSQL(String.Format("SELECT ContractId,ContractNo,StaffId,ContractTypeId,
FORMAT(DateStart,'yyyy-MM-dd') as DateStart,
FORMAT(Dateend,'yyyy-MM-dd') as DateEnd,
ApproveBy,
FORMAT(ApproveDate,'yyyy-MM-dd') as ApproveDate,
CancelBy,
FORMAT(CancelDate,'yyyy-MM-dd') as CancelDate,
CreateBy,
FORMAT(CreateDate,'yyyy-MM-dd') as CreateDate,
FORMAT(SignDate,'yyyy-MM-dd') as SignDate,
ContractStatus,
FORMAT(StatusDate,'yyyy-MM-dd') as StatusDate,
ContractNote
FROM Acc_HRContract WHERE ContractId={0}", Request.QueryString("Id")))
        If rs.Rows.Count > 0 Then
            contractId = rs.Rows(0)("ContractId")
            contractNo = rs.Rows(0)("ContractNo")
            staffId = rs.Rows(0)("StaffId")
            contractTypeId = rs.Rows(0)("ContractTypeId")
            dateStart = "" & rs.Rows(0)("DateStart")
            dateEnd = "" & rs.Rows(0)("DateEnd")
            approveBy = "" & rs.Rows(0)("ApproveBy")
            approveDate = "" & rs.Rows(0)("ApproveDate")
            cancelBy = "" & rs.Rows(0)("CancelBy")
            cancelDate = "" & rs.Rows(0)("CancelDate")
            createBy = "" & rs.Rows(0)("CreateBy")
            createDate = "" & rs.Rows(0)("CreateDate")
            signDate = "" & rs.Rows(0)("SignDate")
            contractStatus = rs.Rows(0)("ContractStatus")
            statusDate = "" & rs.Rows(0)("StatusDate")
            contractNote = "" & rs.Rows(0)("ContractNote")
        End If
        mdl = "btnMdl"
    End If
End Code

<h2>Employee Contract / สัญญาจ้างพนักงาน</h2>
<input type="button" class="btn btn-primary" value="New Contract" onclick="ShowDetail(0)" />
@If dt.Rows.Count>0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>เลขที่สัญญา</th>
                <th>ชื่อ-นามสกุล</th>
                <th>ประเภทสัญญา</th>
                <th>วันที่เริ่มสัญญา</th>
                <th>วันที่สิ้นสุดสัญญา</th>
                <th>หมายเหตุ</th>
                <th>สถานะสัญญา</th>
                <th>วันที่เปลี่ยนสถานะ</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" class="btn btn-primary" value="Edit" onclick="ShowDetail(@dr("ContractId"))" />
                    </td>
                    <td>@dr("ContractNo")</td>
                    <td>@dr("StaffFullName")</td>
                    <td>@dr("ContractType")</td>
                    <td>@dr("DateStart")</td>
                    <td>@dr("DateEnd")</td>
                    <td>@dr("ContractNote")</td>
                    <td>@dr("ContractStatus")</td>
                    <td>@dr("StatusDate")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found / ไม่พบข้อมูล
    </div>
End If
<div class="modal" role="document" id="mdlEdit">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Add/Edit Contract
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Contract Id</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtContractId" name="ContractId" class="form-control" value="@contractId" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Contract No</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtContractNo" name="ContractNo" class="form-control" value="@contractNo" />
                        </div>
                    </div>
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
                            <label>Start Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" name="DateStart" id="txtDateStart" class="form-control" value="@dateStart" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>End Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" name="DateEnd" id="txtDateEnd" class="form-control" value="@dateEnd" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Contract Details</label>
                        </div>
                        <div class="col-sm-8">
                            <textarea class="form-control" id="txtContractNote" name="ContractNote">@contractNote</textarea>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Contract Status</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="txtContractStatus" name="ContractStatus" class="form-control dropdown">
                                @Code
                                    Dim dtStatus = obj.GetDataFromSQL("SELECT * FROM Mas_HRConfig WHERE ConfigCode='CONTRACT_STATUS'")
                                    If dtStatus.Rows.Count > 0 Then
                                        For Each dr As Data.DataRow In dtStatus.Rows
                                            @<option value="@dr("ConfigKey")" @IIf(dr("ConfigKey").ToString.Equals(contractStatus.ToString), "selected", "")>@dr("ConfigValue")</option>
                                        Next
                                    End If
                                End Code
                            </select>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Status Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" name="StatusDate" id="txtStatusDate" class="form-control" value="@statusDate" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Signed Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" name="SignDate" id="txtSignDate" class="form-control" value="@signDate" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Approve By</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" name="ApproveBy" id="txtApproveBy" class="form-control" value="@approveBy" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Approve Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" name="ApproveDate" id="txtApproveDate" class="form-control" value="@approveDate" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Cancel By</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" name="CancelBy" id="txtCancelBy" class="form-control" value="@cancelBy" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Cancel Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" name="CancelDate" id="txtCancelDate" class="form-control" value="@cancelDate" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Create By</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" name="CreateBy" id="txtCreateBy" class="form-control" value="@createBy" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Create Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" name="CreateDate" id="txtCreateDate" class="form-control" value="@createDate" />
                        </div>
                    </div>
                    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-danger" data-dismiss="modal">X</button>
            </div>
        </div>
    </div>
</div>
<input type="button" data-toggle="modal" data-target="#mdlEdit" value="" id="btnMdl" style="display:none;" />
<script type="text/javascript">
    var mdl = '@mdl';
    var msg = '@msg';
    if (msg !== '') {
        alert(msg);
        window.location.href = window.location.pathname + '?DB=@dbName&SRC=@dbSource&Form=HRContract';
    }
    window.onload = function () {
        if (mdl !== '') {
            document.getElementById(mdl).click();
        }
    }
    function ShowDetail(id) {
        window.location.href = window.location.pathname + '?DB=@dbName&SRC=@dbSource&Form=HRContract&Id=' + id;
    }
</script>