@Code
    ViewData("Title") = "WH-Tax Create"
    Dim DocNo As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        DocNo = Request.QueryString("Code")
    End If
    Dim DocType As String = "1"
    If Not Request.QueryString("Type") Is Nothing Then
        DocType = Request.QueryString("Type")
    End If
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim whtNo As String = ""
    Dim msg As String = ""
    If Not Request.Form("DocNo") Is Nothing Then
        DocNo = Request.Form("DocNo")
        If DocNo <> "" Then
            DocType = Request.Form("DocType")
            Dim FormType As String = Request.Form("FormType")
            Dim LawCode As String = Request.Form("LawCode")
            Dim PayTaxType As String = Request.Form("PayTaxType")
            Dim IncType As String = Request.Form("IncType")
            Dim incomeText As String = Request.Form("IncomeText")
            Dim UserID = ViewBag.User
            Dim sql As String = "
EXEC [dbo].[Insert_WHTaxFromTransaction]
   '{0}'
  ,{1}
  ,{2}
  ,{3}
  ,'{4}'
  ,'{5}'
  ,{6}
  ,{7}
"
            Dim result = obj.GetDataFromSQL(String.Format(sql, UserID, FormType, LawCode, IncType, incomeText, DocNo, DocType, PayTaxType))
            msg = obj.Message
            If result.Rows.Count > 0 Then
                whtNo = result.Rows(0).Item("DocNo").ToString()
            End If
        End If
    End If
End Code
<h2>WH-Tax Create</h2>
<form action="" method="post">
    <div class="row">
        <div class="col-sm-4">
            <strong>Document Type</strong>
        </div>
        <div class="col-sm-6">
            <select class="form-control dropdown" name="DocType" id="ddlDocType">
                <option value="1" @(IIf(DocType = "1", "selected", ""))>หัก ณ ที่จ่าย</option>
                <option value="2" @(IIf(DocType = "2", "selected", ""))>กระทำการแทน</option>
                <option value="3" @(IIf(DocType = "3", "selected", ""))>ถูกหัก ณ ที่จ่าย</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <strong>From Document No</strong>
        </div>
        <dvi class="col-sm-6">
            <input type="text" class="form-control" name="DocNo" id="txtDocNo" value="@DocNo" />
        </dvi>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <strong>Form Type</strong>
        </div>
        <dvi class="col-sm-6">
            <select class="form-control dropdown" name="FormType" id="ddlFormType">
                <option value="1">ภงด 1ก</option>
                <option value="2">ภงด 1ก พิเศษ</option>
                <option value="3">ภงด 2</option>
                <option value="4">ภงด 3</option>
                <option value="5">ภงด 2ก</option>
                <option value="6">ภงด 3</option>
                <option value="7">ภงด 53</option>
            </select>
        </dvi>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <strong>Law Code</strong>
        </div>
        <div class="col-sm-6">
            <select class="form-control dropdown" id="txtLawCode" name="LawCode">
                <option value="1">3 เตรส</option>
                <option value="2">65 จัดวา</option>
                <option value="3">69 ทวิ</option>
                <option value="4">48 ทวิ</option>
                <option value="5">50 ทวิ</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <strong>Tax Payment Type</strong>
        </div>
        <div class="col-sm-6">
            <select class="form-control dropdown" id="txtPayTaxType" name="PayTaxType">
                <option value="1">หัก ณ ที่จ่าย</option>
                <option value="2">ออกภาษีให้ตลอดไป</option>
                <option value="3">ออกภาษีให้ครั้งเดียว</option>
                <option value="4">อื่นๆ (ระบุ)</option>
            </select>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <strong>Income Description</strong>
        </div>
        <div class="col-sm-6">
            <input type="text" class="form-control" name="IncomeText" id="txtIncomeText" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <strong>Income Type</strong>
        </div>
        <div class="col-sm-6">
            <select id="txtIncType" class="form-control dropdown" name="IncType">
                <option value="1">
                    1.เงินเดือน ค่าจ้าง เบี้ยเลี้ยง โบนัส ฯลฯ ตามมาตรา 40(1)
                </option>
                <option value="2">
                    2.ค่าธรรมเนียม ค่านายหน้า ฯลฯ ตามมาตรา 40(2)
                </option>
                <option value="3">
                    3.ค่าแห่งลิขสิทธิ์ ฯลฯ ตามมาตรา 40(1)
                </option>
                <option value="4">
                    4.(ก)ค่าดอกเบี้ย ฯลฯ ตามมาตรา 40(4)(ก)
                </option>
                <option value="5">
                    4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.1) ร้อยละ 30
                </option>
                <option value="6">
                    4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.2) ร้อยละ 25
                </option>
                <option value="7">
                    4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.3) ร้อยละ 20
                </option>
                <option value="8">
                    4.(ข)(1)เงินปันผลเงินส่วนแบ่งกำไร (1.4) อัตราอื่นๆ
                </option>
                <option value="9">
                    4.(ข)(2)กรณีผู้รับเงินปันผลไม่ได้รับเครดิตภาษีเพราะกิจการได้รับยกเว้น
                </option>
                <option value="10">
                    4.(ข)(3)เงินปันผลหรือส่วนแบ่งกำไรที่ได้รับยกเว้นไม่ต้องนำรวมมาคำนวณ
                </option>
                <option value="11">
                    4.(ข)(4)กำไรที่รับรู้ทางบัญชีโดยวิธีส่วนได้เสีย
                </option>
                <option value="12">
                    4.(ข)(5)อื่นๆ (ระบุ)
                </option>
                <option value="13">
                    5.การจ่ายเงินได้ที่ต้องหักภาษี ณ ที่จ่ายตามคำสั่งกรมสรรพากรที่ออกตาม มาตรา 3 เตรส
                </option>
                <option value="14">
                    6.อื่นๆ (ระบุ)
                </option>
            </select>
        </div>
    </div>
    <input type="submit" value="Create Document" class="btn btn-success" />
</form>
<p>
    @msg
</p>
<script type="text/javascript">
    let whtNo = '@whtNo';
    if (whtNo !== '') {
        alert('Create From Document No ' + whtNo + ' Successfully!');
        window.open('?Form=FormWHTax&SRC=@dbSource&DB=@dbname&Code=@whtNo','_blank');
    }
</script>