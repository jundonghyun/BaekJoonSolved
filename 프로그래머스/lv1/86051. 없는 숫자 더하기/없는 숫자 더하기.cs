using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;

        int max = int.MinValue;
        List<int> list = new List<int>();
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
            list.Add(numbers[i]);
        }

        for (int i = 0; i < 10; i++)
        {
            if (!list.Contains(i))
            {
                answer += i;
            }
        }
        
        return answer;
    }
}