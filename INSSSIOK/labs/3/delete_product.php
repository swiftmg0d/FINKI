<?php
include 'db_conection.php';

if ($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['id'])) {
    $db = connection();
    $smtm = $db->prepare("DELETE FROM products WHERE id = :id");
    $id = intval($_POST['id']);
    $smtm->bindParam(":id", $id);
    $smtm->execute();

    $db->close();
    header("Location:index.php");
    exit();

}
