package mk.ukim.finki.wp.lab_3.model;

import jakarta.persistence.*;
import lombok.Data;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

@Data
@Entity
@Table(name = "ticket_orders")
public class TicketOrder {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne
    @JoinColumn(name = "movie_id")
    private Movie movie;

    @ManyToOne(cascade = CascadeType.ALL, fetch = FetchType.LAZY)
    @JoinColumn(name = "user_id")
    private User user;

    private Long number0fTickets;
    private LocalDateTime localDateTime;
    @OneToMany
    @JoinColumn(name = "ticketroder_id")
    private List<Price> list0fPrices=new ArrayList<>();

    public TicketOrder(Movie movie, User user, Long number0fTickets,LocalDateTime localDateTime) {
        this.movie = movie;
        this.number0fTickets = number0fTickets;
        this.user=user;
        this.localDateTime=localDateTime;

    }

    public TicketOrder() {
    }

}
