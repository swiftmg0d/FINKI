package mk.ukim.finki.wp.lab_3.repository;

import mk.ukim.finki.wp.lab_3.model.Price;
import org.springframework.data.jpa.repository.JpaRepository;

public interface PriceRepository extends JpaRepository<Price,Long> {
}
