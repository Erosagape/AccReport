@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report A/R"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If

    Dim sqlW As String = ""
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    sqlW &= String.Format(" AND t.RcvDate>='{0}'", dateFrom)
    Dim dateTo = DateAdd("d",-1,DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If
    sqlW &= String.Format(" AND t.RcvDate<='{0}'", dateTo)
    Dim custCode = ""
    If Not Request.QueryString("Code") Is Nothing Then
        custCode = Request.QueryString("Code")
        custCode = "'" & custCode.Replace(",", "','") & "'"
        sqlW &= String.Format(" AND t.PartyCode IN({0})", custCode)
    End If
    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND EXISTS(select 1 from vAR_D where AccDocNo=t.InvNo and (SalesProductName like '%{0}%'  OR PartyName like '%{0}%' OR DocRefNo like '%{0}%'))", qry)
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql As String = "
select RcvNo,RcvDate,InvNo,InvDate,PartyTaxCode,PartyCode,PartyName,
sum(Amount) as TotalAmount,
sum(VatAmount) as TotalVat,
sum(WhtAmount) as TotalWht,
sum(RcvAmt) as TotalNet,
sum(case when DateDiff(MONTH,Invdate,RcvDate)=0 then RcvAmt else 0 end) as TotalThisMonth,
sum(case when DateDiff(MONTH,Invdate,RcvDate)=1 then RcvAmt else 0 end) as TotalLastMonth,
sum(case when DateDiff(MONTH,Invdate,RcvDate)=2 then RcvAmt else 0 end) as TotalTwoMonth,
sum(case when DateDiff(MONTH,Invdate,RcvDate)>2 then RcvAmt else 0 end) as TotalOver2Month
from (
    select r.AccDocNo as RcvNo,
    r.AccBatchDate as Rcvdate,i.AccDocNo as InvNo,i.AccBatchDate as InvDate,
    r.DNetAmt as RcvAmt,i.DNetAmt as InvAmt,i.ProductCode,i.ProductName,r.Amount,r.DVatAmt as VatAmount,r.DWhtAmt as WhtAmount,
    r.PartyCode,r.PartyName,r.PartyTaxCode
    from vTransaction_All r
    inner join vTransaction_All i
    on r.AccSourceDocNo=i.AccDocNo
    and r.AccSourceDocItem=i.AccItemNo
    where i.AccDocType='SI'
) t where t.RcvAmt>0 {0}
group by RcvNo,RcvDate,InvNo,InvDate,PartyTaxCode,PartyCode,PartyName
order by RcvNo,RcvDate
"
    'Dim dh = obj.GetDataFromSQL(String.Format("SELECT *,Isnull(TotalPayment,0) as TotalPay,DATEDIFF(day,GETDATE(),AccEffectiveDate) as OverdueDays FROM vAR_Payment a WHERE DocStatus<>99 {0} ORDER BY AccDocNo", sqlW))
    Dim dt = obj.GetDataFromSQL(String.Format(sql, sqlW))
    Dim tb As New Data.DataTable
    Dim id As String = ""
End Code
<style>
    #reportArea {
        font-size: 10px;
    }

    td {
        padding-left: 2px;
    }
</style>
<div id="reportArea">
    <h4>A/R Received Report</h4>
    <h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    @Code
        If custCode <> "" Then
            @<h4>Customer Code :@custCode</h4>
        End If
        If qry <> "" Then
            @<h4>Filter :*@qry*</h4>
        End If
        If dt.Rows.Count > 0 Then
            @<table>
                <thead>
                    <tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            @<th>@dc.ColumnName</th>
                        Next
                    </tr>
                </thead>
                <tbody>
                    @For each dr As Data.DataRow in dt.Rows
                        @<tr>
                            @For each dc As Data.DataColumn In dt.Columns
                                If dc.ColumnName.IndexOf("Date") >= 0 Then
                                    @<td>@Convert.ToDateTime(dr(dc.ColumnName)).ToString("dd/MM/yyyy")</td>
                                Else
                                    If dc.ColumnName.IndexOf("Total") >= 0 Then
                                        @<td style="text-align:right;">@Convert.ToDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td> 
                                    Else
                                        @<td>@dr(dc.ColumnName)</td>
                                    End If
                                End If
                            Next
                        </tr>
                    Next
                </tbody>
            </table>
        Else
            @<span>No Data To Show</span>
        End If
    End Code
</div>

