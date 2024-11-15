<?php

?>


<html>

<h3 style="text-align: center">Add product</h3>

<div style="display: flex; justify-content: center; flex-direction: column">
    <form method="post" action="add_product_post.php">
        <div style="text-align: center">
            <h5>Name</h5>
            <input name="name">
        </div>
        <div style="text-align: center">
            <h5>Description</h5>
            <input name="description">

        </div>
        <div style="text-align: center">
            <h5>Price</h5>
            <input name="price" type="number">
        </div>
        <div style="text-align: center; margin-top: 5px">
            <button type="submit">Sumbit</button>
        </div>
    </form>


</div>
</html>
