package mk.ukim.finki.wp.lab_3.web.controller;

import jakarta.servlet.http.HttpSession;
import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.Movie;
import mk.ukim.finki.wp.lab_3.model.User;
import mk.ukim.finki.wp.lab_3.service.MovieService;
import mk.ukim.finki.wp.lab_3.service.ProductionService;
import mk.ukim.finki.wp.lab_3.service.TicketOrderService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;


@Controller
@AllArgsConstructor
@RequestMapping("/movies")
public class MovieController {
    private final MovieService movieService;
    private final ProductionService productionService;
    private final TicketOrderService ticketOrderService;

    @GetMapping()
    public String getMoviesPage(HttpSession session,@RequestParam(required = false) String error, Model model) {

        model.addAttribute("movieList", movieService.listAll());
        movieService.mostPopularMovie().ifPresent(i->model.addAttribute("popularMovie",i));
        model.addAttribute("user",(User)session.getAttribute("User"));
        if(error!=null){
            model.addAttribute("error","Please insert valid  data!");
        }
        return "listMovies";
    }

    @PostMapping("/delete/{id}")
    public String deleteMovie(@PathVariable Long id, @RequestParam String deletedMovie) {
        movieService.deleteMovieById(id);
        return "redirect:/movies";
    }

    @GetMapping("/edit/{id}")
    public String editMovie(@RequestParam(required = false) String error,@PathVariable Long id, Model model) {
        if (movieService.findMovieById(id).isPresent()) {
            model.addAttribute("movieEdit", movieService.findMovieById(id).get());
            model.addAttribute("productionList", productionService.findAll());
            if(error!=null){
                model.addAttribute("error","Please insert valid rating!");
            }
            return "addMovie";
        }

        return "redirect:/movies?error=MovieNotFound";
    }

    @GetMapping("/add-form")
    public String getAddMoviePage(@RequestParam(required = false) String error ,Model model) {
        model.addAttribute("productionList", productionService.findAll());
        if(error!=null){
            model.addAttribute("error","Please input valid data!");
        }
        return "addMovie";
    }
//    @PostMapping("/addprice")
//    public String addPriceToProduct(Model model, @RequestParam(required = false) @DateTimeFormat(pattern = "yyyy-MM-dd'T'HH:mm") LocalDateTime from,
//                                    @RequestParam(required = false) @DateTimeFormat(pattern = "yyyy-MM-dd'T'HH:mm") LocalDateTime to,
//                                    @RequestParam String price,@RequestParam Long movie){
//        try{
//            // for exception
//
//            String type=to.toString();
//            String type1=to.toString();
//
//            movieService.updatePriceForMovie(movie,price,from,to);
//
//        }catch (Exception e){
//            return "redirect:/movies?errro";
//        }
//
//
//        return "redirect:/movies";
//    }
    @PostMapping("/result")
    public String SearchMovies(HttpSession httpSession, @RequestParam String SearchedMovie, @RequestParam String SearchedRating, Model model) {
        movieService.mostPopularMovie().ifPresent(i->model.addAttribute("popularMovie",i));
        try{
            User user = (User) httpSession.getAttribute("User");
            List<Movie> list0fMovies=movieService.filterMovie(SearchedMovie,SearchedRating);
            int size=list0fMovies.size();
            model.addAttribute("movieList",list0fMovies);
            model.addAttribute("user", (User) httpSession.getAttribute("User"));
        }catch (RuntimeException exception){
            return "redirect:/movies?error=true";
        }
        return "listMovies";
    }

    @PostMapping("/add")
    public String saveMovie(@RequestParam String title, @RequestParam(required = false) String edit, @RequestParam String summary, @RequestParam String rating, @RequestParam(required = false) Long id, @RequestParam Long production) {
        if (edit.equals("edit")) {
            if (movieService.Check(title, summary, rating)) {
                return "redirect:/movies/edit/" + id + "?error=true";

            }else{
                movieService.editMovie(id,title,summary,rating,production);
            }
        } else {
            if (movieService.Check(title, summary, rating)) {
                return "redirect:/movies/add-form?error=true!";
            }
            else{
                movieService.SaveMovie(title,summary, Double.valueOf(rating),production);

            }

        }


        return "redirect:/movies";


    }
}
