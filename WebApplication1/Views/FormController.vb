Imports System.Web.Mvc

Namespace Views
    Public Class FormController
        Inherits Controller

        ' GET: Form
        Function Index() As ActionResult
            Dim formName = Request.QueryString("Form")
            If formName Is Nothing Then
                formName = ""
            End If
            Return View(formName)
        End Function
    End Class
End Namespace