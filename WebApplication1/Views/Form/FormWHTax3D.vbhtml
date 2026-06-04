@Code
    Layout = Nothing
    ViewData("Title") = "FormWHTax3D"
    ViewBag.Title = "WTax-3"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim yy As Integer = Now.Year
    Dim mm As Integer = Now.Month
    Dim tno As String = ""
    Dim lno As String = "1"
    If Not Request.QueryString("Year") Is Nothing Then
        yy = CInt(Request.QueryString("Year"))
    End If
    If Not Request.QueryString("Month") Is Nothing Then
        mm = CInt(Request.QueryString("Month"))
    End If
    If Not Request.QueryString("TaxNo") Is Nothing Then
        tno = Request.QueryString("TaxNo")
    End If
    If Not Request.QueryString("LawNo") Is Nothing Then
        lno = Request.QueryString("LawNo")
    End If
    Dim sql As String = "
select TaxNumber1,max(TName1) as TName1,max(Branch1) as Branch1,max(TAddress1) as TAddress1,
TaxNumber3,TName3,TAddress3,PayDate,PayTaxDesc,PayRate,DocRefType,
sum(PayAmount) as PayAmount,sum(PayTax) as PayTax
from (
SELECT h.*,d.ItemNo,d.IncType,d.PayDate,d.PayAmount,d.PayTax,d.PayTaxDesc,
d.JNo,d.DocRefType,d.DocRefNo,d.PayRate,
(CASE WHEN h.FormType=1 THEN 'ภงด1ก' ELSE (CASE WHEN h.FormType=2 THEN 'ภงด1ก(พิเศษ)' ELSE (CASE WHEN h.FormType=3 THEN 'ภงด2' ELSE (CASE WHEN h.FormType=4 THEN 'ภงด3' ELSE (CASE WHEN h.FormType=5 THEN 'ภงด2ก' ELSE (CASE WHEN h.FormType=6 THEN 'ภงด3ก' ELSE (CASE WHEN h.FormType=7 THEN 'ภงด53' ELSE 'ไม่ระบุ' END) END) END) END) END) END) END) as FormTypeName,
(CASE WHEN h.TaxLawNo=1 THEN '3เตรส' ELSE (CASE WHEN h.TaxLawNo=2 THEN '65จัตวา' ELSE (CASE WHEN h.TaxLawNo=3 THEN '69ทวิ' ELSE (CASE WHEN h.TaxLawNo=4 THEN '48ทวิ' ELSE (CASE WHEN h.TaxLawNo=5 THEN '50ทวิ' ELSE 'ไม่ระบุ' END) END) END) END) END) as TaxLawName
FROM dbo.Acc_WHTax h LEFT JOIN dbo.Acc_WHTaxDetail d
ON h.DocNo=d.DocNo
WHERE h.FormType=4
{0}
AND NOT ISNULL(h.CancelProve,'')<>''
) a
group by TaxNumber1,Branch1,TaxNumber3,TName3,TAddress3,PayDate,PayTaxDesc,PayRate,DocRefType
order by TaxNumber1,Branch1,TaxNumber3,PayDate
"
    Dim TaxAuthorize As String = "____________________________________________________"
    Dim TaxPosition As String = "________________________________________________"
    Dim dt As New Data.DataTable


    Dim sqlCfg = "select * from Mas_AccConfig where ConfigCode='PROFILE_CONFIG'"
    Dim dc = obj.GetDataFromSQL(sqlCfg)
    If dc.Rows.Count > 0 Then
        For Each dr As Data.DataRow In dc.Rows
            If dr("ConfigKey").Equals("COMPANY_TAXNUMBER") Then
                If dr("ConfigValue").ToString() <> "" And tno = "" Then
                    tno = dr("ConfigValue").ToString()
                End If
            End If
            If dr("ConfigKey").Equals("COMPANY_TAXAUTORIZE") Then
                If dr("ConfigValue").ToString() <> "" Then
                    TaxAuthorize = dr("ConfigValue").ToString()
                End If
            End If
            If dr("ConfigKey").Equals("COMPANY_TAXPOSITION") Then
                If dr("ConfigValue").ToString() <> "" Then
                    TaxPosition = dr("ConfigValue").ToString()
                End If
            End If
        Next
    End If

    Dim sqlW As String = String.Format(" AND h.TaxNumber1='{0}'", tno)
    sqlW &= String.Format(" AND Year(h.DocDate)={0}", yy)
    sqlW &= String.Format(" AND Month(h.DocDate)={0}", mm)
    sqlW &= String.Format(" AND h.TaxLawNo={0}", lno)

    sql = String.Format(sql, sqlW)
    dt = obj.GetDataFromSQL(sql)
End Code

<style>
    * {
        font-family: AngsanaUPC;
        font-size: 13px;
    }

    #pFooter, #dvFooter {
        display: none;
    }

    thead {
        text-align: center;
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

    .flex-container {
        display: flex;
        flex-wrap: nowrap;
    }

        .flex-container > div {
            background-color: #f1f1f1;
            width: 15px;
            margin: 1px;
            text-align: center;
            line-height: 20px;
            font-size: 7px;
        }
</style>
@If dt.Rows.Count > 0 Then
    Dim sumPayAmount As Decimal = 0
    Dim sumPayTax As Decimal = 0
    Dim irow As Integer = 0
    @<table>
        <tr>
            <td>
                <table style="width:100%">
                    <tr>
                        <td style="width:10%">
                            ใบแนบ <label style="font-size:32px;font-weight:bold">ภ.ง.ด.3</label>
                        </td>
                        <td style="width:60%">
                            <br />
                            เลขที่ประจำตัวผู้เสียภาษีอากร (ของผู้มีหน้าที่หักภาษี ณ ที่จ่าย) : <label id="lblTaxNumber1">@dt.Rows(0)("TaxNumber1")</label>
                            สาขา : <label id="lblBranch1">@dt.Rows(0)("Branch1")</label>
                            <br />
                            ชื่อผู้เสียภาษีอากร : <label id="lblTName1">@dt.Rows(0)("TName1")</label><br />
                            ที่อยู่ : <label id="lblTAddress1">@dt.Rows(0)("TAddress1")</label>
                        </td>
                        <td style="width:30%;text-align:right">
                            <br />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td id="report">
                <table id="tbDetail" border="1" style="border-style:solid;border-width:thin;border-collapse:collapse;">
                    <thead style="text-align:center">
                        <tr>
                            <td rowspan="3">
                                <p>ลำดับที่</p>
                            </td>
                            <td>
                                <p>เลขประจำตัวผู้เสียภาษีอากร (ของผู้มีเงินได้)</p>
                            </td>
                            <td colspan="3">
                                <p>รายละเอียดเกี่ยวกับการจ่ายเงิน</p>
                            </td>
                            <td colspan="3">
                                <p>รวมเงินภาษีที่หักและนำส่งในครั้งนี้</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ชื่อผู้มีเงินได้
                                (ให้ระบุให้ชัดเจนว่าเป็น นาย นาง นางสาวหรือยศ)
                            </td>
                            <td rowspan="2">
                                <p>
                                    วัน เดือน ปี<br> ที่จ่าย
                                </p>
                            </td>
                            <td rowspan="2">
                                <p>
                                    1 ประเภทเงินได้<br>(ถ้ามากกว่าหนึ่งประเภทให้กรอกเรียงลงไป)
                                </p>
                            </td>
                            <td rowspan="2">
                                <p>
                                    อัตราภาษีร้อยละ
                                </p>
                            </td>
                            <td rowspan="2">
                                <p>
                                    จำนวนเงินที่จ่ายแต่ละประเภท<br>เฉพาะคนหนึ่งๆ ในครั้งนี้
                                </p>
                            </td>
                            <td rowspan="2">
                                <p>
                                    จำนวนเงิน
                                </p>
                            </td>
                            <td rowspan="2">
                                <p>2 เงื่อนไข</p>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                ที่อยู่ของผู้มีเงินได้ (ให้ระบุเลขที่ ตรอก/ซอย ถนน ตำบล/แขวง อำเภอ/เขต จังหวัด)
                            </td>
                        </tr>
                    </thead>
                    <tbody>
                        @For Each dr As Data.DataRow In dt.Rows
                            irow += 1
                            sumPayAmount += dr("PayAmount")
                            sumPayTax += dr("PayTax")
                            @<tr>
                                <td>@irow</td>
                                <td>
                                    เลขประจำตัวผู้เสียภาษี : @dr("TaxNumber3")
                                    <br />
                                    ชื่อ : @dr("TName3")
                                    <br />
                                    ที่อยู่ : @dr("TAddress3")
                                </td>
                                <td style="text-align:center">
                                    @Convert.ToDateTime(dr("PayDate")).ToString("dd/MM/yyyy")
                                </td>
                                <td>
                                    @dr("PayTaxDesc")
                                </td>
                                <td style="text-align:center">
                                    @dr("PayRate")
                                </td>
                                <td style="text-align:right">
                                    @Convert.ToDecimal(dr("PayAmount")).ToString("#,##0.00")
                                </td>
                                <td style="text-align:right">
                                    @Convert.ToDecimal(dr("PayTax")).ToString("#,##0.00")
                                </td>
                                <td>
                                    @dr("DocRefType")
                                </td>
                            </tr>
                        Next
                    </tbody>
                    <tr>
                        <td colspan="5">
                            <p>รวมยอดเงินได้และภาษีที่นำส่ง (นำไปรวมกับ <b>ใบแนบ ภ.ง.ด.3 </b>แผ่นอื่น(ถ้ามี))</p>
                        </td>
                        <td style="text-align:right">@sumPayAmount.ToString("#,##0.00")</td>
                        <td style="text-align:right">@sumPayTax.ToString("#,##0.00")</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td class="text-left" colspan="3">
                            (ให้กรอกลำดับที่ต่อเนื่องกันไปทุกแผ่น)
                            <br>
                            <b>หมายเหตุ</b> 1 ให้ระบุว่าจ่ายเป็นค่าอะไร เช่น ค่าเช่าอาคาร ค่าสอบบัญชี ค่าทนายความ ค่าวิชาชีพของแพทย์<br />
                            ค่าก่อสร้าง รางวัล ส่วนลดหรือประโยชน์ใดๆ เนื่องจากการส่งเสริมการขาย รางวัลในการประกวด การแข่งขัน การชิงโชค ค่าจ้างแสดงภาพยนต์ ร้องเพลงดนตรี ค่าจ้างทำของ ค่าโฆษณา ค่าขนส่งสินค้า ฯลฯ
                            <br>
                            2 เงื่อนไขการหักภาษี ณ ที่จ่ายให้กรอกดังนี้<br>
                            หัก ณ ที่จ่าย กรอก 1<br>
                            ออกภาษีให้ กรอก 2<br>
                            ออกให้ครั้งเดียว กรอก 3
                        </td>
                        <td colspan="3" style="text-align:center">
                            <br>
                            ลงชื่อ.....................................................ผู้จ่ายเงิน<br>
                            (<input type="text" style="border-style:none;text-align:center;width:150px" value="________________________________________________" />) <br>
                            ตำแหน่ง <input type="text" style="border-style:none;text-align:center;width:150px" value="_________________________________________________" /><br>
                            ยื่นวันที่ <input type="text" style="border-style:none;text-align:center" value="___________________________________" />
                        </td>
                        <td colspan="2">
                            <div class="circle"><br />ตราประทับ<br />นิติบุคคล<br />(ถ้ามี)</div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
End If
