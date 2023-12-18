package mk.ukim.finki.wp.lab_2.model;

import lombok.AllArgsConstructor;
import lombok.Data;

@Data
@AllArgsConstructor
public class Production {
    private long id;
    private String name;
    private String country;
    private String address;

    @Override
    public String toString() {
        return id + ", "+name+", "+country+", "+address;
    }
}
