package mk.ukim.finki.wp.lab_3.model;

import jakarta.persistence.Entity;
import jakarta.persistence.Table;
import jakarta.persistence.*;
import lombok.Data;


import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
@Entity
@Data
@Table(name = "user-cinema")
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "username", nullable = false, length = 50)
    private String username;

    @Column(name = "name", nullable = false, length = 50)
    private String name;

    @Column(name = "surname", nullable = false, length = 50)
    private String surname;

    @Column(name = "password", nullable = false, length = 50)
    private String password;

    private LocalDate date0fBirth;

    @OneToMany(cascade = CascadeType.ALL,fetch = FetchType.EAGER)
    @JoinColumn(name = "user_id")
    private List<ShoppingCart> list0fShoppingCarts;

    @Convert(converter = UserFullnameConverter.class)
    private UserFullname fullname;

    public User(String username, String name, String surname, String password, LocalDate date0fBirth) {
        this.username = username;
        this.name = name;
        this.surname = surname;
        this.password = password;
        this.date0fBirth = date0fBirth;
        list0fShoppingCarts = new ArrayList<>();
    }
    public User(){}
}
