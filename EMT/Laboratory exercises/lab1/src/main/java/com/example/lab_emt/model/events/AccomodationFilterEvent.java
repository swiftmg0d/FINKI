package com.example.lab_emt.model.events;

import com.example.lab_emt.model.Accommodation;
import com.example.lab_emt.model.enums.AccommodationCategory;
import lombok.Getter;
import org.springframework.context.ApplicationEvent;

import java.time.Clock;
@Getter
public class AccomodationFilterEvent  extends ApplicationEvent {
    private final Accommodation accommodation;
    public AccomodationFilterEvent(Accommodation source) {
        super(source);
        accommodation=source;
    }

    public AccomodationFilterEvent(Accommodation source, Clock clock) {
        super(source, clock);
        accommodation=source;
    }
}
