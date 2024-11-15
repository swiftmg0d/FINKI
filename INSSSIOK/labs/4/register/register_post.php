<?php
require_once __DIR__ . '/../database/data_creation.php';

$pdo = openConnection();

if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST["username"]) && isset($_POST["password"])) {

    $username = $_POST["username"];
    $password = $_POST["password"];

    $query = "INSERT INTO users (username, password) VALUES (:username, :password)";

    $stmt = $pdo->prepare($query);

    $stmt->execute(["username" => $username, "password" => $password]);

    header("location: ../index.php");


}