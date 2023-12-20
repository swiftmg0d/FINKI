package mk.ukim.finki.wp.kol2022.g2.service.impl;

import mk.ukim.finki.wp.kol2022.g2.model.Course;
import mk.ukim.finki.wp.kol2022.g2.model.Student;
import mk.ukim.finki.wp.kol2022.g2.model.StudentType;
import mk.ukim.finki.wp.kol2022.g2.model.exceptions.InvalidCourseIdException;
import mk.ukim.finki.wp.kol2022.g2.model.exceptions.InvalidStudentIdException;
import mk.ukim.finki.wp.kol2022.g2.repository.CourseRepository;
import mk.ukim.finki.wp.kol2022.g2.repository.StudentRepository;
import mk.ukim.finki.wp.kol2022.g2.service.CourseService;
import mk.ukim.finki.wp.kol2022.g2.service.StudentService;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.util.List;

@Service
public class StudentServiceImpl implements StudentService, UserDetailsService {
    private final StudentRepository studentRepository;
    private final CourseRepository courseRepository;
    private final CourseService courseService;
    private final PasswordEncoder passwordEncoder;

    public StudentServiceImpl(StudentRepository studentRepository, CourseRepository courseRepository, CourseService courseService, PasswordEncoder passwordEncoder) {
        this.studentRepository = studentRepository;
        this.courseRepository = courseRepository;
        this.courseService = courseService;
        this.passwordEncoder = passwordEncoder;
    }

    @Override
    public List<Student> listAll() {
        return studentRepository.findAll();
    }

    @Override
    public Student findById(Long id) {
        return studentRepository.findById(id).orElseThrow(InvalidStudentIdException::new);
    }

    @Override
    public Student create(String name, String email, String password, StudentType type, List<Long> courseId, LocalDate enrollmentDate) {
        List<Course> courseList = courseRepository.findAllById(courseId);
        if (courseList.isEmpty()) throw new InvalidCourseIdException();
        return studentRepository.save(new Student(name, email, password, type, courseList, enrollmentDate));
    }

    @Override
    public Student update(Long id, String name, String email, String password, StudentType type, List<Long> coursesId, LocalDate enrollmentDate) {
        List<Course> courseList = courseRepository.findAllById(coursesId);
        if (courseList.isEmpty()) throw new InvalidCourseIdException();
        Student updatedStudent = findById(id);
        updatedStudent.setName(name);
        updatedStudent.setEmail(email);
        updatedStudent.setPassword(password);
        updatedStudent.setType(type);
        updatedStudent.setCourses(courseList);
        updatedStudent.setEnrollmentDate(enrollmentDate);
        return studentRepository.save(updatedStudent);
    }

    @Override
    public Student delete(Long id) {
        Student deletedStudent = findById(id);
        studentRepository.delete(deletedStudent);
        return deletedStudent;
    }

    @Override
    public List<Student> filter(Long courseId, Integer yearsOfStudying) {
        if (yearsOfStudying != null && courseId != null) {
            return studentRepository.findStudentsByEnrollmentDateBeforeAndCoursesContaining(LocalDate.now().minusYears(yearsOfStudying), courseService.findById(courseId));
        } else if (courseId != null) {
            return studentRepository.findStudentsByCoursesContaining(courseService.findById(courseId));
        } else if (yearsOfStudying != null) {
            return studentRepository.findStudentsByEnrollmentDateBefore(LocalDate.now().minusYears(yearsOfStudying));
        }
        return listAll();
    }


    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        Student student = studentRepository.findStudentByEmail(username).orElseThrow(() -> new UsernameNotFoundException(username));

        return User.builder()
                .username(student.getEmail())
                .password(passwordEncoder.encode(student.getPassword()))
                .roles(student.getType().name())
                .build();
    }
}
