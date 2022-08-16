import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		
		Scanner stdin = new Scanner(System.in);
		
		int T, k, n;
		
		T = stdin.nextInt();
		
		int arr[][] = new int[15][15];
		
		for(int i = 0; i < 15; i++) {
			for(int j = 1; j < 15; j++) {
				if(i == 0) {
					arr[i][j] = j;
					continue;
				}
				if(j == 1) {
					arr[i][j] = 1;
					continue;
				}
				arr[i][j] = arr[i][j-1] + arr[i-1][j];
			}
		}
		
		for(int i = 0; i < T; i++) {
			k = stdin.nextInt();
			n = stdin.nextInt();
			
			System.out.println(arr[k][n]);
			
		}
		
		
	}
}
