package mk.ukim.finki.wp.kol2022.g3.service.impl;

import mk.ukim.finki.wp.kol2022.g3.model.ForumUser;
import mk.ukim.finki.wp.kol2022.g3.model.ForumUserType;
import mk.ukim.finki.wp.kol2022.g3.model.exceptions.InvalidForumUserIdException;
import mk.ukim.finki.wp.kol2022.g3.repository.ForumUserRepository;
import mk.ukim.finki.wp.kol2022.g3.repository.InterestRepository;
import mk.ukim.finki.wp.kol2022.g3.service.ForumUserService;
import mk.ukim.finki.wp.kol2022.g3.service.InterestService;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class ForumUserServiceImpl implements UserDetailsService, ForumUserService {
    private final ForumUserRepository forumUserRepository;
    private final InterestService interestService;
    private final InterestRepository interestRepository;
    private final  PasswordEncoder passwordEncoder;

    public ForumUserServiceImpl(ForumUserRepository forumUserRepository, InterestService interestService, InterestRepository interestRepository, PasswordEncoder passwordEncoder) {
        this.forumUserRepository = forumUserRepository;
        this.interestService = interestService;
        this.interestRepository = interestRepository;
        this.passwordEncoder = passwordEncoder;
    }

    @Override
    public List<ForumUser> listAll() {
        return forumUserRepository.findAll();
    }

    @Override
    public ForumUser findById(Long id) {
        return forumUserRepository.findById(id).orElseThrow(InvalidForumUserIdException::new);
    }

    @Override
    public ForumUser create(String name, String email, String password, ForumUserType type, List<Long> interestId, LocalDate birthday) {
        return forumUserRepository
                .save(new ForumUser(name, email, password, type,
                        interestId.stream().map(interestService::findById).collect(Collectors.toList()),
                        birthday));
    }

    @Override
    public ForumUser update(Long id, String name, String email, String password, ForumUserType type, List<Long> interestId, LocalDate birthday) {
        ForumUser updatedForumUser = findById(id);
        updatedForumUser.setName(name);
        updatedForumUser.setEmail(email);
        updatedForumUser.setPassword(password);
        updatedForumUser.setType(type);
        updatedForumUser.setInterests(interestId.stream().map(interestService::findById).collect(Collectors.toList()));
        updatedForumUser.setBirthday(birthday);
        return forumUserRepository.save(updatedForumUser);
    }

    @Override
    public ForumUser delete(Long id) {
        ForumUser deletedForumUser=findById(id);
        forumUserRepository.delete(deletedForumUser);
        return deletedForumUser;
    }

    @Override
    public List<ForumUser> filter(Long interestId, Integer age) {
        if(interestId!=null && age!=null){
           return forumUserRepository.findForumUsersByBirthdayBeforeAndInterestsContains(LocalDate.now().minusYears(age),interestService.findById(interestId));
        }else if(interestId!=null){
            return forumUserRepository.findForumUsersByInterestsContains(interestService.findById(interestId));
        }else if(age!=null){
            return forumUserRepository.findForumUsersByBirthdayBefore(LocalDate.now().minusYears(age));
        }
        return listAll();
    }

    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        ForumUser user=forumUserRepository.findForumUserByEmailEquals(username).orElseThrow(()-> new UsernameNotFoundException(username));
        return User.builder()
                .username(user.getName()).password(passwordEncoder.encode(user.getPassword())).roles(user.getType().name()).build();
    }
}
