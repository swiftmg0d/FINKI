<?php
session_start();
require_once __DIR__ . '/../jwt/jwt_helper.php';

if (isset($_SESSION['token']) && decodeJWT($_SESSION['token'])) {
    header("location: ./index.php");
}
?>


<form method="post" action="../register/register_post.php">

    <div>
        <label>Username</label>
        <input type="text" name="username">
    </div>

    <div>
        <label>Password</label>
        <input type="text" name="password">
    </div>

    <div>
        <button type="submit">Submit</button>
    </div>


</form>
