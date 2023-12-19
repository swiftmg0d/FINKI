package mk.ukim.finki.wp.kol2023.g1.service.impl;

import mk.ukim.finki.wp.kol2023.g1.model.Player;
import mk.ukim.finki.wp.kol2023.g1.model.PlayerPosition;
import mk.ukim.finki.wp.kol2023.g1.model.exceptions.InvalidPlayerIdException;
import mk.ukim.finki.wp.kol2023.g1.model.exceptions.InvalidTeamIdException;
import mk.ukim.finki.wp.kol2023.g1.repository.PlayerRepository;
import mk.ukim.finki.wp.kol2023.g1.repository.TeamRepository;
import mk.ukim.finki.wp.kol2023.g1.service.PlayerService;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class PlayerServiceImpl implements PlayerService {
    private final PlayerRepository playerRepository;
    private final TeamRepository teamRepository;

    public PlayerServiceImpl(PlayerRepository playerRepository, TeamRepository teamRepository) {
        this.playerRepository = playerRepository;
        this.teamRepository = teamRepository;
    }

    @Override
    public List<Player> listAllPlayers() {
        return playerRepository.findAll();
    }

    @Override
    public Player findById(Long id) {
        return playerRepository.findById(id).orElseThrow(InvalidPlayerIdException::new);
    }

    @Override
    public Player create(String name, String bio, Double pointsPerGame, PlayerPosition position, Long team) {
        if (!teamRepository.findById(team).isPresent()) throw new InvalidTeamIdException();
        return playerRepository.save(new Player(name, bio, pointsPerGame, position, teamRepository.findById(team).get()));
    }

    @Override
    public Player update(Long id, String name, String bio, Double pointsPerGame, PlayerPosition position, Long team) {
        if (!teamRepository.findById(team).isPresent()) throw new InvalidTeamIdException();
        if (!playerRepository.findById(id).isPresent()) throw new InvalidPlayerIdException();
        playerRepository.findById(id).ifPresent(i -> {
            i.setName(name);
            i.setBio(bio);
            i.setPointsPerGame(pointsPerGame);
            i.setPosition(position);
            i.setTeam(teamRepository.findById(team).get());
            playerRepository.save(i);
        });
        return playerRepository.findById(id).get();
    }

    @Override
    public Player delete(Long id) {
        if (!playerRepository.findById(id).isPresent()) throw new InvalidPlayerIdException();
        Player deletedPlayer = playerRepository.findById(id).get();
        playerRepository.deleteById(id);
        return deletedPlayer;
    }

    @Override
    public Player vote(Long id) {
        if (!playerRepository.findById(id).isPresent()) throw new InvalidPlayerIdException();
        playerRepository.findById(id).ifPresent(i -> i.setVotes(i.getVotes() + 1));
        playerRepository.save(playerRepository.findById(id).get());
        return playerRepository.findById(id).get();
    }

    @Override
    public List<Player> listPlayersWithPointsLessThanAndPosition(Double pointsPerGame, PlayerPosition position) {
        if (pointsPerGame != null && position != null) {
            return playerRepository.findPlayersByPointsPerGameLessThanAndPositionEquals(pointsPerGame,position);
        } else if (position != null) {
            return playerRepository.findPlayersByPositionEquals(position);
        } else if(pointsPerGame!=null) {
            return playerRepository.findPlayersByPointsPerGameLessThan(pointsPerGame);
        }
        return playerRepository.findAll();
    }
}
