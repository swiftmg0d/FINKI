package mk.ukim.finki.wp.june2022.g1.service.impl;

import jdk.jshell.execution.Util;
import mk.ukim.finki.wp.june2022.g1.model.User;
import mk.ukim.finki.wp.june2022.g1.model.exceptions.InvalidUserIdException;
import mk.ukim.finki.wp.june2022.g1.repository.UserRepository;
import mk.ukim.finki.wp.june2022.g1.service.UserService;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class UserServiceImpl implements UserService, UserDetailsService {

    private final UserRepository userRepository;
    private final PasswordEncoder passwordEncoder;

    public UserServiceImpl(UserRepository userRepository, PasswordEncoder passwordEncoder) {
        this.userRepository = userRepository;
        this.passwordEncoder = passwordEncoder;
    }

    @Override
    public User findById(Long id) {
        return userRepository.findById(id).orElseThrow(InvalidUserIdException::new);
    }

    @Override
    public List<User> listAll() {
        return userRepository.findAll();
    }

    @Override
    public User create(String username, String password, String role) {
        return userRepository.save(new User(username, passwordEncoder.encode(password), role.split("_")[1]));
    }

    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        Optional<User> currentUser = userRepository.findUserByUsername(username);
        if(!currentUser.isPresent())throw new UsernameNotFoundException(username);
        return org.springframework.security.core.userdetails.User
                .builder()
                .username(currentUser.get().getUsername())
                .password(currentUser.get().getPassword())
                .roles(currentUser.get().getRole()).build();
    }
}
