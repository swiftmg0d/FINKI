package mk.ukim.finki.wp.lab_3.repository;

import mk.ukim.finki.wp.lab_3.model.Production;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface ProductionRepository extends JpaRepository<Production,Long> {
    Optional<Production>deleteProductionById(Long id);
}
