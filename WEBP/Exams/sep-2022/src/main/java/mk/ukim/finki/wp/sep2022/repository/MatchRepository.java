package mk.ukim.finki.wp.sep2022.repository;

import mk.ukim.finki.wp.sep2022.model.Match;
import mk.ukim.finki.wp.sep2022.model.MatchType;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface MatchRepository  extends JpaRepository<Match,Long> {
    List<Match>findMatchesByTypeEquals(MatchType type);
    List<Match>findMatchesByPriceLessThan(Double price);
    List<Match>findMatchesByPriceLessThanAndTypeEquals(Double price,MatchType type);
}
