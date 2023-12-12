package mk.ukim.finki.wp.lab_3.model.exception;

public class NotValidSaveMovieException extends RuntimeException{
    public NotValidSaveMovieException() {
        super("Movie form not valid");
    }
}
