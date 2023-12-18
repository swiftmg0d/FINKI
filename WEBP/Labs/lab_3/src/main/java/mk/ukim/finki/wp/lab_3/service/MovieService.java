package mk.ukim.finki.wp.lab_3.service;

import mk.ukim.finki.wp.lab_3.model.Movie;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;

import java.util.List;
import java.util.Optional;

public interface MovieService {
    List<Movie> listAll();


    void deleteMovieById(Long id);


    void SaveMovie(String title, String summary, Double rating, Long production);

    Optional<Movie> findMovieById(Long id);

    boolean Check(String text, String summary, String rating);

    void editMovie(Long id, String title, String summary, String rating,Long production);

    Optional<Movie> mostPopularMovie();

    List<Movie> filterMovie(String searchedMovie, String searchedRating);

    void increasePopularity(Long movieID, Integer numTickets);

    void updateStatus(Long movieID);

    List<Movie> listBoughtMovies();

    void updateRating(Long id, Double rating);

    void UpateStatusForAll(List<TicketOrder> ticketOrders);

}
