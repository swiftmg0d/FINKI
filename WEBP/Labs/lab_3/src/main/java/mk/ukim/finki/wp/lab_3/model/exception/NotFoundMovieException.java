package mk.ukim.finki.wp.lab_3.model.exception;

public class NotFoundMovieException extends RuntimeException{
    public NotFoundMovieException(String message) {
        super(String.format("Movie with %s id not found",message));
    }
}
