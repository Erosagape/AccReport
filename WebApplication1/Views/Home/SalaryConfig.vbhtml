@Code
    ViewData("Title") = "SalaryConfig"
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

    Dim salaryTypeId As Integer = 1
    Dim salaryType As String = ""
    Dim salaryStatus As Int16 = 1
    Dim createdBy As String = ""
    Dim createdDate As String = ""
    Dim approvedBy As String = ""
    Dim approveDate As String = ""
    Dim cancelBy As String = ""
    Dim cancelDate As String = ""
    Dim contractType As Integer = 0

    If Not Request.Form("submitHeader") Is Nothing Then
        salaryTypeId = Convert.ToInt16(Request.Form("SalaryTypeId"))
        salaryType = Request.Form("SalaryType")
        salaryStatus = Convert.ToInt16(Request.Form("SalaryStatus"))
        createdBy = Request.Form("CreateBy")
        createdDate = Request.Form("CreateDate")
        approvedBy = Request.Form("ApproveBy")
        approveDate = Request.Form("ApproveDate")
        cancelBy = Request.Form("CancelBy")
        cancelDate = Request.Form("CancelDate")

        sql = "
IF '{0}'='0'
BEGIN
DECLARE @@NewID INT=(SELECT ISNULL(MAX(SalaryTypeId),0)+1 FROM Mas_HRSalaryType)
INSERT INTO Mas_HRSalaryType(SalaryTypeId,SalaryType,SalaryStatus,CreateBy,CreateDate,ApproveBy,ApproveDate,CancelBy,CancelDate)
VALUES(@@NewID,'{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}')
END
ELSE
BEGIN
UPDATE Mas_HRSalaryType
SET SalaryType='{1}',
SalaryStatus={2},
CreateBy='{3}',
CreateDate='{4}',
ApproveBy='{5}',
ApproveDate='{6}',
CancelBy='{7}',
CancelDate='{8}'
WHERE SalaryTypeId={0}
END
"
        sql = String.Format(sql,
                            salaryTypeId,
                            salaryType,
                            salaryStatus,
                            createdBy,
                            createdDate,
                            approvedBy,
                            approveDate,
                            cancelBy,
                            cancelDate
        )
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data Saved successfully."
        End If
    End If


    sql = "SELECT SalaryTypeId,SalaryType,SalaryStatus,
CreateBy,FORMAT(CreateDate,'yyyy-MM-dd') as CreateDate,
ApproveBy,FORMAT(ApproveDate,'yyyy-MM-dd') as ApproveDate,
CancelBy,FORMAT(CancelDate,'yyyy-MM-dd') as CancelDate
FROM Mas_HRSalaryType WHERE SalaryStatus=1"
    Dim rs = obj.GetDataFromSQL(sql)
    If Not Request.QueryString("SalaryType") Is Nothing Then
        salaryTypeId = Convert.ToInt32(Request.QueryString("SalaryType"))
    Else
        If rs.Rows.Count > 0 Then
            salaryTypeId = Convert.ToInt32(rs.Rows(0)("SalaryTypeId"))
        End If
    End If
    Dim json = Newtonsoft.Json.JsonConvert.SerializeObject(rs)
    If Not Request.QueryString("ContractType") Is Nothing Then
        contractType = Convert.ToInt32(Request.QueryString("ContractType"))
    End If

    Dim seq As Integer = 0
    Dim itemNo As String = ""
    Dim salaryName As String = ""
    Dim salaryRate As Decimal = 0
    Dim accCode As String = ""
    Dim salaryBase As Decimal = 0
    Dim salaryEnd As Decimal = 0
    Dim salaryFix As Decimal = 0
    Dim payrollType As Int16 = 1

    If Not Request.Form("submitDetail") Is Nothing Then
        salaryTypeId = Request.Form("SalaryType")
        contractType = Request.Form("ContractType")
        seq = Request.Form("Seq")
        itemNo = Request.Form("ItemNo")
        salaryName = Request.Form("SalaryName")
        salaryRate = Request.Form("SalaryRate")
        accCode = Request.Form("AccCode")
        salaryBase = Request.Form("SalaryBase")
        salaryEnd = Request.Form("SalaryEnd")
        salaryFix = Request.Form("SalaryFix")
        payrollType = Request.Form("PayrollType")

        sql = "
IF '0'='{2}'
BEGIN
    DECLARE @@maxseq int =(SELECT ISNULL(MAX(Seq),0)+1 FROM Mas_HRSalary WHERE SalaryTypeId={0} AND ContractTypeId={1})
    INSERT INTO Mas_HRSalary
    SELECT {0},{1},@@maxseq,{3},'{4}',{5},'{6}',{7},{8},{9},{10}
END
ELSE
BEGIN
    UPDATE Mas_HRSalary
    SET ItemNo={3},SalaryName='{4}',SalaryRate={5},AccCode='{6}'
    ,SalaryBase={7},SalaryEnd={8},SalaryFix={9},PayrollType={10}
    WHERE SalaryTypeId={0} AND ContractTypeId={1} AND Seq={2}
END
"
        sql = String.Format(sql, salaryTypeId, contractType, seq, itemNo, salaryName, salaryRate, accCode, salaryBase, salaryEnd, salaryFix, payrollType)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            msg = "Detail Save Successfully"
        End If
        Response.StatusCode = 200
        Response.SuppressFormsAuthenticationRedirect = True
    End If

    sql = "
select a.SalaryTypeId,
a.SalaryType,
b.ContractTypeId,
c.ContractType,
b.Seq,b.ItemNo,b.SalaryName,
b.SalaryRate,
b.AccCode,d.AccName,
b.SalaryBase,
b.SalaryEnd,
b.SalaryFix,
(case when b.PayrollType =1 then 'ADD' else 'DEDUCT' end)
as PayRollType
from Mas_HRSalaryType a
inner join Mas_HRSalary b
on a.SalaryTypeId=b.SalaryTypeId
inner join Mas_HRContractType c
on b.ContractTypeId=c.ContractTypeId
left join Mas_AccCode d on b.AccCode=d.AccCode
where a.SalaryTypeId=" & salaryTypeId
    If contractType > 0 Then
        sql &= " and b.ContractTypeId=" & contractType
    End If
    dt = obj.GetDataFromSQL(sql)

End Code
<h2>Salary Monthly / กำหนดรายการประจำเดือน</h2>
<div class="row">
    <div class="col-sm-2">
        <label>รูปแบบเงินเดือน</label>
    </div>
    <div class="col-sm-6" style="display:flex;">
        <select id="cboSalaryType" class="form-control dropdown" onchange="RefreshPage()">
            @Code
                For Each dr As Data.DataRow In rs.Rows
                    @<option value="@dr("SalaryTypeId")" @IIf(salaryTypeId.Equals(dr("SalaryTypeId")), "selected", "")>@dr("SalaryType")</option>
                Next
            End Code
        </select>
        <div style="display:flex;">
            <input type="button" value="Edit" class="btn btn-primary" data-toggle="modal" data-target="#mdlEdit" onclick="editData()" />
            <input type="button" value="New" class="btn btn-warning" data-toggle="modal" data-target="#mdlEdit" onclick="clearData()" />
        </div>
    </div>
</div>
<div class="row">
    <div class="col-sm-2">
        <label>ประเภทสัญญาจ้าง</label>
    </div>
    <div class="col-sm-6" style="display:flex;">
        <select id="cboContractType" class="form-control dropdown" onchange="RefreshPage()">
            <option value="0"></option>
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
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th></th>
                @If contractType > 0 Then
                    @<th>สัญญาจ้าง</th>
                End If
                <th>ลำดับ</th>
                <th>ชื่อรายการ</th>
                <th>ตัวคูณ</th>
                <th>ค่าเริ่มต้น</th>
                <th>ค่าสูงสุด</th>
                <th>ค่าคงที่</th>
                <th>ประเภทการจ่ายเงินเดือน</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    @If contractType > 0 Then
                        @<td>
                            <input type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlDetail" value="Edit" onclick="ShowDetail(
    '@dr("SalaryTypeId")', '@dr("ContractTypeId")', '@dr("Seq")',
    '@dr("ItemNo")', '@dr("SalaryName")', '@dr("SalaryRate")', '@dr("SalaryBase")', '@dr("SalaryEnd")',
    '@dr("SalaryFix")','@dr("AccCode")','@dr("PayrollType")'
    )" />
                        </td>
                    End If
                    <td>@dr("ContractType")</td>
                    <td>@dr("Seq")</td>
                    <td>@dr("SalaryName")</td>
                    <td>@dr("SalaryRate")</td>
                    <td>@dr("SalaryBase")</td>
                    <td>@dr("SalaryEnd")</td>
                    <td>@dr("SalaryFix")</td>
                    <td>@dr("PayrollType")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If
<div class="modal" id="mdlDetail" role="document">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h4 class="modal-title">Add/Edit Salary Config Detail</h4>
                <input type="button" id="btnAdd" class="btn btn-warning" value="Add" onclick="AddDetail()" />
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <input type="hidden" id="txtSalaryType" name="SalaryType" value="@salaryTypeId" />
                    <input type="hidden" id="txtContractType" name="ContractType" value="@contractType" />
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Sequence</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtSeq" name="Seq" class="form-control" value="@seq" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Slip Item.No</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtItemNo" name="ItemNo" class="form-control" value="@itemNo" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Salary Name</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtSalaryName" name="SalaryName" class="form-control" value="@salaryName" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Salary Rate</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtSalaryRate" name="SalaryRate" class="form-control" value="@salaryRate" step="any" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Amount</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtSalaryBase" name="SalaryBase" class="form-control" value="@salaryBase" step="any" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Amount Maximum</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtSalaryEnd" name="SalaryEnd" class="form-control" value="@salaryEnd" step="any" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Fix Amount</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtSalaryFix" name="SalaryFix" class="form-control" value="@salaryFix" step="any" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Payroll Type</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="txtPayrollType" name="PayrollType" class="form-control">
                                <option value="1" @(If(payrollType = 1, "selected", ""))>Payment</option>
                                <option value="2" @(If(payrollType = 2, "selected", ""))>Deduct</option>
                            </select>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Account Code</label>
                        </div>
                        <div class="col-sm-8">
                            <div style="display:flex">
                                <input type="text" id="txtAccCode" name="AccCode" class="form-control" value="@accCode" />
                                <input type="button" class="btn btn-default" value="..." onclick="ShowAccList()" />
                            </div>                            
                        </div>
                    </div>
                    <div id="listAcc" style="display:none;">
                        <table class="table table-responsive" border="1">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Code</th>
                                    <th>Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                @Code
                                    Dim dtAcc = obj.GetDataFromSQL("SELECT * FROM Mas_AccCode")
                                    If dtAcc.Rows.Count > 1 Then
                                        For Each dr As Data.DataRow In dtAcc.Rows
                                            @<tr>
                                                <td>
                                                    <input type="button" class="btn btn-warning" onclick="SetData('@dr("AccCode").ToString()')" value="Select" />
                                                </td>
                                                <td>
                                                    @dr("AccCode").ToString()
                                                </td>
                                                <td>
                                                    @dr("AccName").ToString()
                                                </td>
                                            </tr>
                                        Next
                                    End If
                                End Code
                            </tbody>
                        </table>
                    </div>
                    <input type="submit" name="submitDetail" value="Save" class="btn btn-primary" />
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-danger" data-dismiss="modal">X</button>
            </div>
        </div>
    </div>
</div>
<div class="modal" id="mdlEdit" role="document">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h4 class="modal-title">Add/Edit Salary Config</h4>
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <input type="hidden" id="txtSalaryTypeId" name="SalaryTypeId" value="@salaryTypeId" />
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Salary Type Name</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtSalaryTypeName" name="SalaryType" class="form-control" value="@salaryType" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Salary Status</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="cboSalaryStatus" name="SalaryStatus" class="form-control">
                                <option value="1" @(If(salaryStatus = 1, "selected", ""))>Active</option>
                                <option value="0" @(If(salaryStatus = 0, "selected", ""))>Inactive</option>
                            </select>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <input type="checkbox" id="chkApproved" name="Approved" onchange="SetApproved()" @(If(approvedBy <> "", "checked", "")) />
                            <label>Approve By</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtApproveBy" name="ApproveBy" class="form-control" value="@approvedBy" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Approve Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtApproveDate" name="ApproveDate" class="form-control" value="@approveDate" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <input type="checkbox" id="chkCancel" name="Cancel" onchange="SetCancel()" @(If(cancelBy <> "", "checked", "")) />
                            <label>Cancel By</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtCancelBy" name="CancelBy" class="form-control" value="@cancelBy" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Cancel Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtCancelDate" name="CancelDate" class="form-control" value="@cancelDate" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Create By</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtCreateBy" name="CreateBy" class="form-control" value="@createdBy" readonly />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Created Date</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="date" id="txtCreatedDate" name="CreateDate" class="form-control" value="@createdDate" readonly />
                        </div>
                    </div>
                    <input type="submit" name="submitHeader" value="Save" class="btn btn-primary" />
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-danger" data-dismiss="modal">X</button>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var msg = '@msg';
    if(msg!=='') {
        alert(msg);
    }
    var rs = JSON.parse('@Html.Raw(json)');
    function RefreshPage() {
        let st = document.getElementById('cboSalaryType').value;
        let ct = document.getElementById('cboContractType').value;
        window.location = '?Form=SalaryConfig&DB=@dbName&SRC=@dbSource&SalaryType=' + st + '&ContractType=' + ct;
    }
    function editData() {
        rs.filter(x => x.SalaryTypeId == document.getElementById('cboSalaryType').value).forEach(x => {
            document.getElementById('txtSalaryTypeId').value = x.SalaryTypeId;
            document.getElementById('txtSalaryTypeName').value = x.SalaryType;
            document.getElementById('cboSalaryStatus').value = (x.SalaryStatus ? "1" : "0");
            document.getElementById('txtApproveBy').value = x.ApproveBy;
            document.getElementById('chkApproved').checked = (x.ApproveBy !== null && x.ApproveBy !== "");
            document.getElementById('txtApproveDate').value = x.ApproveDate;
            document.getElementById('txtCancelBy').value = x.CancelBy;
            document.getElementById('chkCancel').checked = (x.CancelBy !== null && x.CancelBy !== "");
            document.getElementById('txtCancelDate').value = x.CancelDate;
            document.getElementById('txtCreateBy').value = x.CreateBy;
            document.getElementById('txtCreatedDate').value = x.CreateDate;
        });
    }
    function SetApproved() {
        let chk = document.getElementById('chkApproved');
        let txtApproveBy = document.getElementById('txtApproveBy');
        let txtApproveDate = document.getElementById('txtApproveDate');
        if (chk.checked) {
            document.getElementById('cboSalaryStatus').value = "1";
            txtApproveBy.value = '@ViewBag.User';
            txtApproveDate.value = new Date().toISOString().split('T')[0];
        } else {
            txtApproveBy.value = '';
            txtApproveDate.value = '';
        }
    }
    function SetCancel() {
        let chk = document.getElementById('chkCancel');
        let txtCancelBy = document.getElementById('txtCancelBy');
        let txtCancelDate = document.getElementById('txtCancelDate');
        if (chk.checked) {
            document.getElementById('cboSalaryStatus').value = "0";
            txtCancelBy.value = '@ViewBag.User';
            txtCancelDate.value = new Date().toISOString().split('T')[0];
        } else {
            txtCancelBy.value = '';
            txtCancelDate.value = '';
        }
    }
    function clearData() {
        document.getElementById('txtSalaryTypeId').value = '0';
        document.getElementById('txtSalaryTypeName').value = '';
        document.getElementById('cboSalaryStatus').value = "1";
        document.getElementById('chkApproved').checked = false;
        document.getElementById('txtApproveBy').value = '';
        document.getElementById('txtApproveDate').value = '';
        document.getElementById('chkCancel').checked = false;
        document.getElementById('txtCancelBy').value = '';
        document.getElementById('txtCancelDate').value = '';
    }
    function SetData(code) {
        document.getElementById('txtAccCode').value = code;
        document.getElementById('listAcc').style.display = 'none';
    }
    function ShowAccList() {
        let list = document.getElementById('listAcc');
        if (list.style.display === 'none') {
            list.style.display = 'block';
        } else {
            list.style.display = 'none';
        }
    }
    function AddDetail() {
        document.getElementById('txtSeq').value = 0;
        document.getElementById('txtItemNo').value = 0;
        document.getElementById('txtSalaryName').value = '';
        document.getElementById('txtSalaryRate').value = 0;
        document.getElementById('txtSalaryBase').value = 0;
        document.getElementById('txtSalaryEnd').value = 0;
        document.getElementById('txtSalaryFix').value = 0;
        document.getElementById('txtPayrollType').value = 1;
        document.getElementById('txtAccCode').value = '';
    }
    function ShowDetail(salaryTypeId, contractTypeId, seq, itemNo, salaryName, salaryRate, salaryBase, salaryEnd, salaryFix, accCode, payrollType) {
        document.getElementById('txtSalaryType').value = salaryTypeId;
        document.getElementById('txtContractType').value = contractTypeId;
        document.getElementById('txtSeq').value = seq;
        document.getElementById('txtItemNo').value = itemNo;
        document.getElementById('txtSalaryName').value = salaryName;
        document.getElementById('txtSalaryRate').value = salaryRate;
        document.getElementById('txtSalaryBase').value = salaryBase;
        document.getElementById('txtSalaryEnd').value = salaryEnd;
        document.getElementById('txtSalaryFix').value = salaryFix;
        document.getElementById('txtPayrollType').value = (payrollType === 'ADD' ? 1 : 2);
        document.getElementById('txtAccCode').value = accCode;
    }
</script>