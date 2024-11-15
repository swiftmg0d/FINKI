Креирајте програма која што ќе има за цел да симулира систем за нарачки во еден кафе-бар.

Програмата треба да ги содржи следниве класи, енумерации и карактеристики:

Енумерација CoffeeType со можности: ESPRESSO, LATTE, AMERICANO

Енумерација TeaType со можности: BLACK, GREEN

Направете Trait (карактеристика) Discountable која што ќе има функција да ја намали цената на производот за фиксна сума (applyDiscount(float $amount)). Овој trait треба да го искористите во класите Coffee и Tea.

Креирајте апстрактна класа Beverage која што ќе ги има следниве својства:

   - name (string)

   - price (float)

Креирајте конструктор кои ќе ги постави овие 2 параметри.

Креирајте апстрактна функција calculateTotalPrice(int $quantity) која што има за цел да ја пресмета вкупната сума.

Креирајте класа Coffee која што наследува од Beverage. Во оваа класа треба да имате дополнително својство:

   - type (CoffeeType)

Креирајте соодветно конструктор и овде, со тоа што ќе го повикате и конструкторот од класата Beverage.

Преоптоварете ја функцијата calculateTotalPrice(int $quantity) која што ќе ја пресмета вкупната сума како price * quantity.

Креирајте класа Tea која што наследува од Beverage. Во оваа класа треба да имате дополнително својство:

   - type (TeaType)

Креирајте соодветно конструктор и овде, со тоа што ќе го повикате и конструкторот од класата Beverage.

Преоптоварете ја функцијата calculateTotalPrice(int $quantity) која што ќе ја пресмета вкупната сума како price * quantity.

Креирајте класата Order која што ќе има едно својство items која што е од тип низа од Beverage (користете type hinting).

Креирајте метода addItem(Beverage $beverage, int $quantity) која што има за цел да додаде продукт во нарачката заедно со количината на тој продукт.

Креирајте метода calculateOrderTotal која што ќе има за цел да пресмета вкупната сума на нарачката.

Пример за тоа како треба да ви изгледа кодот за тестирање на вашите класи/енумерации.

// Usage

$coffee = new Coffee("Espresso", 140.0, CoffeeType::ESPRESSO);

$tea = new Tea("Green Tea", 100.0, TeaType::GREEN);

$coffee->applyDiscount(20.0);  // Apply a discount

$order = new Order();

$order->addItem($coffee, 2);  // 2 espresso

$order->addItem($tea, 1);     // 1 green tea

echo "Total order amount: " . $order->calculateOrderTotal() . " MKD";