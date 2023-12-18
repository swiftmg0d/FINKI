package mk.ukim.finki.wp.lab_2.model.exception;

public class NotValidSaveMovieException extends RuntimeException{
    public NotValidSaveMovieException() {
        super("Movie form not valid");
    }
}
