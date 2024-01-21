package mk.ukim.finki.wp.jan2022.g2.service.impl;

import mk.ukim.finki.wp.jan2022.g2.model.Discussion;
import mk.ukim.finki.wp.jan2022.g2.model.DiscussionTag;
import mk.ukim.finki.wp.jan2022.g2.model.exceptions.InvalidDiscussionIdException;
import mk.ukim.finki.wp.jan2022.g2.model.exceptions.InvalidUserIdException;
import mk.ukim.finki.wp.jan2022.g2.repository.DiscussionRepository;
import mk.ukim.finki.wp.jan2022.g2.repository.UserRepository;
import mk.ukim.finki.wp.jan2022.g2.service.DiscussionService;
import mk.ukim.finki.wp.jan2022.g2.service.UserService;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.util.List;

@Service
public class DiscussionServiceImpl implements DiscussionService
{
    private final DiscussionRepository discussionRepository;
    private final UserService userService;
    private final UserRepository userRepository;

    public DiscussionServiceImpl(DiscussionRepository discussionRepository, UserService userService, UserRepository userRepository) {
        this.discussionRepository = discussionRepository;
        this.userService = userService;
        this.userRepository = userRepository;
    }

    @Override
    public List<Discussion> listAll() {
        return discussionRepository.findAll();
    }

    @Override
    public Discussion findById(Long id) {
        return discussionRepository.findById(id).orElseThrow(InvalidDiscussionIdException::new);
    }

    @Override
    public Discussion create(String title, String description, DiscussionTag discussionTag, List<Long> participants, LocalDate dueDate) {
        if(userRepository.findAllById(participants).isEmpty()) throw new InvalidUserIdException();
        return discussionRepository.save(new Discussion(title,description,discussionTag,userRepository.findAllById(participants),dueDate));
    }

    @Override
    public Discussion update(Long id, String title, String description, DiscussionTag discussionTag, List<Long> participants) {
        if(userRepository.findAllById(participants).isEmpty()) throw new InvalidUserIdException();
        Discussion updatedDiscussion=findById(id);
        updatedDiscussion.setTitle(title);
        updatedDiscussion.setDescription(description);
        updatedDiscussion.setTag(discussionTag);
        updatedDiscussion.setParticipants(userRepository.findAllById(participants));
        return discussionRepository.save(updatedDiscussion);
    }

    @Override
    public Discussion delete(Long id) {
        Discussion deletedDiscussion=findById(id);
        discussionRepository.delete(deletedDiscussion);
        return deletedDiscussion;
    }

    @Override
    public Discussion markPopular(Long id) {
        Discussion markedPopular=findById(id);
        markedPopular.setPopular(true);
        return discussionRepository.save(markedPopular);
    }

    @Override
    public List<Discussion> filter(Long participantId, Integer daysUntilClosing) {
        if(participantId!=null && daysUntilClosing!=null){
            return discussionRepository.findDiscussionsByParticipantsContainsAndDueDateBefore(userService.findById(participantId),LocalDate.now().plusDays(daysUntilClosing));
        }else if(participantId!=null){
            return discussionRepository.findDiscussionsByParticipantsContains(userService.findById(participantId));
        }else if(daysUntilClosing!=null){
            return discussionRepository.findDiscussionsByDueDateBefore(LocalDate.now().plusDays(daysUntilClosing));
        }
        return listAll();
    }
}
