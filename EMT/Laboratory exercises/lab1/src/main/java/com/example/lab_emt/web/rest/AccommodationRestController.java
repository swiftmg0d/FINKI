package com.example.lab_emt.web.rest;

import com.example.lab_emt.model.Accommodation;
import com.example.lab_emt.model.dto.AccommodationDto;
import com.example.lab_emt.service.AccommodationService;
import lombok.AllArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@AllArgsConstructor
@RequestMapping("/api/accommodations")
public class AccommodationRestController {
    private final AccommodationService accommodationService;

    @PostMapping("/add")
    public ResponseEntity<Accommodation> addAccommodation(@RequestBody AccommodationDto accommodationDto) {
        return this.accommodationService.addAccommodation(accommodationDto)
                .map(accommodation -> ResponseEntity.ok().body(accommodation))
                .orElseGet(() -> ResponseEntity.badRequest().build());
    }

    @PostMapping("/delete/{id}")
    public ResponseEntity<Accommodation> deleteAccommodation(@PathVariable Long id) {
        return this.accommodationService.deleteAccommodation(id)
                .isPresent() ? ResponseEntity.ok().build() : ResponseEntity.badRequest().build();
    }

    @PostMapping("/edit/{id}")
    public ResponseEntity<Accommodation> editAccommodation(@PathVariable Long id, @RequestBody AccommodationDto accommodationDto) {
        return this.accommodationService.editAccommodation(id, accommodationDto)
                .map(accommodation -> ResponseEntity.ok().body(accommodation))
                .orElseGet(() -> ResponseEntity.badRequest().build());
    }

    @PostMapping("/reserve/{id}")
    public ResponseEntity<Accommodation> reserveAccommodation(@PathVariable Long id) {
        return this.accommodationService.reserveAccommodation(id)
                .map(accommodation -> ResponseEntity.ok().body(accommodation))
                .orElseGet(() -> ResponseEntity.badRequest().build());
    }

    @GetMapping("/listAccommodations")
    public ResponseEntity<List<Accommodation>> getAllAccommodations() {
        return !this.accommodationService.getAllAccommodations()
                .isEmpty() ? ResponseEntity.ok().body(this.accommodationService.getAllAccommodations()) : ResponseEntity.badRequest().build();
    }

    @GetMapping("/filter")
    public ResponseEntity<List<Accommodation>> filterAccommodations(@RequestParam String category) {
        return this.accommodationService.filterByCategory(category)
                .map(filterAccommodations -> ResponseEntity.ok().body(filterAccommodations))
                .orElseGet(() -> ResponseEntity.badRequest().build());
    }
}
