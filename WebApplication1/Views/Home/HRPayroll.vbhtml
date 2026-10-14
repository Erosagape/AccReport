@Code
    ViewData("Title") = "Payroll"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim slipNo As String = ""
    Dim salaryId As Integer = 0
    Dim paymentType As Integer = 1
    Dim staffId As Integer = 0
    Dim paymentToAcc As String = ""
    Dim paymentFromAcc As String = ""
    Dim salaryStatus As Integer = 1
    Dim paymentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
    Dim itemNo As Integer = 0
    Dim salaryName As String = ""
    Dim amountPayment As Decimal = 0
    Dim accCodeDebit As String = ""
    Dim accCodeCredit As String = ""
    Dim amountAdd As Decimal = 0
    Dim amountDeduct As Decimal = 0
    Dim approveBy As String = ""
    Dim approveDate As String = ""
    Dim createBy As String = ViewBag.User
    Dim createDate As String = ""
    Dim cancelBy As String = ""
    Dim cancelDate As String = ""

    Dim showDetail As Boolean = False
    If Not Request.QueryString("SlipNo") Is Nothing Then
        slipNo = Request.QueryString("SlipNo").ToString()
        showDetail = True
    End If

    Dim msg As String = ""
    Dim sql As String = ""
    Dim dateFrom As String = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("yyyy-MM-dd")
    Dim dateTo As String = New DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(1).Month, 1).AddDays(-1).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If
    If Not Request.QueryString("ID") Is Nothing Then
        salaryId = Convert.ToInt32(Request.QueryString("ID"))
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable

    If Not Request.Form("Submit") Is Nothing Then
        salaryId = Request.Form("SalaryId")
        slipNo = Request.Form("SlipNo")
        paymentType = Request.Form("PaymentType")
        staffId = Request.Form("StaffId")
        paymentToAcc = Request.Form("PaymentToAcc")
        paymentFromAcc = Request.Form("PaymentFromAcc")
        paymentDate = Request.Form("PaymentDate")
        itemNo = Request.Form("ItemNo")
        salaryName = Request.Form("SalaryName")
        amountPayment = Request.Form("AmountPayment")
        If amountPayment > 0 Then
            amountAdd = amountPayment
            amountDeduct = 0
            accCodeCredit = ""
            accCodeDebit = Request.Form("AccCode")
        End If
        If amountPayment < 0 Then
            amountDeduct = amountPayment * -1
            amountAdd = 0
            accCodeDebit = ""
            accCodeCredit = Request.Form("AccCode")
        End If
        salaryStatus = Request.Form("SalaryStatus")
        approveDate = Request.Form("ApproveDate")
        approveBy = Request.Form("ApproveBy")
        cancelDate = Request.Form("CancelDate")
        cancelBy = Request.Form("CancelBy")
        createDate = Request.Form("CreateDate")
        createBy = Request.Form("CreateBy")

        sql = "if '{0}'>'0'
BEGIN
    UPDATE Acc_HRPayroll
    SET SlipNo='{1}'
    ,PaymentType={2}
    ,StaffId={3}
    ,PaymentToAcc='{4}'
    ,PaymentFromAcc='{5}'
    ,PaymentDate='{6}'
    ,ItemNo={7}
    ,SalaryName='{8}'
    ,AmountPayment={9}
    ,AmountAdd={10}
    ,AmountDeduct={11}
    ,AccCodeDebit='{12}'
    ,AccCodeCredit='{13}'
    ,SalaryStatus={14}
    ,ApproveDate='{15}'
    ,ApproveBy='{16}'
    ,CancelDate='{17}'
    ,CancelBy='{18}'
    ,CreateDate='{19}'
    ,CreateBy='{20}'
    WHERE SalaryId={0}

    SELECT * FROM Acc_HRPayRoll WHERE SalaryId={0}
END
ELSE
BEGIN
    DECLARE @@sid int=(SELECT ISNULL(MAX(SalaryId),0)+1 FROM Acc_HRPayroll)
    DECLARE @@slipno varchar(20)='{1}'
    IF(@@slipno='')
    begin
        DECLARE @@maxid int=(SELECT ISNULL(MAX(cast(REPLACE(SlipNo,FORMAT(cast('{6}' as datetime),'yyMM'),'') as int)),0)+1 FROM Acc_HRPayRoll
        WHERE SlipNo like FORMAT(cast('{6}' as datetime),'yyMM')+'____')
        SET @@slipno=CONCAT(FORMAT(cast('{6}' as datetime),'yyMM'),FORMAT(@@maxid,'0000'))
    end
    DECLARE @@itemno int={7}
    if(@@itemno=0)
    begin
       SET @@itemno=(select isnull(MAX(itemno),0)+1 FROM Acc_HRPayRoll WHERE SlipNo='{1}')
    end
    INSERT INTO Acc_HRPayRoll
    (SalaryId,SlipNo,PaymentType,StaffId,PaymentToAcc,PaymentFromAcc,
PaymentDate,ItemNo,SalaryName,AmountPayment,AmountAdd,AmountDeduct,
AccCodeDebit,AccCodeCredit,SalaryStatus,ApproveDate,ApproveBy,
CancelDate,CancelBy,CreateDate,CreateBy)
    SELECT @@sid,@@slipno,{2},{3},'{4}','{5}'
    ,'{6}',@@itemno,'{8}',{9},{10},{11}
    ,'{12}','{13}',{14},'{15}','{16}'
    ,'{17}','{18}','{19}','{20}'

    SELECT * FROM Acc_HRPayRoll WHERE SalaryId=@@sid
END"

        sql = String.Format(sql, salaryId, slipNo, paymentType, staffId, paymentToAcc, paymentFromAcc, paymentDate,
        itemNo, salaryName, amountPayment, amountAdd, amountDeduct,
        accCodeDebit, accCodeCredit, salaryStatus, approveDate, approveBy,
        cancelDate, cancelBy, createDate, createBy)

        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If

    sql = "select a.SlipNo,a.PaymentDate,
a.PaymentType,a.PaymentToAcc,a.PaymentFromAcc,
a.SalaryStatus,a.ApproveDate,a.ApproveBy,
a.CancelDate,a.CancelBy,
a.CreateDate,a.CreateBy,
a.TotalPayment,a.TotalRevenue,a.TotalExpense,
a.StaffId,b.StaffName,
e.LevelId,e.LevelName,
b.PositionId,b.PositionName,
d.DepartmentId,d.DepartmentName,
d.DivisionId,d.DivisionName
from vHR_PayrollSlip a
inner join vHR_PayRoll b
on a.StaffId=b.StaffId
inner join Mas_HRPosition c
on b.PositionId=c.PositionId
inner join vMas_HROrgChart d
on c.DepartmentId=d.DepartmentId
inner join Mas_HRLevel e
on c.LevelId=e.LevelId
WHERE a.PaymentDate >= '" & dateFrom & "' AND a.PaymentDate <= '" & dateTo & "'
"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Payroll Slip / รายการสลิปเงินเดือน</h2>
<a class="btn btn-success" href="?Form=PayrollCreate&SRC=@dbSource&DB=@dbname">Payroll Create</a>
<div class="row">
    <div class="col-sm-3">
        <label>Payment From Date</label>
    </div>
    <div class="col-sm-3">
        <label>Payment To Date</label>
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <input type="date" id="txtDateFrom" value="@dateFrom" class="form-control" />
    </div>
    <div class="col-sm-3">
        <input type="date" id="txtDateTo" value="@dateTo" class="form-control" />
    </div>
</div>
<div class="row">
    <div class="col-sm-3">
        <button type="button" class="btn btn-primary" onclick="searchPayroll()">Search</button>
    </div>
</div>
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Slip No</th>
                <th>Payment Date</th>
                <th>Staff Name</th>
                <th>Position</th>
                <th>Department</th>
                <th>Division</th>
                <th>Total Payment</th>
            </tr>
        </thead>
        <tbody>
            @For each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" class="btn btn-sm btn-primary" value="Edit" onclick="showSlip('@dr("SlipNo")')" />
                    </td>
                    <td>
                        <button type="button" onclick="printSlip('@dr("SlipNo")','@dr("StaffId")')">@dr("SlipNo")</button>
                    </td>
                    <td>@convert.ToDateTime(dr("PaymentDate")).ToString("dd/MM/yyyy")</td>
                    <td>@dr("StaffName")</td>
                    <td>@dr("PositionName")</td>
                    <td>@dr("DepartmentName")</td>
                    <td>@dr("DivisionName")</td>
                    <td class="text-right">@String.Format("{0:N2}", dr("TotalPayment"))</td>
                </tr>
            Next
        </tbody>
    </table>
End If
<div class="modal" role="document" id="mdlDetail">
    <div class="modal-dialog-lg">
        <div class="modal-content">
            <div class="modal-body">
                @Code
                    sql = "select
a.[SalaryId]
,a.[SlipNo]
,a.[PaymentType]
,a.[StaffId]
,a.[PaymentToAcc]
,a.[PaymentFromAcc]
,FORMAT(a.[PaymentDate],'yyyy-MM-dd') as [PaymentDate]
,a.[ItemNo]
,a.[SalaryName]
,a.[AmountPayment]
,a.[AmountAdd]
,a.[AmountDeduct]
,a.[AccCodeDebit]
,a.[AccCodeCredit]
,a.[SalaryStatus]
,FORMAT(a.[ApproveDate],'yyyy-MM-dd') as [ApproveDate]
,a.[ApproveBy]
,FORMAT(a.[CancelDate],'yyyy-MM-dd') as [CancelDate]
,a.[Cancelby]
,FORMAT(a.[Createdate],'yyyy-MM-dd') as [CreateDate]
,a.[Createby]
,CONCAT(b.StaffName,' ',b.StaffLastName) as StaffName
from Acc_HRPayroll a
inner join Mas_HRStaff b on a.StaffId = b.StaffId
where a.SlipNo='" & slipNo & "'"
                    Dim rs = obj.GetDataFromSQL(sql)
                    If rs.Rows.Count = 0 Then
                        If slipNo <> "" Then
                            msg = "No data found for Slip No: " & slipNo
                        End If
                    Else
                        staffId = rs.Rows(0)("StaffId")
                        paymentDate = rs.Rows(0)("PaymentDate")
                        Dim dtBook = obj.GetDataFromSQL(String.Format("SELECT a.* FROM Mas_HRBookAccount a
inner join Acc_HRContract b on a.StaffId=b.StaffId
where b.ContractStatus=1 and a.StaffId={0}", staffId))
                        If dtBook.Rows.Count > 0 Then
                            paymentToAcc = dtBook.Rows(0)("BookCode")
                        End If

                        @<b>@rs.Rows(0)("StaffName") งวดวันที่ @convert.ToDateTime(rs.Rows(0)("PaymentDate")).ToString("dd/MM/yyyy")</b>
                        Dim rowFilter = From r As Data.DataRow In rs.Rows.Cast(Of Data.DataRow)()
                                        Where r("SalaryId") = salaryId
                                        Select r
                        If rowFilter.Any() Then
                            Dim row = rowFilter.First()
                            salaryId = row("SalaryId")
                            staffId = row("StaffId")
                            slipNo = row("SlipNo")
                            paymentType = row("PaymentType")
                            paymentToAcc = row("PaymentToAcc")
                            paymentFromAcc = row("PaymentFromAcc")
                            salaryStatus = row("SalaryStatus")
                            paymentDate = row("PaymentDate")
                            itemNo = row("ItemNo")
                            salaryName = row("SalaryName")
                            amountPayment = row("AmountPayment")
                            accCodeDebit = row("AccCodeDebit")
                            accCodeCredit = row("AccCodeCredit")
                            amountAdd = row("AmountAdd")
                            amountDeduct = row("AmountDeduct")
                            approveBy = "" & row("ApproveBy")
                            approveDate = "" & row("ApproveDate")
                            createBy = row("CreateBy")
                            createDate = row("CreateDate")
                            cancelBy = "" & row("CancelBy")
                            cancelDate = "" & row("CancelDate")
                        End If
                    End If
                    @<div class="row">
                        <div class="col-sm-6">
                            <table class="table table-bordered">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>ลำดับ</th>
                                        <th>รายการ</th>
                                        <th>รายได้</th>
                                        <th>รายการหัก</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    @For each dr As Data.DataRow In rs.Rows
                                        @<tr>
                                            <td>
                                                <input type="button" class="btn btn-sm btn-primary" value="Edit" onclick="showItem('@dr("SalaryId")')" />
                                            </td>
                                            <td>@dr("ItemNo")</td>
                                            <td>
                                                @If dr("AmountPayment") > 0 Then
                                                    @dr("SalaryName")
                                                Else
                                                    @<b>หัก - </b> @dr("SalaryName")
                                                End If
                                            </td>
                                            <td class="text-right">@String.Format("{0:N2}", dr("AmountAdd"))</td>
                                            <td class="text-right">@String.Format("{0:N2}", dr("AmountDeduct"))</td>
                                        </tr>
                                    Next
                                </tbody>
                                <tfoot>
                                    <tr>
                                        <td colspan="3">
                                            รวม / Total
                                        </td>
                                        <td class="text-right">@String.Format("{0:N2}", rs.Compute("SUM(AmountAdd)", "1=1"))</td>
                                        <td class="text-right">@String.Format("{0:N2}", rs.Compute("SUM(AmountDeduct)", "1=1"))</td>
                                    </tr>
                                    <tr>
                                        <td colspan="4">ยอดสุทธิ / Net Payment</td>
                                        <td class="text-right">
                                            @String.Format("{0:N2}", rs.Compute("SUM(AmountPayment)", "1=1"))
                                        </td>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                        <div class="col-sm-6">
                            <div id="mdlEdit">
                                <input type="button" value="Add New" class="btn btn-sm btn-success" onclick="AddNewData()" />
                                <form action="" method="post">
                                    <input type="hidden" id="txtSalaryId" name="SalaryId" value="@salaryId" />
                                    <input type="hidden" id="txtStaffId" name="StaffId" value="@staffId" />
                                    <input type="hidden" id="txtCreateBy" name="CreateBy" value="@createBy" />
                                    <input type="hidden" id="txtCreateDate" name="CreateDate" value="@createDate" />
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Payment Date</label>
                                        </div>
                                        <div class="col-sm-8">
                                            <input type="date" class="form-control" id="txtPaymentDate" name="PaymentDate" value="@paymentDate" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Payment Slip</label>
                                        </div>
                                        <div class="col-sm-8" style="display:flex;">
                                            <input type="text" class="form-control" id="txtSlipNo" name="SlipNo" value="@slipNo" />
                                            <input type="button" class="btn btn-default" value="New Slip" onclick="ClearSlipNo()" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Item No</label>
                                        </div>
                                        <div class="col-sm-8">
                                            <input type="number" class="form-control" id="txtItemNo" name="ItemNo" value="@itemNo" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Payment Type</label>
                                        </div>
                                        <div class="col-sm-8">
                                            <select id="txtPaymentType" name="PaymentType" class="form-control dropdown">
                                                <option value="1" @IIf(paymentType.Equals(1), "selected", "")>รายเดือน / Monthly</option>
                                                <option value="2" @IIf(paymentType.Equals(2), "selected", "")>รายวัน / Daily</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Payment From Account</label>
                                        </div>
                                        <div class="col-sm-8">
                                            <input type="text" class="form-control" id="txtPaymentFromAcc" name="PaymentFromAcc" value="@paymentFromAcc" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Payment To Account</label>
                                        </div>
                                        <div class="col-sm-8">
                                            <input type="text" class="form-control" id="txtPaymentToAcc" name="PaymentToAcc" value="@paymentToAcc" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Description</label>
                                        </div>
                                        <div class="col-sm-8">
                                            <input type="text" class="form-control" id="txtSalaryName" name="SalaryName" value="@salaryName" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Amount</label>
                                        </div>
                                        <div class="col-sm-8">
                                            <input type="number" class="form-control" id="txtAmountPayment" name="AmountPayment" value="@amountPayment" step="any" inputmode="decimal" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Payment Status</label>
                                        </div>
                                        <div class="col-sm-8">
                                            <select id="txtSalaryStatus" name="SalaryStatus" class="form-control dropdown">
                                                <option value="1" @IIf(salaryStatus.Equals(1), "selected", "")>ค้างจ่าย / Waiting</option>
                                                <option value="2" @IIf(salaryStatus.Equals(2), "selected", "")>จ่ายแล้ว / Payment</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <label>Account Code</label>
                                        </div>
                                        <div class="col-sm-8" style="display:flex;">
                                            <input type="text" class="form-control" id="txtAccCode" name="AccCode" value="@IIf(amountPayment > 0, accCodeDebit, accCodeCredit)" />
                                            <input type="button" class="btn btn-default" value="..." onclick="ShowAccList()" />
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
                                    <div class="row">
                                        <div class="col-sm-4">
                                            <input type="checkbox" id="chkApproved" name="Approved" onchange="SetApproved()" @(If(approveBy <> "", "checked", "")) />
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
                                            <input type="checkbox" id="chkCancel" name="Cancel" onchange="SetCancel()" @(If(cancelBy <> "", "checked", "")) />
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
                                    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
                                </form>
                            </div>
                        </div>
                    </div>
                End Code
            </div>
            <div class="modal-footer">
                <div style="float:right">
                    <input type="button" class="btn btn-danger" value="X" onclick="searchPayroll()" />
                </div>
            </div>
        </div>
    </div>
</div>
<input type="button" style="display:none;" id="btnDetail" data-target="#mdlDetail" data-toggle="modal" />
<script type="text/javascript">
    var slipNo = "@slipNo";
    var msg = '@msg';
    if (msg !== '') {
        alert(msg);
        searchPayroll();
    }
    window.onload=function() {
        if (slipNo != "") {
            document.getElementById("btnDetail").click();
        }
    }
    function ShowAccList() {
        let list = document.getElementById('listAcc');
        if (list.style.display === 'none') {
            list.style.display = 'block';
        } else {
            list.style.display = 'none';
        }
    }
    function SetData(code) {
        document.getElementById('txtAccCode').value = code;
        document.getElementById('listAcc').style.display = 'none';
    }
    function ClearSlipNo() {
        document.getElementById('txtSlipNo').value = '';
        document.getElementById('txtPaymentDate').value = '@DateTime.Today.ToString("yyyy-MM-dd")';
    }
    function AddNewData() {
        var dateFrom = $("#txtDateFrom").val();
        var dateTo = $("#txtDateTo").val();
        window.location.href = "?Form=HRPayroll&DB=@dbname&SRC=@dbSource&DateFrom=" + dateFrom + "&DateTo=" + dateTo + "&SlipNo=@slipNo&ID=0";

    }
    function showSlip(slipNo) {
        var dateFrom = $("#txtDateFrom").val();
        var dateTo = $("#txtDateTo").val();
        window.location.href = "?Form=HRPayroll&DB=@dbname&SRC=@dbSource&DateFrom=" + dateFrom + "&DateTo=" + dateTo + "&SlipNo=" + slipNo;
    }
    function showItem(id) {
        var dateFrom = $("#txtDateFrom").val();
        var dateTo = $("#txtDateTo").val();
        window.location.href = "?Form=HRPayroll&DB=@dbname&SRC=@dbSource&DateFrom=" + dateFrom + "&DateTo=" + dateTo + "&SlipNo=@slipNo&ID=" + id;
    }
    function searchPayroll() {
        var dateFrom = $("#txtDateFrom").val();
        var dateTo = $("#txtDateTo").val();
        window.location.href = "?Form=HRPAyroll&DB=@dbname&SRC=@dbSource&DateFrom=" + dateFrom + "&DateTo=" + dateTo;
    }
    function SetApproved() {
        var status = document.getElementById("txtSalaryStatus").value;
        if (status == '2') {
            return;
        }
        let chk = document.getElementById('chkApproved');
        let txtApproveBy = document.getElementById('txtApproveBy');
        let txtApproveDate = document.getElementById('txtApproveDate');
        if (chk.checked) {
            txtApproveBy.value = '@ViewBag.User';
            txtApproveDate.value = new Date().toISOString().split('T')[0];
        } else {
            txtApproveBy.value = '';
            txtApproveDate.value = '';
        }
    }
    function SetCancel() {
        var status = document.getElementById("txtSalaryStatus").value;
        if (status == '2') {
            return;
        }
        let chk = document.getElementById('chkCancel');
        let txtCancelBy = document.getElementById('txtCancelBy');
        let txtCancelDate = document.getElementById('txtCancelDate');
        if (chk.checked) {
            txtCancelBy.value = '@ViewBag.User';
            txtCancelDate.value = new Date().toISOString().split('T')[0];
        } else {
            txtCancelBy.value = '';
            txtCancelDate.value = '';
        }
    }
    function printSlip(slipNo, staffId) {
        var url = '@Url.Content("~")/Form?DB=@dbname&SRC=@dbSource&Form=PayrollSlip&Code=' + slipNo + '&Id=' + staffId;
        window.open(url, '_blank');
    }
</script>
