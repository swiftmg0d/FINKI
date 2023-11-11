package mk.ukim.finki.wp.lab_1.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_1.model.TicketOrder;
import mk.ukim.finki.wp.lab_1.model.exception.TicketSelectionException;
import mk.ukim.finki.wp.lab_1.repository.InMemoryTicketOrderRepository;
import mk.ukim.finki.wp.lab_1.service.TicketOrderService;
import org.springframework.stereotype.Service;

import java.util.List;

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

    @Override
    public List<TicketOrder> getAll() {
        return ticketOrderRepository.getAll();
    }
}
