package mk.ukim.finki.wp.lab_1.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_1.model.Movie;
import mk.ukim.finki.wp.lab_1.repository.InMemoryMovieRepository;
import mk.ukim.finki.wp.lab_1.service.MovieService;
import org.springframework.stereotype.Service;

import java.util.List;
@AllArgsConstructor
@Service
public class MovieServiceImpl implements MovieService {

    private final InMemoryMovieRepository movieRepository;
    @Override
    public List<Movie> listAll() {
        return movieRepository.findAll();
    }

    @Override
    public List<Movie> searchMovies(String text, String rating,String type) {
        return movieRepository.searchMovies(text,rating,type);
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

}
