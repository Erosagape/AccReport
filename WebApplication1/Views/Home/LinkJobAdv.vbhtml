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
    Dim debugMode = False
    If Not Request.QueryString("DEBUG") Is Nothing Then
        debugMode = IIf(Request.QueryString("DEBUG") = "Y", True, False)
    End If

    Dim groupField = "ForJNo"
    Dim sqlHead = "
declare @@datefrom date='{1}';
declare @@dateto date='{2}';
declare @@branchcode varchar(3)='{0}';
"
    Dim sql = sqlHead & "
select t.GroupField,t.DocNo,t.PaymentDate,t.AccCode,m.AccName,t.AccDesc,sum(t.Debit) as Debit,sum(t.Credit) as Credit
from
(
--Dr. เงินทดรองจ่ายพนักงาน (ยอด Net+Wht)
select c." & groupField & " as GroupField,b.AdvNo as DocNo,b.PaymentDate,a.AccCode,CONCAT(b.AdvNo,'-',b.PayChqTo) as AccName,b.TRemark as AccDesc,c.AdvNet+c.Charge50Tavi as Debit,0 as Credit
from [" + dbName + "].dbo.Job_AdvHeader b inner join [" + dbName + "].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
,Mas_AccCode a
where b.BranchCode=@@branchcode and b.DocStatus<>99
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','Cashin')
union all
--Cr.เงินสดย่อย (ยอด net)
select c." & groupField & " as GroupField,b.AdvNo,b.PaymentDate,a.AccCode,c.SDescription,b.PaymentRef as AccDesc,0 as Debit,c.AdvNet as Credit
from [" + dbName + "].dbo.Job_AdvHeader b inner join [" + dbName + "].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
,Mas_AccCode a
where b.BranchCode=@@branchcode and b.DocStatus<>99
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
union all
--Cr. หัก ณ ที่จ่ายในนามลูกค้า
select c." & groupField & " as GroupField,b.AdvNo,b.PaymentDate,a.AccCode,concat(c.SDescription,'@',c.AdvAmount),concat(isnull(e.NameThai,b.CustCode),' #',b.Doc50Tavi) as AccDesc,0 as Debit,c.Charge50Tavi as Credit
from [" + dbName + "].dbo.Job_AdvHeader b inner join [" + dbName + "].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
left join [" + dbName + "].dbo.Mas_Company e on b.CustCode=e.CustCode and b.CustBranch=e.Branch
inner join [" + dbName + "].dbo.Job_SrvSingle d on c.SICode=d.SICode
,Mas_AccCode a
where b.BranchCode=@@branchcode
and b.DocStatus<>99  and c.Charge50Tavi>0 and d.IsCredit=1
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCustomer')
union all
--Cr. หัก ณ ที่จ่าย
select c." & groupField & " as GroupField,b.AdvNo,b.PaymentDate,a.AccCode,concat(c.SDescription,'@',c.Charge50Tavi),concat(isnull(e.TName,c.VenCode),' #',b.Doc50Tavi) as AccDesc,0 as Debit,c.Charge50Tavi as Credit
from [" + dbName + "].dbo.Job_AdvHeader b inner join [" + dbName + "].dbo.Job_AdvDetail c
on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo
left join [" + dbName + "].dbo.Job_SrvSingle d on c.SICode=d.SICode
left join [" + dbName + "].dbo.Mas_Vender e on c.VenCode=e.VenCode
,Mas_AccCode a
where b.BranchCode=@@branchcode
and b.DocStatus<>99 and  c.Charge50Tavi>0 and isnull(d.IsCredit,0)=0
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
) t inner join Mas_AccCode m on t.AccCode=m.AccCode
where t.PaymentDate>=@@datefrom and t.PaymentDate<=@@dateto
group by t.GroupField,t.AccCode,t.DocNo,t.PaymentDate,t.AccCode,m.AccName,t.AccDesc
order by t.GroupField,t.AccCode
"
    Dim obj = New AccReport.CUtil()
    sql = String.Format(sql, branch, datefrom, dateto)
    Dim dt = obj.GetDataFromSQL(sql)
End Code
@If dt.Rows.Count > 0 Then
    Dim groupVal As String = ""
    Dim groupDebit As Double = 0
    Dim groupCredit As Double = 0
    Dim sumDebit As Double = 0
    Dim sumCredit As Double = 0
    @<div>
        <b>รายละเอียดการเบิกเงิน</b>
        <table border="1" style="border-style:solid;border-collapse:collapse;border-width:thin;">
            <thead>
                <tr>
                    <th>เลขที่</th>
                    <th>วันที่จ่าย</th>
                    <th>รหัสบัญชี</th>
                    <th>ชื่อบัญชี</th>
                    <th>รายละเอียด</th>
                    <th>เดบิต</th>
                    <th>เครดิต</th>
                </tr>
            </thead>
            <tbody>
                @For Each dr As Data.DataRow In dt.Rows
                    If groupField <> dr("GroupField").ToString() Then
                        If groupDebit + groupCredit > 0 Then
                            @<tr style="font-weight:bold;background-color:lightgreen;">
                                <td colspan="5">
                                    SUM: @groupField
                                </td>
                                <td style="text-align:right;">@groupDebit.ToString("#,##0.00")</td>
                                <td style="text-align:right;">@groupCredit.ToString("#,##0.00")</td>
                            </tr>
                        End If
                        groupField = dr("GroupField").ToString()
                        @<tr style="font-weight:bold;background-color:aquamarine;">
                            <td colspan="7">
                                @groupField
                            </td>
                        </tr>
                        groupDebit = 0
                        groupCredit = 0
                    End If
                    @<tr>
                        <td>@dr("DocNo")</td>
                        <td>@Convert.ToDateTime(dr("PaymentDate")).ToString("dd-MM-yyyy")</td>
                        <td>@dr("AccCode")</td>
                        <td>@dr("AccName")</td>
                        <td>@dr("AccDesc")</td>
                        <td style="text-align:right;">@obj.GetDouble(dr("Debit")).ToString("#,##0.00")</td>
                        <td style="text-align:right;">@obj.GetDouble(dr("Credit")).ToString("#,##0.00")</td>
                    </tr>
                    sumDebit += obj.GetDouble(dr("Debit"))
                    sumCredit += obj.GetDouble(dr("Credit"))
                    groupDebit += obj.GetDouble(dr("Debit"))
                    groupCredit += obj.GetDouble(dr("Credit"))
                Next
                @If groupDebit + groupCredit > 0 Then
                    @<tr style="font-weight:bold;background-color:lightgreen;">
                        <td colspan="5">
                            SUM: @groupField
                        </td>
                        <td style="text-align:right;">@groupDebit.ToString("#,##0.00")</td>
                        <td style="text-align:right;">@groupCredit.ToString("#,##0.00")</td>
                    </tr>
                End If
            </tbody>
            <tfoot>
                <tr style="background-color:aquamarine;font-weight:bold;">
                    <td colspan="5">
                        TOTAL
                    </td>
                    <td style="text-align:right;">@sumDebit.ToString("#,##0.00")</td>
                    <td style="text-align:right;">@sumCredit.ToString("#,##0.00")</td>
                </tr>
            </tfoot>
        </table>
    </div>
End If
@If debugMode Then
    @<textarea>
    @sql
</textarea>
End If
