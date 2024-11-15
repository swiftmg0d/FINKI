<?php

function openConnection(): PDO|null
{
    try {
        $pdo = new PDO("sqlite:" . __DIR__ . '/../database/db.sqlite');

        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

//        echo "Successfully connected to database\n";

        return $pdo;

    } catch (PDOException $e) {
        echo "Unsucessfuly connected to database: " . $e->getMessage() . "\n";

        return null;
    }

}
