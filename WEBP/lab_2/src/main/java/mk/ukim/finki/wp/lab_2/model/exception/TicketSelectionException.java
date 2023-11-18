package mk.ukim.finki.wp.lab_2.model.exception;

public class TicketSelectionException extends RuntimeException {
    public TicketSelectionException() {
        super("Please select number of tickets");
    }
}
