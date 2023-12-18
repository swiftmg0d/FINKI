package mk.ukim.finki.wp.lab_3.repository;

import mk.ukim.finki.wp.lab_3.model.User;
import org.springframework.data.jpa.repository.JpaRepository;

public interface UserRepository extends JpaRepository<User,Long> {
}
