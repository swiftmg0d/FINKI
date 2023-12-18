package mk.ukim.finki.wp.lab_3.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.Movie;
import mk.ukim.finki.wp.lab_3.model.Price;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import mk.ukim.finki.wp.lab_3.model.User;
import mk.ukim.finki.wp.lab_3.model.exception.TicketSelectionException;
import mk.ukim.finki.wp.lab_3.repository.PriceRepository;
import mk.ukim.finki.wp.lab_3.repository.TicketRepository;
import mk.ukim.finki.wp.lab_3.repository.UserRepository;
import mk.ukim.finki.wp.lab_3.service.TicketOrderService;
import org.apache.commons.collections4.ListUtils;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Objects;
import java.util.Optional;

@Service
@AllArgsConstructor
public class TicketOrderServiceImpl implements TicketOrderService {
    private final TicketRepository ticketOrderRepository;
    private final UserRepository userRepository;
    private final PriceRepository priceRepository;

    @Override
    public void addTicket(String movieTitle, String clientName, String address, String numberOfTickets) {
        // if(numberOfTickets.isEmpty()) throw new TicketSelectionException();
        //ticketOrderRepository.AddTicket(new TicketOrder(movieTitle,clientName,address,Long.valueOf(numberOfTickets)));
    }

    @Override
    public TicketOrder placeOrder(Movie movie, Long id, String numTickets) {
        final TicketOrder[] ticketOrder = {null};
        if (Objects.equals(numTickets, "")) throw new TicketSelectionException();
        if (userRepository.findById(id).isPresent()) {
            User user = userRepository.findById(id).get();
            return ticketOrderRepository.save(new TicketOrder(movie, user, Long.valueOf(numTickets), LocalDateTime.now()));
        }

        return null;
    }

    @Override
    public Optional<TicketOrder> findById(Long id) {
        return ticketOrderRepository.findById(id);
    }

    @Override
    public List<TicketOrder> filterBy(LocalDateTime from, LocalDateTime to) {
        return ticketOrderRepository.findByLocalDateTimeBetween(from, to);
    }

    @Override
    public void addPrice(Long id, String price, LocalDateTime from, LocalDateTime to) {
        ticketOrderRepository.findById(id).ifPresent(i -> {
            i.getList0fPrices().add(priceRepository.save(new Price(Integer.parseInt(price), from, to, true)));
            ticketOrderRepository.save(i);
        });
    }

    @Override
    public void removeByMovies(Long id) {
        List<TicketOrder>ticketOrders=ListUtils.subtract(ticketOrderRepository.findAll(),ticketOrderRepository.findAllByMovie_Id(id));
    }

}
