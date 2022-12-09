package Rodendeni;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.Map;
import java.util.stream.IntStream;

public class Rodendeni {

    public static void main(String[] args) throws IOException {
        BufferedReader input=new BufferedReader(new InputStreamReader(System.in));
        int nTimes=Integer.parseInt(input.readLine());
        HashMap<String,String>hashMap=new HashMap<>();
        IntStream.range(0,nTimes).forEach(i->{
            String line= null;
            try {
                line = input.readLine();
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
            String []splited=line.split("\\s+");
            hashMap.put(splited[1],splited[0]);
        });
        HashMap<String,String>hashMap1=new HashMap<>();
        for (Map.Entry<String, String> entry : hashMap.entrySet()) {
            String key = entry.getKey();
            String value = entry.getValue();
            if(key.charAt(3)=='7'){
                hashMap1.put(value,key);
            }
        }
       hashMap1.forEach((key,value)->{
           System.out.print(key+" ");
       });
    }
}
