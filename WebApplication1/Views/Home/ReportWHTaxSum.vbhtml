@Code
    Layout = "~/Views/Shared/Report.vbhtml"
    ViewData("Title") = "Report WH-Tax"
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
        sqlW &= String.Format(" AND DocDate>='{0}'", dateFrom)
    End If
    Dim dateTo = DateAdd("d", -1, DateAdd("m", 1, New Date(DateTime.Now.Year, Now.Month, 1)))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
        sqlW &= String.Format(" AND DocDate<='{0}'", dateTo)
    End If
    Dim custCode = ""
    If Not Request.QueryString("Code") Is Nothing Then
        custCode = Request.QueryString("Code")
        custCode = "'" & custCode.Replace(",", "','") & "'"
        sqlW &= String.Format(" AND TaxNumber1 ='{0}'", custCode)
    End If
    Dim ftype = ""
    If Not Request.QueryString("Type") Is Nothing Then
        ftype = Request.QueryString("Type")
        sqlW &= String.Format(" AND FormType ={0}", ftype)
    End If
    Dim qry As String = ""
    If Not Request.QueryString("Query") Is Nothing Then
        qry = Request.QueryString("Query")
        sqlW &= String.Format(" AND (EXISTS(select 1 from Acc_WHTaxDetail where DocNo=a.DocNo and PayTaxDesc like '%{0}%')  OR TName3 like '%{0}%' OR DocNo like '%{0}%' OR FormTypeName like '%{0}%' OR TaxLawName like '%{0}%')", qry)
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim sql = "SELECT TaxNumber1,Branch1,TName1, 
TaxNumber2,Branch2,TName2, 
TaxNumber3,Branch3,TName3, 
sum(TotalPayAmount) as TotalPayAmount,
sum(TotalPayTax) as TotalPayTax,
FormTypeName,TaxLawName
FROM (
  select *, 
  (case when FormType=4 then 'ภงด3' else
  (case when FormType=7 then 'ภงด53' else 
  (case when FormType=1 then 'ภงด1ก' else
  (case when FormType=2 then 'ภงด1กพิเศษ' else
  (case when FormType=3 then 'ภงด2' else
  (case when FormType=5 then 'ภงด2ก' else
  (case when FormType=6 then 'ภงด3ก' else 'รหัสผิดพลาด'
  end)  end)  end)  end)  end)  end)  end) as FormTypeName,
  (case when TaxLawNo=1 then '3เตรส' else 
  (case when TaxLawNo=2 then '65จัดวา' else 
  (case when TaxLawNo=3 then '69ทวิ' else 
  (case when TaxLawNo=4 then '48ทวิ' else 
  (case when TaxLawNo=5 then '50ทวิ' else 'รหัสผิดพลาด' 
  end)  end)  end)  end)  end) as TaxLawName
  from Acc_WHTax
) a"
    Dim dh = obj.GetDataFromSQL(String.Format(sql & " WHERE CancelProve='' {0}", sqlW) & " group by TaxNumber1,Branch1,TName1, 
TaxNumber2,Branch2,TName2, 
TaxNumber3,Branch3,TName3, 
FormTypeName,TaxLawName")
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
    <h4>WH-Tax Report</h4>
    <h4>Date From : @Convert.ToDateTime(dateFrom).ToString("dd/MM/yyyy") To : @Convert.ToDateTime(dateTo).ToString("dd/MM/yyyy")</h4>
    @Code
        If custCode <> "" Then
            @<h4>Customer Code :@custCode</h4>
        End If
        If qry <> "" Then
            @<h4>Filter :*@qry*</h4>
        End If
        @<table>
            <thead>
                <tr>
                    <th>Tax Author</th>
                    <th>Tax Agent</th>
                    <th>Tax Payer</th>
                    <th>Amount</th>
                    <th>Tax</th>
                    <th>Form.Type</th>
                    <th>Law.No</th>
                </tr>
            </thead>
            <tbody>
                @For each rh As Data.DataRow In dh.Rows
                    @<tr style="font-weight:bold;">
                         <td>@rh("TaxNumber1")/@rh("Branch1") @rh("TName1")</td>
                         <td>@rh("TaxNumber2")/@rh("Branch2") @rh("TName2")</td>
                         <td>@rh("TaxNumber3")/@rh("Branch3") @rh("TName3")</td>
                        <td style="text-align:right">@Convert.ToDouble(rh("TotalPayAmount")).ToString("#,##0.00") </td>
                        <td style="text-align:right">@Convert.ToDouble(rh("TotalPayTax")).ToString("#,##0.00") </td>
                        <td>@rh("FormTypeName")</td>
                        <td>@rh("TaxLawName")</td>
                    </tr>
                Next
            </tbody>

        </table>
    End Code
</div>