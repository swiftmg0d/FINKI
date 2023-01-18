package II_Kolokvium.MovieList;

import java.util.*;

public class MoviesTest {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        MoviesList moviesList = new MoviesList();
        int n = scanner.nextInt();
        scanner.nextLine();
        for (int i = 0; i < n; ++i) {
            String title = scanner.nextLine();
            int x = scanner.nextInt();
            int[] ratings = new int[x];
            for (int j = 0; j < x; ++j) {
                ratings[j] = scanner.nextInt();
            }
            scanner.nextLine();
            moviesList.addMovie(title, ratings);
        }
        scanner.close();
        List<Movie> movies = moviesList.top10ByAvgRating();
        System.out.println("=== TOP 10 BY AVERAGE RATING ===");
        for (Movie movie : movies) {
            System.out.println(movie);
        }
        movies = moviesList.top10ByRatingCoef();
        System.out.println("=== TOP 10 BY RATING COEFFICIENT ===");
        for (Movie movie : movies) {
            System.out.println(movie);
        }
    }
}
class MoviesList{
    List<Movie>sList=new ArrayList<>();
    public List<Movie> top10ByRatingCoef() {
        Collections.sort(sList,Comparator.comparing(Movie::bestRated).reversed().thenComparing(Movie::getTitleMovie));
        if(sList.size()>=10){
            return sList.subList(0,10);
        }else{
            return sList;
        }

    }

    public List<Movie> top10ByAvgRating() {
        Collections.sort(sList,Comparator.comparing(Movie::getAvg).reversed().thenComparing(Movie::getTitleMovie));
        if(sList.size()>=10){
            return sList.subList(0,10);
        }else{
            return sList;
        }
    }

    public void addMovie(String title, int[] ratings) {
        sList.add(new Movie(title,ratings));
    }
}
class Movie{
    private String titleMovie;
    private int []ratings;

    public Movie(String titleMovie, int[] ratings) {
        this.titleMovie = titleMovie;
        this.ratings = ratings;
    }
    public  double getAvg(){
        IntSummaryStatistics intSummaryStatistics=Arrays.stream(ratings).summaryStatistics();
        return intSummaryStatistics.getAverage();
    }
    public double bestRated(){
        IntSummaryStatistics intSummaryStatistics= Arrays.stream(ratings).summaryStatistics();
        return  getAvg()*intSummaryStatistics.getCount()/intSummaryStatistics.getMax();
    }
    @Override
    public String toString() {
        return String.format("%s (%.2f) of %d ratings",titleMovie,getAvg(),ratings.length);
    }

    public String getTitleMovie() {
        return titleMovie;
    }

    public void setTitleMovie(String titleMovie) {
        this.titleMovie = titleMovie;
    }
}