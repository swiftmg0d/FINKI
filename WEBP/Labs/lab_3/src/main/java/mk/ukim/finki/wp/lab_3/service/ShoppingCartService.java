package mk.ukim.finki.wp.lab_3.service;

import mk.ukim.finki.wp.lab_3.model.ShoppingCart;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import mk.ukim.finki.wp.lab_3.model.User;

import java.time.LocalDateTime;
import java.util.List;

public interface ShoppingCartService {
    void addMovieToCart(Long moveID, Long id,Long tickets);
    ShoppingCart makeShoppingCart(User user);
    ShoppingCart getCurrentShoppingCart(Long idUser);

    void confirmShoppingCart(User currentUser);

    void cancelShoppingCart(User currentUser);

    List<TicketOrder> filter(List<TicketOrder> ticketOrders, LocalDateTime from, LocalDateTime to);
}
