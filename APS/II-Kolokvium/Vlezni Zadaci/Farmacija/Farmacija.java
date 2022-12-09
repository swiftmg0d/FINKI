package Farmacija;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Farmacija {
    public static void main(String[] args) throws IOException {
        BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
        int nTimes = Integer.parseInt(input.readLine());
        HashMap<String, MedicineType> hashMap = new HashMap<>();
        IntStream.range(0, nTimes).forEach(i -> {
            String line = null;
            try {
                line = input.readLine();
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
            String[] splited = line.split("\\s+");
            hashMap.put(splited[0], new MedicineType(splited[1], Integer.parseInt(splited[2])));
        });
        String type = input.readLine();
        Collection<MedicineType> medicineTypes = hashMap.values().stream().collect(Collectors.toList());
        MedicineType p1 = null;
        p1 = medicineTypes.stream().filter(i -> i.getMedicineFor().equals(type)).min(Comparator.reverseOrder()).get();
        for (Map.Entry<String, MedicineType> entry : hashMap.entrySet()) {
            String key = entry.getKey();
            MedicineType value = entry.getValue();
            if (value.equals(p1)) {
                System.out.println(key);
            }
        }
    }
}

class MedicineType implements Comparable<MedicineType> {
    private String medicineFor;
    private int medicinePrice;

    public MedicineType(String medicineFor, int medicinePrice) {
        this.medicineFor = medicineFor;
        this.medicinePrice = medicinePrice;
    }

    public String getMedicineFor() {
        return medicineFor;
    }

    public void setMedicineFor(String medicineFor) {
        this.medicineFor = medicineFor;
    }

    public int getMedicinePrice() {
        return medicinePrice;
    }

    public void setMedicinePrice(int medicinePrice) {
        this.medicinePrice = medicinePrice;
    }

    @Override
    public String toString() {
        return medicineFor + " " + medicinePrice;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof MedicineType that)) return false;
        return medicinePrice == that.medicinePrice && medicineFor.equals(that.medicineFor);
    }

    @Override
    public int hashCode() {
        return Objects.hash(medicineFor, medicinePrice);
    }

    @Override
    public int compareTo(MedicineType o) {
        return Integer.compare(o.medicinePrice, medicinePrice);
    }
}
