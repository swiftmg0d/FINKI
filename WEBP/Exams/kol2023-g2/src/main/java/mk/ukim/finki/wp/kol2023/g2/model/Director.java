package mk.ukim.finki.wp.kol2023.g2.model;

import jakarta.persistence.*;

@Entity
public class Director {

    public Director() {
    }

    public Director(String name) {
        this.name = name;
    }
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String name;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
