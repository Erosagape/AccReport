Public Class HomeController
    Inherits CController
    Function Index() As ActionResult
        Dim formName = Request.QueryString("Form")
        If formName Is Nothing Then
            formName = ""
        End If
        Return GetView(formName)
    End Function
    Function Login() As ActionResult
        Return View()
    End Function
    Function Transaction() As ActionResult
        Return GetView("Transaction", True)
    End Function
    Function SetTestLogin() As ActionResult
        ViewBag.User = "STAFF_ACC"
        ViewBag.Token = Session.SessionID
        SetLogin(ViewBag.User, ViewBag.WebIP, ViewBag.JobDatabase, ViewBag.Token, Session.Timeout)
        Return RedirectToAction("Index")
    End Function
    <HttpPost()>
    Function PostLogin(data As FormCollection) As ActionResult
        Dim obj As New CUtil(".", ViewBag.AccDatabase)
        Session("Target") = data("Target")
        Dim dt As Data.DataTable = obj.GetDataFromSQL(String.Format("SELECT * FROM Mas_User where username='{0}' and passwordhash='{1}'", data("UserID"), data("UserPassword")))
        If obj.Message = "" And dt.Rows.Count > 0 Then
            Dim chkResult = SetLogin(data("UserID"), Request.UserHostAddress, data("CustID"), Session.SessionID, Session.Timeout)
            If chkResult Then
                If data("Target") <> "" Then
                    Return Redirect(data("Target"))
                End If
                Return RedirectToAction("Index")
            End If
        End If
        Return RedirectToAction("Login")
    End Function
End Class
