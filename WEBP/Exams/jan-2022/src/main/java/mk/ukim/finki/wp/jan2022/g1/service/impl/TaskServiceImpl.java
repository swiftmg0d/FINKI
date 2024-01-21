package mk.ukim.finki.wp.jan2022.g1.service.impl;

import mk.ukim.finki.wp.jan2022.g1.model.Task;
import mk.ukim.finki.wp.jan2022.g1.model.TaskCategory;
import mk.ukim.finki.wp.jan2022.g1.model.exceptions.InvalidTaskIdException;
import mk.ukim.finki.wp.jan2022.g1.model.exceptions.InvalidUserIdException;
import mk.ukim.finki.wp.jan2022.g1.repository.TaskRepository;
import mk.ukim.finki.wp.jan2022.g1.repository.UserRepository;
import mk.ukim.finki.wp.jan2022.g1.service.TaskService;
import mk.ukim.finki.wp.jan2022.g1.service.UserService;
import org.springframework.stereotype.Service;

import java.nio.file.attribute.UserPrincipalNotFoundException;
import java.time.LocalDate;
import java.util.List;

@Service
public class TaskServiceImpl implements TaskService
{
    private final TaskRepository taskRepository;
    private final UserService userService;
    private final UserRepository userRepository;

    public TaskServiceImpl(TaskRepository taskRepository, UserService userService, UserRepository userRepository) {
        this.taskRepository = taskRepository;
        this.userService = userService;
        this.userRepository = userRepository;
    }

    @Override
    public List<Task> listAll() {
        return taskRepository.findAll();
    }

    @Override
    public Task findById(Long id) {
        return taskRepository.findById(id).orElseThrow(InvalidTaskIdException::new);
    }

    @Override
    public Task create(String title, String description, TaskCategory category, List<Long> assignees, LocalDate dueDate) {
        if(userRepository.findAllById(assignees).isEmpty()) throw new InvalidUserIdException();
        return taskRepository.save(new Task(title,description,category,userRepository.findAllById(assignees),dueDate));
    }

    @Override
    public Task update(Long id, String title, String description, TaskCategory category, List<Long> assignees) {
        if(userRepository.findAllById(assignees).isEmpty()) throw new InvalidUserIdException();
        Task updatedTask=findById(id);
        updatedTask.setTitle(title);
        updatedTask.setDescription(description);
        updatedTask.setCategory(category);
        updatedTask.setAssignees(userRepository.findAllById(assignees));
        return taskRepository.save(updatedTask);
    }

    @Override
    public Task delete(Long id) {
        Task deletedTask=findById(id);
        taskRepository.delete(deletedTask);
        return deletedTask;
    }

    @Override
    public Task markDone(Long id) {
        Task markedTask=findById(id);
        markedTask.setDone(true);
        return taskRepository.save(markedTask);
    }

    @Override
    public List<Task> filter(Long assigneeId, Integer lessThanDayBeforeDueDate) {
        if(assigneeId!=null && lessThanDayBeforeDueDate!=null){
            return taskRepository.findTasksByDueDateLessThanAndAssigneesContains(LocalDate.now().plusDays(lessThanDayBeforeDueDate),userService.findById(assigneeId));
        }else if(assigneeId!=null){
            return taskRepository.findTasksByAssigneesContains(userService.findById(assigneeId));
        }else if(lessThanDayBeforeDueDate!=null){
            return taskRepository.findTasksByDueDateLessThan(LocalDate.now().plusDays(lessThanDayBeforeDueDate));
        }
        return listAll();
    }
}
