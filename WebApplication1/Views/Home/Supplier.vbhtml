@Code
    ViewData("Title") = "Supplier"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql = "SELECT * FROM Mas_Supplier"
    Dim dt = obj.GetDataFromSQL(sql)
End Code
<h2>Supplier</h2>
<table class="dataTable table">
    <thead>
        <tr>
            <th>Code</th>
            <th>TaxNumber/Branch</th>
            <th>Name</th>
            <th>Function</th>
        </tr>
    </thead>
    <tbody>       
        @If dt.Rows.Count > 0 Then
            For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>@dr("SupplierCode")</td>
                    <td>@dr("TaxNumber")/@dr("TaxBranch")</td>
                    <td>@dr("SupplierName") <br /> @dr("SupplierEName")</td>
                    <td>
                        <a href="Form?Form=Transaction&DB=@dbName&SRC=@dbSource&Type=PR&SUP=@dr("SupplierCode")">PURCHASE REQUEST</a><br />
                        <a href="Form?Form=Transaction&DB=@dbName&SRC=@dbSource&Type=PC&SUP=@dr("SupplierCode")">CASH PURCHASE</a><br />
                        <a href="Form?Form=Transaction&DB=@dbName&SRC=@dbSource&Type=PI&SUP=@dr("SupplierCode")">CREDIT PURCHASE</a><br />
                        <a href="Form?Form=Transaction&DB=@dbName&SRC=@dbSource&Type=DI&SUP=@dr("SupplierCode")">DELIVERY</a>
                    </td>
                </tr>
            Next
        End If
    </tbody>
</table>


