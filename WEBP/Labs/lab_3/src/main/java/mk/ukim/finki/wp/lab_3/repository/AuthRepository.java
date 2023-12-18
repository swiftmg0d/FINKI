package mk.ukim.finki.wp.lab_3.repository;

import mk.ukim.finki.wp.lab_3.model.User;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface AuthRepository extends JpaRepository<User,Long> {
    Optional<User>findUserByUsernameAndPassword(String username,String password);
    Optional<User>findUserByUsername(String username);
}
