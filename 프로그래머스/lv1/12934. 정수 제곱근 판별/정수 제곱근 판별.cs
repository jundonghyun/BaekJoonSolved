using System.IO;
using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;

        double temp = Math.Sqrt(n);

        if (temp % 1 == 0)
        {
            return (long)((temp + 1) * (temp + 1));
        }
        else
        {
            return -1;
        }
    }
}