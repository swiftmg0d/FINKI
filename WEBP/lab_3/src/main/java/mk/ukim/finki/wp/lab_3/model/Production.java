package mk.ukim.finki.wp.lab_3.model;

import jakarta.persistence.*;
import lombok.Data;

@Data
@Entity
@Table(name = "productions")
public class Production {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    @Column(name = "name", nullable = false, length = 100)
    private String name;

    @Column(name = "country", nullable = false, length = 100)
    private String country;

    @Column(name = "address", nullable = false, length = 200)
    private String address;

    @Override public String toString() {
        return id + ", "+name+", "+country+", "+address;
    }
    public Production(){}

    public Production(String name, String country, String address) {
        this.name = name;
        this.country = country;
        this.address = address;
    }
}
