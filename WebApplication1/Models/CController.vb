Public Class CController
    Inherits System.Web.Mvc.Controller
    Sub New()
        ViewBag.User = ""
        ViewBag.Token = ""
        ViewBag.Target = ""
    End Sub
    Function SetLogin(userId As String, ipAddress As String, custID As String, sessionId As String, Optional minexpire As Integer = 60) As Boolean
        If SetSession(sessionId) <> sessionId Then
            Dim obj As New CUtil(".", "weblicense")
            Dim sql As String = "
IF NOT EXISTS(select 1 from TWTWebLogin WHERE CustID='{0}' And AppID='{1}' And UserLogIN='{2}')
BEGIN
    INSERT INTO TWTWebLogin
    (CustId,AppId,UserLogIN,FromIP,SessionID,LoginDateTime,ExpireDateTime,SessionData)
    values
    ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')
END 
ELSE
BEGIN
    UPDATE TWTWebLogin
    SET FromIP='{4}',SessionID='{5}',LoginDateTime='{6}',ExpireDateTime='{7}',SessionData='{8}'
    WHERE CustID='{0}' AND AppID='{1}' AND UserLogIN='{2}'
END
"
            sql = String.Format(sql, custID, "ACCOUNT", userId, ipAddress, sessionId, Now.ToString("yyyy-MM-dd"), Now.AddMinutes(minexpire).ToString("yyyy-MM-dd"), "")
            If obj.ExecuteSQL(sql) = "OK" Then
                Return True
            End If
            Return False
        End If
        Return True
    End Function
    Function SetSession(sessionId As String) As String
        Dim obj As New CUtil(".", "weblicense")
        Dim dt As Data.DataTable = obj.GetDataFromSQL(String.Format("SELECT * FROM TWTWebLogin WHERE SessionId='{0}' AND ExpireDateTime>GETDATE()", sessionId))
        If obj.Message = "" And dt.Rows.Count > 0 Then
            ViewBag.User = dt.Rows(0)("UserLogIN")
            ViewBag.Token = sessionId
            Return sessionId
        End If
        Return ""
    End Function
    Function GetView(vName As String, Optional checkLogin As Boolean = False) As ViewResult
        If checkLogin Then
            If ViewBag.Token = "" Then
                Return View("Login")
            End If
        End If
        ViewBag.SetIdentityInsert = My.Settings.SetIdentityInsert
        ViewBag.JobDatabase = My.Settings.JobDB
        ViewBag.AccDatabase = My.Settings.AccDB
        Return View(vName)
    End Function
End Class
