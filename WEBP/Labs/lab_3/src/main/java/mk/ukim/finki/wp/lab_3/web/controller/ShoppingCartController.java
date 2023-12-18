package mk.ukim.finki.wp.lab_3.web.controller;

import jakarta.servlet.http.HttpSession;
import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import mk.ukim.finki.wp.lab_3.model.User;
import mk.ukim.finki.wp.lab_3.service.MovieService;
import mk.ukim.finki.wp.lab_3.service.ShoppingCartService;
import mk.ukim.finki.wp.lab_3.service.TicketOrderService;
import mk.ukim.finki.wp.lab_3.service.UserService;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.time.LocalDateTime;
import java.util.List;

@Controller
@AllArgsConstructor
@RequestMapping("/movies/shopping-cart")
public class ShoppingCartController {
    private final ShoppingCartService shoppingCartService;
    private final UserService userService;
    private final MovieService movieService;
    private final TicketOrderService ticketOrderService;

    @GetMapping()
    public String getShoppingCart(Model model, HttpSession session) {
        User currentUser = (User) session.getAttribute("User");
        int id = Math.toIntExact(currentUser.getId());
        model.addAttribute("user", currentUser);
        try {
            List<TicketOrder> ticketOrders = shoppingCartService.getCurrentShoppingCart(currentUser.getId()).getTicketOrderList();
            model.addAttribute("tickets", ticketOrders);
        } catch (Exception e) {
            return "redirect:/movies";
        }
        return "shopping-cart";
    }

    @PostMapping("/filter")
    public String filterShoppingCart(HttpSession session, Model model, @RequestParam(required = false) @DateTimeFormat(pattern = "yyyy-MM-dd'T'HH:mm") LocalDateTime from,
                                     @RequestParam(required = false) @DateTimeFormat(pattern = "yyyy-MM-dd'T'HH:mm") LocalDateTime to) {
        User currentUser = (User) session.getAttribute("User");
        int id = Math.toIntExact(currentUser.getId());
        model.addAttribute("user", currentUser);

        try {
            // for exception
            String type = from.toString();
            String type1 = to.toString();

            List<TicketOrder> ticketOrders = shoppingCartService.getCurrentShoppingCart(currentUser.getId()).getTicketOrderList();
            model.addAttribute("tickets", shoppingCartService.filter(ticketOrders, from, to));
        } catch (Exception e) {
            return "redirect:/movies/shopping-cart";
        }

        return "shopping-cart";
    }

    @PostMapping("/add")
    public String addToShoppingCart(@RequestParam String tickets, @RequestParam Long movieID, HttpSession session, Model model) {

        User currentUser = (User) session.getAttribute("User");
        int id = Math.toIntExact(currentUser.getId());
        model.addAttribute("user", currentUser);
        shoppingCartService.addMovieToCart(movieID, currentUser.getId(), Long.valueOf(tickets));
        List<TicketOrder> ticketOrders = shoppingCartService.getCurrentShoppingCart(currentUser.getId()).getTicketOrderList();
        model.addAttribute("tickets", ticketOrders);

        return "shopping-cart";
    }

    @PostMapping("/confirm")
    public String confirmShoppingCart(HttpSession session) {
        User currentUser = (User) session.getAttribute("User");
        List<TicketOrder> ticketOrders = shoppingCartService.getCurrentShoppingCart(currentUser.getId()).getTicketOrderList();
        movieService.UpateStatusForAll(ticketOrders);
        shoppingCartService.confirmShoppingCart(currentUser);

        return "redirect:/movies";
    }

    @PostMapping("/cancel")
    public String cancelShoppingCart(HttpSession session) {
        User currentUser = (User) session.getAttribute("User");
        shoppingCartService.cancelShoppingCart(currentUser);
        return "redirect:/movies";
    }

    @PostMapping("/updateprice")
    public String updatePrice(Model model, @RequestParam(required = false) @DateTimeFormat(pattern = "yyyy-MM-dd'T'HH:mm") LocalDateTime from,
                              @RequestParam(required = false) @DateTimeFormat(pattern = "yyyy-MM-dd'T'HH:mm") LocalDateTime to,
                              @RequestParam String price, @RequestParam Long movie) {
        try{
            String type=from.toString();
            String type1=to.toString();
            ticketOrderService.addPrice(movie,price,from,to);
        }catch (Exception e){
            return  "redirect:/movies/shopping-cart?error";
        }



        return "redirect:/movies/shopping-cart";
    }
}
