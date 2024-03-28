package com.example.lab_emt.service;

import com.example.lab_emt.model.Country;
import com.example.lab_emt.model.dto.CountryDto;

import java.util.Optional;

public interface CountryService {
    Optional<Country>addCountry(CountryDto countryDto);
    Optional<Country>findbyId(Long id);

    Optional<Object> deleteCountry(Long id);
}
