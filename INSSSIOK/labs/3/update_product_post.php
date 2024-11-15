<?php

include 'db_conection.php';

if($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST["id"])){

    $db=connection();

    $id = intval($_POST["id"]);
    $name = $_POST["name"];
    $price = floatval($_POST["price"]);
    $description = $_POST["description"];

    echo $id . " " . $name . " " . $price . " " . $description;

    $smtm=$db->prepare("UPDATE products SET name = :name, description = :description, price = :price WHERE id = :id");

    $smtm->bindParam(":name", $name);
    $smtm->bindParam(":description", $description);
    $smtm->bindParam(":price", $price);
    $smtm->bindParam(":id", $id);


    $smtm->execute();

    $db->close();

    header('Location: index.php');


}
