import javax.xml.stream.events.Characters;
import java.util.Scanner;

public class Initials {

    static void printInitials(String name)
    {
        int cnt=1,index=0;
        while (cnt!=name.length()){
            if(name.charAt(cnt)==' '){
                index++;
            }
            cnt++;
        }
        String [] arrString=name.split(" ",cnt);
        for(int i=0;i<index+1;i++){
            System.out.print(arrString[i].toUpperCase().charAt(0));
        }
    }

    public static void main(String args[])
    {
        Scanner input = new Scanner(System.in);
        int n=input.nextInt();
        String name;
        input.nextLine();

        for(int i=0; i<n; i++){
            name = input.nextLine();
            printInitials(name);
            System.out.println();
        }
    }
}

