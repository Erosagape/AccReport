@Code
    ViewData("Title") = "CloseAcc"
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
    If bConn Then
        If Not Request.Form("Submit") Is Nothing Then
            Dim typ = Request.Form("closeType")
            Dim sql As String = ""
            Dim dateFrom = Request.Form("dateFrom")
            Dim dateTo = Request.Form("dateTo")
            Select Case typ
                Case "WHT"
                    sql = String.Format("EXEC dbo.Generate_GLClosingWHT '{1}','{0}','{1}','{2}'", dateFrom, dateTo, ViewBag.User)
                Case "VAT"
                    sql = String.Format("EXEC dbo.Generate_GLClosingVAT '{1}','{0}','{1}','{2}'", dateFrom, dateTo, ViewBag.User)
                Case "P/L"
                    sql = String.Format("EXEC dbo.Generate_GLClosingProfit dbo.GetAccConfig('GL_CONFIG','AccumulateProfit'),'{1}','{0}','{1}','{2}','Closing Acc'", dateFrom, dateTo, ViewBag.User)
            End Select
            If sql <> "" Then
                Dim dt = obj.GetDataFromSQL(sql)
                msg = obj.Message
                If msg = "OK" Then
                    msg = "Journal " & dt.Rows(0)("JournalNo") & " Created"
                End If
            End If
        End If
    End If
End Code
@If bConn Then
    @<h2>ปิดบัญชี / Closing Account</h2>
    @<div class="row">
        <form action="" method="post" class="col-sm-4">
            วันที่เอกสารเริ่มต้น / Voucher Date From : <input type="date" name="dateFrom" id="txtDateFrom" class="form-control" />
            <br />
            วันที่เอกสารสิ้นสุด / Voucher Date To : <input type="date" name="dateTo" id="txtDateTo" class="form-control" />
            <br />
            <select id="cboType" name="closeType" class="form-control dropdown">
                <option value="0">Select Type</option>
                <option value="WHT">WHT = ปิดยัญชีหัก ณ ที่จ่าย เข้า ลูกหนี้-สรรพากร</option>
                <option value="VAT">VAT = ปิดบัญชีภาษีซื้อ/ขาย เข้า ลูกหนี้/เจ้าหนี้-สรรพากร</option>
                <option value="P/L">P/L = ปิดบัญชีกำไร/ขาดทุน เข้า กำไรสะสม </option>
            </select>
            <br />
            <input type="submit" name="submit" value="Process" class="btn btn-danger" />
        </form>
    </div>
    @Code
        Dim rs = obj.GetDataFromSql("select * from vSum_RevenueTax")
        If rs.Rows.Count > 0 Then
            @<b>Estimated Tax Calculated</b>
            @<table class="table table-bordered">
                <thead>
                    <tr>
                        @For each dc As System.Data.DataColumn In rs.Columns
                            @<th>@dc.ColumnName</th>
                        Next
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In rs.Rows
                        @<tr>
                            @For each dc As System.Data.DataColumn In rs.Columns
                                @<td>@dr(dc.ColumnName)</td>
                            Next
                        </tr>
                    Next
                </tbody>
            </table>
        End If
    End Code
    @msg
End If
<script type="text/javascript">
    var msg = "@msg";
    if (msg !== '') {
        alert(msg);
    }
</script>