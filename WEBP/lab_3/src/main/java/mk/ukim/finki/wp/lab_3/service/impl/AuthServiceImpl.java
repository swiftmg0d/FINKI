package mk.ukim.finki.wp.lab_3.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.User;
import mk.ukim.finki.wp.lab_3.repository.AuthRepository;
import mk.ukim.finki.wp.lab_3.service.AuthService;
import org.springframework.stereotype.Service;

import java.util.Optional;
@Service
@AllArgsConstructor
public class AuthServiceImpl implements AuthService {
    private final AuthRepository authRepository;
    @Override
    public Optional<User> loginUser(String username, String password) {
        return authRepository.findUserByUsernameAndPassword(username,password);
    }

    @Override
    public Optional<User> checkAvailability(String username) {
        return authRepository.findUserByUsername(username);
    }

    @Override
    public void saveUser(User createdUser) {
        authRepository.save(createdUser);
    }
}
