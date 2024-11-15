<?php
require_once '../database/data_creation.php';

$pdo = openConnection();

$stmt = $pdo->prepare("SELECT * FROM `cost` WHERE id=:id");
$stmt->execute([':id' => intval($_GET['id'])]);
$cost = $stmt->fetch(PDO::FETCH_ASSOC);
?>

<form method="post" action="update_post.php">
    <div>
        <input type="hidden" name="id" value="<?php echo $cost['id'] ?>">
        <label>Name: </label>
        <input type="text" name="name" value="<?php echo $cost['name'] ?>">
    </div>
    <div>

        <label>Date: </label>
        <input type="date" name="date" value="<?php echo date($cost['date']) ?>">
    </div>
    <div>
        <label>Price: </label>
        <input type="number" name="price" value="<?php echo intval($cost['price']) ?>">

    </div>
    <div>
        <label>Payment: </label>
        <select name="payment">
            <option value="cash"<?php if ($cost['payment'] == 'cash') echo 'selected' ?>>CASH</option>
            <option value="card" <?php if ($cost['payment'] == 'card') echo 'selected' ?> >CARD</option>
        </select>

    </div>
    <div>
        <button type="submit">Sumbit</button>
    </div>



</form>