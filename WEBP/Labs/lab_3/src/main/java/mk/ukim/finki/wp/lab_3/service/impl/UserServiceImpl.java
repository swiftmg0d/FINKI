package mk.ukim.finki.wp.lab_3.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.repository.UserRepository;
import mk.ukim.finki.wp.lab_3.service.UserService;
import org.springframework.stereotype.Service;

@Service
@AllArgsConstructor
public class UserServiceImpl implements UserService {
    private final UserRepository userRepository;
}
