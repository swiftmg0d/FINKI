package Vtor2021Termin1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

public class VTOR {
    static String split(String line){
        String []spluted=line.split("\\s+");
        return spluted[0];
    }
    public static void main(String[] args) throws IOException {
        HashMap<String, String> hashMap = new HashMap<>();
        BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
        int nTimes = Integer.parseInt(input.readLine());

            for(int i=0;i<nTimes;i++){
                String line=input.readLine();
                String []splited=line.split("\\s+");
                hashMap.put(splited[0]+" "+splited[1],splited[2]);
            }
            List<Person>personList=new ArrayList<>();
        String municipality=input.readLine();
            hashMap.forEach((key,value)->{
                String []splited=key.split("\\s+");
                boolean isPositive=true;
                if(splited[0].equals(municipality)){
                    if(value.equals("негативен")){
                        isPositive=false;
                    }
                    personList.add(new Person(splited[1],splited[0],isPositive));
                }
            });
        int postivve=(int)personList.stream().filter(i->i.isPositve()==true).count();
        int negative=(int)personList.stream().filter(i-> i.isPositve()==false).count();
        System.out.println((    (double)postivve)/(postivve+negative));
    }
}

class Person {
    private String pSurname;
    private String pMunicipality;
    private boolean isPositve;

    public Person(String pSurname, String pMunicipality, boolean isPositve) {
        this.pSurname = pSurname;
        this.pMunicipality = pMunicipality;
        this.isPositve=isPositve;
    }

    @Override
    public String toString() {
        return pSurname + " " + pMunicipality+" "+isPositve;
    }

    public boolean isPositve() {
        return isPositve;
    }

    public void setPositve(boolean positve) {
        isPositve = positve;
    }

    public String getpMunicipality() {
        return pMunicipality;
    }
}