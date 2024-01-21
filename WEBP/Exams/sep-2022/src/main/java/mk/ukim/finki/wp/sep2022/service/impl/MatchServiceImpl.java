package mk.ukim.finki.wp.sep2022.service.impl;

import mk.ukim.finki.wp.sep2022.model.Match;
import mk.ukim.finki.wp.sep2022.model.MatchType;
import mk.ukim.finki.wp.sep2022.model.exceptions.InvalidMatchIdException;
import mk.ukim.finki.wp.sep2022.repository.MatchRepository;
import mk.ukim.finki.wp.sep2022.service.MatchLocationService;
import mk.ukim.finki.wp.sep2022.service.MatchService;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class MatchServiceImpl implements MatchService {
    private final MatchRepository matchRepository;
    private final MatchLocationService matchLocationService;

    public MatchServiceImpl(MatchRepository matchRepository, MatchLocationService matchLocationService) {
        this.matchRepository = matchRepository;
        this.matchLocationService = matchLocationService;
    }

    @Override
    public List<Match> listAllMatches() {
        return matchRepository.findAll();
    }

    @Override
    public Match findById(Long id) {
        return matchRepository.findById(id).orElseThrow(InvalidMatchIdException::new);
    }

    @Override
    public Match create(String name, String description, Double price, MatchType type, Long location) {
        return matchRepository.save(new Match(name,description,price,type,matchLocationService.findById(location)));
    }

    @Override
    public Match update(Long id, String name, String description, Double price, MatchType type, Long location) {
        Match updatedMatch=findById(id);
        updatedMatch.setName(name);
        updatedMatch.setDescription(description);
        updatedMatch.setPrice(price);
        updatedMatch.setType(type);
        updatedMatch.setLocation(matchLocationService.findById(location));
        return matchRepository.save(updatedMatch);
    }

    @Override
    public Match delete(Long id) {
        Match deletedMatch=findById(id);
        matchRepository.delete(deletedMatch);
        return deletedMatch;
    }

    @Override
    public Match follow(Long id) {
        Match followedMatch=findById(id);
        followedMatch.setFollows(followedMatch.getFollows()+1);
        return matchRepository.save(followedMatch);
    }

    @Override
    public List<Match> listMatchesWithPriceLessThanAndType(Double price, MatchType type) {
        if(price!=null && type!=null){
            return matchRepository.findMatchesByPriceLessThanAndTypeEquals(price,type);
        }else if(price!=null){
            return matchRepository.findMatchesByPriceLessThan(price);
        }else if(type!=null){
            return matchRepository.findMatchesByTypeEquals(type);
        }
        return listAllMatches();
    }
}
