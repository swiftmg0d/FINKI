import java.util.Arrays;
import java.util.Scanner;


public class LDS {
// Најди ја најдолгата опаѓачка секвенца во една низа. Броевите во секвенцата не мора да се наоѓаат на последователни индекси во низата.

    private static int najdolgaOpagackaSekvenca(int[] a) {
        int aMemory[]=new int[a.length]; Arrays.fill(aMemory,1);
        for(int i=1; i<a.length; i++){
            for(int j=0; j<i; j++){
                if(a[i]<a[j] && aMemory[i]<aMemory[j]+1){
                    aMemory[i] = aMemory[j]+1;
                }
            }
        }
        return Arrays.stream(aMemory).max().getAsInt();
    }

    public static void main(String[] args) {
        Scanner stdin = new Scanner(System.in);

        int n = stdin.nextInt();
        int a[] = new int[n];
        for (int i = 0; i < a.length; i++) {
            a[i] = stdin.nextInt();
        }
        System.out.println(najdolgaOpagackaSekvenca(a));
    }


}
