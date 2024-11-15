<?php
require "database/data_creation.php";
require_once 'jwt/jwt_helper.php';
session_start();
$pdo = openConnection();
$query = "SELECT * FROM cost";

$stmt = $pdo->query($query);
$costs = $stmt->fetchAll(PDO::FETCH_ASSOC);

$query1 = "SELECT * FROM users";

$stmt = $pdo->query($query1);
$users = $stmt->fetchAll(PDO::FETCH_ASSOC);


?>

<div>
    <h3 style="text-align: center">Costs</h3>
    <p style="text-align: center"><a href="/add/index.php">Add cost</a></p>
    <?php
    if (isset($_SESSION['token']) && decodeJWT($_SESSION['token'])) {
        echo '<p style="text-align: center"><a href="/logout/index.php">Logout</a></p>';
    } else {
        echo '<p style="text-align: center"><a href="/login/index.php">Login</a></p>';
    }
    ?>

    <div style="display: flex; justify-content: center; flex-direction: column">
        <div style="display: flex; justify-content: center">
            <p>Name, Date, Price, Payment</p>
            <p style="margin-left: 35px;">Actions</p>
        </div>
        <?php foreach ($costs

                       as $cost) : ?>
            <div style="display:flex; justify-content: center">
                <?php echo $cost['name'] . ", " . $cost['date'] . ", " . $cost['price'] . ", " . $cost['payment']; ?>
                <form method="get" action="update/index.php">
                    <input type="hidden" name="id" value="<?php echo $cost['id'] ?>">
                    <button style="margin-left: 10px"
                        <?php if (!isset($_SESSION['token']) || !decodeJWT($_SESSION['token'])) echo 'disabled' ?>
                    >Update
                    </button>
                </form>
                <form method="post" action="delete/delete_post.php">
                    <input type="hidden" name="id" value="<?php echo $cost['id'] ?>">
                    <button style="margin-left: 10px"
                        <?php if (!isset($_SESSION['token']) || !decodeJWT($_SESSION['token'])) echo 'disabled' ?>

                    >Remove
                    </button>
                </form>
            </div>
        <?php endforeach; ?>
    </div>
</div>
