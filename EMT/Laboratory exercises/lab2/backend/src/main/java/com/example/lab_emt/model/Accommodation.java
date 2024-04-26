package com.example.lab_emt.model;
import com.example.lab_emt.model.enums.AccommodationCategory;
import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@Entity
public class Accommodation {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String name;
    @Enumerated(EnumType.STRING)
    private AccommodationCategory category;
    @ManyToOne
    @JoinColumn(name = "host_id")
    private Host host;
    private Integer num0fRooms;
    private Boolean reserved;
    public Accommodation(String name, AccommodationCategory category, Integer num0fRooms,Host host) {
        this.name = name;
        this.category = category;
        this.num0fRooms = num0fRooms;
        reserved=false;
        this.host=host;
    }
}
