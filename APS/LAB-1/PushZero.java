import java.io.*;
import java.util.Scanner;

public class PushZero
{
    static void pushZerosToEnd(int arr[], int n)
    {
        int cnt=0,cnt1=0;
        int array[] = new int[n];
        while (cnt!=n){
            if(arr[cnt]!=0){
                array[cnt1]=arr[cnt];
                cnt1++;
            }

            cnt++;
        }
        System.out.println("Transformiranata niza e:");

        for(int i=0;i<n;i++){
            System.out.print(array[i]+" ");
        }

    }

    public static void main (String[] args)
    {
        Scanner input=new Scanner(System.in);
        int arr[] = new int[100];

        int n=input.nextInt();
        for (int i=0;i<n;i++){
            arr[i]=input.nextInt();
        }

        pushZerosToEnd(arr, n);

    }
}