package mk.ukim.finki.wp.lab_3.service;

import mk.ukim.finki.wp.lab_3.model.User;

import java.util.Optional;

public interface AuthService {
    Optional<User> loginUser(String username, String password);
    Optional<User>checkAvailability(String username);

    void saveUser(User createdUser);
}
