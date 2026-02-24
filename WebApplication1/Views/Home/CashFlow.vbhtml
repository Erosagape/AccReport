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

    Dim sql = String.Format("EXEC dbo.GetCashFlow {0}", period)
    Dim dt As New Data.DataTable()
    dt = obj.GetDataFromSQL(sql)
End Code
<h3>งบกระแสเงินสด แบบทางตรง</h3>
<b>ประจำงวด :</b> @period
@If dt.Rows.Count > 0 Then
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
            @If dr("lvl") = 0 Or dr("lvl") > 2 Then
                @<b>@dr("AccDesc")</b>
            Else
                If dr("CashIn") > 0 Then
                    @<b><u>+</u></b>
                Else
                    @<b><u>-</u></b>
                End If
                @<span>@dr("AccDesc")</span>
            End If
        </td>
        <td style="text-align:right;">
            @If dr("lvl") = 0 Or dr("lvl") > 2 Then
                @<b>@obj.GetDouble(dr("CashIn")).ToString("#,##0.00")</b>
            Else
                @<span>@obj.GetDouble(dr("CashIn")).ToString("#,##0.00")</span>
            End If
        </td>
        <td style="text-align:right;">
            @If dr("lvl") = 0 Or dr("lvl") > 2 Then
                @<b>@obj.GetDouble(dr("CashOut")).ToString("#,##0.00")</b>
            Else
                @<span>@obj.GetDouble(dr("CashOut")).ToString("#,##0.00")</span>
            End If
        </td>
    </tr>
    Next
</table>
End If 