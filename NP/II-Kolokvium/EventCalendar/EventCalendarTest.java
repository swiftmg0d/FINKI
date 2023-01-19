package II_Kolokvium.EventCalendar;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class EventCalendarTest {
    public static void main(String[] args) throws ParseException {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();
        int year = scanner.nextInt();
        scanner.nextLine();
        EventCalendar eventCalendar = new EventCalendar(year);
        DateFormat df = new SimpleDateFormat("dd.MM.yyyy HH:mm");
        for (int i = 0; i < n; ++i) {
            String line = scanner.nextLine();
            String[] parts = line.split(";");
            String name = parts[0];
            String location = parts[1];
            Date date = df.parse(parts[2]);
            try {
                eventCalendar.addEvent(name, location, date);
            } catch (WrongDateException e) {
                System.out.println(e.getMessage());
            }
        }
        Date date = df.parse(scanner.nextLine());
        eventCalendar.listEvents(date);
        eventCalendar.listByMonth();
    }
}

class WrongDateException extends Exception {
    public WrongDateException(String message) {
        super(message);
    }
}

class Event {
    private String eName;
    private String eLocation;
    private Date eDate;

    public Event(String eName, String eLocation, Date eDate) {
        this.eName = eName;
        this.eLocation = eLocation;
        this.eDate = eDate;
    }

    public String geteName() {
        return eName;
    }

    public void seteName(String eName) {
        this.eName = eName;
    }

    public String geteLocation() {
        return eLocation;
    }

    public void seteLocation(String eLocation) {
        this.eLocation = eLocation;
    }
    public int getMonth(){
        return eDate.getMonth()+1;
    }
    public Date geteDate() {
        return eDate;
    }

    public void seteDate(Date eDate) {
        this.eDate = eDate;
    }

    @Override
    public String toString() {
        String splited[]=eDate.toString().split(" ");
        return String.format("%s %s, %s %s at %s, %s",splited[2],splited[1],splited[5],
                splited[3].split(":")[0]+":"+splited[3].split(":")[1],eLocation,eName);
    }
}

class EventCalendar {
    private int year;
    Map<Date, List<Event>>dateListMap=new HashMap<>();
    Map<String,List<Event>>dayList=new TreeMap<>();
    public EventCalendar(int year) {
        this.year = year;
    }

    public void addEvent(String name, String location, Date date) throws WrongDateException{
        String d1=date.toString().split(" ")[5];
        String splited[]=date.toString().split(" ");
        if(!String.valueOf(year).equals(d1)){
            throw new WrongDateException(String.format("Wrong date: %s %s %s %s %s %s",
                    splited[0],splited[1],splited[2],splited[3],"UTC",splited[5]));
        }
        dayList.putIfAbsent(date.toString().split(" ")[2]+" "+date.toString().split(" ")[1],new ArrayList<>());
        dayList.get(date.toString().split(" ")[2]+" "+date.toString().split(" ")[1]).add(new Event(name,location,date));
        dateListMap.putIfAbsent(date,new ArrayList<>());
        dateListMap.get(date).add(new Event(name,location,date));

    }

    public void listEvents(Date date) {
        List<Event>eventList=dayList.get(date.toString().split(" ")[2]+" "+date.toString().split(" ")[1]);
        if(eventList==null){
            System.out.println("No events on this day!");
            return;
        }
        Collections.sort(eventList,Comparator.comparing(Event::geteDate).thenComparing(Event::geteName));
        eventList.forEach(i->{
            System.out.println(i.toString());
        });
    }

    public void listByMonth() {
        List<Event>sList=new ArrayList<>();
        for (Map.Entry<Date, List<Event>> entry : dateListMap.entrySet()) {
            Date i = entry.getKey();
            List<Event> y = entry.getValue();
            y.forEach(k->{
                sList.add(k);
            });
        }
        Map<Integer,List<Event>>integerListMap=sList.stream().collect(Collectors.groupingBy(Event::getMonth));
        IntStream.range(1,13).forEach(i->{
            integerListMap.putIfAbsent(i,new ArrayList<>());
        });
        for (Map.Entry<Integer, List<Event>> entry : integerListMap.entrySet()) {
            Integer k = entry.getKey();
            List<Event> y = entry.getValue();
            System.out.println(k+" : "+y.size());
        }
    }
}

