package com.example.lab_emt.model.dto;

import com.example.lab_emt.model.Country;
import jakarta.persistence.FetchType;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
public class HostDto {
    private String name;
    private String surname;
    private Long country;
}
