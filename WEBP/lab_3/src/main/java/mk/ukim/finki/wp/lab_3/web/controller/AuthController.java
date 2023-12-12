package mk.ukim.finki.wp.lab_3.web.controller;

import jakarta.servlet.http.HttpSession;
import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.User;
import mk.ukim.finki.wp.lab_3.service.AuthService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.time.LocalDate;

@Controller
@AllArgsConstructor
@RequestMapping
public class AuthController {
    private final AuthService authService;

    @GetMapping("/login")
    private String getLoginPage() {
        return "login";
    }

    @GetMapping("/register")
    private String getRegisterPage(@RequestParam(required = false) String error, Model model) {
        if (error != null) {
            String msgType = error.equals("1") ? "Username taken, please choise diffrent username" : "Please insert valid data!";
            model.addAttribute("error", msgType);
        }
        return "register";
    }

    @PostMapping("/register/create-account")
    private String createAccount(@RequestParam String username, @RequestParam String name, @RequestParam String surname, @RequestParam String password, @RequestParam String date) {
        try {
            LocalDate date0f = LocalDate.of(Integer.parseInt(date.split("-")[0]), Integer.parseInt(date.split("-")[1]), Integer.parseInt(date.split("-")[2]));
            User createdUser = new User(username, name, surname, password, date0f);
            if(authService.checkAvailability(username).isPresent()){
                return "redirect:/register?error=1";
            }
            authService.saveUser(createdUser);
        } catch (RuntimeException e) {
            return "redirect:/register?error=2";
        }

        return "redirect:/login";
    }

    @PostMapping("/login/check-status")
    private String checkLogin(HttpSession httpSession, @RequestParam String username, @RequestParam String password) {
        boolean isTrue = authService.loginUser(username, password).isPresent();
        if (authService.loginUser(username, password).isPresent()) {
            httpSession.setAttribute("User", authService.loginUser(username, password).get());
            return "redirect:/movies";
        } else {
            return "redirect:/login";
        }
    }

    @PostMapping("/logout")
    private String logout(HttpSession session) {
        session.invalidate();
        return "redirect:/login";
    }

}
