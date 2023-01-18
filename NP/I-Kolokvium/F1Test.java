import javax.swing.text.html.parser.Parser;
import java.io.*;
import java.util.Arrays;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

import static java.lang.System.out;

public class F1Test {

    public static void main(String[] args) {
        F1Race f1Race = new F1Race();
        f1Race.readResults(System.in);
        f1Race.printSorted(System.out);
    }

}

class Racer implements Comparable<Racer>{
    String rName;
    String rBestTime;
    List<String> rLaps;

    public Racer(String line) {
        String[] splited = line.split("\\s+");
        rName = splited[0];
        rLaps= IntStream.range(1,splited.length).mapToObj(i->splited[i]).collect(Collectors.toList());
        rBestTime=IntStream.range(0,rLaps.size()).mapToObj(i->rLaps.get(i)).min(Comparator.naturalOrder()).get();
    }

    public int timeInInteger(String time) {
        String[] splited = time.split(":");
        return Integer.parseInt(splited[0]) * 60000 + Integer.parseInt(splited[1]) * 1000 + Integer.parseInt(splited[0]);
    }

    @Override
    public String toString() {
        return rName+" "+ rBestTime;
    }

    @Override
    public int compareTo(Racer o) {
        return Integer.compare(timeInInteger(rBestTime),timeInInteger(o.rBestTime));
    }
}

class F1Race {
    List<Racer> f1Racers;

    public void readResults(InputStream in) {
        BufferedReader bufferedReader = null;

            bufferedReader = new BufferedReader(new InputStreamReader(in));

        f1Racers = bufferedReader.lines().map(i -> new Racer(i)).collect(Collectors.toList());
        try {
            bufferedReader.close();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }
    void sort(){
        f1Racers.sort(Comparator.naturalOrder());
    }
    public void printSorted(OutputStream out) {
        PrintWriter printWriter= null;

            printWriter = new PrintWriter(new OutputStreamWriter(out));

        sort();
        for(int i=0;i<f1Racers.size();i++){
                printWriter.println((1+i+". ")+f1Racers.get(i).toString());
            }
        printWriter.close();
    }

}