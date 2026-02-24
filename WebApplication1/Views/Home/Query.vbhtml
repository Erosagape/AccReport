@Code
    ViewData("Title") = "Trans"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbName = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbName = Request.QueryString("DB")
    End If
    Dim qry As String = "select GETDATE() as CurrentDate;"
    If Not Request.Form("Qry") Is Nothing Then
        qry = Request.Form("Qry")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim sql = qry
    Dim dt = obj.GetDataFromSQL(sql)
End Code
    <form action="" method="post">
        <textarea name="Qry" id="txtQry">@qry</textarea>
        <input type="submit" name="submit" value="Submit" />
    </form>
@If dt.Rows.Count > 0 Then
    @<table border="1"class="table table-border table-responsive" style="border-style:solid;border-collapse:collapse;border-width:thin;">
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
        @<td>@dr(dc.ColumnName)</td>
    Next
</tr>
            Next
        </tbody>
    </table>
Else
    @<b>@obj.Message</b>
End If