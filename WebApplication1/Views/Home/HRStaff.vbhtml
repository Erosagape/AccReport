@Code
    ViewData("Title") = "HRStaff"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    Dim dt As New Data.DataTable

    Dim msg As String = ""
    Dim sql As String = ""

    Dim StaffId As Integer = 0
    Dim StaffCode As String = ""
    Dim StaffType As Integer = 0
    Dim CitizenType As Integer = 0
    Dim Title As String = ""
    Dim TitleEN As String = ""
    Dim StaffName As String = ""
    Dim StaffNameEN As String = ""
    Dim StaffMiddleName As String = ""
    Dim StaffLastName As String = ""
    Dim StaffLastNameEN As String = ""
    Dim Nationality As String = ""
    Dim StaffRegisterAddr As String = ""
    Dim StaffRegisterAddrEN As String = ""
    Dim StaffCitizenID As String = ""
    Dim StaffCitizenIDExpireDate As String = ""
    Dim StaffAddrZipcode As String = ""
    Dim StaffUnderlingId As Integer = 0
    Dim UserID As String = ""

    If Request.Form("submit") IsNot Nothing Then
        StaffId = Request.Form("StaffId")
        StaffCode = Request.Form("StaffCode")
        StaffType = Request.Form("StaffType")
        CitizenType = Request.Form("CitizenType")
        Title = Request.Form("Title")
        TitleEN = Request.Form("TitleEN")
        StaffName = Request.Form("StaffName")
        StaffNameEN = Request.Form("StaffNameEN")
        StaffMiddleName = Request.Form("StaffMiddleName")
        StaffLastName = Request.Form("StaffLastName")
        StaffLastNameEN = Request.Form("StaffLastNameEN")
        Nationality = Request.Form("Nationality")
        StaffRegisterAddr = Request.Form("StaffRegisterAddr")
        StaffRegisterAddrEN = Request.Form("StaffRegisterAddrEN")
        StaffCitizenID = Request.Form("StaffCitizenID")
        StaffCitizenIDExpireDate = Request.Form("StaffCitizenIDExpireDate")
        StaffAddrZipcode = Request.Form("StaffAddrZipcode")
        StaffUnderlingId = Request.Form("StaffUnderlingId")
        UserID = Request.Form("UserID")
        sql = "declare @@StaffId int={0}
declare @@StaffCode varchar(50)='{1}'
declare @@StaffType int={2}
declare @@CitizenType int={3}
declare @@Title varchar(50)='{4}'
declare @@TitleEN varchar(50)='{5}'
declare @@StaffName varchar(200)='{6}'
declare @@StaffNameEN varchar(200)='{7}'
declare @@StaffMiddleName varchar(200)='{8}'
declare @@StaffLastName varchar(200)='{9}'
declare @@StaffLastNameEN varchar(200)='{10}'
declare @@Nationality varchar(10)='{11}'
declare @@StaffRegisterAddr varchar(max)='{12}'
declare @@StaffRegisterAddrEN  varchar(max)='{13}'
declare @@StaffCitizenID varchar(50)='{14}'
declare @@StaffCitizenIDExpireDate date='{15}'
declare @@StaffAddrZipcode varchar(50)='{16}'
declare @@StaffUnderlingId int={17}
declare @@UserID  varchar(50)='{18}'

if @@StaffCode=''
begin
	set @@StaffCode=dbo.GetNewStaffCode('P-###','[department]','[division]')
end

if @@StaffId=0
begin
	set @@StaffId=(select isnull(MAX(StaffId),0)+1 from Mas_HRStaff)
    
    SET IDENTITY_INSERT Mas_HRStaff ON

	INSERT INTO Mas_HRStaff
    (StaffId,StaffCode,StaffType,CitizenType,Title,TitleEN,StaffName,StaffNameEN,StaffMiddleName,StaffLastName,StaffLastNameEN,
    Nationality,StaffRegisterAddr,StaffRegisterAddrEN,StaffCitizenID,StaffCitizenIDExpireDate,StaffAddrZipcode,StaffUnderlingId,UserID)
	SELECT @@StaffId,@@StaffCode,@@StaffType,@@CitizenType,
	@@Title,@@TitleEN,@@StaffName,@@StaffNameEN,@@StaffMiddleName,@@StaffLastName,@@StaffLastNameEN,
	@@Nationality,@@StaffRegisterAddr,@@StaffRegisterAddrEN,@@StaffCitizenID,@@StaffCitizenIDExpireDate,
	@@StaffAddrZipcode,@@StaffUnderlingId,@@UserID
end
else
begin
	UPDATE Mas_HRStaff 
	SET StaffCode=@@StaffCode
	,StaffType=@@StaffType
	,CitizenType=@@CitizenType
	,Title=@@Title
	,TitleEN=@@TitleEN
	,StaffName=@@StaffName
	,StaffNameEN=@@StaffNameEN
	,StaffMiddleName=@@StaffMiddleName
	,StaffLastName=@@StaffLastName
	,StaffLastNameEN=@@StaffLastNameEN
	,Nationality=@@Nationality
	,StaffRegisterAddr=@@StaffRegisterAddr
	,StaffRegisterAddrEN=@@StaffRegisterAddrEN
	,StaffCitizenID=@@StaffCitizenID
	,StaffCitizenIDExpireDate=@@StaffCitizenIDExpireDate
	,StaffAddrZipcode=@@StaffAddrZipcode
	,StaffUnderlingId=@@StaffUnderlingId
	,UserID=@@UserID 
	WHERE StaffId=@@StaffId 
end

"
        sql = String.Format(sql, StaffId, StaffCode, StaffType, CitizenType, Title, TitleEN, StaffName, StaffNameEN,
        StaffMiddleName, StaffLastName, StaffLastNameEN, Nationality, StaffRegisterAddr, StaffRegisterAddrEN, StaffCitizenID, StaffCitizenIDExpireDate, StaffAddrZipcode, StaffUnderlingId, UserID)
        msg = obj.ExecuteSQL(sql)
        dt = obj.GetDataFromSQL(String.Format("SELECT * FROM Mas_HRStaff WHERE StaffCode='{0}'", StaffCode))
    End If
    If Not Request.QueryString("ID") Is Nothing Then
        dt = obj.GetDataFromSQL(String.Format("SELECT * FROM Mas_HRStaff WHERE StaffId={0}", Request.QueryString("ID")))
    End If
    If Not Request.QueryString("Code") Is Nothing Then
        dt = obj.GetDataFromSQL(String.Format("SELECT * FROM Mas_HRStaff WHERE StaffCode='{0}'", Request.QueryString("Code")))
    End If
    Dim mode As String = ""
    If Not Request.QueryString("Edit") Is Nothing Then
        mode = Request.QueryString("Edit").ToString()
    End If
    If dt.Rows.Count > 0 Then
        StaffId = dt.Rows(0)("StaffId")
        StaffCode = dt.Rows(0)("StaffCode")
        StaffType = dt.Rows(0)("StaffType")
        CitizenType = dt.Rows(0)("CitizenType")
        Title = dt.Rows(0)("Title")
        TitleEN = dt.Rows(0)("TitleEN")
        StaffName = dt.Rows(0)("StaffName")
        StaffNameEN = dt.Rows(0)("StaffNameEN")
        StaffMiddleName = dt.Rows(0)("StaffMiddleName")
        StaffLastName = dt.Rows(0)("StaffLastName")
        StaffLastNameEN = dt.Rows(0)("StaffLastNameEN")
        Nationality = dt.Rows(0)("Nationality")
        StaffRegisterAddr = dt.Rows(0)("StaffRegisterAddr")
        StaffRegisterAddrEN = dt.Rows(0)("StaffRegisterAddrEN")
        StaffCitizenID = dt.Rows(0)("StaffCitizenID")
        StaffCitizenIDExpireDate = Convert.ToDateTime(dt.Rows(0)("StaffCitizenIDExpireDate")).ToString("yyyy-MM-dd")
        StaffAddrZipcode = dt.Rows(0)("StaffAddrZipcode")
        StaffUnderlingId = dt.Rows(0)("StaffUnderlingId")
        UserID = dt.Rows(0)("UserID")
    End If
End Code
<div class="container-fluid">
    <h2>Staff/Employee - บันทึกข้อมูลพนักงาน</h2>
    <input type="button" id="btnModal" class="btn btn-primary" onclick="ClearData()" value="Add New Staff" />
    <input type="button" id="btnModalN" class="btn btn-primary" data-toggle="modal" data-target="#mdlData" value="Add New Staff" style="display:none" />
    <table class="table table-responsive">
        <thead>
            <tr>
                <th>#</th>
                <th>Staff Code</th>
                <th>Staff Name</th>
            </tr>
        </thead>
        <tbody>
            @Code
                Dim dtStaff As New Data.DataTable
                dtStaff = obj.GetDataFromSQL("SELECT StaffId,StaffCode,Title,StaffName,StaffMiddleName,StaffLastName FROM Mas_HRStaff")
                For Each dr As Data.DataRow In dtStaff.Rows
                    @<tr>
                        <td><input type="button" class="btn btn-info" value="Edit" onclick="EditStaff(@dr("StaffId"))" /></td>
                        <td>@dr("StaffCode")</td>
                        <td>@dr("Title") @dr("StaffName") @dr("StaffMiddleName") @dr("StaffLastName")</td>
                    </tr>
                Next
            End Code
        </tbody>
    </table>
    <div class="modal fade" role="dialog" id="mdlData">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <form action="" method="post" style="display:flex;flex-direction:column;width:100%">
                        <input type="hidden" name="StaffId" class="form-control" value="@StaffId" /><br />
                        <label>Staff Code / รหัสพนักงาน</label> <input type="text" name="StaffCode" class="form-control" value="@StaffCode" /><br />
                        <label>Staff Type / ประเภทพนักงาน</label>
                        <select id="cboStaffType" class="form-control dropdown" onclick="SetStaffType()">
                            @Code
                                Dim dtStaffType As New Data.DataTable
                                dtStaffType = obj.GetDataFromSQL("SELECT ConfigKey as StaffType,ConfigValue as ConfigName FROM Mas_HRConfig WHERE ConfigCode='STAFF_TYPE'")
                                For Each dr As Data.DataRow In dtStaffType.Rows
                                    Dim selected As String = ""
                                    If StaffType = dr("StaffType") Then
                                        selected = "selected"
                                    End If
                                    @<option value="@dr("StaffType")" @selected>@dr("ConfigName")</option>
                                Next
                            End Code
                        </select>
                        <input type="hidden" name="StaffType" class="form-control" value="@StaffType" />
                        <label>Citizen Type / กลุ่มพลเมือง</label>
                        <select id="cboCitizenType" class="form-control dropdown" onclick="SetCitizenType()">
                            @Code
                                Dim dtCitizenType As New Data.DataTable
                                dtCitizenType = obj.GetDataFromSQL("SELECT ConfigKey as CitizenType,ConfigValue as ConfigName FROM Mas_HRConfig WHERE ConfigCode='CITIZEN_TYPE'")
                                For Each dr As Data.DataRow In dtCitizenType.Rows
                                    Dim selected As String = ""
                                    If CitizenType = dr("CitizenType") Then
                                        selected = "selected"
                                    End If
                                    @<option value="@dr("CitizenType")" @selected>@dr("ConfigName")</option>
                                Next
                            End Code
                        </select>
                        <input type="hidden" name="CitizenType" class="form-control" value="@CitizenType" />
                        <label>Title / คำนำหน้า</label> <input type="text" name="Title" class="form-control" value="@Title" /><br />
                        <label>Title (ENG) / คำนำหน้า (ENG)</label> <input type="text" name="TitleEN" class="form-control" value="@TitleEN" /><br />
                        <label>First Name  / ชื่อ</label> <input type="text" name="StaffName" class="form-control" value="@StaffName" /><br />
                        <label>First Name (ENG) / ชื่อ (ENG)</label> <input type="text" name="StaffNameEN" class="form-control" value="@StaffNameEN" /><br />
                        <label>Middle Name / ชื่อกลาง</label> <input type="text" name="StaffMiddleName" class="form-control" value="@StaffMiddleName" /><br />
                        <label>Last Name (TH) / นามสกุล (TH)</label> <input type="text" name="StaffLastName" class="form-control" value="@StaffLastName" /><br />
                        <label>Last Name (ENG) / นามสกุล (ENG)</label> <input type="text" name="StaffLastNameEN" class="form-control" value="@StaffLastNameEN" /><br />
                        <label>Nationality / สัญชาติ</label> <input type="text" name="Nationality" class="form-control" value="@Nationality" /><br />
                        <label>Register Address (TH) / ที่อยู่ตามทะเบียน (TH)</label> <input type="text" name="StaffRegisterAddr" class="form-control" value="@StaffRegisterAddr" /><br />
                        <label>Register Address (ENG) / ที่อยู่ตามทะเบียน (ENG)</label> <input type="text" name="StaffRegisterAddrEN" class="form-control" value="@StaffRegisterAddrEN" /><br />
                        <label>Citizen ID / เลขประจำตัวประชาชน</label> <input type="text" name="StaffCitizenID" class="form-control" value="@StaffCitizenID" /><br />
                        <label>Citizen ExpireDate / วันหมดอายุ</label> <input type="date" name="StaffCitizenIDExpireDate" class="form-control" value="@StaffCitizenIDExpireDate" /><br />
                        <label>Zipcode / รหัสไปรษณีย์</label> <input type="text" name="StaffAddrZipcode" class="form-control" value="@StaffAddrZipcode" /><br />
                        <input type="hidden" name="StaffUnderlingId" class="form-control" value="@StaffUnderlingId" /><br />
                        <input type="hidden" name="UserID" class="form-control" value="@UserID" /><br />
                        <input type="submit" name="submit" value="Save" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var msg = "@msg";
    if (msg !== '') {
        alert(msg);
    }
    var mode = "@mode";
    window.onload=function () {
        if (mode === 'Y') {
            document.getElementById("btnModalN").click();
        }
    }

    function SetStaffType() {
        var cbo = document.getElementById("cboStaffType");
        var selectedValue = cbo.options[cbo.selectedIndex].value;
        document.getElementsByName("StaffType")[0].value = selectedValue;
    }
    function SetCitizenType() {
        var cbo = document.getElementById("cboCitizenType");
        var selectedValue = cbo.options[cbo.selectedIndex].value;
        document.getElementsByName("CitizenType")[0].value = selectedValue;
    }
    function EditStaff(StaffId) {
        window.location.href = "?Form=HRStaff&SRC=@dbSource&DB=@dbName&Id=" + StaffId + "&Edit=Y";
    }
    function ClearData() {
        window.location.href = "?Form=HRStaff&SRC=@dbSource&DB=@dbName&Id=0&Edit=Y";
    }
</script>