<?php
session_start();
require_once __DIR__ . '/../jwt/jwt_helper.php';
if(isset($_SESSION['token']) && decodeJWT($_SESSION['token'])){
    header("location: ./index.php");
}
?>




<form method="post" action="/login/login_post.php">
    <div>
        <label>Username</label>
        <input type="text" name="username">
    </div>
    <div>
        <label>Password</label>
        <input type="text" name="password">
    </div>
    <div>
        <label>Don't have an account?</label>
        <a href="../register/index.php"> Register</a>
    </div>
    <div>
        <button type="submit">Sumbit</button>
    </div>

</form>
