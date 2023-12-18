package mk.ukim.finki.wp.lab_1.web.servlet;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_1.model.TicketOrder;
import org.thymeleaf.context.WebContext;
import org.thymeleaf.spring6.SpringTemplateEngine;
import org.thymeleaf.web.servlet.JakartaServletWebApplication;

import java.io.IOException;

@AllArgsConstructor
@WebServlet(name = "TicketOrder", urlPatterns = "/ticketOrder")
public class TicketOrderServlet extends HttpServlet {

    private final SpringTemplateEngine springTemplateEngine;

    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {

        WebContext webContext = new WebContext(JakartaServletWebApplication.buildApplication(getServletContext()).buildExchange(req, resp));

        HttpSession httpSession = req.getSession();

        webContext.setVariable("TicketOrder", (TicketOrder) httpSession.getAttribute("TicketOrder"));

        springTemplateEngine.process("orderConfirmation.html", webContext, resp.getWriter());

    }
}
