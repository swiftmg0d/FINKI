<?php
require_once '../database/data_creation.php';

$pdo = openConnection();


if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST["id"]) && $pdo) {


    $stm = $pdo->prepare("SELECT * FROM Cost WHERE id=:id");
    $stm->execute(['id' => intval($_POST["id"])]);
    $cost = $stm->fetch(PDO::FETCH_ASSOC);

    if (intval($cost["price"]) > 100) {
        echo "Can't delete cost that are over 100!";
        echo "<a href='../index.php'>Go back to the main site!</a>";
        exit();
    }


    $pdo->prepare("DELETE FROM cost WHERE id = :id")
        ->execute([":id" => intval($_POST["id"])]);
    header("Location: ../index.php");
}