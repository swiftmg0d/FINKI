package mk.ukim.finki.wp.lab_1.web.filter;

import jakarta.servlet.*;
import jakarta.servlet.annotation.WebFilter;
import jakarta.servlet.annotation.WebInitParam;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import mk.ukim.finki.wp.lab_1.model.TicketOrder;

import java.io.IOException;

@WebFilter(filterName = "OrderConfirmationFilter", urlPatterns = {"/ticketOrder"},
        initParams = @WebInitParam(name = "ignore-path",value = "/ticketOrder"))
public class OrderConfirmationFilter implements Filter {

    private String ignorePath;

    @Override
    public void init(FilterConfig filterConfig) throws ServletException {
        ignorePath =filterConfig.getInitParameter("ignore-path");
    }

    @Override
    public void doFilter(ServletRequest servletRequest, ServletResponse servletResponse, FilterChain filterChain) throws IOException, ServletException {

        HttpServletResponse httpServletResponse = (HttpServletResponse) servletResponse;
        HttpServletRequest httpServletRequest = (HttpServletRequest) servletRequest;

        TicketOrder ticketOrder = (TicketOrder) httpServletRequest.getSession().getAttribute("TicketOrder");
        String path = httpServletRequest.getServletPath();

        if(ignorePath.startsWith(path)  && ticketOrder!=null){
            filterChain.doFilter(servletRequest,servletResponse);
        }else{
            httpServletResponse.sendRedirect("");
        }

    }
}
