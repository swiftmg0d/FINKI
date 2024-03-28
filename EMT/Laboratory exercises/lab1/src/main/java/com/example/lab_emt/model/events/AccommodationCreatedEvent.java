package com.example.lab_emt.model.events;

import com.example.lab_emt.model.Accommodation;
import com.example.lab_emt.model.dto.AccommodationDto;
import com.example.lab_emt.model.enums.AccommodationCategory;
import lombok.Getter;
import org.springframework.context.ApplicationEvent;

import java.time.Clock;
import java.time.LocalDate;
import java.time.LocalDateTime;

@Getter
public class AccommodationCreatedEvent  extends ApplicationEvent {
    private final LocalDateTime occurredOn;
    private final Accommodation accommodation;
    public AccommodationCreatedEvent(Accommodation source) {
        super(source);
        this.occurredOn = LocalDateTime.now();
        accommodation=source;
    }

    public AccommodationCreatedEvent(Accommodation source, LocalDateTime occurredOn) {
        super(source);
        this.occurredOn = LocalDateTime.now();
        accommodation=source;
    }
}
