package mk.ukim.finki.wp.kol2022.g1.service.impl;

import mk.ukim.finki.wp.kol2022.g1.model.Employee;
import mk.ukim.finki.wp.kol2022.g1.model.EmployeeType;
import mk.ukim.finki.wp.kol2022.g1.model.exceptions.InvalidEmployeeIdException;
import mk.ukim.finki.wp.kol2022.g1.model.exceptions.InvalidSkillIdException;
import mk.ukim.finki.wp.kol2022.g1.repository.EmployeeRepository;
import mk.ukim.finki.wp.kol2022.g1.repository.SkillRepository;
import mk.ukim.finki.wp.kol2022.g1.service.EmployeeService;
import mk.ukim.finki.wp.kol2022.g1.service.SkillService;
import org.springframework.context.annotation.Bean;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class EmployeeServiceImpl implements EmployeeService, UserDetailsService {
    private final EmployeeRepository employeeRepository;
    private final SkillService skillService;
    private final SkillRepository skillRepository;

    public EmployeeServiceImpl(EmployeeRepository employeeRepository, SkillService skillService, SkillRepository skillRepository) {
        this.employeeRepository = employeeRepository;
        this.skillService = skillService;
        this.skillRepository = skillRepository;
    }

    @Override
    public List<Employee> listAll() {
        return employeeRepository.findAll();
    }

    @Override
    public Employee findById(Long id) {
        return employeeRepository.findById(id).orElseThrow(InvalidEmployeeIdException::new);
    }

    @Override
    public Employee create(String name, String email, String password, EmployeeType type, List<Long> skillId, LocalDate employmentDate) {
        if(skillRepository.findAllById(skillId).isEmpty()) throw new InvalidSkillIdException();
        return employeeRepository.save(new Employee(name,email,password,type,skillRepository.findAllById(skillId),employmentDate));
    }

    @Override
    public Employee update(Long id, String name, String email, String password, EmployeeType type, List<Long> skillId, LocalDate employmentDate) {
        Employee updatedEmployee = findById(id);
        updatedEmployee.setName(name);
        updatedEmployee.setEmail(email);
        updatedEmployee.setPassword(password);
        updatedEmployee.setType(type);
        updatedEmployee.setSkills(skillId.stream().map(skillService::findById).collect(Collectors.toList()));
        updatedEmployee.setEmploymentDate(employmentDate);
        return employeeRepository.save(updatedEmployee);
    }

    @Override
    public Employee delete(Long id) {
        Employee deletedEmployee=findById(id);
        employeeRepository.delete(deletedEmployee);
        return deletedEmployee;
    }

    @Override
    public List<Employee> filter(Long skillId, Integer yearsOfService) {
        if(skillId!=null && yearsOfService!=null){
            return employeeRepository.findEmployeesByEmploymentDateBeforeAndSkillsContains(LocalDate.now().minusYears(yearsOfService),skillService.findById(skillId));
        }else if(yearsOfService!=null){
            return employeeRepository.findEmployeesByEmploymentDateBefore(LocalDate.now().minusYears(yearsOfService));
        }else if(skillId!=null){
            return employeeRepository.findEmployeesBySkillsContains(skillService.findById(skillId));
        }
        return listAll();
    }
    @Bean
    PasswordEncoder passwordEncoder(){
        return new BCryptPasswordEncoder(10);
    }
    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        Employee currentEmployee=employeeRepository.findEmployeesByEmail(username).orElseThrow(()->new UsernameNotFoundException(username));
        return User.builder().username(currentEmployee.getEmail()).password(passwordEncoder().encode(currentEmployee.getPassword())).roles(currentEmployee.getType().name()).build();
    }
}
