<?php
require_once __DIR__ . '/../vendor/autoload.php';

use \Firebase\JWT\JWT;
use \Firebase\JWT\Key;
use Dotenv\Dotenv;

Dotenv::createImmutable(__DIR__ . "/../" )->load();
function createJWT($id): null|string
{
    try {
        $secretKey = $_ENV["SECRET_KEY"];

        $payload = [
            'iss' => $_ENV["ISSUER"],
            'iat' => time(),
            'exp' => time() + (60 * 60),
            'data' => [
                "id" => $id
            ]
        ];
        return JWT::encode($payload, $secretKey, 'HS256');
    } catch (Exception $e) {
        echo $e->getMessage();
        return null;
    }
}

function decodeJWT($jwt): stdClass|null
{
    try {
        $secretKey = $_ENV["SECRET_KEY"];
        return JWT::decode($jwt, new Key($secretKey, 'HS256'));
    } catch (Exception $e) {
        echo $e->getMessage();
        return null;
    }
}
