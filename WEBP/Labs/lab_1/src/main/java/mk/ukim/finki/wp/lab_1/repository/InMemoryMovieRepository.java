package mk.ukim.finki.wp.lab_1.repository;

import mk.ukim.finki.wp.lab_1.bootstrap.DataHolder;
import mk.ukim.finki.wp.lab_1.model.Movie;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.stream.Collectors;

@Repository
public class InMemoryMovieRepository {
    public List<Movie> findAll() {
        return DataHolder.list0fMovies;
    }

    public List<Movie> searchMovies(String text, String rating,String type) {
        if(type.equals("MOVIE")) return DataHolder.list0fMovies.stream().filter(i->i.getTitle().toLowerCase().contains(text.toLowerCase())).collect(Collectors.toList());
        else if(type.equals("RATING"))return DataHolder.list0fMovies.stream().filter(i->i.getRating()>=Double.valueOf(rating)).collect(Collectors.toList());
        return DataHolder.list0fMovies;

    }

    public String mostPopularMovie() {
        final String[] movie = {null};
        final int[] mostTickets = {Integer.MIN_VALUE};
        DataHolder.movieTicketCount.forEach((i, v) -> {
            if (v > mostTickets[0]) {
                mostTickets[0] = v;
                movie[0] = i;
            }
        });
        return movie[0];
    }

    public void IncreasePopularity(String movie, String tickets) {
        int ticket = Integer.valueOf(tickets);
        DataHolder.movieTicketCount.computeIfPresent(movie, (k, v) -> v + ticket);
    }

    public int mostTickets() {
        return DataHolder.movieTicketCount.get(mostPopularMovie());
    }
}
