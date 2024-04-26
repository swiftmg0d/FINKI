package com.example.lab_emt.web.rest;

import com.example.lab_emt.model.Country;
import com.example.lab_emt.model.Host;
import com.example.lab_emt.model.dto.CountryDto;
import com.example.lab_emt.model.dto.HostDto;
import com.example.lab_emt.service.CountryService;
import com.example.lab_emt.service.HostService;
import lombok.AllArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@AllArgsConstructor
@RequestMapping("/api/host")
@CrossOrigin
public class HostRestController {
    private final HostService hostService;

    @PostMapping("/add")
    public ResponseEntity<Host> addHost(@RequestBody HostDto hostDto){
        return this.hostService.addHost(hostDto)
                .map(country -> ResponseEntity.ok().body(country))
                .orElseGet(() -> ResponseEntity.badRequest().build());
    }
    @PostMapping("/delete/{id}")
    public ResponseEntity<Host>deleteHost(@PathVariable Long id){
        return this.hostService.deleteHost(id)
                .isPresent() ? ResponseEntity.ok().build() : ResponseEntity.badRequest().build();
    }
    @GetMapping("/list")
    public ResponseEntity<List<Host>>getAllHosts(){
        return ResponseEntity.ok(this.hostService.findAll());
    }

}