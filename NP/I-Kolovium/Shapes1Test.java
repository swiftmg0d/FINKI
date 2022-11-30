import java.io.*;
import java.util.Comparator;
import java.util.IntSummaryStatistics;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Shapes1Test {

    public static void main(String[] args) {
        ShapesApplication shapesApplication = new ShapesApplication();

        System.out.println("===READING SQUARES FROM INPUT STREAM===");
        System.out.println(shapesApplication.readCanvases(System.in));
        System.out.println("===PRINTING LARGEST CANVAS TO OUTPUT STREAM===");
        shapesApplication.printLargestCanvasTo(System.out);

    }
}
class Canvases implements Comparable<Canvases>{
    private String idCanvas;
    private List<Integer>sLits;

    public Canvases(String line) {
        String [] splited=line.split("\\s+");
        idCanvas=splited[0];
        sLits=IntStream.range(1,splited.length).mapToObj(i->Integer.parseInt(splited[i])).collect(Collectors.toList());
    }
    public int getCnt(){
        return sLits.size();
    }
    public int sum(){
        return 4*IntStream.range(0,sLits.size()).mapToObj(i->sLits.get(i)).reduce(0,(x,y)->x+y  ).intValue();
    }

    @Override
    public String toString() {
        return idCanvas+" "+getCnt()+" "+sum();
    }
    @Override
    public int compareTo(Canvases o) {
        return Integer.compare(sum(),o.sum());
    }
}
class ShapesApplication{
    private List<Canvases>sLists;
    public Canvases max(){
        return sLists.stream().max(Comparator.naturalOrder()).get();
    }
    public int readCanvases(InputStream in) {
        BufferedReader bufferedReader=new BufferedReader(new InputStreamReader(in));
        sLists=bufferedReader.lines().map(i->new Canvases(i)).collect(Collectors.toList());
        try {
            bufferedReader.close();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
        return IntStream.range(0,sLists.size()).mapToObj(i->sLists.get(i)).map(i->i.getCnt()).reduce( (x,y)->x+y ).get();
    }

    public void printLargestCanvasTo(PrintStream out) {
        PrintWriter printWriter=new PrintWriter(new OutputStreamWriter(out));
        printWriter.println(max().toString());
        printWriter.close();
    }
}