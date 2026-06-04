<style>
    #topMenu {
        display: none;
    }
    td {
        padding: 5px 5px 5px 5px;
    }
</style>
@Code
    Layout = "~/Views/Shared/A4.vbhtml"
    ViewBag.Title = "Cash Flow"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim period = DateTime.Now.Year()
    If Not Request.QueryString("Period") Is Nothing Then
        period = Request.QueryString("Period")
    End If
    Dim accCode As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        accCode = Request.QueryString("Code")
    End If
    Dim sql = String.Format("
DECLARE @@accCode varchar(20)='{1}'
IF @@accCode=''
BEGIN
    SET @@accCode=dbo.GetAccConfig('AP_CONFIG','CashOut')
END
EXEC dbo.GetCashFlow {0},@@accCode
", period, accCode)

    Dim dateCheck As Integer = 0
    Dim dateFrom As String = ""
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
        dateCheck += 1
    End If
    Dim dateTo As String = ""
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        dateCheck += 1
    End If
    If dateCheck = 2 Then
        sql = String.Format("
DECLARE @@accCode varchar(20)='{2}'
IF @@accCode=''
BEGIN
    SET @@accCode=dbo.GetAccConfig('AP_CONFIG','CashOut')
END
EXEC dbo.GetCashFlow_ByDate '{0}','{1}',@@accCode", dateFrom, dateTo, accCode)
    End If
    Dim dt As New Data.DataTable()
    dt = obj.GetDataFromSQL(sql)
End Code
<h3>งบกระแสเงินสด แบบทางตรง</h3>
@If dateCheck = 2 Then
    @<b>ระหว่างวันที่ :</b> @dateFrom @<b>ถึงวันที่ : </b> @dateTo
Else
    @<b>ประจำงวด : </b> @period
End If
@If dt.Rows.Count > 0 Then
    @<b>รหัสบัญชี : </b> @<a href="#" onclick="ChangeAccCode()">@dt.Rows(0)("AccCode") </a>
    @<table border="1" style="border-style:solid;border-collapse:collapse;">
         <thead>
             <tr>
                 <th>
                     รายการเคลื่อนไหว
                 </th>
                 <th>เงินสดรับ</th>
                 <th>เงินสดจ่าย</th>
             </tr>

         </thead>
    @For Each dr As Data.DataRow In dt.Rows
    @<tr>
        <td>
            @If dr("lvl") = 0 Or dr("lvl") >= 2 Then
                @<b>@dr("AccDesc")</b>
                If dr("CashIn") > 0 Then
                    @<b><u>+</u></b>
                Else
                    @<b><u>-</u></b>
                End If
            Else
                @<span>@dr("AccDesc")</span>
            End If
        </td>
        <td style="text-align:right;">
            @If dr("lvl") = 0 Or dr("lvl") >= 2 Then
                @<b>@obj.GetDouble(dr("CashIn")).ToString("#,##0.00")</b>
            Else
                @<span>@obj.GetDouble(dr("CashIn")).ToString("#,##0.00")</span>
            End If
        </td>
        <td style="text-align:right;">
            @If dr("lvl") = 0 Or dr("lvl") >= 2 Then
                @<b>@obj.GetDouble(dr("CashOut")).ToString("#,##0.00")</b>
            Else
                @<span>@obj.GetDouble(dr("CashOut")).ToString("#,##0.00")</span>
            End If
        </td>
    </tr>
    Next
</table>
End If 
<script type="text/javascript">
    function ChangeAccCode() {
        var code = prompt("ระบุรหัสบัญชีเงินสดจ่ายที่ต้องการดู");
        if (code != null) {
            var url = window.location.href;
            url = url.replace(/(&|\?)Code=[^&]*/, '');
            if (url.indexOf("?") > -1) {
                url += "&Code=" + code;
            } else {
                url += "?Code=" + code;
            }
            window.location.href = url;
        }
    }
</script>