import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        int n, differ, t;
        
        t = sc.nextInt();
        
        for(int num = 0; num < t; num++){
            int differtemp = 100;
            int mid = 0;
            int sum1 = 0, sum2 = 0;
            int output1 = 0, output2 = 0;

            ArrayList<Integer> temp1 = new ArrayList<Integer>();
            ArrayList<Integer> temp2 = new ArrayList<Integer>();
    
            n = sc.nextInt();

            mid = n / 2;

            int[] arr = new int[n+1]; //배열은 0부터 시작하기때문에 N값에서 한개를 더 늘려줘야 N개의 배열이 생성됨
            
            for(int i = 2; i <= n; i++){
                for(int j = i * 2; j < arr.length; j+=i){ //2의 배수의 인덱스값을 0으로 바꿔서 소수가 아님을 판별
                    arr[j] = 1;
                }
            }

            sum1 = mid;
            sum2 = mid;

            while(true){
                
                if(arr[sum1] != 1 && arr[sum2] != 1 && sum1 + sum2 == n){
                    System.out.println(sum1);
                    System.out.println(sum2);

                    break;
                }
                sum1--;
                sum2++;
                
            }
        }
        sc.close();

        return;

    }
}