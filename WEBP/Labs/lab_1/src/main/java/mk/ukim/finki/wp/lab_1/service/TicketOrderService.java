package mk.ukim.finki.wp.lab_1.service;

import mk.ukim.finki.wp.lab_1.model.TicketOrder;

import java.util.List;

public interface TicketOrderService {
    TicketOrder placeOrder(String movieTitle, String clientName, String address, String numberOfTickets);
    void addTicket(String movieTitle, String clientName, String address, String numberOfTickets);
    List<TicketOrder>getAll();


}
