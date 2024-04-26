package com.example.lab_emt.service.impl;

import com.example.lab_emt.model.Host;
import com.example.lab_emt.model.dto.HostDto;
import com.example.lab_emt.repository.CountryRepository;
import com.example.lab_emt.repository.HostRepository;
import com.example.lab_emt.service.CountryService;
import com.example.lab_emt.service.HostService;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
@AllArgsConstructor
public class HostServiceImpl implements HostService {
    private final HostRepository hostRepository;
    private final CountryService countryService;
    @Override
    public Host findbyId(Long host) {
        return hostRepository.findById(host).orElseThrow(()->new RuntimeException("Unknown host"));
    }

    @Override
    public Optional<Host> addHost(HostDto hostDto) {
        return Optional.of(hostRepository.save(new Host(hostDto.getName(),hostDto.getSurname(),countryService.findbyId(hostDto.getCountry()).get())));
    }

    @Override
    public Optional<Object> deleteHost(Long id) {
        Host host=findbyId(id);
        hostRepository.delete(host);
        return Optional.of(host);
    }

    @Override
    public List<Host> findAll() {
        return hostRepository.findAll();
    }
}
