@Code
    ViewData("Title") = "HRTaxDeductConfig"
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

    Dim TaxYear As Integer = 0
    Dim Seq As Integer = 0
    Dim DeductDesc As String = ""
    Dim DeductAmount As Decimal = 0
    Dim DeductMax As Decimal = 0

    Dim msg As String = ""
    Dim sql As String = ""

    If Not Request.Form("submit") Is Nothing Then
        TaxYear = Convert.ToInt32(Request.Form("TaxYear"))
        Seq = Convert.ToInt32(Request.Form("Seq"))
        DeductDesc = Request.Form("DeductDesc")
        DeductAmount = Convert.ToDecimal(Request.Form("DeductAmount"))
        DeductMax = Convert.ToDecimal(Request.Form("DeductMax"))
        sql = "IF '0'='{1}'
                BEGIN
                    DECLARE @@MaxSeq INT=(SELECT ISNULL(MAX([Seq]),0)+1 FROM [dbo].[Mas_HRTaxDeduct] where [TaxYear]='{0}')
                    INSERT INTO [dbo].[Mas_HRTaxDeduct] ([TaxYear], [Seq], [DeductDesc], [DeductAmount], [DeductMax])
                    VALUES ('{0}',@@MaxSeq, '{2}', {3}, {4})
                END
                ELSE
                BEGIN
                    UPDATE [dbo].[Mas_HRTaxDeduct] 
                    SET [DeductDesc]='{2}', [DeductAmount]={3}, [DeductMax]={4}
                    WHERE [TaxYear]='{0}' AND [Seq]='{1}'
                END"
        sql = String.Format(sql, TaxYear, Seq, DeductDesc, DeductAmount, DeductMax)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            msg = "Save Successfully"
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
        End If
    End If

    sql = "select TaxYear,Seq,DeductDesc,DeductAmount,DeductMax from Mas_HRTaxDeduct"
    dt = obj.GetDataFromSQL(sql)
End Code
<h2>Tax Deductable Config / กำหนดการลดหล่อนภาษี</h2>
<input type="button" value="Add New Deduction" data-target="#mdlEdit" data-toggle="modal" class="btn btn-sm btn-success" 
       onclick="editTaxDeductConfig('@DateTime.Now.Year','0','','0','0')" />
@If dt.Rows.Count > 0 Then
    @<table class="table table-bordered table-striped">
        <thead>
            <tr>
                <th>#</th>
                <th>ปีภาษี</th>
                <th>ลำดับ</th>
                <th>รายการลดหย่อน</th>
                <th>จำนวนเงินลดหย่อน</th>
                <th>จำนวนเงินสูงสุด</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" class="btn btn-info" value="Edit" data-target="#mdlEdit" data-toggle="modal" onclick="editTaxDeductConfig(
                            '@dr("TaxYear")', '@dr("Seq")', '@dr("DeductDesc")', '@dr("DeductAmount")', '@dr("DeductMax")')" />
                    </td>
                    <td>@dr("TaxYear")</td>
                    <td>@dr("Seq")</td>
                    <td>@dr("DeductDesc")</td>
                    <td>@dr("DeductAmount")</td>
                    <td>@dr("DeductMax")</td>
                </tr>
            Next
        </tbody>
    </table>
Else
    @<div class="alert alert-warning" role="alert">
        No data found.
    </div>
End If
<div class="modal" id="mdlEdit" role="document">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h4 class="modal-title">Edit Tax Deductable Config</h4>
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Tax Year</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtTaxYear" name="TaxYear" class="form-control" value="@TaxYear" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Sequence</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtSeq" name="Seq" class="form-control" value="@Seq" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Deduct Description</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="text" id="txtDeductDesc" name="DeductDesc" class="form-control" value="@DeductDesc" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Deduct Amount</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtDeductAmount" name="DeductAmount" class="form-control" value="@DeductAmount" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <label>Deduct Maximum Value</label>
                        </div>
                        <div class="col-sm-8">
                            <input type="number" id="txtDeductMax" name="DeductMax" class="form-control" value="@DeductMax" />
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
    if(msg!==''){
        alert(msg);
    }
    function editTaxDeductConfig(TaxYear, Seq, DeductDesc, DeductAmount, DeductMax) {
        document.getElementById('txtTaxYear').value = TaxYear;
        document.getElementById('txtSeq').value = Seq;
        document.getElementById('txtDeductDesc').value = DeductDesc;
        document.getElementById('txtDeductAmount').value = DeductAmount;
        document.getElementById('txtDeductMax').value = DeductMax;
    }
</script>