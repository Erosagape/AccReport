@Code
    ViewData("Title") = "HRTaxDeduct"
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

    Dim TaxYear As String = DateTime.Today.Year.ToString
    Dim StaffId As Integer = 0
    If Not Request.QueryString("Staff") Is Nothing Then
        StaffId = Request.QueryString("Staff")
    End If
    Dim DeductSeq As Integer = 0
    Dim DeductQty As Double = 1
    Dim DeductAmount As Double = 0
    Dim DeductTotal As Double = 0

    If Not Request.Form("Submit") Is Nothing Then
        TaxYear = Request.Form("TaxYear")
        StaffId = Request.Form("StaffId")
        DeductSeq = Request.Form("DeductSeq")
        DeductQty = Request.Form("DeductQty")
        DeductAmount = Request.Form("DeductAmount")
        DeductTotal = Request.Form("DeductTotal")

        sql = "IF NOT EXISTS(select 1 FROM Acc_HRTaxDeduct WHERE TaxYear = {0} AND StaffId = {1} AND DeductSeq = {2})
BEGIN
INSERT INTO Acc_HRTaxDeduct (TaxYear, StaffId, DeductSeq, DeductQty, DeductAmount, DeductTotal)
SELECT {0}, {1}, {2}, {3}, {4}, {5}
END
ELSE
BEGIN
UPDATE Acc_HRTaxDeduct
SET DeductQty = {2}, DeductAmount = {3}, DeductTotal = {4}
WHERE TaxYear = {0} AND StaffId = {1}
AND DeductSeq = {2}
END
"
        sql = String.Format(sql, TaxYear, StaffId, DeductSeq, DeductQty, DeductAmount, DeductTotal)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            msg = "Tax deduction data saved successfully."
        Else
            msg = obj.Message
        End If
    End If

    sql = "select a.TaxYear,a.StaffId,CONCAT(b.StaffName,' ',b.StaffLastName) as StaffName,a.DeductSeq,
c.DeductDesc,a.DeductQty,a.DeductAmount,a.DeductTotal from Acc_HRTaxDeduct a
inner join Mas_HRStaff b on a.StaffId = b.StaffId
inner join Mas_HRTaxDeduct c on a.TaxYear = c.TaxYear and a.DeductSeq = c.Seq
"
    If StaffId > 0 Then
        sql &= " where a.StaffId = " & StaffId
    End If
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Tax Deduct</h2>
<form action="" method="post">
    <div class="row">
        <div class="col-sm-4">
            <label>Staff ID</label>
        </div>
        <div class="col-sm-8" style="display:flex">
            <select id="txtStaffId" name="StaffId" class="form-control dropdown">
                <option value=""></option>
                @Code
                    Dim dtStaff = obj.GetDataFromSQL("SELECT * FROM Mas_HRStaff")
                    If dtStaff.Rows.Count > 0 Then
                        For Each dr As System.Data.DataRow In dtStaff.Rows
                            @<option value="@dr("StaffID")" @IIf(dr("StaffId").ToString.Equals(StaffId.ToString), "selected", "")>
                                @dr("Title")@dr("StaffName") @dr("StaffLastName")
                            </option>
                        Next
                    End If
                End Code
            </select>            
            <input type="button" value="Search" class="btn btn-primary" onclick="SearchStaff()" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Deduct Seq</label>
        </div>
        <div class="col-sm-8" style="display:flex">
            <input type="number" name="DeductSeq" value="@DeductSeq" class="form-control" />
            <input type="button" value="Choose Deduct" onclick="ShowDeductList()" />
        </div>
    </div>
    <div id="mdlDeduction" style="display:none;">
        <table class="table table-bordered">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Deduct Seq</th>
                    <th>Description</th>
                    <th>Amount</th>
                    <th>Max</th>
                </tr>
            </thead>
            <tbody>
                @Code
                    Dim dtDeduct = obj.GetDataFromSQL("SELECT * FROM Mas_HRTaxDeduct ")
                    If dtDeduct.Rows.Count > 0 Then
                        For Each dr As System.Data.DataRow In dtDeduct.Rows
                            @<tr>
                                <td>
                                    <input type="button" value="Select" onclick="SelectDeduct('@dr("TaxYear")','@dr("Seq")','@dr("DeductAmount")','@dr("DeductMax")')" />
                                </td>
                                <td>@dr("Seq")</td>
                                <td>@dr("DeductDesc")</td>
                                <td>@dr("DeductAmount")</td>
                                <td>@dr("DeductMax")</td>
                            </tr>
                        Next
                    End If
                End Code
            </tbody>
        </table>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Tax Year</label>
        </div>
        <div class="col-sm-8">
            <input type="number" name="TaxYear" value="@TaxYear" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Deduct Qty</label>
        </div>
        <div class="col-sm-8">
            <input type="number" name="DeductQty" value="@DeductQty" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Deduct Amount</label>
        </div>
        <div class="col-sm-8">
            <input type="number" name="DeductAmount" value="@DeductAmount" class="form-control" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <label>Deduct Total</label>
        </div>
        <div class="col-sm-8">
            <input type="number" name="DeductTotal" value="@DeductTotal" class="form-control" />
        </div>
    </div>
    <input type="submit" name="submit" value="Save" class="btn btn-primary" />
</form>
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>Tax Year</th>
                <th>Staff ID</th>
                <th>Deduct Seq</th>
                <th>Deduct Qty</th>
                <th>Deduct Amount</th>
                <th>Deduct Total</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As System.Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" class="btn btn-info" value="Edit" onclick="LoadDeduct('@dr("StaffId")','@dr("TaxYear")', '@dr("DeductSeq")', '@dr("DeductQty")', '@dr("DeductAmount")', '@dr("DeductTotal")')" />
                    </td>
                    <td>@dr("TaxYear")</td>
                    <td>@dr("StaffName")</td>
                    <td>@dr("DeductSeq") / @dr("DeductDesc")</td>
                    <td>@dr("DeductQty")</td>
                    <td>@dr("DeductAmount")</td>
                    <td>@dr("DeductTotal")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<p>No tax deduction data found.</p>
End If
<script type="text/javascript">
    var msg = '@msg';
    if (msg !== '') {
        alert(msg);
    }
    function ShowDeductList() {
        document.getElementById("mdlDeduction").style.display = "block";
    }
    function SelectDeduct(yy, seq, amount, max) {
        document.getElementsByName("TaxYear")[0].value = yy;
        document.getElementsByName("DeductSeq")[0].value = seq;
        document.getElementsByName("DeductAmount")[0].value = amount;
        document.getElementsByName("DeductTotal")[0].value = max;
        document.getElementById("mdlDeduction").style.display = "none";
    }
    function LoadDeduct(staffId, taxYear, deductSeq, deductQty, deductAmount, deductTotal) {
        document.getElementsByName("StaffId")[0].value = staffId;
        document.getElementsByName("TaxYear")[0].value = taxYear;
        document.getElementsByName("DeductSeq")[0].value = deductSeq;
        document.getElementsByName("DeductQty")[0].value = deductQty;
        document.getElementsByName("DeductAmount")[0].value = deductAmount;
        document.getElementsByName("DeductTotal")[0].value = deductTotal;
    }
    function SearchStaff() {
        var staffId = document.getElementById("txtStaffId").value;
        window.location.href = "?Form=HRTaxDeduct&DB=@dbName&SRC=@dbSource&Staff=" + staffId;
    }
</script>
