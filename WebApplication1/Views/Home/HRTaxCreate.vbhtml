@Code
    ViewData("Title") = "HRTaxCreate"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim msg As String = ""
    Dim sql As String = ""
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable
    Dim docDate = New Date(DateTime.Now.Year, 12, 31).ToString("yyyy-MM-dd")
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    Dim dateTo = DateAdd("d", -1, DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1))).ToString("yyyy-MM-dd")
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If
    Dim incType As Integer = 1
    Dim lawNo As Integer = 0
    Dim docType As String = "PND1"
    Dim note As String = ""
    If Not Request.Form("Submit") Is Nothing Then
        sql = "DECLARE @@RC int
DECLARE @@DocType varchar(10)='{10}'
DECLARE @@TaxId varchar(50)='{0}'
DECLARE @@TaxName varchar(500)='{1}'
DECLARE @@TaxAddress varchar(2000)='{2}'
DECLARE @@TaxBranch varchar(6)='{3}'
DECLARE @@CompType int={4}
DECLARE @@User varchar(10)='{5}'
DECLARE @@IncType int={6}
DECLARE @@TaxNote varchar(500)='{7}'
DECLARE @@DateFrom date='{8}'
DECLARE @@DateTo date='{9}'
DECLARE @@DocDate date='{11}'
DECLARE @@MinValue int=0

IF '{10}'='PND1'
BEGIN
    EXECUTE @@RC = [dbo].[Insert_WHTaxFromPayroll]
    @@DocType
    ,@@TaxId
    ,@@TaxName
    ,@@TaxAddress
    ,@@TaxBranch
    ,0
    ,@@CompType
    ,@@User
    ,@@IncType
    ,@@TaxNote
    ,@@DateFrom
    ,@@DateTo
    ,@@MinValue
END
ELSE
BEGIN
    EXECUTE @@RC = [dbo].[Insert_WHTaxSumFromPayroll]
    @@DocType
    ,@@TaxId
    ,@@TaxName
    ,@@TaxAddress
    ,@@TaxBranch
    ,1
    ,@@CompType
    ,@@User
    ,@@IncType
    ,@@TaxNote
    ,@@DocDate
END
"
        sql = String.Format(sql, Request.Form("TaxNumber"), Request.Form("TName"), Request.Form("TAddress"), Request.Form("TaxBranch"), Request.Form("LawNo"), ViewBag.User, Request.Form("IncType"), Request.Form("Note"), Request.Form("DateFrom"), Request.Form("DateTo"), Request.Form("DocType"), Request.Form("DocDate"))
        msg = obj.ExecuteSQL(sql)
        dateFrom = Request.Form("DateFrom")
        dateTo = Request.Form("DateTo")
        incType = Request.Form("IncType")
        lawNo = Request.Form("LawNo")
        docDate = Request.Form("DocDate")
        docType = Request.Form("DocType")
        note = Request.Form("Note")
        Response.StatusCode = 200
        Response.SuppressFormsAuthenticationRedirect = True
    End If

    dt = obj.GetDataFromSQL("SELECT * FROM vProfileConfig")
    Dim taxnumber As String = ""
    Dim taxname As String = ""
    Dim taxaddress As String = ""
    Dim taxbranch As String = ""
    If dt.Rows.Count > 0 Then
        taxnumber = dt.Rows(0)("CompanyTaxNo")
        taxbranch = dt.Rows(0)("CompanyTaxBranch")
        taxname = dt.Rows(0)("CompanyName")
        taxaddress = dt.Rows(0)("CompanyAddress")
    End If

End Code
<h2>สร้างรายการ ภงด1/1ก</h2>
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-3">
            <form action="" method="post">
                Company Tax-Id : <input type="text" id="txtTaxNumber" class="form-control" name="TaxNumber" value="@taxnumber" />
                Branch <input type="text" id="txtTaxBranch" class="form-control" name="TaxBranch" value="@taxbranch" />
                <br />
                Company Name : <input type="text" id="txtTName" class="form-control" name="TName" value="@taxname" />
                <br />
                Company Address : <input type="text" id="txtTAddress" class="form-control" name="TAddress" value="@taxaddress" />
                <br />
                <select id="txtDocType" name="DocType" class="form-control dropdown">
                    <option value="PND1" @IIf(docType.Equals("PND1"), "selected", "")>ภงด.1</option>
                    <option value="PND1A" @IIf(docType.Equals("PND1A"), "selected", "")>ภงด.1ก</option>
                </select>
                <b>ภงด.1</b>
                Date From :<input type="date" id="txtDateFrom" name="DateFrom" class="form-control" value="@dateFrom" />
                <br />
                Date To :<input type="date" id="txtDateTo" name="DateTo" class="form-control" value="@dateTo" />
                <br />
                <b>ภงด.1ก</b>
                Document Date :<input type="date" id="txtDocDate" name="DocDate" class="form-control" value="@docDate" />
                <br />
                <select id="txtIncType" name="IncType" class="form-control dropdown">
                    <option value="1" @IIf(incType.Equals(1), "selected", "")>
                        1.เงินเดือน ค่าจ้าง เบี้ยเลี้ยง โบนัส ฯลฯ ตามมาตรา 40(1)
                    </option>
                    <option value="2" @IIf(incType.Equals(2), "selected", "")>
                        2.ค่าธรรมเนียม ค่านายหน้า ฯลฯ ตามมาตรา 40(2)
                    </option>
                    <option value="3" @IIf(incType.Equals(3), "selected", "")>
                        3.ค่าแห่งลิขสิทธิ์ ฯลฯ ตามมาตรา 40(1)
                    </option>
                    <option value="4" @IIf(incType.Equals(4), "selected", "")>
                        4.(ก)ค่าดอกเบี้ย ฯลฯ ตามมาตรา 40(4)(ก)
                    </option>
                    <option value="5" @IIf(incType.Equals(5), "selected", "")>
                        4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.1) ร้อยละ 30
                    </option>
                    <option value="6" @IIf(incType.Equals(6), "selected", "")>
                        4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.2) ร้อยละ 25
                    </option>
                    <option value="7" @IIf(incType.Equals(7), "selected", "")>
                        4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.3) ร้อยละ 20
                    </option>
                    <option value="8" @IIf(incType.Equals(8), "selected", "")>
                        4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.4) อัตราอื่นๆ
                    </option>
                    <option value="9" @IIf(incType.Equals(9), "selected", "")>
                        4.(ข)(2)กรณีผู้รับเงินปันผลไม่ได้รับเครดิตภาษีเพราะกิจการได้รับยกเว้น
                    </option>
                    <option value="10" @IIf(incType.Equals(10), "selected", "")>
                        4.(ข)(3)เงินปันผลหรือส่วนแบ่งกำไรที่ได้รับยกเว้นไม่ต้องนำรวมมาคำนวณ
                    </option>
                    <option value="11" @IIf(incType.Equals(11), "selected", "")>
                        4.(ข)(4)กำไรที่รับรู้ทางบัญชีโดยวิธีส่วนได้เสีย
                    </option>
                    <option value="12" @IIf(incType.Equals(12), "selected", "")>
                        4.(ข)(5)อื่นๆ (ระบุ)
                    </option>
                    <option value="13" @IIf(incType.Equals(13), "selected", "")>
                        5.การจ่ายเงินได้ที่ต้องหักภาษี ณ ที่จ่ายตามคำสั่งกรมสรรพากรที่ออกตาม มาตรา 3 เตรส
                    </option>
                    <option value="14" @IIf(incType.Equals(14), "selected", "")>
                        6.อื่นๆ (ระบุ)
                    </option>
                </select>
                <br />
                <select id="txtLawNo" class="form-control dropdown" name="LawNo">
                    <option value="0" @IIf(lawNo.Equals(0), "selected", "")>องค์กรขนาดเล็ก</option>
                    <option value="1" @IIf(lawNo.Equals(1), "selected", "")>องค์กรขนาดใหญ่</option>
                </select>
                <br />
                Note : <input type="text" id="txtNote" name="Note" class="form-control" value="@note" />
                <br />
                <input type="submit" value="Create" name="Submit" class="btn btn-success" />
            </form>
        </div>
        <div class="col-sm-9">
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>Doc No</th>
                        <th>Doc Date</th>
                        <th>Employee Tax </th>
                        <th>Employee Name </th>
                        <th>Tax Amount </th>
                    </tr>
                </thead>
                <tbody>
                    @Code
                        dt = obj.GetDataFromSQL("SELECT * FROM Acc_WHTax WHERE DocNo like 'PND1%' ORDER BY DocDate DESC,DocNo")
                        If dt.Rows.Count > 0 Then
                            For Each dr As Data.DataRow In dt.Rows
                                @<tr>
                                    <td>
                                        <a href="~/Form?Form=FormWHTax&SRC=@dbSource&DB=@dbname&Code=@dr("DocNo")">@dr("DocNo")</a>
                                    </td>
                                    <td>@Convert.ToDateTime(dr("DocDate")).ToString("dd/MM/yyyy")</td>
                                    <td>@dr("TaxNumber3")</td>
                                    <td>@dr("TName3")</td>
                                    <td style="text-align:right;">@dr("TotalPayTax")</td>
                                </tr>
                            Next
                        End If
                    End Code                         
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
</script>