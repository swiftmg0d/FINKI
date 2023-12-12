package mk.ukim.finki.wp.lab_3.repository.impl;

import mk.ukim.finki.wp.lab_3.bootstrap.DataHolder;
import mk.ukim.finki.wp.lab_3.model.Production;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public class InMemoryProductionRepository {
    public static Optional<Production> deleteByID(Long id) {
        Optional<Production> production=DataHolder.list0fProductions.stream().filter(i->i.getId()==id).findFirst();
        production.ifPresent(i->DataHolder.list0fProductions.remove(i));
        return production;
    }

    public List<Production>findAll(){
        return DataHolder.list0fProductions;
    }

    public Optional<Production> findByID(Long id) {
        return DataHolder.list0fProductions.stream().filter(i->i.getId()==id).findFirst();
    }

    public void saveProduction(Long id, String name, String country, String address) {
        DataHolder.list0fProductions.forEach(i->{
            if(i.getId()==id){
                i.setName(name);
                i.setAddress(address);
                i.setCountry(country);
            }
        });
    }
}
