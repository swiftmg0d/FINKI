package mk.ukim.finki.wp.lab_2.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_2.model.Movie;
import mk.ukim.finki.wp.lab_2.model.Production;
import mk.ukim.finki.wp.lab_2.repository.InMemoryMovieRepository;
import mk.ukim.finki.wp.lab_2.service.MovieService;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@AllArgsConstructor
@Service
public class MovieServiceImpl implements MovieService {

    private final InMemoryMovieRepository movieRepository;
    @Override
    public List<Movie> listAll() {
        return movieRepository.findAll();
    }

    @Override
    public List<Movie> searchMovies(String text, String rating) {
        return movieRepository.searchMovies(text,rating);
    }

    @Override
    public String mostPopularMovie() {
        return movieRepository.mostPopularMovie();
    }

    @Override
    public int mostTickets() {
        return movieRepository.mostTickets();
    }

    @Override
    public void IncreasePopularity(String movie,String tickets) {
         movieRepository.IncreasePopularity(movie,tickets);
    }

    @Override
    public void deleteMovieById(Long id,String selectedMovie) {
        movieRepository.deleteMovieById(id,selectedMovie);
    }

    @Override
    public void deleteMovieByProduction(Production production) {
        movieRepository.deleteMovieByProduction(production);
    }

    @Override
    public void SaveMovie(String title, String summary, String rating, String id, Production production) {
        movieRepository.saveMovie(title, summary, rating, id, production);
    }


    @Override
    public Optional<Movie> findMovieById(Long id) {
        return movieRepository.findMovieById(id);
    }

    @Override
    public boolean Check(String text,String summary,String rating) {
        return movieRepository.Check(text,summary,rating);
    }

    @Override
    public void updateStatus(String selectedMovie,int numTickets) {
        movieRepository.updateStatus(selectedMovie,numTickets);
    }

    @Override
    public List<Movie> listAllBoughtMovies() {
        return movieRepository.listAllBoughtMovies();
    }

    @Override
    public void updateRating(String movie, String rating) {
        movieRepository.updateRating(movie,rating);
    }



}
