public class Solution {
    public int solution(int n) {
        int answer = 0;
        int a = 1, b = 0, c = 0, i;
        
        for (i = 0; i <= n; i++)
        {
            if (i <= 1)
            {
                c = i;
            }
            else
            {
                c = a % 1234567 + b % 1234567;
                b = a;
                a = c;
            }
        }

        answer = c % 1234567;
        
        return answer;
    }
}