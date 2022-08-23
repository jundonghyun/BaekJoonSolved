using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];

        int sum = brown + yellow;
        int diff = Int32.MaxValue;
        //int key, value = 0;

        List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();

        for (int i = 1; i < sum; i++)
        {
            int temp = sum / i;
            if (sum % i == 0)
            {
                if (diff > Math.Abs(temp - i))
                {
                    diff = temp - i;
                    if (i < temp && (i - 2) * (temp - 2) == yellow)
                    {
                        list.Clear();
                        list.Add(new KeyValuePair<int, int>(temp, i));
                    }
                    else
                    {
                        if((i - 2) * (temp - 2) == yellow)
                        {
                            list.Clear();
                            list.Add(new KeyValuePair<int, int>(i, temp));
                        }
                        
                    }
                }
            }
        }

        answer[0] = list[0].Key;
        answer[1] = list[0].Value;

        return answer;
    }
}