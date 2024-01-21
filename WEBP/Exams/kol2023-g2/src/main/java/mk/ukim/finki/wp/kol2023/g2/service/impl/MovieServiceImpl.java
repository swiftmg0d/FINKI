package mk.ukim.finki.wp.kol2023.g2.service.impl;

import mk.ukim.finki.wp.kol2023.g2.model.Genre;
import mk.ukim.finki.wp.kol2023.g2.model.Movie;
import mk.ukim.finki.wp.kol2023.g2.model.exceptions.InvalidMovieIdException;
import mk.ukim.finki.wp.kol2023.g2.repository.MovieRepository;
import mk.ukim.finki.wp.kol2023.g2.service.DirectorService;
import mk.ukim.finki.wp.kol2023.g2.service.MovieService;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class MovieServiceImpl implements MovieService {
    private final MovieRepository movieRepository;
    private final DirectorService directorService;

    public MovieServiceImpl(MovieRepository movieRepository, DirectorService directorService) {
        this.movieRepository = movieRepository;
        this.directorService = directorService;
    }

    @Override
    public List<Movie> listAllMovies() {
        return movieRepository.findAll();
    }

    @Override
    public Movie findById(Long id) {
        return movieRepository.findById(id).orElseThrow(InvalidMovieIdException::new);
    }

    @Override
    public Movie create(String name, String description, Double rating, Genre genre, Long director) {
        return movieRepository.save(new Movie(name,description,rating,genre,directorService.findById(director)));
    }

    @Override
    public Movie update(Long id, String name, String description, Double rating, Genre genre, Long director) {
        Movie updatedMovie=findById(id);
        updatedMovie.setName(name);
        updatedMovie.setDescription(description);
        updatedMovie.setRating(rating);
        updatedMovie.setGenre(genre);
        updatedMovie.setDirector(directorService.findById(director));
        return movieRepository.save(updatedMovie);
    }

    @Override
    public Movie delete(Long id) {
        Movie deletedMovie=findById(id);
        movieRepository.delete(deletedMovie);
        return deletedMovie;
    }

    @Override
    public Movie vote(Long id) {
        Movie votedMovie=findById(id);
        votedMovie.setVotes(votedMovie.getVotes()+1);
        return movieRepository.save(votedMovie);
    }

    @Override
    public List<Movie> listMoviesWithRatingLessThenAndGenre(Double rating, Genre genre) {
        if(rating!=null && genre!=null){
            return movieRepository.findMoviesByGenreEqualsAndRatingLessThan(genre,rating);
        }else if(rating!=null){
            return movieRepository.findMoviesByRatingLessThan(rating);
        }else if(genre!=null){
            return movieRepository.findMoviesByGenreEquals(genre);

        }
        return listAllMovies();
    }
}
