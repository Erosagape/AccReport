@Code
    ViewData("Title") = "LinkJob"
    Dim dbName = "job_ace"
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim branch = "00"
    If Not Request.QueryString("Branch") Is Nothing Then
        branch = Request.QueryString("Branch")
    End If
    Dim datefrom = "2020-01-01"
    If Not Request.QueryString("DateFrom") Is Nothing Then
        datefrom = Request.QueryString("DateFrom")
    End If
    Dim dateto = "2025-02-28"
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateto = Request.QueryString("DateTo")
    End If
    Dim sqlHead = "
declare @@datefrom date='{1}';
declare @@dateto date='{2}';
declare @@branchcode varchar(3)='{0}';
"
    Dim sql = sqlHead & "
declare @@payadv float;
declare @@whdcust float;
declare @@whdcomp float;
declare @@netadv float;
--source
select @@payadv =sum(TotalAdvance+Total50Tavi),@@netadv=sum(TotalAdvance),
@@whdcust=sum(WhtCust),@@whdcomp=sum(whtComp)
from
[" + dbName + "].dbo.Job_AdvHeader a
inner join (
select d.BranchCode,d.advNo,sum(case when s.IsCredit=1 then d.Charge50Tavi else 0 end) as whtcust,
sum(case when not isnull(s.IsCredit,0)=1 then d.Charge50Tavi else 0 end) as whtcomp
from [" + dbName + "].dbo.Job_AdvDetail d left join [" + dbName + "].dbo.Job_SrvSingle s on d.SICode=s.SICode
group by d.BranchCode,d.AdvNo
) b on a.BranchCode=b.BranchCode and a.AdvNO=b.AdvNo
where a.BranchCode=@@branchcode and a.DocStatus<>99 and a.PaymentDate>=@@datefrom and a.PaymentDate<=@@dateto
select round(@@payadv,2) as DebitPaymentSum,
round(@@whdcomp,2) as CreditWhtComp,
round(@@whdcust,2) as CreditWhtCust,
round(@@netadv,2) as CreditCashOut
"
    Dim cnnStr = "Data Source=.;Initial Catalog=AccConcept;User id=sa;Password='9t;yogm851';Persist Security Info=False"
    Dim obj = New AccReport.CUtil(cnnStr)
    sql = String.Format(sql, branch, datefrom, dateto)
    Dim dt = obj.GetDataFromSQL(sql)
    Dim msg As String = "Ready"
    Dim bComplete = False
    If obj.Message = "" Then
        bComplete = True
        msg = dt.Rows.Count
    Else
        msg = obj.Message
    End If
End Code
<h2>Link Job</h2>
@If Not bComplete Then
    @msg
Else
    @<div class="container">
        <b>Total Payment</b>
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@Convert.ToDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @msg
    @Code
        sql = sqlHead & "
declare @@paynet float;
declare @@unduevatbuy float;
select @@paynet=sum(Amt-AmtDisc),@@unduevatbuy=sum(AmtVat)
from [" + dbName + "].dbo.Job_PaymentDetail d
inner join [" + dbName + "].dbo.Job_PaymentHeader h on
d.BranchCode=h.BranchCode and d.DocNo=h.DocNo
inner join [" + dbName + "].dbo.Job_SrvSingle s on d.SICode=s.SICode
where h.BranchCode=@@branchcode and not h.CancelProve<>'' and s.IsExpense=1
and h.DocDate>=@@datefrom and h.DocDate<=@@dateto

select @@paynet+@@unduevatbuy as CreditDebtSum,@@unduevatbuy as DebitVatBuy,@@paynet as DebitNet
"
        sql = String.Format(sql, branch, datefrom, dateto)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            bComplete = True
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If
    End Code
    @<div class="container">
        <b>Total Payables</b>
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@Convert.ToDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @msg
    @code
        sql = sqlHead & "
select sum(TotalCharge) as TotalCreditIncome,
sum(TotalVat) as TotalCreditVATSale
,sum(TotalCharge)+sum(TotalVat) as TotalDebitService
,sum(TotalAdvance) as TotalDebitAdvance
from [" + dbName + "].dbo.Job_InvoiceHeader h
where h.BranchCode=@@branchcode and not isnull(cancelprove,'')<>''
and DocDate>=@@datefrom and DocDate<=@@dateto
"

        sql = String.Format(sql, branch, datefrom, dateto)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            bComplete = True
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If
    End Code
    @<div class="container">
        <b>Total Receivables</b>
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@Convert.ToDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @msg
    @Code
        sql = sqlHead & "
declare @@netserv float;
declare @@compwht float;
declare @@rcvserv float;
declare @@rcvadv float;
declare @@rcvap float;
declare @@custwht float;

select @@netserv=sum(ReceiptNet),@@compwht=sum(ReceiptWht),@@rcvserv=sum(ReceiptNet+ReceiptWht) from vRV_LinkJob where amtCharge>0
select @@rcvadv=sum(case when IsFromAdv=1 then ReceiptNet else 0 end),@@rcvap=sum(case when IsFromAdv=0 then ReceiptNet else 0 end),@@custwht=sum(ReceiptWht)
from vRV_LinkJob where amtAdvance>0

select sum(rd.Net) as DebitCal,@@netserv +@@rcvadv+@@rcvap+@@custwht as DebitCash,@@compwht as DebitWhtComp,@@netserv +@@rcvadv+@@rcvap+@@custwht+@@compwht as DebitSum
,@@rcvserv as CreditServ,@@rcvadv as CreditAdv,@@rcvap as CreditAP,@@custwht as CreditCustWht
from [" + dbName + "].dbo.Job_ReceiptDetail rd
inner join [" + dbName + "].dbo.Job_ReceiptHeader rh
on rd.BranchCode=rh.BranchCode and rd.ReceiptNo=rh.ReceiptNo
where rh.BranchCode=@@branchcode and
not isnull(rh.CancelProve,'')<>''
and rh.ReceiptDate>=@@datefrom and rh.ReceiptDate<=@@dateto
"
        sql = String.Format(sql, branch, datefrom, dateto)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            bComplete = True
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If

    End Code
    @<div class="container">
        <b>Total Received</b>
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@Convert.ToDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @msg
    @Code
        sql = sqlHead & "
select
sum(cd.UsedAmount) as DebitSum,
sum(case when a.AdvNO is not null then cd.ChargeVAT else 0 end) as DebitVAT,
sum(case when a.AdvNO is not null then 0 else cd.ChargeVAT end) as DebitVATUndue,
sum(case when a.AdvNO is not null then cd.Tax50Tavi else 0 end) as CreditWHT,
sum(case when a.AdvNO is not null then cd.UsedAmount+cd.ChargeVAT-cd.Tax50Tavi else 0 end) as CreditAdv,
sum(case when a.AdvNO is not null then 0 else cd.UsedAmount+cd.ChargeVAT end) as CreditAP
from [" + dbName + "].dbo.Job_ClearDetail cd
inner join [" + dbName + "].dbo.Job_ClearHeader ch
on cd.BranchCode=ch.BranchCode and cd.ClrNo=ch.ClrNo
left join [" + dbName + "].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo
and cd.BranchCode=a.BranchCode
inner join [" + dbName + "].dbo.Job_SrvSingle s
on cd.SICode=s.SICode
inner join vMas_Product p
on cd.SICode=p.ProductCode
where ch.BranchCode=@@branchcode and ch.ClrDate>=@@datefrom and ch.ClrDate<=@@dateto
and ch.DocStatus<>99 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')=''
"
        sql = String.Format(sql, branch, datefrom, dateto)
        dt = obj.GetDataFromSQL(sql)
        If obj.Message = "" Then
            bComplete = True
            msg = dt.Rows.Count
        Else
            msg = obj.Message
        End If
    End Code
    @<div class="container">
        <b>Total Cost</b>
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    @For each dc As Data.DataColumn In dt.Columns
                        @<th>@dc.ColumnName</th>
                    Next
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    @<tr>
                        @For each dc As Data.DataColumn In dt.Columns
                            If Not IsDBNull(dr(dc.ColumnName)) Then
                                @<td style="text-align:right;">@Convert.ToDouble(dr(dc.ColumnName)).ToString("#,##0.00")</td>
                            Else
                                @<td></td>
                            End If
                        Next
                    </tr>
                Next
            </tbody>
        </table>
    </div>
    @msg
        End If
