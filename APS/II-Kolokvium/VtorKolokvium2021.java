package II_Kolokvium_2022;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.text.SimpleDateFormat;
import java.util.*;

public class VtorKolokvium2021 {

    public static void main(String[] args) throws IOException {
        List<Driver>driverList=new ArrayList<>();
        SimpleDateFormat simpleDateFormat=new SimpleDateFormat("hh:mm:ss");
        BufferedReader input=new BufferedReader(new InputStreamReader(System.in));
        int nTimes= Integer.parseInt(input.readLine());
        HashMap<String,String>hashMap=new HashMap<>();
            for(int i=0;i<nTimes;i++){
                String line=input.readLine();
                String []splited=line.split("\\s+");
                hashMap.put(splited[0], (splited[1]+" "+splited[2]));
            }
      int maxSpeed=Integer.parseInt(input.readLine());
            String caught=input.readLine();
            String []splited=caught.split("\\s+");
            for(int i=0;i<splited.length;i+=3){
                driverList.add(new Driver(hashMap.get(splited[i]),Integer.parseInt(splited[i+1]),splited[i+2]));
            }
        driverList.stream().filter(i->i.getSpeed()>maxSpeed).sorted(Driver::compareTo).forEach(i-> System.out.println(i.toString()));
    }
}
class Driver implements Comparable<Driver>{
    private String name;
    private int speed;
    private Date time;

    public Driver(String name, int speed, String time) {
        this.name = name;
        this.speed = speed;
        String []splited=time.split(":");
        this.time=new Date(Integer.parseInt(splited[0]),Integer.parseInt(splited[1]),Integer.parseInt(splited[2]));
    }

    @Override
    public int compareTo(Driver o) {
        return this.time.compareTo(o.time);
    }

    public int getSpeed() {
        return speed;
    }

    @Override
    public String toString() {
        return name;
    }
}