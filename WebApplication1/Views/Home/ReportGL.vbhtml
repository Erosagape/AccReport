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
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt = obj.GetDataFromSQL("SELECT AccCode,AccName from vMas_AccCode a where exists(select 1 from Acc_JournalDT where AccCode = a.AccCode) order by AccCode")
    Dim arAccCode As String = ""
    Dim rs = obj.GetDataFromSQL("SELECT dbo.GetAccConfig('AR_CONFIG','Sales') as t")
    If rs.Rows.Count > 0 Then
        arAccCode = rs.Rows(0)(0).ToString()
    End If
    Dim apAccCode As String = ""
    rs = obj.GetDataFromSQL("SELECT dbo.GetAccConfig('AP_CONFIG','Purchase') as t")
    If rs.Rows.Count > 0 Then
        apAccCode = rs.Rows(0)(0).ToString()
    End If
    Dim pvAccCode As String = ""
    rs = obj.GetDataFromSQL("SELECT dbo.GetAccConfig('AP_CONFIG','CashOut') as t")
    If rs.Rows.Count > 0 Then
        pvAccCode = rs.Rows(0)(0).ToString()
    End If
    Dim rvAccCode As String = ""
    rs = obj.GetDataFromSQL("SELECT dbo.GetAccConfig('AR_CONFIG','CashIn') as t")
    If rs.Rows.Count > 0 Then
        rvAccCode = rs.Rows(0)(0).ToString()
    End If
End Code

<h2>Report - General Ledger</h2>
<div class="container-fluid">
    <div class="row">
        <div class="col-sm-2">
            Date From:<br />
            <input type="date" id="txtDateFrom" value="@dateFrom.ToString("yyyy-MM-dd")" class="form-control" />
        </div>
        <div class="col-sm-2">
            Date To:<br />
            <input type="date" id="txtDateTo" value="@dateTo.ToString("yyyy-MM-dd")" class="form-control" />
        </div>
        <div class="col-sm-2">
            Type Ledger:<br />
            <select id="txtLedger" class="form-control dropdown" onchange="SetGL(this.value)">
                <option value="">ALL</option>
                <option value="4">รายได้</option>
                <option value="5">ค่าใช้จ่าย</option>
                <option value="@apAccCode">A/P เจ้าหนี้</option>
                <option value="@arAccCode">A/R ลุกหนี้</option>
                <option value="@pvAccCode">P/V จ่าย</option>
                <option value="@rvAccCode">R/V รับ</option>
            </select>
        </div>
        <div class="col-sm-2">
            Acc.Code:
            <br />
            <input type="text" id="txtAccCode" class="form-control" />
        </div>
        <div class="col-sm-2">
            <br />
            <input type="button" id="btnSubmit" value="Print" onclick="PrintData()" class="btn btn-success" />
        </div>
    </div>
</div>
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
<script type="text/javascript">
    function SetGL(val) {
        document.getElementById("txtAccCode").value = val;
    }
    function SetData(val) {

        if (document.getElementById("txtAccCode").value !== '') {
            val = document.getElementById("txtAccCode").value + "," + val;
        }
        document.getElementById("txtAccCode").value = val;
    }
    function PrintData() {
        let dateFrom = document.getElementById("txtDateFrom").value;
        let dateTo = document.getElementById("txtDateTo").value;
        let accCode = document.getElementById("txtAccCode").value;
        window.location.href = "?Form=GeneralLedger&DB=@dbname&SRC=@dbSource&Code=" + accCode + "&DateFrom=" + dateFrom + "&DateTo=" + dateTo;
    }
</script>

