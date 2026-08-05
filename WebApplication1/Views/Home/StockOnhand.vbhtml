@Code
    ViewData("Title") = "Stock Onhand"

    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim sqlW = ""

    Dim warehouse As String = ""
    If Not Request.QueryString("WH") Is Nothing Then
        warehouse = Request.QueryString("WH")
        sqlW &= String.Format(" WarehouseCode like '{0}%'", warehouse)
    End If

    Dim pdcode As String = ""
    If Not Request.QueryString("Code") Is Nothing Then
        pdcode = Request.QueryString("Code")
        If sqlW <> "" Then sqlW &= " AND "
        sqlW &= String.Format(" StockProductCode like '{0}%'", pdcode)
    End If
    Dim accode As String = ""
    If Not Request.QueryString("acc") Is Nothing Then
        accode = Request.QueryString("acc")
        If sqlW <> "" Then sqlW &= " AND "
        sqlW &= String.Format(" AssetAccCode like '{0}%'", accode)
    End If
    Dim sql = "select * from vStock_Onhand "
    If sqlW <> "" Then
        sql &= " WHERE " & sqlW
    End If
    sql &= " ORDER BY StockProductCode"
End Code
<h2>Stock Onhand</h2>
<div id="mdlProduct" class="modal" role="dialog">
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
                                    <input type="button" class="btn btn-success" onclick="SetData('@dr("StockProductCode")','@dr("WarehouseCode")')" value="Select" />
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
            <input type="button" data-dismiss="modal" class="btn btn-danger" value="Close" />
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
            <Label> Warehouse :   </Label>
            <br />
            <input type="text" id="txtWarehouseCode" value="@warehouse" />
        </div>
        <div Class="col-sm-3">
            <Label> G/L Code :   </Label>
            <br />
            <input type="text" id="txtAccCode" value="@accode" />
        </div>
    </div>
    <div Class="row">
        <div Class="col">
            <input type="button" value="Show" Class="btn btn-success" onclick="RefreshPage()" />
        </div>
    </div>
</div>
<div Class="container-fluid">
    @Code
        Dim dt = obj.GetDataFromSQL(sql)
        If dt.Rows.Count > 0 Then
            Dim sumQty As Double = 0
            Dim sumAmount As Double = 0
            @<table border="1" class="table table-bordered">
                <thead>
                    <tr>
                        <th>Warehouse</th>
                        <th>Account</th>
                        <th>Product</th>
                        <th>Qty</th>
                        <th>Price</th>
                        <th>Amount</th>
                    </tr>
                </thead>
                <tbody>
                    @For Each dr As Data.DataRow In dt.Rows
                        sumQty += dr("SumQty")
                        sumAmount += dr("SumAmount")
                        @<tr>
                            <td>
                                <a href="?Form=StockCard&DB=@dbname&SRC=@dbSource&Code=@dr("StockProductCode")&WH=@dr("WarehouseCode")">
                                    @dr("WarehouseCode")
                                </a>
                            </td>
                            <td>
                                @dr("AssetAccCode") / @dr("AssetAccName")
                            </td>
                            <td>
                                @dr("StockProductCode").ToString() / @dr("ProductName").ToString() @dr("ProductBrand").ToString() @dr("ProductColor").ToString()
                            </td>
                            <td class="text-right">
                                @dr("SumQty") @dr("UnitStock")
                            </td>
                            <td class="text-right">
                                @obj.GetDouble(dr("AvgPrice")).ToString("#,##0.0000")
                            </td>
                            <td class="text-right">
                                @obj.GetDouble(dr("SumAmount")).ToString("#,##0.00")
                            </td>
                        </tr>
                    Next
                    <tr>
                        <td colspan="5">TOTAL</td>
                        <td>@sumAmount.ToString("#,##0.00")</td>
                    </tr>
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
        let productCode = document.getElementById('txtProductCode').value;
        let accCode = document.getElementById('txtAccCode').value;
        window.location.href = "?Form=StockOnhand&DB=@dbname&SRC=@dbSource&Acc="+accCode+"&Code="+ productCode+ "&WH=" + warehouseCode;
    }
</script>

