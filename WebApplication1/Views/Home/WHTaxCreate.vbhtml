@Code
    ViewData("Title") = "WHTaxCreate"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim msg As String = ""
    Dim docno As String = ""
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    If Not Request.Form("submit") Is Nothing Then
        Dim AccDocNo = Request.Form("AccDocNo")
        Dim FormType = Request.Form("FormType")
        Dim IncType = Request.Form("IncType")
        Dim TaxLawNo = Request.Form("TaxLawNo")
        Dim PayTaxType = Request.Form("PayTaxType")
        Dim UserId = ViewBag.User
        Dim sqlTemp As String = "EXEC dbo.Insert_WHTaxFromPC '{0}',{1},'{2}','{3}',{4},{5}"
        msg = obj.ExecuteSQL(String.Format(sqlTemp, AccDocNo, FormType, TaxLawNo, UserId, IncType, PayTaxType))
        If msg = "OK" Then
            docno = AccDocNo
        End If
    End If
    Dim sql As String = "SELECT * FROM vPC_H a WHERE NOT EXISTS(select 1 from Acc_WHTax WHERE DocNo = a.AccDocNo) AND TotalWht > 0"
    Dim dt As New Data.DataTable
    dt = obj.GetDataFromSQL(sql)
End Code
<div class="container-fluid">
    <h2>สร้างใบหัก ณ ที่จ่ายจากใบจ่ายเงิน</h2>
    <div style="display:flex;flex-direction:column;width:100%">
        @If dt.Rows.Count > 0 Then
            For Each dr As Data.DataRow In dt.Rows
                @<form action="" method="post" style="display:flex">
                    <input type="text" style="width:100%" value="@dr("AccDocNo") /  @dr("PartyName")" readonly />
                    <input type="number" value="@dr("TotalWht")" readonly step=".01"/>
                    <input type="hidden" name="AccDocNo" value="@dr("AccDocNo")" />
                    <select id="txtFormType" name="FormType">
                        <option value="1">
                            ภ.ง.ด. 1 ก.
                        </option>
                        <option value="2">
                            ภ.ง.ด. 1 ก. (พิเศษ)
                        </option>
                        <option value="3">
                            ภ.ง.ด. 2
                        </option>
                        <option value="4">
                            ภ.ง.ด. 3
                        </option>
                        <option value="5">
                            ภ.ง.ด. 2 ก.
                        </option>
                        <option value="6">
                            ภ.ง.ด. 3 ก.
                        </option>
                        <option value="7">
                            ภ.ง.ด. 53
                        </option>
                    </select>
                    <select id="txtIncType" name="IncType">
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
                    <select name="TaxLawNo">
                        <option value="1" selected>3 เตรส</option>
                        <option value="2">65 จัดวา</option>
                        <option value="3">69 ทวิ</option>
                        <option value="4">48 ทวิ</option>
                        <option value="5">50 ทวิ</option>
                    </select>
                    <select name="PayTaxType">
                        <option value="1">หัก ณ ที่จ่าย</option>
                        <option value="2">ออกภาษีให้ตลอดไป</option>
                        <option value="3">ออกภาษีให้ครั้งเดียว</option>
                        <option value="4">อื่นๆ (ระบุ)</option>
                    </select>
                    <button type="submit" name="submit" class="btn btn-primary">Create WHTax</button>
                </form>
            Next
        End If

    </div>
</div>

@msg
<script type="text/javascript">
    var msg = '@msg';
    var docno = '@docno';
    if (msg !== '') {
        alert(msg);
        window.location.href = 'Form?Form=FormWHTax&SRC=@dbSource&DB=@dbname&Code=@docno';
    }
</script>