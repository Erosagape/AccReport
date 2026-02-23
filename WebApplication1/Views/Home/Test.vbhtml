@Code
    ViewData("Title") = "Login"
    Dim desktopMode As String = "false"
    If Not Request.QueryString("MODE") Is Nothing Then
        If Request.QueryString("MODE") = "DESKTOP" Then
            desktopMode = "true"
        End If
    End If
End Code
<script type="text/javascript">
    const path = '@Url.Content("~")';
    var hasTouchScreen = false;
    var desktopMode = @desktopMode;
    if ("maxTouchPoints" in navigator) {
      hasTouchScreen = navigator.maxTouchPoints > 0;
    }

    if (hasTouchScreen && !desktopMode) {
      window.location.href=path+'uitestacc';
    } else {
      window.location.href=path+'accui';
    }
</script>

