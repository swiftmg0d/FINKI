package mk.ukim.finki.wp.lab_2.service;

import mk.ukim.finki.wp.lab_2.model.Movie;
import mk.ukim.finki.wp.lab_2.model.Production;

import java.util.List;
import java.util.Optional;

public interface MovieService {
    List<Movie> listAll();

    List<Movie> searchMovies(String text, String rating);

    String mostPopularMovie();

    int mostTickets();

    void IncreasePopularity(String movie, String tickets);

    void deleteMovieById(Long id, String selectedMovie);
    void deleteMovieByProduction(Production production);

    void SaveMovie(String title, String summary, String rating, String id, Production production);

    Optional<Movie> findMovieById(Long id);

    boolean Check(String text, String summary, String rating);

    void updateStatus(String selectedMovie,int numTickets);

    List<Movie> listAllBoughtMovies();

    void updateRating(String movie,String rating);
}
