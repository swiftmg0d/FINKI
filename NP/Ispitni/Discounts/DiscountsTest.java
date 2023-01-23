    import java.io.BufferedReader;
    import java.io.InputStream;
    import java.io.InputStreamReader;
    import java.util.*;
    import java.util.stream.Collectors;
    import java.util.stream.Stream;

    /**
     * Discounts
     */
    public class DiscountsTest {
        public static void main(String[] args) {
            Discounts discounts = new Discounts();
            int stores = discounts.readStores(System.in);
            System.out.println("Stores read: " + stores);
            System.out.println("=== By average discount ===");
            discounts.byAverageDiscount().forEach(System.out::println);
            System.out.println("=== By total discount ===");
            discounts.byTotalDiscount().forEach(System.out::println);
        }
    }
    class Product{
        private int price;
        private int priceOnDiscount;

        public Product(int price, int priceOnDiscount) {
            this.price = price;
            this.priceOnDiscount = priceOnDiscount;
        }
        public static Product createProduct(String line){
            String splited[]=line.split(":");
            return new Product(Integer.parseInt(splited[1]),Integer.parseInt(splited[0]));
        }

        public int getPrice() {
            return price;
        }

        public void setPrice(int price) {
            this.price = price;
        }

        public int getPriceOnDiscount() {
            return priceOnDiscount;
        }

        public void setPriceOnDiscount(int priceOnDiscount) {
            this.priceOnDiscount = priceOnDiscount;
        }
        public int getAvg(){
            double d=priceOnDiscount/(double)price;
            d*=100;
            d=Math.ceil(d);
            return 100-(int)d;
        }

        @Override
        public String toString() {
            if(getAvg()>=10){
                return String.format("%d%% %d/%d",getAvg(),priceOnDiscount,price);
            }
            return String.format(" %d%% %d/%d",getAvg(),priceOnDiscount,price);

        }
    }
    class Store{
        private String storeName;
        private List<Product>productList;

        public Store(String storeName, List<Product> productList) {
            this.storeName = storeName;
            this.productList = productList;
        }
        public static Store createStore(String line){
            String splitted[]=line.split(" ");
            return new Store(splitted[0],Arrays.stream(splitted).skip(1).filter(i->!i.isEmpty()).map(Product::createProduct).collect(Collectors.toList()));
        }
    public double getAvg(){
            return productList.stream().mapToInt(i->i.getAvg()).summaryStatistics().getAverage();
    }
        @Override
        public String toString() {
            StringBuilder sb=new StringBuilder(1000);
            sb.append(String.format("%s\n",storeName));
            sb.append(String.format("Average discount: %.1f%%\n",
                    productList.stream().mapToInt(i->i.getAvg()).summaryStatistics().getAverage()
            ));
            sb.append(String.format("Total discount: %d\n",totalDiscount()));
            int cnt=0;
            Collections.sort(productList,Comparator.comparing(Product::getAvg).thenComparing(Product::getPriceOnDiscount).reversed());
            for (Product i : productList) {
                if(cnt==productList.size()-1){
                    sb.append(String.format("%s", i.toString()));
                }else{
                    cnt++;
                    sb.append(String.format("%s\n", i.toString()));
                }

            }
            return sb.toString();
        }
        public int totalDiscount(){
            final int[] sum = {0};
            productList.forEach(i->{
                sum[0] +=i.getPrice()- i.getPriceOnDiscount();
            });
            return sum[0];
        }
    }
    class Discounts{
        List<Store>storeList=new ArrayList<>();
        public int readStores(InputStream in) {
            BufferedReader bufferedReader=new BufferedReader(new InputStreamReader(in));
            storeList=bufferedReader.lines().map(Store::createStore).collect(Collectors.toList());
            return storeList.size();
        }

        public List<Store> byAverageDiscount() {
            List<Store> stores=storeList.stream().sorted(Comparator.comparing(Store::getAvg).reversed()).collect(Collectors.toList()).subList(0,3);
            return stores;
        }

        public List<Store> byTotalDiscount() {
                List<Store> stores=storeList.stream().sorted(Comparator.comparing(Store::totalDiscount)).collect(Collectors.toList()).subList(0,3);
            return stores;
        }
    }