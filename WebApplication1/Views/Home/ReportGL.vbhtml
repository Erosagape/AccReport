@Code
    ViewData("Title") = "ReportGL"
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
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim obj = New AccReport.CUtil(".", dbSource)
    Dim dt = obj.GetDataFromSQL("SELECT AccCode,AccName from vMas_AccCode order by AccCode")
End Code

<h2>Report - General Ledger</h2>
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-3">
            Date From:<br />
            <input type="date" id="txtDateFrom" value="@dateFrom.ToString("yyyy-MM-dd")" />
        </div>
        <div class="col-sm-3">
            Date To:<br />
            <input type="date" id="txtDateTo" value="@dateTo.ToString("yyyy-MM-dd")" />
        </div>
        <div class="col-sm-3">
            <a href="#" data-toggle="modal" data-target="#mdlAccCode">Acc.Code:</a>
            <br />
            <input type="text" id="txtAccCode" />
        </div>
        <div class="col-sm-3">
            <br />
            <input type="button" id="btnSubmit" value="Print" onclick="PrintData()" class="btn btn-success"/>
        </div>
    </div>
</div>
<div class="modal fade" id="mdlAccCode">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                Select Account Code
            </div>
            <div class="modal-body">
                <table id="tbAcc" border="1" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Acc.Code</th>
                            <th>Acc.Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        @If dt.Rows.Count > 0 Then
                            For Each dr As Data.DataRow In dt.Rows
                                @<tr>
                                    <td>
                                        <input type="button" class="btn btn-success" onclick="SetData('@dr("AccCode")')" value="Select" data-dismiss="modal" />
                                    </td>
                                    <td>
                                        @dr("AccCode").ToString()
                                    </td>
                                    <td>
                                        @dr("AccName").ToString()
                                    </td>
                                </tr>
                            Next
                        End If
                    </tbody>
                </table>
            </div>
            <div Class="modal-footer">
                <input type="button" Class="btn btn-danger" value="X" data-dismiss="modal" />
            </div>
        </div>
    </div>
    
</div>
<script type="text/javascript">
    function SetData(val) {
        document.getElementById("txtAccCode").value = val;
    }
    function PrintData() {
        let dateFrom = document.getElementById("txtDateFrom").value;
        let dateTo = document.getElementById("txtDateTo").value;
        let accCode = document.getElementById("txtAccCode").value;
	window.location.href = "?Form=GeneralLedger&DB=@dbname&SRC=@dbSource&Code="+ accCode +"&DateFrom="+ dateFrom + "&DateTo=" + dateTo;
    }
</script>

