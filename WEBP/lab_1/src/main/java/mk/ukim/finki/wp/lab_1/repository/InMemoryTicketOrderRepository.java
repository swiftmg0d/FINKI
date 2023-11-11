package mk.ukim.finki.wp.lab_1.repository;

import mk.ukim.finki.wp.lab_1.bootstrap.DataHolder;
import mk.ukim.finki.wp.lab_1.model.TicketOrder;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class InMemoryTicketOrderRepository {

    public TicketOrder placeOrder(String movieTitle, String clientName, String address, Long numberOfTickets) {
        return DataHolder.ticketOrder = new TicketOrder(movieTitle, clientName, address, numberOfTickets);
    }

    public void AddTicket(TicketOrder ticketOrder) {
        DataHolder.list0fTickets.add(ticketOrder);
    }

    public List<TicketOrder> getAll() {
        return DataHolder.list0fTickets;
    }

}
