import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		
		Scanner stdin = new Scanner(System.in);
		
		int T, H, W, N;
		
		T = stdin.nextInt();
		
		
		for(int i = 0; i < T; i++) {
			H = stdin.nextInt();
			W = stdin.nextInt();
			N = stdin.nextInt();
			int count = 0;

			for(int j = 1; j <= W; j++) {
				for(int k = 1; k <= H; k++) {
					count++;
					if(count == N) {
						if(j < 10) {
							if(k > 9) {
								System.out.println(k+"0"+j); //k = 10, j = 1 == 1001
								break;
							}
							else { // k = 9, j = 1 == 901
								System.out.println(k+"0"+j);
								break;
							}
						}
						else {
							if(k > 9) { // k = 10, j = 10 == 1010
								System.out.println(k+""+j);
								break;
							}
							else { // k = 9; j = 11 == 911
								System.out.println(k+""+j);
								break;
							}
						}
					}
				}
			}
			stdin.nextLine();
		}
	}
}
