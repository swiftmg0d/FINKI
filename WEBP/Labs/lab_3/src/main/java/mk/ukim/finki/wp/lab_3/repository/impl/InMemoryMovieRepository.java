package mk.ukim.finki.wp.lab_3.repository.impl;

import mk.ukim.finki.wp.lab_3.bootstrap.DataHolder;
import mk.ukim.finki.wp.lab_3.model.Movie;
import mk.ukim.finki.wp.lab_3.model.Production;
import org.springframework.stereotype.Repository;

import java.util.IntSummaryStatistics;
import java.util.List;
import java.util.Objects;
import java.util.Optional;
import java.util.stream.Collectors;

@Repository
public class InMemoryMovieRepository {
    public List<Movie> findAll() {
        return DataHolder.list0fMovies;
    }

    public List<Movie> searchMovies(String text, String rating) {

        if (Objects.equals(text, "") && Objects.equals(rating, "")) {
            return DataHolder.list0fMovies;
        } else if (Objects.equals(text, "")) {
            return DataHolder.list0fMovies.stream().filter(i -> i.getRating() >= Double.parseDouble(rating)).collect(Collectors.toList());
        } else if (Objects.equals(rating, "")) {
            return DataHolder.list0fMovies.stream().filter(i -> i.getTitle().toLowerCase().contains(text.toLowerCase())).collect(Collectors.toList());
        }
        return null;
    }

    public String mostPopularMovie() {
        IntSummaryStatistics intSummaryStatistics = DataHolder.movieTicketCount.values().stream().mapToInt(i -> i).summaryStatistics();
        return DataHolder.movieTicketCount.keySet().stream().filter(i -> DataHolder.movieTicketCount.get(i).
                equals(intSummaryStatistics.
                        getMax())).findFirst().orElseThrow(RuntimeException::new);
    }

    public void IncreasePopularity(String movie, String tickets) {
        int ticket = Integer.parseInt(tickets);
        DataHolder.movieTicketCount.computeIfPresent(movie, (k, v) -> v + ticket);
    }

    public int mostTickets() {
        return DataHolder.movieTicketCount.get(mostPopularMovie());
    }

    public void deleteMovieById(Long id, String selectedMovie) {
        Optional<Movie> deleteMovie = DataHolder.list0fMovies.stream().filter(i -> i.getId().equals(id)).findFirst();
        deleteMovie.ifPresent(movie -> {
            DataHolder.movieTicketCount.put(selectedMovie, 0);
            DataHolder.list0fMovies.remove(movie);
        });
    }

    public void saveMovie(String title, String summary, String rating, String id, Production production) {
       try{
           Optional<Movie> foundMovie = DataHolder.list0fMovies.stream().filter(i -> Objects.equals(i.getId(), Long.valueOf(id))).findFirst();
           if (foundMovie.isPresent()) {
               DataHolder.list0fMovies.forEach(i -> {
                   if (i.getId() == Long.parseLong(id)) {
                       Object removed=DataHolder.movieTicketCount.remove(i.getTitle());
                       i.setTitle(title);
                       i.setSummary(summary);
                       i.setRating(Double.parseDouble(rating));
                       i.setProduction(production);
                       DataHolder.movieTicketCount.put(title, (Integer) removed);
                   }
               });
       }}catch (Exception e){
           DataHolder.list0fMovies.add(new Movie(title,summary,Double.parseDouble(rating),production));
           DataHolder.movieTicketCount.put(title,0);
       }
    }

    public Optional<Movie> findMovieById(Long id) {
        return DataHolder.list0fMovies.stream().filter(i -> i.getId().equals(id)).findFirst();
    }

    public boolean Check(String text, String summary, String rating) {
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

    public void deleteMovieByProduction(Production production) {
        DataHolder.list0fMovies = DataHolder.list0fMovies.stream().filter(i -> !i.getProduction().equals(production)).collect(Collectors.toList());
    }

    public void updateStatus(String selectedMovie,int numTickets) {
        DataHolder.list0fMovies.stream().forEach(i->{
            if(i.getTitle().equals(selectedMovie)){
                i.setBought(true);
                i.setNumTickets(i.getNumTickets()+numTickets);

            }
        });
    }

    public List<Movie> listAllBoughtMovies() {
        return DataHolder.list0fMovies.stream().filter(i->i.isBought()).collect(Collectors.toList());
    }

    public void updateRating(String movie,String rating) {
        try {
            DataHolder.list0fMovies.forEach(i->{
                if(i.getTitle().equals(movie)){
                    i.setRating(i.getRating()+Double.parseDouble(rating));
                    i.setNumOfRatingsGiven(i.getNumOfRatingsGiven()+1);
                    i.setRating(i.getRating()/i.getNumOfRatingsGiven());
                }
            });
        }catch (Exception e){}
    }
}
