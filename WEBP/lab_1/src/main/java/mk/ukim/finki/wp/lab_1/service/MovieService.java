package mk.ukim.finki.wp.lab_1.service;

import mk.ukim.finki.wp.lab_1.model.Movie;

import java.util.List;

public interface MovieService {
    List<Movie> listAll();
    List<Movie> searchMovies(String text,String rating,String type);
    String mostPopularMovie();
    int mostTickets();
    public void IncreasePopularity(String movie,String tickets);

}
