package mk.ukim.finki.wp.lab_3.service.impl;

import lombok.AllArgsConstructor;
import mk.ukim.finki.wp.lab_3.model.Production;
import mk.ukim.finki.wp.lab_3.repository.ProductionRepository;
import mk.ukim.finki.wp.lab_3.service.ProductionService;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
@AllArgsConstructor
public class ProductionServiceImpl implements ProductionService {
    private final ProductionRepository productionRepository;
    @Override
    public List<Production> findAll() {
        return productionRepository.findAll();
    }

    @Override
    public Optional<Production> deleteByID(Long id) {
       return productionRepository.deleteProductionById(id);
    }

    @Override
    public  Optional<Production> findByID(Long id) {
        return productionRepository.findById(id);
    }

    @Override
    public void saveProduction(Long id, String name, String country, String address) {
        productionRepository.save(new Production(name,country,address));
    }
}
