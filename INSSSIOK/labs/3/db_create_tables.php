<?php
include 'db_conection.php';

$db = connection();

$query = <<<SQL
CREATE TABLE IF NOT EXISTS 'products'
(
    id integer primary key AUTOINCREMENT,
    'name' varchar(255) not null,
    'description' varchar(255) not null,
    'price' numeric not null
)
SQL;
$db->query($query);

$smtm = $db->prepare("INSERT INTO products(name, description, price) VALUES(:name, :description, :price)");


$name = "Chocolate";
$description = "Yummy";
$price = 72;

$smtm->bindParam(':name', $name);
$smtm->bindParam(':description', $description);
$smtm->bindParam(':price', $price);

$smtm->execute();

if ($db->exec($query)) {
    echo "Table products successfully created";
} else {
    echo "Error creating table: ";
}
$db->close();
