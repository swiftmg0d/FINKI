package mk.ukim.finki.wp.lab_3.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.Movie;
import mk.ukim.finki.wp.lab_3.model.ShoppingCart;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import mk.ukim.finki.wp.lab_3.model.User;
import mk.ukim.finki.wp.lab_3.model.énum.StatusCode;
import mk.ukim.finki.wp.lab_3.repository.MovieRepository;
import mk.ukim.finki.wp.lab_3.repository.ShoppingCartRepository;
import mk.ukim.finki.wp.lab_3.repository.TicketRepository;
import mk.ukim.finki.wp.lab_3.repository.UserRepository;
import mk.ukim.finki.wp.lab_3.service.ShoppingCartService;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Service
@AllArgsConstructor
public class ShoppingCartServiceImpl implements ShoppingCartService {
    private final ShoppingCartRepository shoppingCartRepository;
    private final MovieRepository movieRepository;
    private final UserRepository userRepository;
    private final TicketRepository ticketRepository;

    @Override
    public void addMovieToCart(Long moveID, Long id,Long tickets) {
        Optional<Movie> curretMovie = movieRepository.findById(moveID);
        Optional<User> curretnUser = userRepository.findById(id);
        curretnUser.ifPresent(i->{
            ShoppingCart cart=makeShoppingCart(i);
            curretMovie.ifPresent(k -> {
                cart.getTicketOrderList().add(ticketRepository.save(new TicketOrder(k, i, tickets, LocalDateTime.now())));
            });
            shoppingCartRepository.save(cart);
            i.getList0fShoppingCarts().add(cart);
            userRepository.save(i);
        });
    }

    @Override
    public ShoppingCart makeShoppingCart(User user) {
        return shoppingCartRepository.findByUserEqualsAndSTATUSEquals(user,StatusCode.CREATED)
                .orElseGet(()-> shoppingCartRepository.save(new ShoppingCart(userRepository.findById(user.getId()).get(),LocalDateTime.now())));
    }

    @Override
    public ShoppingCart getCurrentShoppingCart(Long idUser) {
        return shoppingCartRepository.findByUserEqualsAndSTATUSEquals(userRepository.findById(idUser).get(),StatusCode.CREATED).orElseThrow(RuntimeException::new);
    }

    @Override
    public void confirmShoppingCart(User currentUser) {
        shoppingCartRepository.findByUserEqualsAndSTATUSEquals(currentUser,StatusCode.CREATED).ifPresent(i->{
            i.setSTATUS(StatusCode.FINISHED);
            shoppingCartRepository.save(i);
        });
    }

    @Override
    public void cancelShoppingCart(User currentUser) {
        shoppingCartRepository.findByUserEqualsAndSTATUSEquals(currentUser,StatusCode.CREATED).ifPresent(i->{
            i.setSTATUS(StatusCode.CANCLED);
            shoppingCartRepository.save(i);
        });
    }

    @Override
    public List<TicketOrder> filter(List<TicketOrder> ticketOrders, LocalDateTime from, LocalDateTime to) {
        List<TicketOrder>ticketOrderList=ticketRepository.findByLocalDateTimeBetween(from,to);
        List<TicketOrder>ticketOrders1=new ArrayList<>();
        ticketOrders.forEach(i->{
            ticketOrderList.forEach(k->{
                if(k.equals(i)){
                    ticketOrders1.add(k);
                }
            });
        });
        return ticketOrders1;
    }
}
