package mk.ukim.finki.wp.lab_3.web.controller;

import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import mk.ukim.finki.wp.lab_3.model.User;
import mk.ukim.finki.wp.lab_3.service.MovieService;
import mk.ukim.finki.wp.lab_3.service.TicketOrderService;
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
    public String showTicket(@RequestParam(required = false) String error, Model model, HttpSession httpSession) {
        if (httpSession.isNew()) return "redirect:/movies";
        Long id= (Long) httpSession.getAttribute("TicketOrder");
        ticketOrderService.findById(id).ifPresent(i->{
            model.addAttribute("ticketOrder", i);

        });
        if(error!=null){
            model.addAttribute("error","Please insear valid rating!");
        }
        model.addAttribute("list0fBoughtMovies",movieService.listBoughtMovies());
        int size=movieService.listBoughtMovies().size();

        return "orderConfirmation";


    }

    @PostMapping("/updateRating")
    public String updateRating(@RequestParam String rating,@RequestParam Long movieID){
        try{
            movieService.updateRating(movieID,Double.parseDouble(rating));
        }catch (RuntimeException e){
            return "redirect:/ticketConfirmation?error=true";
        }

        return "redirect:/ticketConfirmation";
    }

    @PostMapping("/ticketCreated")
    public String ShowTicketConfirmation(Model model,@RequestParam(required = false) Long movieID, @RequestParam(required = false) Long selectedMovie, @RequestParam(required = false) String numTickets, HttpSession httpSession, HttpServletRequest request, HttpServletResponse response) {
        if (selectedMovie == null || numTickets.isEmpty())
            return "redirect:/movies?error=true";
        User user= (User) httpSession.getAttribute("User");
        TicketOrder ticketOrder=ticketOrderService.placeOrder(movieService.findMovieById(movieID).get(),user.getId(),numTickets);
        httpSession.setAttribute("TicketOrder", ticketOrder.getId());
        movieService.increasePopularity(movieID,Integer.parseInt(numTickets));
        movieService.updateStatus(movieID);
        return "redirect:/ticketConfirmation";
    }
}
