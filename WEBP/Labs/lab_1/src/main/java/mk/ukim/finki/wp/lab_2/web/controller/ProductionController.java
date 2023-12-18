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
@RequestMapping("/productions")
public class ProductionController {
    private final ProductionService productionService;
    private final MovieService movieService;
    @GetMapping()
    public String showProductions(Model model){
        model.addAttribute("listProductions",productionService.findAll());
        return  "listProductions";
    }
    @GetMapping("/edit/{id}")
    public String editProduction(@PathVariable Long id,Model model){
        Production production=productionService.findByID(id).orElseThrow(RuntimeException::new);
        model.addAttribute("editProduction",production);

        return "addProduction";
    }
    @PostMapping("/delete/{id}")
    public String deleteProduction(@PathVariable Long id){
        productionService.deleteByID(id).ifPresent(movieService::deleteMovieByProduction);
        return "redirect:/productions";
    }
    @PostMapping("/edited")
    public String editedProdution(Model model, @RequestParam Long id,
                                  @RequestParam String name,@RequestParam String country,@RequestParam String address){
        productionService.saveProduction(id,name,country,address);
        return "redirect:/productions";
    }
}
