package mk.ukim.finki.wp.lab_3.repository;

import mk.ukim.finki.wp.lab_3.model.ShoppingCart;
import mk.ukim.finki.wp.lab_3.model.User;
import mk.ukim.finki.wp.lab_3.model.énum.StatusCode;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface ShoppingCartRepository extends JpaRepository<ShoppingCart,Long> {
    Optional<ShoppingCart>findShoppingCartByIdAndSTATUS(Long id,StatusCode statusCode);
    Optional<ShoppingCart> findByUserEqualsAndSTATUSEquals(User user,StatusCode statusCode);
}
