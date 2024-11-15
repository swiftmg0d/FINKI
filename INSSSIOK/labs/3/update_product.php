<?php
include 'db_conection.php';

if ($_SERVER["REQUEST_METHOD"] == "GET" && isset($_GET["id"])) {
    $id = intval($_GET["id"]);
    $db = connection();
    $smtm = $db->prepare("SELECT * FROM products WHERE id=:id");
    $smtm->bindParam(":id", $id);
    $product = $smtm->execute()->fetchArray(SQLITE3_ASSOC);


}

?>


<html lang="en">

<h3 style="text-align: center">Update product</h3>

<div style="display: flex; justify-content: center; flex-direction: column">
    <form method="post" action="update_product_post.php">
        <div style="text-align: center">
            <input name="id" value="<?php echo $product["id"]; ?>" hidden>

            <h5>Name</h5>
            <input name="name" value="<?php echo $product["name"]; ?>"></input>
        </div>
        <div style="text-align: center">
            <h5>Description</h5>
            <input name="description" value="<?php echo $product["description"]; ?>"></input>

        </div>
        <div style="text-align: center">
            <h5>Price</h5>
            <input name="price" type="number" value="<?php echo $product["price"]; ?>"></input>
        </div>
        <div style="text-align: center; margin-top: 5px">
            <button type="submit">Sumbit</button>
        </div>
    </form>


</div>
</html>
