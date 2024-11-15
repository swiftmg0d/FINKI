<?php
require '../database/data_creation.php';
require '../jwt/jwt_helper.php';

$pdo = openConnection();
session_start();
if ($_SERVER["REQUEST_METHOD"] == "POST") {

    $stmt = $pdo->prepare("SELECT * FROM users WHERE username = :username");
    $stmt->execute(["username" => $_POST["username"]]);

    $user = $stmt->fetch(PDO::FETCH_ASSOC);

    if (!$user){
        echo '<a href="../login/index.php">Login again</a>';
        echo '<br>';
        die("The user does not exist!");
    }

    if ($_POST["password"] === $user["password"]) {
        $token = createJWT($user["id"]);

        session_regenerate_id(true);

        $_SESSION["token"] = $token;
        header("Location: ../index.php");
    }


}
