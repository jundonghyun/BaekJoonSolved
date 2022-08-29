using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int zeroCount = 0;
        int min = 0;

        List<int> temp = win_nums.ToList();

        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                zeroCount++;
                continue;
            }

            if (temp.Contains(lottos[i]))
            {
                min++;
            }
        }


        temp.Clear();
        if (min == 0 && zeroCount == 0)
        {
            temp.Add(6);
        }
        else
        {
            temp.Add(7 - (min + zeroCount)); //최대값
        }

        if (min == 0)
        {
            temp.Add(6);
        }
        else
        {
            temp.Add(7 - min);
        }

        int[] answer = temp.ToArray();

        return answer;
    }
}