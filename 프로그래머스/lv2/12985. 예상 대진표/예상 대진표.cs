using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;

            while (a != b)
            {
                float a1 = (float)a / 2;
                float b1 = (float)b / 2;
                a = int.Parse(Math.Ceiling(a1).ToString());
                b = int.Parse(Math.Ceiling(b1).ToString());
                
                answer++;
            }

            return answer;
    }
}