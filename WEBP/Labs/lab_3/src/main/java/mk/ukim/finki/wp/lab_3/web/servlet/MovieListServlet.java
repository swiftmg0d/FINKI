package mk.ukim.finki.wp.lab_3.web.servlet;

import jakarta.servlet.*;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.service.MovieService;
import mk.ukim.finki.wp.lab_3.service.TicketOrderService;
import org.thymeleaf.context.WebContext;
import org.thymeleaf.spring6.SpringTemplateEngine;
import org.thymeleaf.web.servlet.JakartaServletWebApplication;

import java.io.IOException;

@AllArgsConstructor
@WebServlet(name = "MovieList", urlPatterns = {""})
public class MovieListServlet extends HttpServlet {

    private final MovieService movieService;
    private final TicketOrderService ticketOrderService;
    private final SpringTemplateEngine springTemplateEngine;


    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

        WebContext webContext = new WebContext(JakartaServletWebApplication.buildApplication(getServletContext()).buildExchange(req, resp));
     //   webContext.setVariable("popularMovie", movieService.mostPopularMovie());
       // webContext.setVariable("ticketsNumber", movieService.mostTickets());

        String type = "";
        String searchedMovie = req.getParameter("SearchedMovie");
        String searchedRating = req.getParameter("SearchedRating");

        if (searchedMovie == "" && searchedRating == "") {
            type = "SHOW";
        } else if (searchedMovie == "") {
            type = "RATING";
        } else if (searchedRating == "") {
            type = "MOVIE";
        }


       // webContext.setVariable("movieList", movieService.searchMovies(req.getParameter("SearchedMovie"), req.getParameter("SearchedRating")));


        springTemplateEngine.process("listMovies.html", webContext, resp.getWriter());
    }

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

        String numTickets = req.getParameter("numTickets");
        String movieName = req.getParameter("selectedMovie");
        HttpSession session = req.getSession();
        try {
            //session.setAttribute("TicketOrder", ticketOrderService.placeOrder(movieName, req.getLocalName(), req.getRemoteAddr(), numTickets));
            ticketOrderService.addTicket(movieName, req.getLocalName(), req.getRemoteAddr(), numTickets);
           // movieService.IncreasePopularity(movieName, numTickets);

        } catch (RuntimeException e) {
        }
        resp.sendRedirect("/ticketOrder");


    }
}
