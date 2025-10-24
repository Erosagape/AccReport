Public Class HomeController
    Inherits CController
    Function Index() As ActionResult
        Dim formName = Request.QueryString("Form")
        If formName Is Nothing Then
            formName = ""
        End If
        Return GetView(formName)
    End Function
    Function Test() As ActionResult
        Return View()
    End Function
    Function TestLogin(data As CLogin) As ActionResult
        Return RedirectToAction("Test", data)
    End Function
    Sub PostLogin(data As CLogin)
        Dim obj As New CUtil(".", data.dbAlias)
        Dim dt As Data.DataTable = obj.GetDataFromSQL(String.Format("SELECT * FROM Mas_User where username='{0}' and passwordhash='{1}'", data.userId, data.hashPassword))
        If obj.Message = "" And dt.Rows.Count > 0 Then
            Dim chkResult = SetLogin(data.userId, Request.UserHostAddress, data.custId, Session.SessionID, Session.Timeout)
            If chkResult Then
                Response.StatusCode = 200
            Else
                Response.StatusCode = 500
            End If
        End If
    End Sub
End Class
