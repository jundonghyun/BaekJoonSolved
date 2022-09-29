import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		
		Scanner stdin = new Scanner(System.in);
		
		int num = stdin.nextInt();
		int down = 0; //분모
		int up = 0; //분자
		int count = 0;
	
		while(num > 0) {
			count++;
			num -= count;
		}
		
		if(count % 2 == 0) {
			up = count+num;
			down = 1+(-num);
			System.out.println(up + "/" + down);
		}
		else {
			up = 1+(-num);
			down = count+num;
			System.out.println(up + "/" + down);
		}
	}
}
