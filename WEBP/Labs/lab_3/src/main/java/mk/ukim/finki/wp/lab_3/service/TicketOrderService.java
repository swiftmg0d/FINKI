package mk.ukim.finki.wp.lab_3.service;

import mk.ukim.finki.wp.lab_3.model.Movie;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;


public interface TicketOrderService {
    void addTicket(String movieTitle, String clientName, String address, String numberOfTickets);
    TicketOrder placeOrder(Movie movie, Long id, String numTickets);

    Optional<TicketOrder> findById(Long id);

    List<TicketOrder> filterBy(LocalDateTime from, LocalDateTime to);

    void addPrice(Long id, String price, LocalDateTime from, LocalDateTime to);

    void removeByMovies(Long id);
}
