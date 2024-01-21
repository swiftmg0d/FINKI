package mk.ukim.finki.wp.jan2023.repository;

import mk.ukim.finki.wp.jan2023.model.Party;
import org.springframework.data.jpa.repository.JpaRepository;

public interface PartyRepository extends JpaRepository<Party,Long> {
}
