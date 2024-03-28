package com.example.lab_emt.jobs;

import org.springframework.scheduling.annotation.Scheduled;
import org.springframework.stereotype.Component;

import java.util.Date;

@Component
public class ScheduledTasks {
    @Scheduled(fixedDelay = 1000)
    public void reportCurrentTime() {
        System.out.println("The time is now " + new Date());
    }
}
