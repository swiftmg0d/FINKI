package mk.ukim.finki.wp.lab_3.model;

import jakarta.persistence.*;
import lombok.Data;
import mk.ukim.finki.wp.lab_3.model.énum.StatusCode;
import org.springframework.format.annotation.DateTimeFormat;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;
@Entity
@Data
public class ShoppingCart {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne(cascade = CascadeType.ALL, fetch = FetchType.LAZY)
    @JoinColumn(name = "user_id")
    private User user;

    @DateTimeFormat(pattern = "yyyy-MM-dd' 'HH:mm:ss")
    private LocalDateTime dateCreated;

    @Enumerated(EnumType.STRING)
    private StatusCode STATUS;

    @ManyToMany(cascade = CascadeType.ALL, fetch = FetchType.LAZY)
    @JoinTable(name = "shopping_cart_ticket_order_list")
    private List<TicketOrder> ticketOrderList;
    public ShoppingCart(){}

    public ShoppingCart(User user, LocalDateTime dateCreated) {
        this.user = user;
        this.dateCreated = dateCreated;
        this.STATUS=StatusCode.CREATED;
        ticketOrderList=new ArrayList<>();

    }
}
