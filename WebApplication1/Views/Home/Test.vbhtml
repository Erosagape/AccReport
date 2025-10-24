@Code
    ViewData("Title") = "Test"
    Dim mdl As AccReport.CLogin = Model
End Code
<h2>Test</h2>
@If Not mdl Is Nothing Then
    @<p>
        Login : @mdl.userId
        Hash : @mdl.hashPassword
        DB : @mdl.dbAlias
        License : @mdl.custId
    </p>
End If


