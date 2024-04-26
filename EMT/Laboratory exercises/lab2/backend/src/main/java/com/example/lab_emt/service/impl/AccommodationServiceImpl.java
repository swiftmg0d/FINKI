package com.example.lab_emt.service.impl;

import com.example.lab_emt.model.Accommodation;
import com.example.lab_emt.model.dto.AccommodationDto;
import com.example.lab_emt.model.enums.AccommodationCategory;
import com.example.lab_emt.model.events.AccommodationCreatedEvent;
import com.example.lab_emt.model.events.AccomodationFilterEvent;
import com.example.lab_emt.repository.AccommodationRepository;
import com.example.lab_emt.repository.CountryRepository;
import com.example.lab_emt.service.AccommodationService;
import com.example.lab_emt.service.CountryService;
import com.example.lab_emt.service.HostService;
import lombok.AllArgsConstructor;
import org.springframework.context.ApplicationEvent;
import org.springframework.context.ApplicationEventPublisher;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.yaml.snakeyaml.util.EnumUtils;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

@Service
@AllArgsConstructor
public class AccommodationServiceImpl implements AccommodationService {
    private final AccommodationRepository accommodationRepository;
    private final ApplicationEventPublisher applicationEventPublisher;
    private final HostService hostService;

    @Override
    public Optional<Accommodation> addAccommodation(AccommodationDto accommodationDto) {
        return Optional.of(accommodationRepository.save(new Accommodation(accommodationDto.getName(),
                                        AccommodationCategory.values()[accommodationDto.getCategory().intValue()],
                                        accommodationDto.getNum0fRooms()
                                        , hostService.findbyId(accommodationDto.getHost())

                                )
                        )
                )
                .map(accommodation -> {
                    applicationEventPublisher.publishEvent(new AccommodationCreatedEvent(accommodation));
                    return accommodation;
                });

    }

    @Override
    public Optional<Accommodation> deleteAccommodation(Long id) {
        Accommodation deletedAccommodation = accommodationRepository.findById(id).
                orElseThrow(() -> new RuntimeException("Accommodation not found"));
        accommodationRepository.delete(deletedAccommodation);
        return Optional.of(deletedAccommodation);
    }

    @Override
    public Optional<Accommodation> editAccommodation(Long id, AccommodationDto accommodationDto) {
        Accommodation editedAccommodation = findById(id);
        editedAccommodation.setName(accommodationDto.getName());
        editedAccommodation.setCategory(AccommodationCategory.values()[accommodationDto.getCategory().intValue()]);
        editedAccommodation.setNum0fRooms(accommodationDto.getNum0fRooms());
        return Optional.of(accommodationRepository.save(editedAccommodation));
    }

    @Override
    public Accommodation findById(Long id) {
        return accommodationRepository.findById(id).orElseThrow(() -> new RuntimeException("Accommodation not found"));
    }

    @Override
    public Optional<Accommodation> reserveAccommodation(Long id) {
        Accommodation reservedAccommodation = findById(id);
        reservedAccommodation.setReserved(!reservedAccommodation.getReserved());
        return Optional.of(accommodationRepository.save(reservedAccommodation));
    }

    @Override
    public List<Accommodation> getAllAccommodations() {
        return accommodationRepository.findAll();
    }

    @Override
    public Optional<List<Accommodation>> filterByCategory(String category) {
        AccommodationCategory accommodationCategory = null;
        try {
            accommodationCategory = AccommodationCategory.valueOf(category);
        } catch (RuntimeException e) {
            return Optional.empty();
        }
        accommodationRepository.findAllByCategoryAndReserved(accommodationCategory, true).forEach(i -> applicationEventPublisher.publishEvent(new AccomodationFilterEvent(i)));
        return Optional.of(accommodationRepository.findAllByCategoryAndReserved(accommodationCategory, false));

    }

    @Override
    public Optional<Accommodation> getAccommodation(Long id) {
        return accommodationRepository.findById(id);
    }

}
