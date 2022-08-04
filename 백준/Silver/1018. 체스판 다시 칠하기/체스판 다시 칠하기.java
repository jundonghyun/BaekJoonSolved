import java.util.Scanner;

public class Main {    

    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int M = sc.nextInt();
        String[] board = new String[N];

        int min = 64;
        int count;

        sc.nextLine();

        for (int i = 0; i < N; i++) {
            board[i] = sc.nextLine();
        }

        for (int i = 0; i < N - 7; i++) {
            for (int j = 0; j < M - 7; j++) {
                count = compareBoard(board, i, j);
                if (min > count) {
                    min = count;
                }
            }
        }

        System.out.println(min);
    }

    public static int compareBoard(String[] board, int x, int y) {
        int count1 = 0;
        int count2 = 0;
        String[] chessBoard1 = {"BWBWBWBW","WBWBWBWB","BWBWBWBW","WBWBWBWB","BWBWBWBW","WBWBWBWB","BWBWBWBW","WBWBWBWB"};
        String[] chessBoard2 = {"WBWBWBWB","BWBWBWBW","WBWBWBWB","BWBWBWBW","WBWBWBWB","BWBWBWBW","WBWBWBWB","BWBWBWBW"};

        for (int i = x; i < x + 8; i++) {
            for (int j = y; j < y + 8; j++) {
                if (board[i].charAt(j) != chessBoard1[i - x].charAt(j - y)) {
                    count1++;
                }
                if (board[i].charAt(j) != chessBoard2[i - x].charAt(j - y)) {
                    count2++;
                }
            }
        }

        if (count1 > count2) {
            return count2;
        }

        return count1;
    }
}