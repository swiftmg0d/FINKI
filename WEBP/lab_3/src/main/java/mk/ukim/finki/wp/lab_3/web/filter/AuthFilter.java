package mk.ukim.finki.wp.lab_3.web.filter;

import jakarta.servlet.*;
import jakarta.servlet.annotation.WebFilter;
import jakarta.servlet.annotation.WebInitParam;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import mk.ukim.finki.wp.lab_3.model.User;

import java.io.IOException;

@WebFilter(filterName = "AuthFilter",urlPatterns = {"/*"},
initParams = {@WebInitParam(name = "ignore-path1",value = "/login"),@WebInitParam(name = "ignore-path2",value = "/register")})
public class AuthFilter implements Filter {
    private String[] ignorePaths;

    @Override
    public void init(FilterConfig filterConfig) throws ServletException {
        ignorePaths=new String[2];
        ignorePaths[0]=filterConfig.getInitParameter("ignore-path1");
        ignorePaths[1]=filterConfig.getInitParameter("ignore-path2");
    }

    @Override
    public void doFilter(ServletRequest servletRequest, ServletResponse servletResponse, FilterChain filterChain) throws IOException, ServletException {

        HttpServletResponse resp = (HttpServletResponse) servletResponse;
        HttpServletRequest req = (HttpServletRequest) servletRequest;
        User user= (User) req.getSession().getAttribute("User");
        String uri=req.getRequestURI();

        if(user!=null || uri.contains(ignorePaths[0]) || uri.contains(ignorePaths[1])){
            filterChain.doFilter(req,resp);
        }else{
            resp.sendRedirect("/login");
        }



    }
}
