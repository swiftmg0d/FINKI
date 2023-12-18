package mk.ukim.finki.wp.lab_3.model;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;

import java.time.LocalDateTime;

@Entity
public class Price {
    private int value;
    private LocalDateTime from;
    private LocalDateTime to;
    private boolean discount;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    public Price() {
    }

    public Price(int value, LocalDateTime from, LocalDateTime to, boolean discount) {
        this.value = value;
        this.from = from;
        this.to = to;
        this.discount = discount;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Long getId() {
        return id;
    }
}
