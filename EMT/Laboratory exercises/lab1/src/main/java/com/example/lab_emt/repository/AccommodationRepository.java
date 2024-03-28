package com.example.lab_emt.repository;

import com.example.lab_emt.model.Accommodation;
import com.example.lab_emt.model.enums.AccommodationCategory;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface AccommodationRepository extends JpaRepository<Accommodation, Long> {
    List<Accommodation> findAllByCategory(AccommodationCategory category);
    List<Accommodation> findAllByCategoryAndReserved(AccommodationCategory category,boolean reserve);
}
