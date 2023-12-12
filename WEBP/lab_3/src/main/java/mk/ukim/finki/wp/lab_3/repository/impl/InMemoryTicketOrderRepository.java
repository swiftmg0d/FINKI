package mk.ukim.finki.wp.lab_3.repository.impl;

import mk.ukim.finki.wp.lab_3.bootstrap.DataHolder;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class InMemoryTicketOrderRepository {

    public TicketOrder placeOrder(String movieTitle, String clientName, String address, Long numberOfTickets) {
        return null;
    }

    public void AddTicket(TicketOrder ticketOrder) {
        DataHolder.list0fTickets.add(ticketOrder);
    }

    public List<TicketOrder> getAll() {
        return DataHolder.list0fTickets;
    }

}
