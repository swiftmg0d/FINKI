package mk.ukim.finki.wp.lab_1.model;

import lombok.AllArgsConstructor;
import lombok.Data;

@Data
@AllArgsConstructor
public class Movie {
    private String title;
    private String summary;
    private double rating;
}
