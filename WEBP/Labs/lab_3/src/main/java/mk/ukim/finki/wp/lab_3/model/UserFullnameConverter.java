package mk.ukim.finki.wp.lab_3.model;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import jakarta.persistence.AttributeConverter;
import jakarta.persistence.Converter;
import lombok.SneakyThrows;

import java.io.IOException;

@Converter
public class UserFullnameConverter implements AttributeConverter<UserFullname, String> {

    private static final ObjectMapper objectMapper = new ObjectMapper();

    @SneakyThrows
    @Override
    public String convertToDatabaseColumn(UserFullname attribute) {
        try {
            return objectMapper.writeValueAsString(attribute);
        } catch (JsonProcessingException e) {
            throw new RuntimeException("Failed to convert UserFullname to String", e);
        }
    }

    @SneakyThrows
    @Override
    public UserFullname convertToEntityAttribute(String dbData) {
        try {
            return objectMapper.readValue(dbData, UserFullname.class);
        } catch (IOException e) {
            throw new RuntimeException("Failed to convert String to UserFullname", e);
        }
    }
}
