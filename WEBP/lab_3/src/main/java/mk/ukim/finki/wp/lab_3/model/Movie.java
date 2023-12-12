package mk.ukim.finki.wp.lab_3.model;

import jakarta.persistence.*;
import lombok.Data;

@Data
@Entity
public class Movie {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "title", nullable = false, length = 100)
    private String title;

    @Column(name = "summary", nullable = false, length = 500)
    private String summary;

    @Column(name = "rating")
    private double rating;

    @ManyToOne
    private Production production;

    @Column(name = "bought")
    private boolean bought;

    private int numOfRatingsGiven;
    private int numTickets;

    public Movie(String title, String summary, double rating, Production production) {
        this.title = title;
        this.summary = summary;
        this.rating = rating;
        this.production = production;
        bought=false;
        numOfRatingsGiven=1;
        numTickets=0;
    }
    public Movie(){}
}
