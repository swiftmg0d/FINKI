<?php
require_once "../database/data_creation.php";

$pdo = openConnection();


if ($pdo) {

    $querry = <<<SQL
        CREATE TABLE IF NOT EXISTS cost
        (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT NOT NULL,
            date DATE NOT NULL,
            price FLOAT(12) NOT NULL,
            payment TEXT NOT NULL
        )
    SQL;

    $pdo->exec($querry);

    $querry1 = <<<SQL
        CREATE TABLE IF NOT EXISTS users
        (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            username TEXT NOT NULL,
            password TEXT NOT NULL
        )
    SQL;

    $pdo->exec($querry1);

    exit();

} else {
    echo "Coudn't open connection";
}
