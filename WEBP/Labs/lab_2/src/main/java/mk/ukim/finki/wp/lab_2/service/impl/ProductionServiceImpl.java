package mk.ukim.finki.wp.lab_2.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_2.model.Production;
import mk.ukim.finki.wp.lab_2.repository.InMemoryProductionRepository;
import mk.ukim.finki.wp.lab_2.service.ProductionService;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
@AllArgsConstructor
public class ProductionServiceImpl implements ProductionService {
    private final InMemoryProductionRepository inMemoryProductionRepository;
    @Override
    public List<Production> findAll() {
        return inMemoryProductionRepository.findAll();
    }

    @Override
    public Optional<Production> deleteByID(Long id) {
       return InMemoryProductionRepository.deleteByID(id);
    }

    @Override
    public  Optional<Production> findByID(Long id) {
        return inMemoryProductionRepository.findByID(id);
    }

    @Override
    public void saveProduction(Long id, String name, String country, String address) {
        inMemoryProductionRepository.saveProduction(id,name,country,address);
    }
}
