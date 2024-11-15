<?php
include 'db_conection.php';


if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $db = connection();

    $product_name = $_POST['name'];
    $product_price = intval($_POST['price']);
    $product_description = $_POST['description'];

    $smtm = $db->prepare("INSERT INTO products (name, price, description) VALUES (:name, :price, :description)");
    $smtm->bindParam(':name', $product_name);
    $smtm->bindParam(':price', $product_price);
    $smtm->bindParam(':description', $product_description);
    $smtm->execute();

    $db->close();

    header('Location: index.php');
    exit();


}