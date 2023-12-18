package mk.ukim.finki.wp.lab_3.repository;

import mk.ukim.finki.wp.lab_3.model.TicketOrder;
import org.springframework.data.jpa.repository.JpaRepository;

import java.time.LocalDateTime;
import java.util.List;

public interface TicketRepository extends JpaRepository<TicketOrder,Long> {
    List<TicketOrder>findByLocalDateTimeBetween(LocalDateTime from,LocalDateTime to);
    List<TicketOrder>findByMovieId(Long id);
    List<TicketOrder>findAllByMovie_Id(Long id);

}
