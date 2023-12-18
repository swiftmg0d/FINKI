package mk.ukim.finki.wp.lab_1.model;

import lombok.AllArgsConstructor;
import lombok.Data;

@Data
@AllArgsConstructor
public class TicketOrder {
    private String movieTitle;
    private String clientName;
    private String clientAddress;
    private Long number0fTickets;
}
