@Code
    ViewBag.Title = "WTax-53"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
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
SELECT a.TaxNumber1,a.TName1,a.TAddress1,Branch1,FormType,TaxLawNo,Year(DocDate)+543 as TaxYear,Month(DocDate) as TaxMonth,
sum(a.PayAmount) as SumPayAmount,sum(a.PayTax) as SumPayTax,Count(DISTINCT a.TName3) as CountDoc
FROM (
SELECT h.*,d.ItemNo,d.IncType,d.PayDate,d.PayAmount,d.PayTax,d.PayTaxDesc,
d.JNo,d.DocRefType,d.DocRefNo,d.PayRate,
(CASE WHEN h.FormType=1 THEN 'ภงด1ก' ELSE (CASE WHEN h.FormType=2 THEN 'ภงด1ก(พิเศษ)' ELSE (CASE WHEN h.FormType=3 THEN 'ภงด2' ELSE (CASE WHEN h.FormType=4 THEN 'ภงด3' ELSE (CASE WHEN h.FormType=5 THEN 'ภงด2ก' ELSE (CASE WHEN h.FormType=6 THEN 'ภงด3ก' ELSE (CASE WHEN h.FormType=7 THEN 'ภงด53' ELSE 'ไม่ระบุ' END) END) END) END) END) END) END) as FormTypeName,
(CASE WHEN h.TaxLawNo=1 THEN '3เตรส' ELSE (CASE WHEN h.TaxLawNo=2 THEN '65จัตวา' ELSE (CASE WHEN h.TaxLawNo=3 THEN '69ทวิ' ELSE (CASE WHEN h.TaxLawNo=4 THEN '48ทวิ' ELSE (CASE WHEN h.TaxLawNo=5 THEN '50ทวิ' ELSE 'ไม่ระบุ' END) END) END) END) END) as TaxLawName
FROM dbo.Acc_WHTax h LEFT JOIN dbo.Acc_WHTaxDetail d
ON h.DocNo=d.DocNo
WHERE h.FormType=7 {0}
AND NOT ISNULL(h.CancelProve,'')<>''  AND isnull(h.TaxNumber2,'')='' ) a
GROUP BY a.TaxNumber1,a.TName1,a.TAddress1,Branch1,FormType,TaxLawNo,Year(DocDate),Month(DocDate)
ORDER BY a.TName1
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

    Dim IDCard1 As String = ""
    Dim TaxNumber1 As String = ""
    Dim Branch1 As String = ""
    Dim TName1 As String = ""
    Dim TAddress1 As String = ""
    Dim FormType As String = ""
    Dim TaxYear As String = ""
    Dim TaxMonth As String = ""
    Dim sumPayAmount As String = ""
    Dim sumPayTax As String = ""
    Dim countDoc As String = ""

    If dt.Rows.Count > 0 Then
        For Each dr As Data.DataRow In dt.Rows
            Branch1 = dr("Branch1").ToString()
            TName1 = dr("TName1").ToString()
            TAddress1 = dr("TAddress1").ToString()
            FormType = dr("FormType")
            TaxYear = dr("TaxYear")
            TaxMonth = dr("TaxMonth")
            sumPayAmount = Convert.ToDouble(dr("SumPayAmount")).ToString("#,###,##0.00")
            sumPayTax = Convert.ToDouble(dr("SumPayTax")).ToString("#,###,##0.00")
            countDoc = dr("CountDoc")
            If TName1.IndexOf("จำกัด") > 0 Or TName1.IndexOf("LTD") > 0 Then
                TaxNumber1 = dr("TaxNumber1")
            Else
                IDCard1 = dr("IDCard1")
            End If
        Next
    End If
End Code
<style>
    * {
        font-family: AngsanaUPC;
        font-size: 14px;
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
</style>
<img src="~/pnd53.png" style="width:100%" />
<div style="display:flex">
    <div style="flex:55%;border-bottom-style:solid;border-bottom-width:1px">
        <div style="display:flex;flex-direction:column">
            <div style="flex:1">
                <div style="display:flex;flex-direction:row">
                    <div style="flex:1">
                        เลขที่ประจำตัวประชาชนของผู้มีหน้าที่หัก ณ ที่จ่าย :
                    </div>
                    <div style="flex:1">
                        <label id="lblIDCard1">@IDCard1</label>
                    </div>
                </div>
            </div>
            <div style="flex:1">
                <div style="display:flex;flex-direction:row">
                    <div style="flex:1">
                        เลขที่ประจำตัวผู้เสียภาษีของผู้มีหน้าที่หัก ณ ที่จ่าย<br />
                        (ที่เป็นผู้ไม่มีเลขประจำตัวบัตรประชาชน) :
                    </div>
                    <div style="flex:1">
                        <label id="lblTaxNumber1">@TaxNumber1</label>
                    </div>
                </div>
            </div>
        </div>
        <div style="flex:1">
            <div style="display:flex;flex-direction:row">
                <div style="flex:1">
                    <b>ชื่อผู้มีหน้าที่หักภาษี ณ ที่จ่าย (หน่วยงาน)</b>
                </div>
                <div style="flex:1">
                    <b>สาขาที่</b>
                    <input type="text" id="lblBranch1" style="width:50px;height:20px" value="@Branch1" />
                </div>
            </div>
        </div>
        <div style="flex:1">
            <label id="lblTName1">@TName1</label>
            <br />
            <label id="lblTAddress1">@TAddress1</label>
        </div>
    </div>
    <div style="flex:45%;border-left-style:solid;border-left-width:1px;border-bottom-style:solid;border-bottom-width:1px">
        <div style="display:flex;flex-direction:column">
            <div style="width:100%;text-align:center;background-color:lightgray">
                นำส่งภาษีตาม
            </div>
            <div style="font-weight:bold">
                <div>
                    @If lno = "1" Then
                        @<input type="checkbox" checked />
                    Else
                        @<input type="checkbox" />
                    End If
                    (1) มาตรา 3 เตรส แห่งประมวลรัษฏากร<br />
                </div>
                <div>
                    @If lno = "2" Then
                        @<input type="checkbox" checked />
                    Else
                        @<input type="checkbox" />
                    End If
                    (2) มาตรา 65 จัตวา แห่งประมวลรัษฏากร<br />
                </div>
                <div>
                    @If lno = "3" Then
                        @<input type="checkbox" checked />
                    Else
                        @<input type="checkbox" />
                    End If
                    (3) มาตรา 69 ทวิ แห่งประมวลรัษฏากร<br />
                </div>
            </div>
            <div style="display:flex;flex-direction:row;border-top-style:solid;border-top-width:1px">
                <div style="flex:1;padding:5px 5px 5px 5px">
                    <input type="checkbox" checked /> (1) ยื่นปกติ
                </div>
                <div style="flex:2;padding:5px 5px 5px 5px">
                    <input type="checkbox" />(2) ยื่นเพิ่มเติมครั้งที่ <input type="text" style="width:30px" />
                </div>
            </div>
        </div>
    </div>
</div>
<div style="display:flex">
    <div style="flex:55%;border-bottom-style:solid;border-bottom-width:1px;padding:5px 5px 5px 5px">
        <div>
            <b>เดือนที่จ่ายเงินได้พึงประเมิน</b> (ให้ทำเครื่องหมาย <input type="checkbox" checked /> ลงใน <input type="checkbox" /> หน้าชื่อเดือน) พ.ศ. <input type="text" style="width:50px;height:20px" value="@TaxYear" />
        </div>
        <div style="display:flex">
            <div style="flex:1">
                @If TaxMonth = 1 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (1) มกราคม
            </div>
            <div style="flex:1">
                @If TaxMonth = 2 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (2) กุมภาพันธ์
            </div>
            <div style="flex:1">
                @If TaxMonth = 3 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (3) มีนาคม
            </div>
            <div style="flex:1">
                @If TaxMonth = 4 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (4) เมษายม
            </div>
        </div>
        <div style="display:flex">
            <div style="flex:1">
                @If TaxMonth = 5 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (5) พฤษภาคม
            </div>
            <div style="flex:1">
                @If TaxMonth = 6 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (6) มิถุนายน
            </div>
            <div style="flex:1">
                @If TaxMonth = 7 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (7) กรกฏาคม
            </div>
            <div style="flex:1">
                @If TaxMonth = 8 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (8) สิงหาคม
            </div>
        </div>
        <div style="display:flex">
            <div style="flex:1">
                @If TaxMonth = 9 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (9) กันยายน
            </div>
            <div style="flex:1">
                @If TaxMonth = 10 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (10) ตุลาคม
            </div>
            <div style="flex:1">
                @If TaxMonth = 11 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (11) พฤศจิกายน
            </div>
            <div style="flex:1">
                @If TaxMonth = 12 Then
                    @<input type="checkbox" checked />
                Else
                    @<input type="checkbox" />
                End If
                (12) ธันวาคม
            </div>
        </div>
    </div>
    <div style="flex:45%;border-left-style:solid;border-left-width:1px;border-bottom-style:solid;border-bottom-width:1px">

    </div>
</div>
<br />
<div style="display:flex">
    <div style="flex:40%;text-align:center;font-size:16px;">
        มีรายละเอียดการหักเป็นรายผู้มีเงินได้ ปรากฏตาม
        <br />
        (ให้แสดงรายละเอียดใน<b>ใบแนบ ภ.ง.ด. 53</b> หรือใน<b>สื่อบันทึกในระบบคอมพิวเตอร์</b>อย่างใดอย่างหนึ่งเท่านั้น)
    </div>
    <div style="flex:60%;">
        <div style="display:flex;">
            <div style="flex:2;font-size:16px">
                <input type="checkbox" checked /> ใบแนบ <b>ภ.ง.ด. 53</b> ที่แนบมาพร้อมนี้
            </div>
            <div style="flex:1;font-size:16px">
                จำนวน <input type="text" style="width:50px" id="txtCountDoc" value="@countDoc" /> ราย
                <br />
                จำนวน <input type="text" style="width:50px" id="txtCountPage" /> แผ่น
            </div>
        </div>
        <div style="display:flex;">
            <div style="flex:2;font-size:16px">
                <input type="checkbox" /> สื่อบันทึกในระบบคอมพิวเตอร์ ที่แนบมาพร้อมนี้
            </div>
            <div style="flex:1;font-size:16px">
                จำนวน <input type="text" style="width:50px" /> ราย
                <br />
                จำนวน <input type="text" style="width:50px" /> แผ่น
            </div>
        </div>
        <div style="text-align:right;">
            (ตามหนังสือแสดงความประสงค์ ทะเบียนรับเลขที่......................................)
            <br />
            หรือตามหนังสือข้อตกลงการใช้งานฯ เลขอ้างอิงการลงทะเบียน................................................)
        </div>
    </div>
</div>
<br />
<div style="display:flex;flex-direction:column;align-items:center">
    <div style="width:80%;display:flex">
        <div style="flex:2;text-align:center;background-color:lightgrey;border-style:solid;border-width:1px">
            <b>สรุปรายการภาษีที่นำส่ง</b>
        </div>
        <div style="flex:1;text-align:center;border-style:solid;border-width:1px">
            จำนวนเงิน
        </div>
    </div>
    <div style="width:80%;display:flex">
        <div style="flex:2">
            <b>1. รวมยอดเงินได้ทั้งสิ้น</b>
        </div>
        <div style="flex:1">
            <input type="text" id="txtSumPayAmount" style="width:100%;text-align:right" value="@sumPayAmount" />
                        </div>
    </div>
    <div style="width:80%;display:flex">
        <div style="flex:2">
            <b>2. รวมยอดภาษีที่นำส่งทั้งสิ้น</b>
        </div>
        <div style="flex:1">
            <input type="text" id="txtSumPayTax" style="width:100%;text-align:right" value="@sumPayTax" />
                        </div>
    </div>
    <div style="width:80%;display:flex">
        <div style="flex:2">
            <b>3. เงินเพิ่ม(ถ้ามี)</b>
        </div>
        <div style="flex:1">
            <input type="text" value="0.00" style="width:100%;text-align:right" />
                        </div>
    </div>
    <div style="width:80%;display:flex">
        <div style="flex:2">
            <b>4. รวมยอดภาษีที่นำส่งทั้งสิ้นและเงินเพิ่ม (2.+3.)</b>
        </div>
        <div style="flex:1">
            <input type="text" id="txtSumTax" style="width:100%;text-align:right" value="@sumPayTax" />
                        </div>
    </div>
</div>
<br />
<hr />
<br />
<div>
    <div style="width:100%;text-align:center;font-size:16px;float:left">
        <div style="float:right">
            <br />
            <div class="circle"><br />ประทับตรา<br />นิติบุคคล<br />(ถ้ามี)</div>
            <br />
        </div>
                ข้าพเจ้าขอรับรองว่า รายการที่แจ้งไว้ข้างต้นนี้ เป็นรายการที่ถูกต้องและครบถ้วนทุกประการ
        <br />
        <br />
        <br />
        ลงชื่อ..............................................................................................ผู้จ่ายเงิน
        <br />
        (<input type="text" style="border-style:none;text-align:center" value="@TaxAuthorize" />)
        <br />
        ตำแหน่ง <input type="text" style="border-style:none;text-align:center" value="@TaxPosition" /> <br>
        ยื่นวันที่ <input type="text" style="border-style:none;text-align:center" value="______/_____________/________" />
    </div>
</div>
<div style="page-break-before:always">
    <p style="text-align:center;font-weight:bolder;font-size:14px">คำชี้แจง</p>
    <table style="width:100%;">
        <tr>
            <td style="width:50%">
                <img src="~/prd53_left1.png" style="width:90%" />
                <img src="~/prd53_left2.png" style="width:90%" />
            </td>
            <td style="width:50%">
                <img src="~/prd53_right1.png" style="width:90%" />
                <img src="~/prd53_right2.png" style="width:90%" />
            </td>
        </tr>
                    </table>
</div>
