<?php

require_once '../database/data_creation.php';

$pdo = openConnection();

if ($_SERVER['REQUEST_METHOD'] == 'POST' && $pdo) {

    $name = $_POST["name"];
    $date = date("Y-m-d", strtotime($_POST["date"]));
    $price = floatval($_POST["price"]);
    $payment = $_POST["payment"];
    $id = intval($_POST["id"]);

    echo $name . " " . $date . " " . $price . " " . $payment;

    $querry = "UPDATE cost SET name=:name,date=:date,price=:price,payment=:payment WHERE id=:id";


    $stmt = $pdo->prepare($querry);
    $stmt->execute(['name' => $name, 'date' => $date, 'price' => $price, 'payment' => $payment, 'id' => $id]);
    header("location: ../index.php");

} else {
    echo "Error";
}