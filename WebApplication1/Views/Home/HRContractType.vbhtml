@Code
    ViewData("Title") = "HRContractType"
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

    Dim contractTypeId As Integer = 0
    Dim contractType As String = ""
    Dim isCheckTime As Int16 = 0
    Dim minuteCheck As Integer = 0
    Dim dayCheck As Integer = 0
    Dim monthCheck As Integer = 0
    Dim paymentDays As Integer = 0
    Dim paymentDay As Integer = 0
    If Not Request.Form("Submit") Is Nothing Then
        contractTypeId = Request.Form("ContractTypeId")
        contractType = Request.Form("ContractType")
        isCheckTime = Request.Form("IsCheckTime")
        minuteCheck = Request.Form("MinuteCheck")
        dayCheck = Request.Form("DayCheck")
        monthCheck = Request.Form("MonthCheck")
        paymentDays = Request.Form("PaymentDays")
        paymentDay = Request.Form("PaymentDay")
        sql = "
IF '0'='{0}'
BEGIN
    DECLARE @@id int=(SELECT ISNULL(MAX(ContractTypeId),0)+1 FROM Mas_HRContractType)
    SET IDENTITY_INSERT Mas_HRContractType ON
    
    INSERT INTO Mas_HRContractType
    SELECT @@id,'{1}',{2},{3},{4},{5},{6},{7}
    
    SET IDENTITY_INSERT Mas_HRContractType OFF
END
ELSE
BEGIN
    UPDATE Mas_HRContractType
    SET 
        ContractType='{1}',
        IsCheckTime={2},
        MinuteCheck={3},
        DayCheck={4},
        MonthCheck={5},
        PaymentDays={6},
        PaymentDay={7}
    WHERE ContractTypeId={0}
END
"
        msg = obj.ExecuteSQL(String.Format(sql, contractTypeId, contractType, isCheckTime, minuteCheck, dayCheck, monthCheck, paymentDays, paymentDay))
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If
    sql = "select ContractTypeId,ContractType,(case when IsCheckTime=1 then 1 else 0 end) as IsCheckTime,MinuteCheck,DayCheck,MonthCheck,PaymentDays,PaymentDay
FROM Mas_HRContractType"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Contract Configuration / กำหนดค่าสัญญาจ้าง</h2>
<input type="button" value="Add New"  class="btn btn-sm btn-success" onclick="editData(0,'',0,0,0,0,0,0)" />
@If dt.Rows.Count > 0 Then
    @<div class="row">
        <div class="col-sm-6">
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Contract Type</th>
                    </tr>
                </thead>
                <tbody>
                    @For each dr As Data.DataRow In dt.Rows
                        @<tr>
                            <td>
                                <input type="button" value="Edit" class="btn btn-sm btn-primary" onclick="editData('@dr("ContractTypeId")','@dr("ContractType")','@dr("IsCheckTime")','@dr("MinuteCheck")','@dr("DayCheck")','@dr("MonthCheck")','@dr("PaymentDays")','@dr("PaymentDay")')" />
                            </td>
                            <td>
                                @dr("ContractType")
                            </td>
                        </tr>
                    Next
                </tbody>
            </table>
        </div>
        <div class="col-sm-6">
            <hr />
            <form action="" method="post">
                <div class="row">
                    <div class="col-sm-4">
                        <label>Contract Type Id</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" id="txtContractTypeID" name="ContractTypeId" value="@contractTypeId" class="form-control" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Contract Type Name</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="text" id="txtContractType" name="ContractType" value="@contractType" class="form-control" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Check Minute</label>
                    </div>
                    <div class="col-sm-8">
                        <select id="txtIsCheckTime" name="IsCheckTime" class="form-control dropdown">
                            <option value="0" @IIf(isCheckTime = 1, "", "selected")>No</option>
                            <option value="1" @IIf(isCheckTime = 1, "selected", "")>Yes</option>
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Work Minutes Per Day</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" id="txtMinuteCheck" name="MinuteCheck" value="@minuteCheck" class="form-control" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Work Days Per Month</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" id="txtDayCheck" name="DayCheck" value="@dayCheck" class="form-control" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Work Months Per Year</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" id="txtMonthCheck" name="MonthCheck" value="@monthCheck" class="form-control" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Payroll Days</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" id="txtPaymentDays" name="PaymentDays" value="@PaymentDays" class="form-control" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4">
                        <label>Payment Day</label>
                    </div>
                    <div class="col-sm-8">
                        <input type="number" id="txtPaymentDay" name="PaymentDay" value="@paymentDay" class="form-control" />
                    </div>
                </div>
                <input type="submit" name="submit" value="Save" class="btn btn-primary" />
            </form>
        </div>
    </div>
Else
    @<p>No data available.</p>
End If
<script type="text/javascript">
    var msg = '@msg';
    if(msg !== '') {
        alert(msg);
    }
    function editData(Id, Name, ChkTime ,MinChk,DayChk,MonthChk,PayDays,PayDay) {
        document.getElementById('txtContractTypeID').value = Id;
        document.getElementById('txtContractType').value = Name;
        document.getElementById('txtIsCheckTime').value = ChkTime;
        document.getElementById('txtMinuteCheck').value = MinChk;
        document.getElementById('txtDayCheck').value = DayChk;
        document.getElementById('txtMonthCheck').value = MonthChk;
        document.getElementById('txtPaymentDays').value = PayDays;
        document.getElementById('txtPaymentDay').value = PayDay;
    }
</script>