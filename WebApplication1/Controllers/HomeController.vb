Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim formName = Request.QueryString("Form")
        If formName Is Nothing Then
            formName = ""
        End If
        Return View(formName)
    End Function

End Class
