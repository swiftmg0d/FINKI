<?php
require_once 'db_conection.php';

$db = connection();

$query = "SELECT * FROM `products`";
$result = $db->query($query);

?>

<html>


<div style="margin: auto; display: flex; justify-content: center; flex-direction: column">
    <div>
        <h3 style="text-align: center">Products</h3>
        <p style="text-align: center"><a href="add_product.php">Add new product</a></p>
    </div>
    <div style="display: flex; justify-content: center">
        <ul style="list-style: none; text-align: left">
            <?php while ($products = $result->fetchArray(SQLITE3_ASSOC)): ?>
                <li style="border: 1px solid black; padding: 3px"> Name: <?php echo $products["name"] ?>,
                    Description: <?php echo $products["description"] ?>, Price: <?php echo $products["price"] ?> $
                    <form style="display: inline; padding: 1px" method="get" action="update_product.php">
                        <button type="submit">Update</button>
                        <input type="hidden" name="id" value="<?php echo $products["id"] ?>">
                    </form>

                    <form style="display: inline; padding: 1px" method="post" action="delete_product.php">
                        <input type="hidden" name="id" value="<?php echo $products["id"] ?>">
                        <button type="submit">Delete</button>
                    </form>
                </li>
            <?php endwhile; ?>

        </ul>
    </div>
</div>

</html>


