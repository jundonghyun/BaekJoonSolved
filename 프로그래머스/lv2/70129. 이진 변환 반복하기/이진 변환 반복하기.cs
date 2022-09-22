using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];

        int count = 0;
        int removeCount = 0;

        string s1 = s;

        while (s1.Length != 1)
        {
            string temp = "";
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != '0')
                {
                    temp += s1[i];
                }
                else
                {
                    removeCount++;
                }
            }

            s1 = Convert.ToString(temp.Length, 2);
            
            count++;
        }

        answer[0] = count;
        answer[1] = removeCount;
        
        return answer;
    }
}