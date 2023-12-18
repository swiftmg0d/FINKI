package mk.ukim.finki.wp.lab_2.service;

import mk.ukim.finki.wp.lab_2.model.TicketOrder;


public interface TicketOrderService {
    TicketOrder placeOrder(String movieTitle, String clientName, String address, String numberOfTickets);
    void addTicket(String movieTitle, String clientName, String address, String numberOfTickets);


}
