<?php

enum Coffeetype: string
{
    case ESPRESSO = "Espresso";
    case LATE = "Late";
    case AMERICANO = "Americano";
}

enum TeaType: string
{
    case BLACK = "black";
    case GREEN = "green";

}

trait Discountable
{
    function applyDiscount(float $amount): void
    {
        $this->price = $this->price - $amount;
    }
}

abstract class Beverage
{
    public function __construct(public string $name, public float $price)
    {
    }

    abstract function calculateTotalPrice(int $quantity);
}

class Coffee extends Beverage
{
    use Discountable;

    public function __construct(public string $name, public float $price, public Coffeetype $type)
    {
        parent::__construct($name, $price);
    }

    function calculateTotalPrice(int $quantity): float|int
    {
        return $this->price * $quantity;
    }
}

class Tea extends Beverage
{
    use Discountable;

    public function __construct(public string $name, public float $price, public TeaType $type)
    {
        parent::__construct($name, $price);
    }

    function calculateTotalPrice(int $quantity): float|int
    {
        return $this->price * $quantity;
    }
}

class Order
{
    public array $items = [];

    function addItem(Beverage $beverage, int $quantity)
    {
        $this->items[] = ["item" => $beverage, "quantity" => $quantity];
    }

    function calulateOrderTotal(): int
    {
        return array_reduce($this->items, function ($initial, $item) {
            return $initial + $item["item"]->price * $item["quantity"];
        }, 0);
    }
}

$coffee = new Coffee("Espresso", 140, Coffeetype::ESPRESSO);
$tea = new Tea("Black", 140, Teatype::BLACK);
echo $coffee->price;
$coffee->applyDiscount(30);
echo "</br>";
echo $coffee->price;
$order = new Order();
$order->addItem($coffee, 2);
$order->addItem($tea, 2);
echo "</br>";

echo "Total order amount: " . $order->calulateOrderTotal() . " MKD";

