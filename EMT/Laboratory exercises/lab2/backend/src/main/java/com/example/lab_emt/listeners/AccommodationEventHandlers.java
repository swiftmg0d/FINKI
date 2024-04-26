package com.example.lab_emt.listeners;

import com.example.lab_emt.model.events.AccommodationCreatedEvent;
import com.example.lab_emt.model.events.AccomodationFilterEvent;
import org.springframework.context.event.EventListener;
import org.springframework.stereotype.Component;

@Component
public class AccommodationEventHandlers {
    @EventListener
    public void handleAccommodationCreatedEvent(AccommodationCreatedEvent event) {
        System.out.println("Accommodation created: " + event.getAccommodation() + ", on: " + event.getOccurredOn());
    }

    @EventListener
    public void handleAccommodationFilterEvent(AccomodationFilterEvent event) {
        System.out.println(event.getAccommodation() + " is  reserved!");
    }
}
