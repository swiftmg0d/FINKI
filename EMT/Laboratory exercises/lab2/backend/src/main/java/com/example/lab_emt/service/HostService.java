package com.example.lab_emt.service;

import com.example.lab_emt.model.Host;
import com.example.lab_emt.model.dto.HostDto;

import java.util.List;
import java.util.Optional;

public interface HostService {
    Host findbyId(Long host);
    Optional<Host>addHost(HostDto hostDto);

    Optional<Object> deleteHost(Long id);
    List<Host> findAll();
}
