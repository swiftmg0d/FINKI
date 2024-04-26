package com.example.lab_emt.service;

import com.example.lab_emt.model.Accommodation;
import com.example.lab_emt.model.dto.AccommodationDto;
import com.example.lab_emt.model.enums.AccommodationCategory;
import jakarta.persistence.*;

import java.util.List;
import java.util.Optional;

public interface AccommodationService {
    Optional<Accommodation> addAccommodation(AccommodationDto accommodationDto);
    Optional<Accommodation> deleteAccommodation(Long id);
    Optional<Accommodation> editAccommodation(Long id,AccommodationDto accommodationDto);
    Accommodation findById(Long id);
    Optional<Accommodation> reserveAccommodation(Long id);

    List<Accommodation> getAllAccommodations();

    Optional<List<Accommodation>> filterByCategory(String category);

    Optional<Accommodation> getAccommodation(Long id);
}
