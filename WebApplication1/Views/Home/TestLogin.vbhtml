@Code
    ViewData("Title") = "TestLogin"
End Code
<h2>TestLogin</h2>
<input type="button" onclick="TestLogin()" value="Test" />
<script type="text/javascript">
    function TestLogin() {
        var obj = {
            userId: 'ADMIN',
            hashPassword: 'xxxxx',
            dbAlias: 'AccConcept',
            custId: 'TEST'
        };        
        //var json = JSON.stringify({ data : obj });
        //var json = JSON.stringify(obj);
        var path = window.location.pathname;
        $.post(path +'/TestLogin', obj, function () {
            alert('success');
        });
    }
</script>

