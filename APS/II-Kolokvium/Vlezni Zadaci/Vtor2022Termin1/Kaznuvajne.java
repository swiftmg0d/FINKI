package Vtor2022Termin1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Kaznuvajne {
    public static void main(String[] args) throws IOException {

        BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
        int nTimes = Integer.parseInt(input.readLine());

        HashMap<String, String> hashMap = new HashMap<>();

        IntStream.range(0, nTimes).forEach(i -> {

            String line = null;

            try {
                line = input.readLine();
            } catch (IOException e) {
                throw new RuntimeException(e);
            }

            String[] splited = line.split("\\s+");
            hashMap.put(splited[0], splited[1] + " " + splited[2]);

        });
        int maxSpeed= Integer.parseInt(input.readLine());
        String line=input.readLine();
        String splited[]=line.split("\\s+");
        List<Driver>driverList=new ArrayList<>();
        for(int i=0;i<splited.length;i+=3){
            String date[]=splited[i+2].split(":");
            driverList.add(new Driver(hashMap.get(splited[i]),Integer.parseInt(splited[i+1]),
                    new Date(Integer.parseInt(date[0]),Integer.parseInt(date[1]),Integer.parseInt(date[2]))));
        }


        driverList= driverList.stream().filter(i->i.getDriverSpeed()>maxSpeed).collect(Collectors.toList());
        driverList.sort(Driver::compareTo);
        driverList.stream().forEach(i->{
            System.out.println(i);
        });
    }

}
class Driver implements Comparable<Driver>{
    public int getDriverSpeed() {
        return driverSpeed;
    }

    public void setDriverSpeed(int driverSpeed) {
        this.driverSpeed = driverSpeed;
    }

    private String driverName;
    private int driverSpeed;
    private Date driverDate;

    public Driver(String driverName, int driverSpeed, Date driverDate) {
        this.driverName = driverName;
        this.driverSpeed = driverSpeed;
        this.driverDate = driverDate;
    }

    @Override
    public String toString() {
        return driverName;
    }

    @Override
    public int compareTo(Driver o) {
        return driverDate.compareTo(o.driverDate);

    }
}