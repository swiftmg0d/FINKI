package Vtor2021Termin2;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.DoubleSummaryStatistics;
import java.util.HashMap;
import java.util.List;
import java.util.stream.IntStream;

public class PMCesticki {
    public static void main(String[] args) throws IOException {

        BufferedReader input=new BufferedReader(new InputStreamReader(System.in));
        HashMap<Double,String>hashMap=new HashMap<>();

        int nTimes= Integer.parseInt(input.readLine());
        IntStream.range(0, nTimes).forEach(i -> {
            String line = null;
            try {
                line = input.readLine();
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
            String[] splited = line.split("\\s+");
            hashMap.put(Double.parseDouble(splited[1].toString()), splited[0]);

        });

        String municipality=input.readLine();
        List<Double> doubleList=new ArrayList<>();
        hashMap.forEach( (key,value)->{
            if(value.equals(municipality)){
                doubleList.add(key);
            }
        });
        DoubleSummaryStatistics doubleSummaryStatistics=doubleList.stream().mapToDouble(i->i).summaryStatistics();
        System.out.printf("%.2f",doubleSummaryStatistics.getAverage());
    }
}
