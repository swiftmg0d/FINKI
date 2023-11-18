package mk.ukim.finki.wp.lab_2.bootstrap;

import jakarta.annotation.PostConstruct;
import mk.ukim.finki.wp.lab_2.model.Movie;
import mk.ukim.finki.wp.lab_2.model.Production;
import mk.ukim.finki.wp.lab_2.model.TicketOrder;
import org.springframework.stereotype.Component;

import java.util.*;
import java.util.stream.IntStream;

@Component
public class DataHolder {
    public static List<Movie> list0fMovies = new ArrayList<>();
    public static TicketOrder ticketOrder = null;
    public static List<TicketOrder> list0fTickets = new ArrayList<>();
    public static List<Production> list0fProductions=new ArrayList<>();
    public static HashMap<String, Integer> movieTicketCount = new HashMap<>(100);
    public static Random random = new Random();

    @PostConstruct
    public void init() {
        IntStream.range(1,6).forEach(i->list0fProductions.add(new Production((long) (Math.random()*1000),"Production"+i,"Country"+i,"Address"+i)));
        IntStream.range(1, 11).forEach(i -> {
            Movie createdMovie = new Movie("Movie" + i,
                    Arrays.asList("Sc-Fi", "Drama", "Comedy").get(random.nextInt(3)),
                    Math.round(random.nextDouble(1, 10) * 100) / 100.00,
                    list0fProductions.get(i%5));
            list0fMovies.add(createdMovie);
            movieTicketCount.putIfAbsent(createdMovie.getTitle(), 0);
        });

    }
}
