@Code
    ViewData("Title") = "FormWHTax"
    Layout = Nothing
    Dim DocNo As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        DocNo = Request.QueryString("Code")
    End If
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
End Code
<script src="~/Scripts/util.js"></script>
<style>
    #topMenu {
        display: none;
    }
    * {
        font-family: Tahoma;
        font-size: 12px;
        margin: 0;
        padding: 0;
    }

    .circle {
        width: 100px; /* ความกว้าง */
        height: 100px; /* ความสูง */
        -moz-border-radius: 70px;
        -webkit-border-radius: 70px;
        border: 1px solid #000000;
        border-radius: 50%;
        text-align: center;
    }

    .money_text {
        border-style: solid;
        border-width: 1px;
        width: 70%;
        float: right;
        text-align: center;
        padding: 1px;
    }

    .amount {
        text-align: right;
    }
</style>
<div style="float:left;">
    <b>ฉบับที่ 1</b><i>(สำหรับผู้ถูกหักภาษี ณ ที่จ่ายใช้แนบพร้อมกับแบบแสดงรายการภาษี)</i><br />
    <b>ฉบับที่ 2</b><i>(สำหรับผู้ถูกหักภาษี ณ ที่จ่ายเก็บไว้เป็นหลักฐาน)</i>
</div>
@Code    
    Dim DocDate As Date = DateTime.MinValue
    Dim TaxNumber1 As String = ""
    Dim TName1 As String = ""
    Dim TAddress1 As String = ""
    Dim TaxNumber2 As String = ""
    Dim TName2 As String = ""
    Dim TAddress2 As String = ""
    Dim TaxNumber3 As String = ""
    Dim TName3 As String = ""
    Dim TAddress3 As String = ""
    Dim IDCard1 As String = ""
    Dim IDCard2 As String = ""
    Dim IDCard3 As String = ""
    Dim SeqInForm As Integer
    Dim FormType As Integer
    Dim TaxLawNo As String = ""
    Dim IncRate As Double = 0
    Dim IncOther As String = ""
    Dim UpdateBy As String = ""
    Dim TotalPayAmount As Double
    Dim TotalPayTax As Double
    Dim SoLicenseNo As String = ""
    Dim SoLicenseAmount As Double
    Dim SoAccAmount As Double
    Dim PayeeAccNo As String = ""
    Dim SoTaxNo As String = ""
    Dim PayTaxType As String = ""
    Dim PayTaxOther As String = ""
    Dim CancelProve As String = ""
    Dim CancelReason As String = ""
    Dim LastUpdate As Date = DateTime.MinValue
    Dim TeacherAmt As Double = 0
    Dim Branch1 As String = ""
    Dim Branch2 As String = ""
    Dim Branch3 As String = ""
    Dim IsCSV As Integer = 0
    Dim PayDate(15) As String
    Dim PayDesc(15) As String
    Dim PayAmount(15) As String
    Dim PayTax(15) As String
    If DocNo <> "" Then
        Dim dh = obj.GetDataFromSQL(String.Format("SELECT * FROM Acc_WHTax WHERE DocNo='{0}'", DocNo))
        If dh.Rows.Count > 0 Then
            For Each dr As Data.DataRow In dh.Rows
                DocDate = dr("DocDate")
                TaxNumber1 = dr("TaxNumber1")
                TName1 = dr("TName1")
                TAddress1 = dr("TAddress1")
                TaxNumber2 = dr("TaxNumber2")
                TName2 = dr("TName2")
                TAddress2 = dr("TAddress2")
                TaxNumber3 = dr("TaxNumber3")
                TName3 = dr("TName3")
                TAddress3 = dr("TAddress3")
                IDCard1 = dr("IDCard1")
                IDCard2 = dr("IDCard2")
                IDCard3 = dr("IDCard3")
                SeqInForm = dr("SeqInForm")
                FormType = dr("FormType")
                TaxLawNo = dr("TaxLawNo")
                IncRate = dr("IncRate")
                IncOther = dr("IncOther")
                UpdateBy = dr("UpdateBy")
                TotalPayAmount = dr("TotalPayAmount")
                TotalPayTax = dr("TotalPayTax")
                SoLicenseNo = dr("SoLicenseNo")
                SoLicenseAmount = dr("SoLicenseAmount")
                SoAccAmount = dr("SoAccAmount")
                PayeeAccNo = dr("PayeeAccNo")
                SoTaxNo = dr("SoTaxNo")
                PayTaxType = dr("PayTaxType")
                PayTaxOther = dr("PayTaxOther")
                CancelProve = dr("CancelProve")
                CancelReason = dr("CancelReason")
                LastUpdate = dr("LastUpdate")
                TeacherAmt = dr("TeacherAmt")
                Branch1 = dr("Branch1")
                Branch2 = dr("Branch2")
                Branch3 = dr("Branch3")
                IsCSV = dr("IsCSV")
            Next
        End If
        Dim dt = obj.GetDataFromSQL(String.Format("SELECT * FROM Acc_WHTaxDetail WHERE DocNo='{0}'", DocNo))
        If dt.Rows.Count > 0 Then
            For r As Integer = 0 To dt.Rows.Count - 1
                Dim dr As Data.DataRow = dt.Rows(r)
                Dim i As Integer = CInt(dr("IncType"))
                Dim c As Integer = 14
                If i = 14 And c < 16 And PayDesc(c - 1) <> "" Then
                    c = c + 1
                    PayDesc(c - 1) = dr("PayTaxDesc")
                    PayDate(c - 1) = Convert.ToDateTime(dr("PayDate")).AddYears(543).ToString("dd/MM/yyyy")
                    If Convert.ToDouble(dr("PayAmount")) > 0 Then
                        PayAmount(c - 1) = (Convert.ToDouble(PayAmount(c - 1)) + Convert.ToDouble(dr("PayAmount"))).ToString("#,##0.00")
                    End If
                    If Convert.ToDouble(dr("PayTax")) > 0 Then
                        PayTax(c - 1) = (Convert.ToDouble(PayTax(c - 1)) + Convert.ToDouble(dr("PayTax"))).ToString("#,##0.00")
                    End If
                Else
                    PayDesc(i - 1) = dr("PayTaxDesc")
                    PayDate(i - 1) = Convert.ToDateTime(dr("PayDate")).AddYears(543).ToString("dd/MM/yyyy")
                    If Convert.ToDouble(dr("PayAmount")) > 0 Then
                        PayAmount(i - 1) = (Convert.ToDouble(PayAmount(i - 1)) + Convert.ToDouble(dr("PayAmount"))).ToString("#,##0.00")
                    End If
                    If Convert.ToDouble(dr("PayTax")) > 0 Then
                        PayTax(i - 1) = (Convert.ToDouble(PayTax(i - 1)) + Convert.ToDouble(dr("PayTax"))).ToString("#,##0.00")
                    End If
                End If
            Next
        End If
    End If
End Code
<div style="float:right;">
    เลขที่ <label id="txtDocNo">@DocNo</label>
</div>
<table border="1" style="border-style:solid;border-width:thin;border-collapse:collapse" width="100%">
    <tr>
        <td colspan="4" style="text-align:center;vertical-align:top">
            <b>หนังสือรับรองการหักภาษี ณ ที่จ่าย</b><br />
            ตามมาตรา ๕๐ ทวิ แห่งประมวลรัษฏากร
        </td>
    </tr>
    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right">
                เลขประจำตัวผู้เสียภาษี : <label id="txtTaxNumber1" style="text-decoration:underline">@TaxNumber1</label>
            </div>
            <b>ผู้มีหน้าที่หักภาษี ณ ที่จ่าย</b>
            <p>ชื่อ <span><label id="txtTName1" style="text-decoration:underline">@TName1</label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress1" style="text-decoration:underline">@TAddress1</label></span></p>
            <i>(ให้ระบุ ชื่ออาคาร/หมู่บ้าน ห้องเลขที่ ชั้นที่ เลขที่ ตรอก/ซอย หมู่ที่ ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด และโทรศัพท์)</i>
        </td>
    </tr>

    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right">
                เลขประจำตัวผู้เสียภาษี : <label id="txtTaxNumber2" style="text-decoration:underline">@TaxNumber2</label>
            </div>
            <b>กระทำแทนโดย</b>
            <p>ชื่อ <span><label id="txtTName2" style="text-decoration:underline">@TName2</label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress2" style="text-decoration:underline">@TAddress2</label></span></p>
            <i>(ให้ระบุ ชื่ออาคาร/หมู่บ้าน ห้องเลขที่ ชั้นที่ เลขที่ ตรอก/ซอย หมู่ที่ ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด และโทรศัพท์)</i>
        </td>
    </tr>

    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:right;">
                เลขประจำตัวผู้เสียภาษี : <label id="txtTaxNumber3" style="text-decoration:underline">@TaxNumber3</label>
            </div>
            <b>ผู้ถูกหักภาษี ณ ที่จ่าย</b>
            <p>ชื่อ <span><label id="txtTName3" style="text-decoration:underline">@TName3</label></span></p>
            <i>(ให้ระบุว่าเป็น บุคคล นิติบุคคล บริษัท สมาคม หรือคณะบุคคล)</i>
            <p>ที่อยู่ <span><label id="txtTAddress3" style="text-decoration:underline">@TAddress3</label></span></p>
            <i>(ให้ระบุ ชื่ออาคาร/หมู่บ้าน ห้องเลขที่ ชั้นที่ เลขที่ ตรอก/ซอย หมู่ที่ ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด และโทรศัพท์)</i>
        </td>
    </tr>
    <tr>
        <td colspan="4" style="vertical-align:top">
            <div style="float:left">
                ลำดับที่ <label id="txtSeqInform" style="width:100px;border:solid;border-width:thin;">@SeqInForm</label> ในแบบ
            </div>
            <div style="float:left">
                <div style="text-align:left">
                    <input type="hidden" id="txtFormType" value="@FormType" />
                    @If FormType = "1" Then
                        @<input type="checkbox" id="chkFormType1" name="chkFormType" checked>
                    Else
                        @<input type="checkbox" id="chkFormType1" name="chkFormType">
                    End If
                    (1) ภ.ง.ด.1ก.
                    @If FormType = "2" Then
                        @<input type="checkbox" id="chkFormType2" name="chkFormType" checked>
                    Else
                        @<input type="checkbox" id="chkFormType2" name="chkFormType">
                    End If
                    (2) ภ.ง.ด.1ก. พิเศษ
                    @If FormType = "3" Then
                        @<input type="checkbox" id="chkFormType3" name="chkFormType" checked>
                    Else
                        @<input type="checkbox" id="chkFormType3" name="chkFormType">
                    End If
                    (3) ภ.ง.ด.2
                    @If FormType = "4" Then
                        @<input type="checkbox" id="chkFormType4" name="chkFormType" checked>
                    Else
                        @<input type="checkbox" id="chkFormType4" name="chkFormType">
                    End If
                    (4) ภ.ง.ด.3<br />
                    @If FormType = "5" Then
                        @<input type="checkbox" id="chkFormType5" name="chkFormType" checked>
                    Else
                        @<input type="checkbox" id="chkFormType5" name="chkFormType">
                    End If(5) ภ.ง.ด.2ก.
                    @If FormType = "6" Then
                        @<input type="checkbox" id="chkFormType6" name="chkFormType" checked>
                    Else
                        @<input type="checkbox" id="chkFormType6" name="chkFormType">
                    End If
                    (6) ภ.ง.ด.3ก.
                    @If FormType = "7" Then
                        @<input type="checkbox" id="chkFormType7" name="chkFormType" checked>
                    Else
                        @<input type="checkbox" id="chkFormType7" name="chkFormType">
                    End If
                    (7) ภ.ง.ด.53
                </div>
            </div>
        </td>
    </tr>
    <tr style="text-align:center;font-weight:bold">
        <td width="60%">
            <label>ประเภทเงินได้ที่จ่าย</label>
        </td>
        <td width="10%">
            <label>วัน เดือน <br />หรือปีภาษี<br />ที่จ่าย</label>
        </td>

        <td width="15%">
            <label>จำนวนเงินที่จ่าย</label>
        </td>
        <td width="15%">
            <label>ภาษีที่หักและนำส่งไว้</label>
        </td>
    </tr>


    <tr>
        <td>
            1.เงินเดือน ค่าจ้าง เบี้ยเลี้ยง โบนัส ฯลฯ ตามมาตรา 40(1)
        </td>
        <td style="text-align:center"><label id="txtPayDate1">@PayDate(0)</label></td>
        <td class="amount"><label id="txtPayAmount1">@PayAmount(0)</label></td>
        <td class="amount"><label id="txtPayTax1">@PayTax(0)</label></td>
    </tr>

    <tr>
        <td>
            2.ค่าธรรมเนียม ค่านายหน้า ฯลฯ ตามมาตรา 40(2)
        </td>
        <td style="text-align:center"><label id="txtPayDate2">@PayDate(1)</label></td>
        <td class="amount"><label id="txtPayAmount2">@PayAmount(1)</label></td>
        <td class="amount"><label id="txtPayTax2">@PayTax(1)</label></td>
    </tr>

    <tr>
        <td>
            3.ค่าแห่งลิขสิทธิ์ ฯลฯ ตามมาตรา 40(1)
        </td>
        <td style="text-align:center"><label id="txtPayDate3">@PayDate(2)</label></td>
        <td class="amount"><label id="txtPayAmount3">@PayAmount(2)</label></td>
        <td class="amount"><label id="txtPayTax3">@PayTax(2)</label></td>
    </tr>

    <tr>
        <td>
            4.(ก)ค่าดอกเบี้ย ฯลฯ ตามมาตรา 40(4)(ก)
        </td>
        <td style="text-align:center"><label id="txtPayDate4">@PayDate(3)</label></td>
        <td class="amount"><label id="txtPayAmount4">@PayAmount(3)</label></td>
        <td class="amount"><label id="txtPayTax4">@PayTax(3)</label></td>
    </tr>

    <tr>
        <td>
            &nbsp;  &nbsp;(ข)เงินปันผลเงินส่วนแบ่งกำไร ฯลฯ ตามมาตรา 40(4)(ข)
            <br />
            &nbsp;  &nbsp;  &nbsp;  &nbsp;(1)กรณีผู้ได้รับเงินปันผลได้รับเครดิตภาษี โดยจ่ายจากกำไรสุทธิของกิจการที่ต้องเสียภาษีเงินได้นิติบุคคลในอัตราดังนี้
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            @If PayTax(4) <> "" Then
                @<input type="checkbox" checked>
            Else
                @<input type="checkbox">
            End If
            (1.1) อัตราร้อยละ 30 ของกำไรสุทธิ
        </td>
        <td style="text-align:center"><label id="txtPayDate5">@PayDate(4)</label></td>
        <td class="amount"><label id="txtPayAmount5">@PayAmount(4)</label></td>
        <td class="amount"><label id="txtPayTax5">@PayTax(4)</label></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            @If PayTax(5) <> "" Then
                @<input type="checkbox" checked>
            Else
                @<input type="checkbox">
            End If
            (1.2) อัตราร้อยละ 25 ของกำไรสุทธิ
        </td>
        <td style="text-align:center"><label id="txtPayDate6">@PayDate(5)</label></td>
        <td class="amount"><label id="txtPayAmount6">@PayAmount(5)</label></td>
        <td class="amount"><label id="txtPayTax6">@PayTax(5)</label></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            @If PayTax(6) <> "" Then
                @<input type="checkbox" checked>
            Else
                @<input type="checkbox">
            End If
            (1.3) อัตราร้อยละ 20 ของกำไรสุทธิ
        </td>
        <td style="text-align:center"><label id="txtPayDate7">@PayDate(6)</label></td>
        <td class="amount"><label id="txtPayAmount7">@PayAmount(6)</label></td>
        <td class="amount"><label id="txtPayTax7">@PayTax(6)</label></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;  &nbsp;&nbsp;&nbsp;
            @If PayTax(7) <> "" Then
            @<input type="checkbox" checked>
            Else
            @<input type="checkbox">
            End If
            (1.4) อัตราอื่นๆ (ระบุ)<label id="txtPayDesc8" style="text-decoration:underline">@PayDesc(7)</label>ของกำไรสุทธิ
        </td>
        <td style="text-align:center"><label id="txtPayDate8">@PayDate(7)</label></td>
        <td class="amount"><label id="txtPayAmount8">@PayAmount(7)</label></td>
        <td class="amount"><label id="txtPayTax8">@PayTax(7)</label></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (2) กรณีผู้รับเงินปันผลไม่ได้รับเครดิตภาษี เนื่องจากจ่ายจากกำไรสุทธิของกิจการที่ได้รับยกเว้นภาษีเงินได้นิติบุคคล
        </td>
        <td style="text-align:center"><label id="txtPayDate9">@PayDate(8)</label></td>
        <td class="amount"><label id="txtPayAmount9">@PayAmount(8)</label></td>
        <td class="amount"><label id="txtPayTax9">@PayTax(8)</label></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (3) เงินปันผลหรือส่วนแบ่งกำไรที่ได้รับยกเว้นไม่ต้องนำรวมมาคำนวณเป็นรายได้เพื่อคำนวณภาษีเงินได้นิติบุคคล
        </td>
        <td style="text-align:center"><label id="txtPayDate10">@PayDate(9)</label></td>
        <td class="amount"><label id="txtPayAmount10">@PayAmount(9)</label></td>
        <td class="amount"><label id="txtPayTax10">@PayTax(9)</label></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (4) กำไรที่รับรู้ทางบัญชีโดยวิธีส่วนได้เสีย
        </td>
        <td style="text-align:center"><label id="txtPayDate11">@PayDate(10)</label></td>
        <td class="amount"><label id="txtPayAmount11">@PayAmount(10)</label></td>
        <td class="amount"><label id="txtPayTax11">@PayTax(10)</label></td>
    </tr>
    <tr>
        <td>
            &nbsp;  &nbsp;  &nbsp;
            (5) อื่นๆ (ระบุ)<label id="txtPayDesc12">@PayDesc(11)</label>
        </td>
        <td style="text-align:center"><label id="txtPayDate12">@PayDate(11)</label></td>
        <td class="amount"><label id="txtPayAmount12">@PayAmount(11)</label></td>
        <td class="amount"><label id="txtPayTax12">@PayTax(11)</label></td>
    </tr>
    <tr>
        <td>
            5.การจ่ายเงินได้ที่ต้องหักภาษี ณ ที่จ่ายตามคำสั่งกรมสรรพากรที่ออกตาม มาตรา 3 เตรส เช่น รางวัล ส่วนลดหรือประโยชน์ใด เนื่องจากการ ส่งเสริมการขาย รางวัลในการประกวด การแข่งขัน
            การชิงโชค ค่าแสดง ของนักแสดงสาธารณะ ค่าจ้างทำของ ค่าโฆษณา ค่าเช่า ค่าขนส่ง ค่าบริการ ค่าเบี้ยประกันวินาศภัย ฯลฯ
        </td>
        <td style="text-align:center"><label id="txtPayDate13">@PayDate(12)</label></td>
        <td class="amount"><label id="txtPayAmount13">@PayAmount(12)</label></td>
        <td class="amount"><label id="txtPayTax13">@PayTax(12)</label></td>
    </tr>
    <tr>
        <td>
            6.อื่นๆ (ระบุ)<label id="txtPayDesc14" style="text-decoration:underline">@PayDesc(13)</label>
        </td>
        <td style="text-align:center"><label id="txtPayDate14">@PayDate(13)</label></td>
        <td class="amount"><label id="txtPayAmount14">@PayAmount(13)</label></td>
        <td class="amount"><label id="txtPayTax14">@PayTax(13)</label></td>
    </tr>
    @If PayDesc(14) <> "" Then
        @<tr>
            <td>
                <label id="txtPayDesc15" style="text-decoration:underline">@PayDesc(14)</label>
            </td>
            <td style="text-align:center"><Label id="txtPayDate15">@PayDate(14)</Label></td>
            <td Class="amount"><label id="txtPayAmount15">@PayAmount(14)</label></td>
            <td Class="amount"><label id="txtPayTax15">@PayTax(14)</label></td>
        </tr>

    End If
    @If PayDesc(15) <> "" Then
        @<tr>
            <td>
                <label id="txtPayDesc16" style="text-decoration:underline">@PayDesc(15)</label>
            </td>
            <td style="text-align:center"><Label id="txtPayDate16">@PayDate(15)</Label></td>
            <td Class="amount"><label id="txtPayAmount16">@PayAmount(15)</label></td>
            <td Class="amount"><label id="txtPayTax16">@PayTax(15)</label></td>
        </tr>
    End If
    <tr style="text-align:right">
        <td colspan="2"><b>รวมเงินที่จ่ายและภาษีที่หักนำส่ง</b></td>
        <td><label id="txtSumPayAmount">@TotalPayAmount.ToString("#,##0.00")</label></td>
        <td><label id="txtSumPayTax">@TotalPayTax.ToString("#,##0.00")</label></td>
    </tr>
    <tr>
        <td colspan="4">
            รวมเงินที่จ่ายและภาษีที่หักนำส่ง (ตัวอักษร)
            <div class="money_text right">
                <label id="txtPayTaxMoney"></label>
            </div>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <b>เงินที่จ่ายเข้า  </b>กองทุนสงเคราะห์ครูโรงเรียนเอกชน <label id="txtTeacherAmt">@TeacherAmt.ToString("#,##0.00")</label> บาท  กองทุนประกันสังคม <label id="txtSoLicenseAmt">@SoLicenseAmount.ToString("#,##0.00")</label> บาท กองทุนสำรองเลี้ยงชีพ <label id="txtSoAccAmount">@SoAccAmount.ToString("#,##0.00")</label>บาท
        </td>
    </tr>
</table>
<table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin" width="100%">

    <tr>
        <td>
            <p>ผู้จ่ายเงิน</p>
            <input type="hidden" id="txtPayTaxType" value="@PayTaxType" />
            @If CInt(PayTaxType) = 1 Then
                @<input type="checkbox" checked id="chkPayTaxType1" name="chkPayTaxType">
            Else
                @<input type="checkbox" id="chkPayTaxType1" name="chkPayTaxType">
            End If
            (1) หักภาษี ณ ที่จ่าย<br>
            @If CInt(PayTaxType) = 2 Then
                @<input type="checkbox" checked id="chkPayTaxType2" name="chkPayTaxType">
            Else
                @<input type="checkbox" id="chkPayTaxType2" name="chkPayTaxType">
            End If
            (2) ออกภาษีให้ตลอดไป<br>
            @If CInt(PayTaxType) = 3 Then
                @<input type="checkbox" checked id="chkPayTaxType3" name="chkPayTaxType">
            Else
                @<input type="checkbox" id="chkPayTaxType3" name="chkPayTaxType">
            End If
            (3) ออกภาษีให้ครั้งเดียว<br>
            @If CInt(PayTaxType) = 4 Then
                @<input type="checkbox" checked id="chkPayTaxType4" name="chkPayTaxType">
            Else
                @<input type="checkbox" id="chkPayTaxType4" name="chkPayTaxType">
            End If
            (4) อื่นๆ (ระบุ)<label id="txtPayTaxOther" style="text-decoration:underline">@PayTaxOther</label><br>
        </td>

        <td style="text-align:center">
            <p>ขอรับรองว่า ข้อความและตัวเลขดังกล่าวข้างต้นถูกต้องตรงกับความจริงทุกประการ</p><br /><br /><br />
            (ลงชื่อ)<label id="txtUpdateName" style="text-decoration:underline"></label> ผู้มีหน้าที่หักภาษี ณ ที่จ่าย<br>
            <label id="txtDocDate" style="text-decoration:underline">@DocDate.AddYears(543).ToString("dd/MM/yyyy")</label> วัน เดือน ปี ที่ออกหนังสือรับรอง
        </td>

        <td>
            <div class="circle"><br /><br /><br />ตราประทับนิติบุคคลถ้ามี</div>
        </td>
    </tr>
</table>

<div>
    <b>หมายเหตุ</b> ให้สามารถอ้างอิงหรือสอบยันกันได้ระหว่างลำดับที่ตามหนังสือรับรองฯ กับแบบยื่นรายการภาษีหัก ณ ที่จ่าย<br />
    <b>คำเตือน</b> ผู้มีหน้าที่ออกหนังสือรับรองหักภาษี ณ ที่จ่าย ฝ่าฝืนไม่ปฏิบัติตามมาตรา 50 ทวิ แห่งประมวลรัษฏากรต้องรับโทษทางอาญาตามมาตรา 35 แห่งประมวลรัษฏากร
</div>
<script type="text/javascript">
    var tot = CNumThai(@TotalPayTax);
    document.getElementById('txtPayTaxMoney').textContent = tot;
    
</script>