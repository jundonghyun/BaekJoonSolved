import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.Scanner;

public class Main {
    static int max = 0;
    static int[] aux;
    public static void main(String[] args) throws IOException {
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int n = Integer.parseInt(br.readLine());

        int[] arr = new int[n];

        for(int i = 0; i < n; i++){
            int num = Integer.parseInt(br.readLine());
            arr[i] = num;
            if(max < arr[i]){
                max = arr[i];
            }
        }

        countingSort(arr);

        for (int i = 0; i < aux.length; i++) {
            bw.write(aux[i] + "\n");
        }

        bw.flush();

        bw.close();
        br.close();
    }

    public static void countingSort(int[] arr) {
        int[] tmp = new int[max+1];
        aux = new int[arr.length];

        for(int i = 0; i < arr.length; i++){
            tmp[arr[i]] += 1;
        }

        for(int i = 1; i < max+1; i++){
            tmp[i] += tmp[i-1];
        }

        for(int i = arr.length - 1; i >= 0; i--){
            if(arr[i] != 0){
                aux[tmp[arr[i]] - 1] = arr[i];
                tmp[arr[i]] -= 1;
            }
        }
    }
}