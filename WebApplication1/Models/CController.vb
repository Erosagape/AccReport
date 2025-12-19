Public Class CController
    Inherits System.Web.Mvc.Controller
    Sub New()
        ViewBag.WebIP = My.Settings.WebIP
        ViewBag.SetIdentityInsert = My.Settings.SetIdentityInsert
        ViewBag.JobDatabase = My.Settings.JobDB
        ViewBag.AccDatabase = My.Settings.AccDB
    End Sub
    Function SetLogin(userId As String, ipAddress As String, custID As String, sessionId As String, Optional minexpire As Integer = 60) As Boolean
        If SetSession(userId) <> sessionId Then
            Dim obj As New CUtil(".", "weblicense")
            Dim sql As String = "
IF NOT EXISTS(select 1 from TWTWebLogin WHERE CustID='{0}' And AppID='{1}' And UserLogIN='{2}')
BEGIN
    INSERT INTO TWTWebLogin
    (CustId,AppId,UserLogIN,FromIP,SessionID,LoginDateTime,ExpireDateTime,SessionData)
    values
    ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')
END 
ELSE
BEGIN
    UPDATE TWTWebLogin
    SET FromIP='{3}',SessionID='{4}',LoginDateTime='{5}',ExpireDateTime='{6}',SessionData='{7}'
    WHERE CustID='{0}' AND AppID='{1}' AND UserLogIN='{2}'
END
"
            sql = String.Format(sql, custID, "ACCOUNT", userId, ipAddress, sessionId, Now.ToString("yyyy-MM-dd HH:mm:ss"), Now.AddMinutes(minexpire).ToString("yyyy-MM-dd HH:mm:ss"), ViewBag.Token)
            If obj.ExecuteSQL(sql) = "OK" Then
                Session("UserLogin") = userId
                Session("Token") = sessionId
                Return True
            End If
            Return False
        End If
        Return True
    End Function
    Function SetSession(userid As String) As String
        Dim obj As New CUtil(".", "weblicense")
        Dim dt As Data.DataTable = obj.GetDataFromSQL(String.Format("SELECT * FROM TWTWebLogin WHERE UserLogIN='{0}' AND ExpireDateTime>GETDATE()", userid))
        If obj.Message = "" And dt.Rows.Count > 0 Then
            ViewBag.User = dt.Rows(0)("UserLogIN")
            ViewBag.Token = dt.Rows(0)("SessionId")
            Return ViewBag.Token
        End If
        Return ""
    End Function
    Function GetView(vName As String, Optional checkLogin As Boolean = False) As ViewResult
        SetSession(Session("UserLogin"))
        If checkLogin Then
            Session("Target") = vName
            If ViewBag.Token = "" Then
                ViewBag.Target = vName
                Return View("Login")
            End If
        End If
        If ViewBag.WebIP = "" Then
            ViewBag.WebIP = "."
        End If
        Return View(vName)
    End Function
End Class
