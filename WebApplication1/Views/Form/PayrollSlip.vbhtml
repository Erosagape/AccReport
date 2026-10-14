<style>
    #topMenu {
        display: none;
    }
</style>
@Code
    Layout = "~/Views/Shared/A4.vbhtml"
    ViewData("Title") = "Payroll"
    Dim docno As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        docno = Request.QueryString("Code")
    End If
    Dim id As Integer = 0
    If Not Request.QueryString("Id") Is Nothing Then
        Integer.TryParse(Request.QueryString("Id"), id)
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
    Dim dt As New Data.DataTable
    Dim sql As String = "select concat(b.StaffName,' ',b.StaffLastName) as StaffName,e.PositionName,
a.* from Acc_HRPayRoll a
inner join Mas_HRStaff b on
a.StaffId=b.StaffId
inner join Acc_HRContract c on b.StaffId=c.StaffId
inner join Mas_HRPayRollConfig d on c.ContractTypeId=d.ContractTypeId
inner join Mas_HREmployment f on c.ContractNo=f.ContractNo
and d.PositionId=f.PositionId and c.StaffId=f.StaffId
inner join Mas_HRPosition e on d.PositionId=e.PositionId
where a.SlipNo='{0}' AND a.StaffId='{1}'"
    dt = obj.GetDataFromSQL(String.Format(sql, docno, id))
End Code
@If dt.Rows.Count > 0 Then
    Dim totalPay As Double = 0
    @<div class="container">
        <div class="row">
            <div class="col-sm-4">
                <b> ใบจ่ายเงินเดือน</b> วันที่ @Convert.ToDateTime(dt.Rows(0)("PaymentDate")).ToString("dd/MM/yyyy")
            </div>
            <div class="col-sm-8">
                <b> ชื่อ :  </b> @dt.Rows(0)("StaffName") <b> ตำแหน่ง :  </b> @dt.Rows(0)("PositionName")
            </div>
        </div>
        <table style="width:100%">
            <tr>
                <td colspan="2"><b>รายการรับ</b></td>
                <td colspan="2"><b>รายการจ่าย</b></td>
            </tr>
            @For Each dr As Data.DataRow In dt.Rows
                totalPay += dr("AmountPayment")
                @<tr>
                    <td>
                        @If dr("AmountPayment") > 0 Then
                            @dr("SalaryName")
                        End If
                    </td>
                    <td style="text-align:right;">
                        @If dr("AmountPayment") > 0 Then
                            @Convert.ToDouble(dr("AmountAdd")).ToString("N2")
                        End If
                    </td>
                    <td>
                        @If dr("AmountPayment") < 0 Then
                            @dr("SalaryName")
                        End If
                    </td>
                    <td style="text-align:right;">
                        @If dr("AmountPayment") < 0 Then
                            @Convert.ToDouble(dr("AmountDeduct")).ToString("N2")
                        End If
                    </td>
                </tr>
            Next
            <tr>
                <td colspan="3"><b>รวมสุทธิ</b></td>
                <td style="text-align:right"><b>@totalPay.ToString("N2")</b></td>
            </tr>
        </table>
    </div>
End If
