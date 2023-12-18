package mk.ukim.finki.wp.lab_3.repository;

import mk.ukim.finki.wp.lab_3.model.Movie;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface MovieRepository extends JpaRepository<Movie,Long> {
    List<Movie> findMoviesByTitleContainsIgnoreCase(String title);
    List<Movie>findMoviesByRatingGreaterThanEqual(Double rating);
    List<Movie>findMoviesByTitleContainsIgnoreCaseAndRatingGreaterThanEqual(String title,Double rating);
    List<Movie>findMoviesByBoughtIsTrue();

}
