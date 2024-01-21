package mk.ukim.finki.wp.jan2023.service.impl;

import mk.ukim.finki.wp.jan2023.model.Candidate;
import mk.ukim.finki.wp.jan2023.model.Gender;
import mk.ukim.finki.wp.jan2023.model.exceptions.InvalidCandidateIdException;
import mk.ukim.finki.wp.jan2023.repository.CandidateRepository;
import mk.ukim.finki.wp.jan2023.repository.PartyRepository;
import mk.ukim.finki.wp.jan2023.service.CandidateService;
import mk.ukim.finki.wp.jan2023.service.PartyService;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.util.List;

@Service
public class CandidateServiceImpl implements CandidateService {
    private final CandidateRepository candidateRepository;
    private final PartyService partyService;
    private final PartyRepository partyRepository;

    public CandidateServiceImpl(CandidateRepository candidateRepository, PartyService partyService, PartyRepository partyRepository) {
        this.candidateRepository = candidateRepository;
        this.partyService = partyService;
        this.partyRepository = partyRepository;
    }

    @Override
    public List<Candidate> listAllCandidates() {
        return candidateRepository.findAll();
    }

    @Override
    public Candidate findById(Long id) {
        return candidateRepository.findById(id).orElseThrow(InvalidCandidateIdException::new);
    }

    @Override
    public Candidate create(String name, String bio, LocalDate dateOfBirth, Gender gender, Long party) {
        return candidateRepository.save(new Candidate(name,bio,dateOfBirth,gender,partyService.findById(party)));
    }

    @Override
    public Candidate update(Long id, String name, String bio, LocalDate dateOfBirth, Gender gender, Long party) {
        Candidate updatedCandidate=findById(id);
        updatedCandidate.setName(name);
        updatedCandidate.setBio(bio);
        updatedCandidate.setDateOfBirth(dateOfBirth);
        updatedCandidate.setGender(gender);
        updatedCandidate.setParty(partyService.findById(party));
        return candidateRepository.save(updatedCandidate);
    }

    @Override
    public Candidate delete(Long id) {
        Candidate deletedCandidate=findById(id);
        candidateRepository.delete(deletedCandidate);
        return deletedCandidate;
    }

    @Override
    public Candidate vote(Long id) {
        Candidate votedCandidate=findById(id);
        votedCandidate.setVotes(votedCandidate.getVotes()+1);
        return candidateRepository.save(votedCandidate);
    }

    @Override
    public List<Candidate> listCandidatesYearsMoreThanAndGender(Integer yearsMoreThan, Gender gender) {
        if(yearsMoreThan!=null && gender!=null){
            return candidateRepository.findCandidatesByGenderEqualsAndDateOfBirthBefore(gender,LocalDate.now().minusYears(yearsMoreThan));
        }else if(yearsMoreThan!=null){
            return candidateRepository.findCandidatesByDateOfBirthBefore(LocalDate.now().minusYears(yearsMoreThan));
        }else if(gender!=null){
            return candidateRepository.findCandidatesByGenderEquals(gender);
        }
        return listAllCandidates();
    }
}
