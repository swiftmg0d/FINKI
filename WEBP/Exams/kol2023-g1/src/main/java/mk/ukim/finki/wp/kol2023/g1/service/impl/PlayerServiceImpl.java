package mk.ukim.finki.wp.kol2023.g1.service.impl;

import mk.ukim.finki.wp.kol2023.g1.model.Player;
import mk.ukim.finki.wp.kol2023.g1.model.PlayerPosition;
import mk.ukim.finki.wp.kol2023.g1.model.exceptions.InvalidPlayerIdException;
import mk.ukim.finki.wp.kol2023.g1.repository.PlayerRepository;
import mk.ukim.finki.wp.kol2023.g1.repository.TeamRepository;
import mk.ukim.finki.wp.kol2023.g1.service.PlayerService;
import mk.ukim.finki.wp.kol2023.g1.service.TeamService;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class PlayerServiceImpl implements PlayerService {
    private final PlayerRepository playerRepository;
    private final TeamService teamService;
    private final TeamRepository teamRepository;

    public PlayerServiceImpl(PlayerRepository playerRepository, TeamService teamService, TeamRepository teamRepository) {
        this.playerRepository = playerRepository;
        this.teamService = teamService;
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
        return playerRepository.save(new Player(name,bio,pointsPerGame,position,teamService.findById(team)));
    }

    @Override
    public Player update(Long id, String name, String bio, Double pointsPerGame, PlayerPosition position, Long team) {
        Player updatedPlayer=findById(id);
        updatedPlayer.setName(name);
        updatedPlayer.setBio(bio);
        updatedPlayer.setPointsPerGame(pointsPerGame);
        updatedPlayer.setPosition(position);
        updatedPlayer.setTeam(teamService.findById(team));
        return playerRepository.save(updatedPlayer);
    }

    @Override
    public Player delete(Long id) {
        Player deletedPlayer=findById(id);
        playerRepository.delete(deletedPlayer);
        return deletedPlayer;
    }

    @Override
    public Player vote(Long id) {
        Player votedPlayer=findById(id);
        votedPlayer.setVotes(votedPlayer.getVotes()+1);
        return playerRepository.save(votedPlayer);
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
