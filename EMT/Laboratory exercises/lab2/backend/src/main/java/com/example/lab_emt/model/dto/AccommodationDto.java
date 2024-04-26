package com.example.lab_emt.model.dto;

import com.example.lab_emt.model.enums.AccommodationCategory;
import jakarta.persistence.EnumType;
import jakarta.persistence.Enumerated;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class AccommodationDto {
    private String name;
    private Long category;
    private Integer num0fRooms;
    private Long host;
}
