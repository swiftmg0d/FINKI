package II_Kolokvium.CarTest;

import java.util.*;

public class CarTest {
    public static void main(String[] args) {
        CarCollection carCollection = new CarCollection();
        String manufacturer = fillCollection(carCollection);
        carCollection.sortByPrice(true);
        System.out.println("=== Sorted By Price ASC ===");
        print(carCollection.getList());
        carCollection.sortByPrice(false);
        System.out.println("=== Sorted By Price DESC ===");
        print(carCollection.getList());
        System.out.printf("=== Filtered By Manufacturer: %s ===\n", manufacturer);
        List<Car> result = carCollection.filterByManufacturer(manufacturer);
        print(result);
    }

    static void print(List<Car> cars) {
        for (Car c : cars) {
            System.out.println(c);
        }
    }

    static String fillCollection(CarCollection cc) {
        Scanner scanner = new Scanner(System.in);
        while (scanner.hasNext()) {
            String line = scanner.nextLine();
            String[] parts = line.split(" ");
            if(parts.length < 4) return parts[0];
            Car car = new Car(parts[0], parts[1], Integer.parseInt(parts[2]),
                    Float.parseFloat(parts[3]));
            cc.addCar(car);
        }
        scanner.close();
        return "";
    }
}
class CarCollection{
    List<Car>carCollection;

    public CarCollection() {
        carCollection=new ArrayList<>();
    }

    public List<Car> filterByManufacturer(String manufacturer) {
        List<Car>newList=new ArrayList<>();
        carCollection.forEach(i->{
            if(i.getMmanufacturer().compareToIgnoreCase(manufacturer)==0){
                newList.add(i);
            }
        });
        Collections.sort(newList,new CompareCarsString());
        return newList;
    }

    public void addCar(Car car) {
            carCollection.add(car);
    }

    public void sortByPrice(boolean b) {
        if(b==true){
            Collections.sort(carCollection,new CompareCars());
        }else{
            Collections.sort(carCollection,new CompareCars().reversed());
        }
    }

    public List<Car> getList() {
        return carCollection;
    }

}
class CompareCarsString implements Comparator<Car>{

    @Override
    public int compare(Car o1, Car o2) {
        return o1.getModel().compareToIgnoreCase(o2.getModel());
    }
}
class CompareCars implements Comparator<Car>{

    @Override
    public int compare(Car o1, Car o2) {
       int x=Integer.compare(o1.getPrice(),o2.getPrice());
       if(x==0){
           return x=Float.compare(o1.getPower(),o2.getPower());
       }
       return x;
    }
}
class Car{
    private String mmanufacturer;
    private String model;
    private int price;
    private float power;

    public String getMmanufacturer() {
        return mmanufacturer;
    }

    public void setMmanufacturer(String mmanufacturer) {
        this.mmanufacturer = mmanufacturer;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public int getPrice() {
        return price;
    }

    public void setPrice(int price) {
        this.price = price;
    }

    public float getPower() {
        return power;
    }

    public void setPower(float power) {
        this.power = power;
    }

    public Car(String mmanufacturer, String model, int price, float power) {
        this.mmanufacturer = mmanufacturer;
        this.model = model;
        this.price = price;
        this.power = power;
    }

    @Override
    public String toString() {
        return String.format("%s %s (%.0fKW) %d",mmanufacturer,model,power,price);
    }
}