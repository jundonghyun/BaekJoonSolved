using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];

            string[] person = new string[n];

            List<string> list = new List<string>();
            

            int count = 0;
            
            foreach (var i in words)
            {
                person[count] += i + " ";
                count++;
                if (count == n)
                {
                    count = 0;
                }    
            }

            count = 0;
            int pos = 0;

            while (list.Count != words.Length)
            {
                string[] temp = person[count].Split();

                if (list.Count == 0)
                {
                    list.Add(temp[pos]);
                    count++;
                    continue;
                }
                else
                {
                    string t = list[list.Count-1];
                    string t1 = temp[pos];
                    if (!t[t.Length-1].Equals(t1[0]) || list.Contains(t1))
                    {
                        answer[0] = count+1;
                        answer[1] = pos+1;
                        
                        break;
                    }
                    else
                    {
                        list.Add(t1);
                        count++;
                    }
                }

                if (count == person.Length)
                {
                    count = 0;
                    pos++;
                }
            }
            
            return answer;
    }
}