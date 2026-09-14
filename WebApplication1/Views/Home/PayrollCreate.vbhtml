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
    Dim sql As String = "SELECT * FROM Mas_HRStaff"
    Dim dt As New Data.DataTable
    dt = obj.GetDataFromSQL(sql)
    If Request.Form("submit") IsNot Nothing Then
        Dim StaffId = Request.Form("StaffId")
        Dim PayDate = Request.Form("PayDate")
        Dim StartDate = Request.Form("StartDate")
        Dim EndDate = Request.Form("EndDate")
        Dim Note = Request.Form("Note")
        Dim PostFlag = Request.Form("PostFlag")
        sql = "EXEC dbo.Insert_PayrollByStaff '{0}',1,'{1}',{2}"
        msg = obj.ExecuteSQL(String.Format(sql, PayDate, ViewBag.User, StaffId))
        If msg = "OK" Then
            sql = "EXEC dbo.Insert_AddDeductPayroll '{0}','{1}','{2}',{3}"
            msg = obj.ExecuteSQL(String.Format(sql, StartDate, EndDate, ViewBag.User, StaffId))
            If msg = "OK" Then
                If PostFlag = "Y" Then
                    sql = "EXEC dbo.Insert_PayrollToJournal '{0}','{1}','{2}','{3}','{4}'"
                    msg = obj.ExecuteSQL(String.Format(sql, StartDate, EndDate, PayDate, ViewBag.User, Note))
                End If
                If msg = "OK" Then
                    msg = "สร้างรายการเงินเดือนเรียบร้อยแล้ว"
                Else
                    msg = obj.Message
                End If
            Else
                msg = obj.Message
            End If
        Else
            msg = obj.Message
        End If
    End If
End Code

<h2>สร้างรายการเงินเดือน</h2>
<div class="container-fluid">
    <input type="button" value="รายชื่อพนักงาน" onclick="openStaffList()" />
    @If dt.Rows.Count > 0 Then

        @<form action="" method="post" style="display:flex;flex-direction:column;width:100%">
            <label>พนักงาน</label>
            <select id="txtStaff" name="StaffId">
                @For Each dr As Data.DataRow In dt.Rows
                    @<option value="@dr("StaffId")">
                        @dr("StaffName")
                    </option>
                Next
            </select>
            <label>วันที่จ่าย</label>
            <input type="date" name="PayDate" placeholder="วันที่จ่าย" />
            <label>วันทำงานเริ่มต้น</label>
            <input type="date" name="StartDate" placeholder="วันทำงานเริ่มต้น" />
            <label>วันทำงานสิ้นสุด</label>
            <input type="date" name="EndDate" placeholder="วันทำงานสิ้นสุด" />
            <label>หมายเหตุ</label>
            <input type="text" name="Note" placeholder="หมายเหตุ" />
            <select name="PostFlag">
                <option value="N">ยังไม่ลงบัญชี</option>
                <option value="Y">ลงบัญชี</option>
            </select>
            <input type="submit" name="submit" value="สร้างรายการเงินเดือน" />
        </form>
    End If
    <table>
        <thead>
            <tr>
                <th>Staff Name</th>
                <th>Slip#</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                Dim rs = obj.GetDataFromSQL(String.Format("SELECT TOP 1 SlipNo,PaymentDate FROM Acc_HRPayRoll WHERE StaffId={0} ORDER BY PaymentDate DESC", dr("StaffId")))
                @<tr>
                    <td>@dr("StaffName")</td>
                    <td>
                        @If rs.Rows.Count > 0 Then
                            Dim r = rs.Rows(0)
                            @<button type="button" onclick="printSlip('@r("SlipNo")')">@r("SlipNo")</button>
                        End If
                    </td>
                </tr>
            Next
        </tbody>
    </table>
</div>
@msg
<script type="text/javascript">
    var msg = '@msg';
    if (msg !== '') {
        alert(msg);
    }
    function printSlip(slipNo) {
        var url = '@Url.Content("~")/Form?DB=@dbname&SRC=@dbSource&Form=PayrollSlip&Code=' + slipNo;
        window.open(url, '_blank');
    }
    function openStaffList() {
        var url = '@Url.Content("~")/?DB=@dbname&SRC=@dbSource&Form=HRStaff';
        window.open(url, '_blank');
    }
</script>