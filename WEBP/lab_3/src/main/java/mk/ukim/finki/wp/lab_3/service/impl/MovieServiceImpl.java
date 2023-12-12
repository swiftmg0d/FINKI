package mk.ukim.finki.wp.lab_3.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.Movie;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import mk.ukim.finki.wp.lab_3.repository.MovieRepository;
import mk.ukim.finki.wp.lab_3.repository.ProductionRepository;
import mk.ukim.finki.wp.lab_3.service.MovieService;
import mk.ukim.finki.wp.lab_3.service.TicketOrderService;
import org.springframework.stereotype.Service;

import java.util.*;

@AllArgsConstructor
@Service
public class MovieServiceImpl implements MovieService {
    private final MovieRepository movieRepository;
    private final ProductionRepository productionRepository;
    private final TicketOrderService ticketOrderService;


    @Override
    public List<Movie> listAll() {
        return movieRepository.findAll();
    }


    @Override
    public void deleteMovieById(Long id) {
        ticketOrderService.removeByMovies(id);
        movieRepository.deleteById(id);
    }

    @Override
    public void SaveMovie(String title, String summary, Double rating, Long production) {
        productionRepository.findById(production).ifPresent(i -> movieRepository.save(new Movie(title, summary, rating, i)));
    }


    @Override
    public Optional<Movie> findMovieById(Long id) {
        return movieRepository.findById(id);
    }

    public boolean CheckIf(String text, String summary, String rating) {
        if (Objects.equals(text, "") || Objects.equals(summary, "") || Objects.equals(rating, "")) {
            return true;
        }
        for (char c : rating.toCharArray()) {
            if (Character.isLetter(c)) {
                return true;
            }
        }
        return false;
    }

    @Override
    public boolean Check(String text, String summary, String rating) {
        return CheckIf(text, summary, rating);
    }

    @Override
    public void editMovie(Long id, String title, String summary, String rating, Long production) {
        movieRepository.findById(id).ifPresent(i -> {
            i.setTitle(title);
            i.setSummary(summary);
            i.setRating(Double.parseDouble(rating));
            i.setProduction(productionRepository.findById(production).get());
            movieRepository.save(i);
        });
    }

    @Override
    public Optional<Movie> mostPopularMovie() {
        return movieRepository.findAll().stream().max(Comparator.comparingInt(Movie::getNumTickets));
    }

    @Override
    public List<Movie> filterMovie(String searchedMovie, String searchedRating) {
        if (!Objects.equals(searchedMovie, "") && !Objects.equals(searchedRating, "")) {
            return movieRepository.findMoviesByTitleContainsIgnoreCaseAndRatingGreaterThanEqual(searchedMovie, Double.valueOf(searchedRating));
        } else if (!Objects.equals(searchedMovie, "")) {
            return movieRepository.findMoviesByTitleContainsIgnoreCase(searchedMovie);
        } else if (!Objects.equals(searchedRating, "")) {
            return movieRepository.findMoviesByRatingGreaterThanEqual(Double.valueOf(searchedRating));
        }
        return null;
    }

    @Override
    public void increasePopularity(Long movieID, Integer numTickets) {
        movieRepository.findById(movieID).ifPresent(i -> {
            i.setNumTickets(i.getNumTickets() + numTickets);
            movieRepository.save(i);
        });
    }

    @Override
    public void updateStatus(Long movieID) {
        movieRepository.findById(movieID).ifPresent(i -> {
            i.setBought(true);
            movieRepository.save(i);
            ;
        });
    }

    @Override
    public List<Movie> listBoughtMovies() {
        return movieRepository.findMoviesByBoughtIsTrue();
    }

    @Override
    public void updateRating(Long id, Double rating) {
        movieRepository.findById(id).ifPresent(i -> {
            i.setNumOfRatingsGiven(i.getNumOfRatingsGiven() + 1);
            i.setRating((i.getRating() + rating) / i.getNumOfRatingsGiven());
            movieRepository.save(i);
        });
    }

    @Override
    public void UpateStatusForAll(List<TicketOrder> ticketOrders) {
        ticketOrders.forEach(i -> {
            increasePopularity(i.getMovie().getId(), Math.toIntExact(i.getNumber0fTickets()));
            updateStatus(i.getMovie().getId());
        });
    }


    }



