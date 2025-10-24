@Code
    ViewData("Title") = "Stock Card Report"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    If Not Request.QueryString("DateFrom") Is Nothing Then
        dateFrom = Request.QueryString("DateFrom")
    End If
    Dim dateTo = DateAdd("d", -1, New Date(DateTime.Now.Year, Now.Month + 1, 1))
    If Not Request.QueryString("DateTo") Is Nothing Then
        dateTo = Request.QueryString("DateTo")
    End If
    Dim warehouse As String = ""
    If Not Request.QueryString("WH") Is Nothing Then
        warehouse = Request.QueryString("WH")
    End If
    Dim pdcode As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        pdcode = Request.QueryString("Code")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim sql = String.Format("select * from vStock_Card WHERE WarehouseCode='{0}' and StockProductCode='{1}' ", warehouse, pdcode)
    sql &= String.Format(" AND AccEffectiveDate>='{0}'", dateFrom)
    sql &= String.Format(" AND AccEffectiveDate<='{0}'", dateTo)
    sql &= " ORDER BY AccEffectiveDate,TransID"
End Code
<h2>@ViewBag.Title</h2>
<div id="mdlProduct" class="modal modal-dialog">    
    <div class="modal-content">
        <div class="modal-header">
            Select Product
        </div>
        <div class="modal-body">
            @Code
                Dim sqlSelect = "select distinct StockProductCode,ProductName,WarehouseCode from vStock_Onhand"
                Dim ds = obj.GetDataFromSQL(sqlSelect)
                @<table border="1" class="table table-bordered table-responsive">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Code</th>
                                <th>Name</th>
                                <th>Warehouse</th>
                            </tr>
                        </thead>
                        <tbody>
                            @for Each dr As Data.DataRow In ds.Rows
                                @<tr>
                            <td data-dismiss="modal">
                                <input type="button" class="btn btn-success" onclick="SetData('@dr("StockProductCode")','@dr("WarehouseCode")')" value="Select"/>
                            </td>
<td>@dr("StockProductCode")</td>
<td>@dr("ProductName")</td>
<td>@dr("WarehouseCode")</td>
</tr>
                            Next
                        </tbody>
                </table>
            End Code
        </div>
        <div class="modal-footer">
            <input type="button" data-dismiss="modal" class="btn btn-danger" value="Close"/>
        </div>
    </div>    
</div>
<div class="container">
    <div class="row">
        <div class="col-sm-3">
            <a href="#" data-target="#mdlProduct" data-toggle="modal">Product Code:</a>
            <br />
            <input type="text" id="txtProductCode" value="@pdcode" />            
        </div>
        <div Class="col-sm-3">
            <Label> Warehouse :   </label>
            <br />
            <input type = "text" id="txtWarehouseCode" value="@warehouse"/>
        </div>
        <div Class="col-sm-3">
            <Label>Date From:</label>
            <br />
            <input type = "date" id="txtDateFrom" value="@dateFrom.ToString("yyyy-MM-dd")" />
        </div>
        <div Class="col-sm-3">
            To
            <br />
            <input type = "date" id="txtDateTo" value="@dateTo.ToString("yyyy-MM-dd")" />
        </div>
    </div>
    <div Class="row">
        <div Class="col">
            <input type = "button" value="Show" Class="btn btn-success" onclick="RefreshPage()" />
        </div>
    </div>        
</div>
<div Class="container-fluid">
    @Code
        Dim balSql As String = String.Format("select sum(TransQty) as BalQty,sum(TransAmount) as BalAmt from vStock_Card where WarehouseCode='{0}' and  StockProductCode='{1}'", warehouse, pdcode)
        balSql &= String.Format(" AND AccEffectiveDate<'{0}'", dateFrom)
        Dim dt As New Data.DataTable
        dt = obj.GetDataFromSQL(balSql)
        Dim balQty As Double = 0
        Dim balAmount As Double = 0
        If dt.Rows.Count > 0 Then
            balQty = obj.GetDouble(dt.Rows(0)("BalQty"))
            balAmount = obj.GetDouble(dt.Rows(0)("BalAmt"))
        End If

        dt = obj.GetDataFromSQL(sql)
        If dt.Rows.Count > 0 Then
            @<table border="1" class="table table-bordered">
                 <thead>
                     <tr>
                         <th>Date</th>
                         <th>#Ref</th>
                         <th>Party</th>
                         <th>IN</th>
                         <th>OUT</th>
                         <th>BAL</th>
                         <th>AMT</th>
                     </tr>
                 </thead>
                <tbody>
                    <tr>
                        <td></td>
                        <td>Balance</td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td class="text-right">@balQty</td>
                        <td class="text-right">@balAmount</td>
                    </tr>
                    @For Each dr As Data.DataRow In dt.Rows
                        balQty += obj.GetDouble(dr("QtyIN"))
                        balQty -= obj.GetDouble(dr("QtyOUT"))
                        balAmount += obj.GetDouble(dr("AmountIN"))
                        balAmount -= obj.GetDouble(dr("AmountOUT"))
                            @<tr>
    <td>
        @Convert.ToDateTime(dr("AccEffectiveDate")).ToString("dd/MM/yyyy")
    </td>
    <td>
        @dr("AccDocNo").ToString()
    </td>
    <td>
        @dr("PartyName").ToString()
    </td>
    <td class="text-right">
        @dr("QtyIN")
    </td>
    <td class="text-right">
        @dr("QtyOUT")
    </td>
    <td class="text-right">
        @balQty
    </td>
    <td class="text-right">
        @balAmount
    </td>
</tr>
                    Next
                </tbody>
            </table>
        Else
            @<span>No Data To Show</span>
        End If
        End Code
</div>

<script type="text/javascript">
    function SetData(pd, wh) {
        document.getElementById('txtWarehouseCode').value = wh;
        document.getElementById('txtProductCode').value = pd;
    }
    function RefreshPage() {
        let warehouseCode = document.getElementById('txtWarehouseCode').value;
        let dateFrom = document.getElementById('txtDateFrom').value;
        let dateTo = document.getElementById('txtDateTo').value;
        let productCode = document.getElementById('txtProductCode').value;
        window.location.href = "?Form=StockCard&DB=@dbname&SRC=@dbSource&Code="+ productCode +"&DateFrom="+ dateFrom + "&DateTo=" + dateTo + "&WH=" + warehouseCode;
    }
</script>

