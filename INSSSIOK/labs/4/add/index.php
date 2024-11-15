<?php

?>


<form method="post" action="add_post.php">
    <div>
        <label>Name: </label>
        <input type="text" name="name">
    </div>
    <div>
        <label>Date: </label>
        <input type="date" name="date">
    </div>
    <div>
        <label>Price: </label>
        <input type="number" name="price">
    </div>

    <div>
        <label>Payment: </label>
        <select name="payment">
            <option value="cash">CASH</option>
            <option value="card">CARD</option>
        </select>

    </div>

    <div>
        <div>
            <button type="submit">Sumbit</button>
        </div>


</form>
