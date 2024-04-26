package com.example.lab_emt.service.impl;

import com.example.lab_emt.model.Country;
import com.example.lab_emt.model.dto.CountryDto;
import com.example.lab_emt.repository.CountryRepository;
import com.example.lab_emt.service.CountryService;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.Optional;

@Service
@AllArgsConstructor
public class CountryServiceImpl  implements CountryService {
    private final CountryRepository countryRepository;
    @Override
    public Optional<Country> addCountry(CountryDto countryDto) {
        return Optional.of(countryRepository.save(new Country(countryDto.getName(), countryDto.getContinent())));
    }

    @Override
    public Optional<Country> findbyId(Long id) {
        return countryRepository.findById(id);
    }

    @Override
    public Optional<Object> deleteCountry(Long id) {
        Country country=findbyId(id).orElseThrow(()->new RuntimeException("Not existing!"));
        countryRepository.delete(country);
        return Optional.of(country);
    }
}
