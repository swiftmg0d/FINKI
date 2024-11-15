<?php

require_once '../database/data_creation.php';

$pdo = openConnection();

if ($_SERVER['REQUEST_METHOD'] == 'POST' && $pdo) {
    $name = $_POST["name"];
    $date = date("Y-m-d", strtotime($_POST["date"]));
    $price = floatval($_POST["price"]);
    $payment = $_POST["payment"];
    echo $name . " " . $date . " " . $price . " " . $payment;

    $query = <<< SQL
        INSERT INTO cost (name,date,price,payment) VALUES (:name,:date,:price,:payment)
    SQL;
    $statement = $pdo->prepare($query);
    $statement->execute(['name' => $name, 'date' => $date, 'price' => $price, 'payment' => $payment]);

    header("location: ../index.php");


}
