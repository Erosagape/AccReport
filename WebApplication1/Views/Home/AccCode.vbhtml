@Code
    ViewData("Title") = "Account Code Management"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim bConn = obj.IsConnect()
    Dim dt As Data.DataTable = obj.GetDataFromSQL("SELECT * FROM [dbo].[Mas_AccCode]")
    Dim msg As String = ""
    Dim sql As String = "IF NOT EXISTS(SELECT 1 FROM [dbo].[Mas_AccCode] where [AccCode]='{0}')
BEGIN
INSERT INTO [dbo].[Mas_AccCode]
           ([AccCode]
           ,[AccName]
           ,[AccNameEN]
           ,[AccTypeID]
           ,[AccMainCode])
     VALUES(
           '{0}'
           ,'{1}'
           ,'{2}'
           ,{3}
           ,'{4}'
           )
END
ELSE
BEGIN
UPDATE [dbo].[Mas_AccCode]
   SET 
      [AccName] = '{1}'
      ,[AccNameEN] = '{2}'
      ,[AccTypeID] = {3}
      ,[AccMainCode] = '{4}'
 WHERE [AccCode] = '{0}'
END
"
    If Not Request.Form("AccCode") Is Nothing Then
        Dim accCode = Request.Form("AccCode")
        Dim accName = Request.Form("AccName")
        Dim accNameEN = Request.Form("AccNameEN")
        Dim accTypeID = Request.Form("AccTypeID")
        Dim accMainCode = Request.Form("AccMainCode")

        sql = String.Format(sql, accCode, accName, accNameEN, accTypeID, accMainCode)
        msg = obj.ExecuteSQL(sql)
        If msg = "OK" Then
            Response.StatusCode = 200
            Response.SuppressFormsAuthenticationRedirect = True
            msg = "Data saved successfully."
        End If
    End If
End Code
@If dt.Rows.Count>0 Then
    @<table class="table table-bordered">
        <thead>
            <tr>
                <th>#</th>
                <th>Acc.Code</th>
                <th>Acc.Name</th>
                <th>Acc.Name (EN)</th>
                <th>Acc.Type ID</th>
                <th>Acc.Control</th>
            </tr>
        </thead>
        <tbody>
            @For Each dr As Data.DataRow In dt.Rows
                @<tr>
                    <td>
                        <input type="button" class="btn btn-primary" value="Edit" data-toggle="modal" data-target="#mdlEdit" onclick="EditData('@dr("AccCode")','@dr("AccName")','@dr("AccNameEN")','@dr("AccTypeID")','@dr("AccMainCode")')" />
                    </td>
                    <td>@dr("AccCode")</td>
                    <td>@dr("AccName")</td>
                    <td>@dr("AccNameEN")</td>
                    <td>@dr("AccTypeID")</td>
                    <td>@dr("AccMainCode")</td>
                </tr>
            Next
        </tbody>
    </table>    
Else
    @<p>No data found.</p>
End If
<input type="button" class="btn btn-success" value="Add New Code" onclick="ClearData()" data-toggle="modal" data-target="#mdlEdit" />
<div id="mdlEdit" class="modal" role="dialog">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Edit Account Code
            </div>
            <div class="modal-body">
                <form action="" method="post">
                    <div class="row">
                        <div class="col-sm-2">
                            Code
                        </div>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtAccCode" name="AccCode" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">
                            Name
                        </div>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtAccName" name="AccName" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">
                            Name (English)
                        </div>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtAccNameEN" name="AccNameEN" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">
                            Type
                        </div>
                        <div class="col-sm-10">
                            <select id="txtAccTypeID" class="form-control dropdown" name="AccTypeID">
                                <option value="1">Asset / สินทรัพย์</option>
                                <option value="2">Liability / หนี้สิน</option>
                                <option value="3">Capital / ส่วนของผู้ถือหุ้น</option>
                                <option value="4">Revenue / รายได้</option>
                                <option value="5">Expense / ค่าใช้จ่าย</option>
                                <option value="6">Temporary / บัญชีพัก</option>
                            </select>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">
                            Main Code
                        </div>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtAccMainCode" name="AccMainCode" />
                        </div>
                    </div>
                    <input type="submit" class="btn btn-success" value="Save" />
                </form>
            </div>
        </div>
    </div>   
</div>
<script type="text/javascript">
    let msg = '@msg';
    if (msg !== '') {
        alert(msg);
        if (window.history.replaceState) {
            window.history.replaceState(null, null, window.location.href);
        }
        window.location.reload();
    }
    function ClearData() {
        document.getElementById("txtAccCode").value = "";
        document.getElementById("txtAccName").value = "";
        document.getElementById("txtAccNameEN").value = "";
        document.getElementById("txtAccTypeID").value = "1";
        document.getElementById("txtAccMainCode").value = "";
    }
    function EditData(accCode, accName, accNameEN, accTypeID, accMainCode) {
        document.getElementById("txtAccCode").value = accCode;
        document.getElementById("txtAccName").value = accName;
        document.getElementById("txtAccNameEN").value = accNameEN;
        document.getElementById("txtAccTypeID").value = accTypeID;
        document.getElementById("txtAccMainCode").value = accMainCode;
    }        
</script>