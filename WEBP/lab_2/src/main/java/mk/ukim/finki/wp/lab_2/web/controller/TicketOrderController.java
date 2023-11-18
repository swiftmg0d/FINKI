package mk.ukim.finki.wp.lab_2.web.controller;

import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_2.service.MovieService;
import mk.ukim.finki.wp.lab_2.service.TicketOrderService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

@Controller
@AllArgsConstructor
@RequestMapping("/ticketConfirmation")
public class TicketOrderController {
    private final TicketOrderService ticketOrderService;
    private final MovieService movieService;

    @GetMapping()
    public String showTicket(Model model, HttpSession httpSession) {
        if (httpSession.isNew()) return "redirect:/movies";

        model.addAttribute("TicketOrder", httpSession.getAttribute("TicketOrder"));
        model.addAttribute("list0fBoughtMovies",movieService.listAllBoughtMovies());

        return "orderConfirmation";


    }

    @PostMapping("/updateRating")
    public String updateRating(@RequestParam String rating,@RequestParam String movieTitle){
        movieService.updateRating(movieTitle,rating);
        return "redirect:/ticketConfirmation";
    }

    @PostMapping("/ticketCreated")
    public String ShowTicketConfirmation(Model model, @RequestParam(required = false) String selectedMovie, @RequestParam(required = false) String numTickets, HttpSession httpSession, HttpServletRequest request, HttpServletResponse response) {
        if (selectedMovie == null || numTickets.isEmpty())
            return "redirect:/movies?error=Please..select..movie..and..number..of..tickets!";
        httpSession.setAttribute("TicketOrder", ticketOrderService.placeOrder(selectedMovie, request.getLocalName(), request.getLocalAddr(), numTickets));
        movieService.updateStatus(selectedMovie,Integer.parseInt(numTickets));
        movieService.IncreasePopularity(selectedMovie, numTickets);
        movieService.mostPopularMovie();
        return "redirect:/ticketConfirmation";
    }
}
