package mk.ukim.finki.wp.lab_3.bootstrap;

import jakarta.annotation.PostConstruct;
import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.Movie;
import mk.ukim.finki.wp.lab_3.model.Production;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import mk.ukim.finki.wp.lab_3.repository.ProductionRepository;
import org.springframework.stereotype.Component;

import java.util.*;
import java.util.stream.IntStream;
@AllArgsConstructor
@Component
public class DataHolder {
    public static List<Movie> list0fMovies = new ArrayList<>();
    public static TicketOrder ticketOrder = null;
    public static List<TicketOrder> list0fTickets = new ArrayList<>();
    public static List<Production> list0fProductions=new ArrayList<>();
    public static HashMap<String, Integer> movieTicketCount = new HashMap<>(100);
    public static Random random = new Random();
    private final ProductionRepository productionRepository;
    @PostConstruct
    public void init() {

//        IntStream.range(1, 11).forEach(i -> {
//            Movie createdMovie = new Movie("Movie" + i,
//                    Arrays.asList("Sc-Fi", "Drama", "Comedy").get(random.nextInt(3)),
//                    Math.round(random.nextDouble(1, 10) * 100) / 100.00,
//                    list0fProductions.get(i%5));
//            list0fMovies.add(createdMovie);
//            movieTicketCount.putIfAbsent(createdMovie.getTitle(), 0);
//        });
        if(productionRepository.count()==0){
            IntStream.range(1,6).forEach(i->list0fProductions.add(new Production("Production"+i,"Country"+i,"Address"+i)));
            productionRepository.saveAll(list0fProductions);
        }
    }
}
