package mk.ukim.finki.wp.lab_2.model;

import lombok.AllArgsConstructor;
import lombok.Data;

import java.util.Random;

@Data
@AllArgsConstructor
public class Movie {
    private String title;
    private String summary;
    private double rating;
    private Long id;
    private Production production;
    private boolean isBought;
    private int numOfRatingsGiven;
    private int numTickets;

    public Movie(String title, String summary, double rating, Production production) {
        this.title = title;
        this.summary = summary;
        this.rating = rating;
        this.production = production;
        Random random=new Random();
        id= random.nextLong(100,999);
        isBought=false;
        numOfRatingsGiven=1;
        numTickets=0;
    }
}
