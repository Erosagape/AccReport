@Code
    ViewData("Title") = "TestLogin"
End Code
<h2>TestLogin</h2>
<input type="button" onclick="TestLogin()" value="Test" />
<script type="text/javascript">
    function TestLogin() {
        var obj = {
            Target: '/?Form=Report',
            UserPassword: 'A6xnQhbz4Vx2HuGl4lXwZ5U2I8iziLRFnhP5eNfIRvQ=',
            CustID: 'demoacc',
            UserID: 'TEST'
        };

        var path = window.location.pathname;
        $.post(path + '/Home/PostLogin', obj, function () {
            alert('success');
            window.location.reload();
        });
    }
</script>

