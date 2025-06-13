Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim formName = Request.QueryString("Form")
        If formName Is Nothing Then
            formName = ""
        End If
        ViewBag.SetIdentityInsert = My.Settings.SetIdentityInsert
        ViewBag.JobDatabase = My.Settings.JobDB
        ViewBag.AccDatabase = My.Settings.AccDB
        Return View(formName)
    End Function

End Class
