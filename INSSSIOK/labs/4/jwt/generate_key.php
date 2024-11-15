<?php
$length = 32;
try {
    echo bin2hex(random_bytes($length));
} catch (Exception $e) {
    echo $e->getMessage();
}
