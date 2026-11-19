@Code
    ViewData("Title") = "PayrollCreate"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim msg As String = ""
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql As String = "SELECT * FROM vHR_Payroll"
    Dim dt As New Data.DataTable
    dt = obj.GetDataFromSQL(sql)
    If Request.Form("submit") IsNot Nothing Then
        Dim StaffId As Integer = Request.Form("StaffId")
        Dim PayDate = Request.Form("PayDate")
        Dim StartDate = Request.Form("StartDate")
        Dim EndDate = Request.Form("EndDate")
        Dim Note = Request.Form("Note")
        Dim PostFlag = Request.Form("PostFlag")
        If StaffId = 0 Then
            If PostFlag = "Y" Then
                sql = "EXEC dbo.Insert_PayrollToJournal '{0}','{1}','{2}'"
                Dim postmsg = obj.ExecuteSQL(String.Format(sql, PayDate, ViewBag.User, Note))
                If postmsg = "OK" Then
                    msg &= "บันทึกบัญชีเรียบร้อยแล้ว"
                Else
                    msg &= obj.Message
                End If
            Else
                For Each dr As System.Data.DataRow In dt.Rows
                    sql = "EXEC dbo.Insert_PayrollByStaff '{0}',1,'{1}',{2}"
                    Dim result = obj.ExecuteSQL(String.Format(sql, PayDate, ViewBag.User, dr("StaffId")))
                    If result = "OK" Then
                        sql = "EXEC dbo.Insert_AddDeductPayroll '{0}','{1}','{2}',{3},'{4}'"
                        result = obj.ExecuteSQL(String.Format(sql, StartDate, EndDate, ViewBag.User, dr("StaffId"), PayDate))
                        If result = "OK" Then
                            msg &= "สร้างรายการเงินเดือน " & dr("StaffName") & " เรียบร้อยแล้ว"
                        Else
                            msg &= obj.Message
                        End If
                    Else
                        msg &= obj.Message
                    End If
                Next
            End If
        Else
            If PostFlag = "Y" Then
                sql = "EXEC dbo.Insert_PayrollToJournal '{0}','{1}','{2}'"
                msg = obj.ExecuteSQL(String.Format(sql, PayDate, ViewBag.User, Note))
                If msg = "OK" Then
                    msg &= "บันทึกบัญชีเรียบร้อยแล้ว"
                Else
                    msg = obj.Message
                End If
            Else
                sql = "EXEC dbo.Insert_PayrollByStaff '{0}',1,'{1}',{2}"
                msg = obj.ExecuteSQL(String.Format(sql, PayDate, ViewBag.User, StaffId))
                If msg = "OK" Then
                    sql = "EXEC dbo.Insert_AddDeductPayroll '{0}','{1}','{2}',{3},'{4}'"
                    msg = obj.ExecuteSQL(String.Format(sql, StartDate, EndDate, ViewBag.User, StaffId, PayDate))
                    If msg = "OK" Then
                        msg &= "สร้างรายการเงินเดือนเรียบร้อยแล้ว"
                    Else
                        msg = obj.Message
                    End If
                Else
                    msg = obj.Message
                End If
            End If
        End If
    End If
End Code

<h2>สร้างรายการเงินเดือน</h2>
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-3">
            @If dt.Rows.Count > 0 Then
                @<form action="" method="post" style="display:flex;flex-direction:column;width:100%">
                    <label>พนักงาน</label>
                    <select id="txtStaff" name="StaffId" class="form-control dropdown">
                        <option value="0">ALL</option>
                        @For Each dr As Data.DataRow In dt.Rows
                            @<option value="@dr("StaffId")">
                                @dr("StaffName")
                            </option>
                        Next
                    </select>
                    <label>วันที่จ่าย</label>
                    <input type="date" name="PayDate" placeholder="วันที่จ่าย" class="form-control" />
                    <label>วันทำงานเริ่มต้น</label>
                    <input type="date" name="StartDate" placeholder="วันทำงานเริ่มต้น" class="form-control" />
                    <label>วันทำงานสิ้นสุด</label>
                    <input type="date" name="EndDate" placeholder="วันทำงานสิ้นสุด" class="form-control" />
                    <label>หมายเหตุ</label>
                    <input type="text" name="Note" placeholder="หมายเหตุ" class="form-control" />
                    <label>ลงบัญชี</label>
                    <select name="PostFlag" class="form-control dropdown">
                        <option value="N">ยังไม่ลงบัญชี</option>
                        <option value="Y">ลงบันทึกบัญชี</option>
                    </select>
                    <input type="submit" name="submit" value="สร้างรายการเงินเดือน" class="btn btn-success" />
                </form>
            End If
        </div>
        <div class="col-sm-9">
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Staff Name</th>
                        <th>Contract Type</th>
                        <th>Slip#</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt.Rows
                        Dim rs = obj.GetDataFromSQL(String.Format("SELECT distinct SlipNo,PaymentDate FROM Acc_HRPayRoll WHERE StaffId={0} ORDER BY PaymentDate DESC", dr("StaffId")))
                        @<tr>
                            <td>@dr("StaffName") / @dr("PositionName")</td>
                            <td>@dr("ContractType")</td>
                            <td>
                                @If rs.Rows.Count > 0 Then
                                    For Each r As Data.DataRow In rs.Rows
                                        @<button type="button" onclick="printSlip('@r("SlipNo")','@dr("StaffId")')">@Convert.ToDateTime(r("PaymentDate")).ToString("dd/MM/yyyy")</button>
                                    Next
                                End If
                            </td>
                        </tr>
                    Next
                </tbody>
            </table>
        </div>
    </div>
</div>
@msg
<script type="text/javascript">
    var msg = '@msg';
    if (msg !== '') {
        alert(msg);
    }
    function printSlip(slipNo,staffId) {
        var url = '@Url.Content("~")/Form?DB=@dbname&SRC=@dbSource&Form=PayrollSlip&Code=' + slipNo + '&Id=' + staffId;
        window.open(url, '_blank');
    }
    function openStaffList() {
        var url = '@Url.Content("~")/?DB=@dbname&SRC=@dbSource&Form=HRStaff';
        window.open(url, '_blank');
    }
</script>