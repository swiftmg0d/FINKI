package mk.ukim.finki.wp.lab_2.web.controller;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_2.model.Production;
import mk.ukim.finki.wp.lab_2.service.MovieService;
import mk.ukim.finki.wp.lab_2.service.ProductionService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;


@Controller
@AllArgsConstructor
@RequestMapping("/movies")
public class MovieController {
    private final MovieService movieService;
    private final ProductionService productionService;

    @GetMapping()
    public String getMoviesPage(@RequestParam(required = false) String error, Model model) {

        model.addAttribute("movieList", movieService.listAll());
        model.addAttribute("popularMovie", movieService.mostPopularMovie());
        model.addAttribute("ticketsNumber", movieService.mostTickets());

        return "listMovies";
    }

    @PostMapping("/delete/{id}")
    public String deleteMovie(@PathVariable Long id, @RequestParam String deletedMovie) {
        movieService.deleteMovieById(id, deletedMovie);

        return "redirect:/movies";
    }

    @GetMapping("/edit/{id}")
    public String editMovie(@PathVariable Long id, Model model) {
        if (movieService.findMovieById(id).isPresent()) {
            model.addAttribute("movieEdit", movieService.findMovieById(id).get());
            model.addAttribute("productionList", productionService.findAll());
            return "addMovie";
        }

        return "redirect:/movies?error=MovieNotFound";
    }

    @GetMapping("/add-form")
    public String getAddMoviePage(Model model) {
        model.addAttribute("productionList", productionService.findAll());

        return "addMovie";
    }

    @PostMapping("/result")
    public String SearchMovies(@RequestParam String SearchedMovie, @RequestParam String SearchedRating, Model model) {
        model.addAttribute("movieList", movieService.searchMovies(SearchedMovie, SearchedRating));
        model.addAttribute("popularMovie", movieService.mostPopularMovie());
        model.addAttribute("ticketsNumber", movieService.mostTickets());

        return "listMovies";
    }

    @PostMapping("/add")
    public String saveMovie(@RequestParam String title, @RequestParam(required = false) String edit, @RequestParam String summary, @RequestParam String rating, @RequestParam String id, @RequestParam String production) {
        String[] productionParam = production.split(" ");
        if (edit.equals("edit")) {
            if (movieService.Check(title, summary, rating)) {
                return "redirect:/movies/edit/" + id + "?error=Invalid.rating";

            }
        } else {
            if (movieService.Check(title, summary, rating)) {
                return "redirect:/movies/add-form?error=Please..input..in..valid.form!";
            }

        }
        movieService.SaveMovie(title, summary, rating, id, new Production(Long.parseLong(productionParam[0]), productionParam[1], productionParam[2], productionParam[3]));


        return "redirect:/movies";


    }
}
