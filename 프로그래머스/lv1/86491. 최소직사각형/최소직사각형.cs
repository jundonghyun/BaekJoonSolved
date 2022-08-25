using System;
using System.IO;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;

        List<int> width = new List<int>(); //큰값이 여기들어가게
        List<int> height = new List<int>();
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int max = sizes[i, 0];
            if (sizes[i, 0] > sizes[i, 1])
            {
                width.Add(sizes[i, 0]);
                height.Add(sizes[i, 1]);
            }
            else
            {
                width.Add(sizes[i, 1]);
                height.Add(sizes[i, 0]);
            }
        }
        
        width.Sort();
        height.Sort();

        answer = width[width.Count-1] * height[height.Count-1];
        
        return answer;
    }
}