@Code
    ViewData("Title") = "Customer"
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim sql = "SELECT * FROM Mas_Customer"
    Dim dt = obj.GetDataFromSQL(sql)
End Code
<h2>Customer</h2>
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
                    <td>@dr("CustomerCode")</td>
                    <td>@dr("TaxNumber")/@dr("TaxBranch")</td>
                    <td>@dr("CustomerName") <br /> @dr("CustomerEName")</td>
                    <td>
                        <a href="Form?Form=Transaction&DB=@dbName&SRC=@dbSource&Type=SR&CUST=@dr("CustomerCode")">QUOTATION</a><br />
                        <a href="Form?Form=Transaction&DB=@dbName&SRC=@dbSource&Type=RC&CUST=@dr("CustomerCode")">CASH SALE</a><br />
                        <a href="Form?Form=Transaction&DB=@dbName&SRC=@dbSource&Type=SI&CUST=@dr("CustomerCode")">CREDIT SALE</a><br />
                        <a href="Form?Form=Transaction&DB=@dbName&SRC=@dbSource&Type=DO&CUST=@dr("CustomerCode")">DELIVERY</a>
                    </td>
                </tr>
            Next
        End If
    </tbody>
</table>


