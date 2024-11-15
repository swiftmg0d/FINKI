<?php

function connection(): SQLite3
{
    return new SQLite3(__DIR__ . "/database/db.sqlite");
}


