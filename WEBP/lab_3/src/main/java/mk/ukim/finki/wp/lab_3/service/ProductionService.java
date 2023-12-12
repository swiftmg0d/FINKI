package mk.ukim.finki.wp.lab_3.service;

import mk.ukim.finki.wp.lab_3.model.Production;

import java.util.List;
import java.util.Optional;

public interface ProductionService {
    List<Production>findAll();


    Optional<Production> deleteByID(Long id);

    Optional<Production> findByID(Long id);

    void saveProduction(Long id, String name, String country, String address);
}
