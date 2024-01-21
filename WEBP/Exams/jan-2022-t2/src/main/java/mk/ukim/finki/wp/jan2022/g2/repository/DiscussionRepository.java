package mk.ukim.finki.wp.jan2022.g2.repository;

import mk.ukim.finki.wp.jan2022.g2.model.Discussion;
import mk.ukim.finki.wp.jan2022.g2.model.User;
import org.springframework.data.jpa.repository.JpaRepository;

import java.time.LocalDate;
import java.util.List;


public interface DiscussionRepository extends JpaRepository<Discussion,Long> {
    List<Discussion>findDiscussionsByParticipantsContains(User user);
    List<Discussion>findDiscussionsByDueDateBefore(LocalDate date);
    List<Discussion>findDiscussionsByParticipantsContainsAndDueDateBefore(User user,LocalDate date);
}
