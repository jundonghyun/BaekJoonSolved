using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int min = Int32.MaxValue;

        for(int i = 1; i < n; i++)
        {
            if (n % i == 1)
            {
                if (min > i)
                {
                    min = i;
                }
            }
        }
        
        return min;
    }
}