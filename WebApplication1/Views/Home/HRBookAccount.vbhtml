@Code
    ViewData("Title") = "HRBookAccount"
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

    Dim staffId As Integer = 0
    Dim contractId As Integer = 0
    If Not Request.QueryString("ID") Is Nothing Then
        contractId = Convert.ToInt32(Request.QueryString("ID"))
        Dim r = obj.GetDataFromSQL(String.Format("SELECT * FROM Acc_HRContract WHERE ContractId={0}", contractId))
        If r.Rows.Count > 0 Then
            staffId = r.Rows(0)("StaffId")
        End If
    End If
    Dim bankCode As String = ""
    Dim bookCode As String = ""
    Dim bookName As String = ""

    If Not Request.Form("Submit") Is Nothing Then
        staffId = Request.Form("StaffId")
        contractId = Request.Form("ContractId")
        bankCode = Request.Form("BankCode")
        bookCode = Request.Form("BookCode")
        bookName = Request.Form("BookName")
        sql = "
IF NOT EXISTS(SELECT 1 FROM Mas_HRBookAccount WHERE ContractId={0} AND StaffId={1})
BEGIN
    INSERT INTO Mas_HRBookAccount
    SELECT {1},{0},'{2}','{3}','{4}'
END
ELSE
BEGIN
    UPDATE Mas_HRBookAccount 
    SET BankCode='{2}',BookCode='{3}',BookName='{4}'
    WHERE ContractId={0} AND StaffId={1}
END
"
        sql = String.Format(sql, contractId, staffId, bankCode, bookCode, bookName)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If

    sql = "SELECT a.[StaffId],concat(b.[StaffName],' ',b.[StaffLastName]) as [StaffName]
,a.[ContractId]
,a.[BankCode]
,a.[BookCode]
,a.[BookName]
FROM [Mas_HRBookAccount] a
INNER JOIN [Mas_HRStaff] b
on a.StaffId=b.StaffId
"
    If Not Request.QueryString("ID") Is Nothing Then
        sql &= String.Format(" WHERE a.ContractId={0}", contractId)
    End If
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Employee Bank Accounts / สมุดบัญชีของพนักงาน</h2>
<input type="button" class="btn btn-warning" value="Add New" data-target="#mdlEdit" data-toggle="modal" onclick="SetData('@contractId','@staffId','','','')" />
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Bank Name</th>
                <th>Account Name</th>
                <th>Staff Name</th>
            </tr>
        </thead>
        <tbody>
            @For each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" class="btn btn-primary" value="Edit" data-target="#mdlEdit" data-toggle="modal" onclick="SetData('@dr("ContractId")','@dr("StaffId")','@dr("BankCode")','@dr("BookCode")','@dr("BookName")')" />
                    </td>
                    <td>
                        @dr("BankCode")
                    </td>
                    <td>
                        @dr("BookCode") / @dr("BookName")
                    </td>
                    <td>
                        @dr("StaffName")
                    </td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div>No Data To show</div>
End If
<div class="modal" role="document" id="mdlEdit">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-body">
                <form action="" method="post">
                    <input type="hidden" id="txtStaffId" name="StaffId" value="@staffId" />
                    <input type="hidden" id="txtContractId" name="ContractId" value="@contractId" />
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Contract Id</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="cboContractId" class="form-control dropdown" onchange="SetCombo()">
                                <option value="0/0"></option>
                                @Code
                                    Dim dtContract = obj.GetDataFromSQL("SELECT * FROM Acc_HRContract")
                                    If dtContract.Rows.Count > 0 Then
                                        For Each dr As System.Data.DataRow In dtContract.Rows
                                            @<option value="@dr("ContractId")/@dr("StaffId")" @IIf(dr("ContractId").ToString().Equals(contractId.ToString), "selected", "")>@dr("ContractNo")</option>
                                        Next
                                    End If
                                End Code
                            </select>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Staff</label>
                        </div>
                        <div class="col-sm-8">
                            <select id="cboStaffId" class="form-control dropdown" disabled>
                                <option value="0"></option>
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
                            <label>Bank</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtBankCode" class="form-control" name="BankCode" value="@bankCode" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>A/C No</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtBookCode" class="form-control" name="BookCode" value="@bookCode" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>A/C Name</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtBookName" class="form-control" name="BookName" value="@bookName" />
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
<script type="text/javascript">
    var msg = '@msg';
    if (msg !== '') {
            alert(msg);
    }
    function SetCombo() {
        var data = document.getElementById('cboContractId').value;
        document.getElementById('txtContractId').value = data.substr(0, data.indexOf('/'));
        document.getElementById('txtStaffId').value = data.substr(data.indexOf('/') + 1, data.length);
        document.getElementById('cboStaffId').value = data.substr(data.indexOf('/') + 1, data.length);
    }
    function SetData(ct, st, bank, book, nme) {
        document.getElementById('txtContractId').value = ct;
        document.getElementById('txtStaffId').value = st;
        document.getElementById('txtBankCode').value = bank;
        document.getElementById('txtBookCode').value = book;
        document.getElementById('txtBbokName').value = nme;
    }
</script>