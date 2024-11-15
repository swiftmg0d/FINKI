<?php
require_once "../database/data_creation.php";

$pdo = openConnection();


if ($pdo) {


    $stmt = $pdo->prepare("INSERT INTO cost (name, date, price, payment) VALUES (:name, :date, :price, :payment)");
    $stmt->execute(["name" => "ZIVE", "date" => date("2023-09-12"), "price" => 60, "payment" => "CARD"]);

    $stmt = $pdo->prepare("INSERT INTO users (username, password) VALUES (:username, :password)");
    $stmt->execute(["username" => "admin", "password" => "admin"]);


    exit();

} else {
    echo "Coudn't open connection";
}
