package II_Kolokvium.BooksTest;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;
import java.util.stream.Collectors;

public class BooksTest {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();
        BookCollection booksCollection = new BookCollection();
        Set<String> categories = fillCollection(scanner, booksCollection);
        System.out.println("=== PRINT BY CATEGORY ===");
        for (String category : categories) {
            System.out.println("CATEGORY: " + category);
            booksCollection.printByCategory(category);
        }
        System.out.println("=== TOP N BY PRICE ===");
        print(booksCollection.getCheapestN(n));
    }

    static void print(List<Book> books) {
        for (Book book : books) {
            System.out.println(book);
        }
    }

    static TreeSet<String> fillCollection(Scanner scanner,
                                          BookCollection collection) {
        TreeSet<String> categories = new TreeSet<String>();
        while (scanner.hasNext()) {
            String line = scanner.nextLine();
            String[] parts = line.split(":");
            Book book = new Book(parts[0], parts[1], Float.parseFloat(parts[2]));
            collection.addBook(book);
            categories.add(parts[1]);
        }
        return categories;
    }
}
class BookCollection{
    public BookCollection() {
        bookList=new ArrayList<>();
    }

    private List<Book>bookList;
    public void addBook(Book book) {
        bookList.add(book);
    }

    public void printByCategory(String category) {
        bookList.sort(new CompareTitlePrice());
        bookList.stream().filter(i->i.getCategory().equalsIgnoreCase(category)).forEach(i->{
            System.out.println(i.toString());
        });
    }

    public List<Book> getCheapestN(int n) {
        List<Book>list=new ArrayList<>();
        if(n<bookList.size()){
            list=bookList;
        }else{
            for (int i = 0; i <n ; i++) {
                list.add(bookList.get(i));
            }
        }
        Collections.sort(list,new ComparePrice());
        return list;
    }
}
class ComparePrice implements Comparator<Book>{

    @Override
    public int compare(Book o1, Book o2) {
        return Float.compare(o1.getPrice(),o2.getPrice());
    }
}
class CompareTitlePrice implements Comparator<Book>{

    @Override
    public int compare(Book o1, Book o2) {
        int x=o1.getTitle().compareTo(o2.getTitle());
        if(x==0){
            x=Float.compare(o1.getPrice(),o2.getPrice());
        }
        return x;
    }

}
class Book{
    private String title;
    private String category;
    private float price;

    public Book(String title, String category, float price) {
        this.title = title;
        this.category = category;
        this.price = price;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getCategory() {
        return category;
    }

    public void setCategory(String category) {
        this.category = category;
    }

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    @Override
    public String toString() {
        return String.format("%s (%s) %.2f",title,category,price);
    }
}