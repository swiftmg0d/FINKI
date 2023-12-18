package mk.ukim.finki.wp.lab_2.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_2.model.TicketOrder;
import mk.ukim.finki.wp.lab_2.model.exception.TicketSelectionException;
import mk.ukim.finki.wp.lab_2.repository.InMemoryTicketOrderRepository;
import mk.ukim.finki.wp.lab_2.service.TicketOrderService;
import org.springframework.stereotype.Service;

@Service
@AllArgsConstructor
public class TicketOrderServiceImpl implements TicketOrderService {
    private final InMemoryTicketOrderRepository ticketOrderRepository;
    @Override
    public TicketOrder placeOrder(String movieTitle, String clientName, String address, String numberOfTickets) {
        if(numberOfTickets.isEmpty()) throw new TicketSelectionException();
        return ticketOrderRepository.placeOrder(movieTitle,clientName,address,Long.valueOf(numberOfTickets));
    }

    @Override
    public void addTicket(String movieTitle, String clientName, String address, String numberOfTickets) {
        if(numberOfTickets.isEmpty()) throw new TicketSelectionException();
        ticketOrderRepository.AddTicket(new TicketOrder(movieTitle,clientName,address,Long.valueOf(numberOfTickets)));
    }

}
