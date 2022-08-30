using System;
using System.Collections.Generic;
using System.IO;
public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[3];
        int[] count = new int[3];
        
        int[] p1 = { 1, 2, 3, 4, 5 };
        int[] p2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] p3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == p1[i % p1.Length]) count[0]++;
            if (answers[i] == p2[i % p2.Length]) count[1]++;
            if (answers[i] == p3[i % p3.Length]) count[2]++;
        }

        int max = 0;

        for (int i = 0; i < count.Length; i++)
        {
            if (max < count[i])
            {
                max = count[i];
            }
        }

        List<int> list = new List<int>();

        for (int i = 0; i < count.Length; i++)
        {
            if (max == count[i])
            {
                list.Add(i+1);
            }
        }

        answer = list.ToArray();
        
        return answer;
    }
}