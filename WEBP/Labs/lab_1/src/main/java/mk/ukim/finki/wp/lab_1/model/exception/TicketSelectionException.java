package mk.ukim.finki.wp.lab_1.model.exception;

public class TicketSelectionException extends RuntimeException {
    public TicketSelectionException() {
        super("Please select number of tickets");
    }
}
