package com.example.lab_emt.web.rest;

import com.example.lab_emt.model.Accommodation;
import com.example.lab_emt.model.Country;
import com.example.lab_emt.model.dto.AccommodationDto;
import com.example.lab_emt.model.dto.CountryDto;
import com.example.lab_emt.service.AccommodationService;
import com.example.lab_emt.service.CountryService;
import lombok.AllArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@AllArgsConstructor
@RequestMapping("/api/country")
@CrossOrigin
public class CountryRestController {
    private final CountryService countryService;

    @PostMapping("/add")
    public ResponseEntity<Country> addAccommodation(@RequestBody CountryDto countryDto){
        return this.countryService.addCountry(countryDto)
                .map(country -> ResponseEntity.ok().body(country))
                .orElseGet(() -> ResponseEntity.badRequest().build());
    }
    @PostMapping("/delete/{id}")
    public ResponseEntity<Country>deleteAccommodation(@PathVariable Long id){
        return this.countryService.deleteCountry(id)
                .isPresent() ? ResponseEntity.ok().build() : ResponseEntity.badRequest().build();
    }


}
