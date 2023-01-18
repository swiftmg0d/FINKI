package II_Kolokvium.AuditionTest;

import java.util.*;
import java.util.stream.Stream;

public class AuditionTest {
    public static void main(String[] args) {
        Audition audition = new Audition();
        List<String> cities = new ArrayList<String>();
        Scanner scanner = new Scanner(System.in);
        while (scanner.hasNextLine()) {
            String line = scanner.nextLine();
            String[] parts = line.split(";");
            if (parts.length > 1) {
                audition.addParticpant(parts[0], parts[1], parts[2],
                        Integer.parseInt(parts[3]));
            } else {
                cities.add(line);
            }
        }
        for (String city : cities) {
            System.out.printf("+++++ %s +++++\n", city);
            audition.listByCity(city);
        }
        scanner.close();
    }
}
class Audition{
    HashMap<String ,List<Person>>hashMap;

    public Audition() {
        hashMap=new HashMap<>();
    }


    public void addParticpant(String cityPerson, String codePerson, String namePerson, int agePerson) {
        Person p1=new Person(cityPerson,codePerson,namePerson,agePerson);
        if(hashMap.containsKey(cityPerson)){
            List<Person>personList=hashMap.get(cityPerson);
            boolean isTrue=true;
            for (Person person : personList) {
                if(person.getCode().equals(codePerson)){
                    isTrue=false;
                }
            }
            if(isTrue){
                personList.add(p1);
            }
        }else{
            List<Person>personList=new ArrayList<>();
            personList.add(p1);
            hashMap.put(cityPerson,personList);
        }


        }



    public void listByCity(String city) {
        Stream<Person>personStream=hashMap.get(city).stream().sorted(new ComparePersons());
        personStream.forEach(i->{
            System.out.println(i.toString());
        });
    }
}
class ComparePersons implements Comparator<Person>{

    @Override
    public int compare(Person o1,Person o2) {
        int x = o1.getName().compareTo(o2.getName());
        if(x == 0) {
            int y = Integer.compare(o1.getAge(), o2.getAge());
            if(y==0) {
                return o1.getCode().compareTo(o2.getCode());
            }
            return y;
        }

        return x;
    }
}
class Person{
    @Override
    public String toString() {
        return String.format("%s %s %d",code,name,age);
    }

    private String city;
    private  String code;
    private String name;
    private int age;

    public Person(String city, String code, String name, int age) {
        this.city = city;
        this.code = code;
        this.name = name;
        this.age = age;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }
}