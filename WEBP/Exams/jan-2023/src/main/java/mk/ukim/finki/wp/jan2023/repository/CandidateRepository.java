package mk.ukim.finki.wp.jan2023.repository;

import mk.ukim.finki.wp.jan2023.model.Candidate;
import mk.ukim.finki.wp.jan2023.model.Gender;
import org.springframework.data.jpa.repository.JpaRepository;

import java.time.LocalDate;
import java.util.List;

public interface CandidateRepository extends JpaRepository<Candidate,Long> {
    List<Candidate> findCandidatesByDateOfBirthBefore(LocalDate date);
    List<Candidate> findCandidatesByGenderEquals(Gender gender);
    List<Candidate>findCandidatesByGenderEqualsAndDateOfBirthBefore(Gender gender,LocalDate date);
}
