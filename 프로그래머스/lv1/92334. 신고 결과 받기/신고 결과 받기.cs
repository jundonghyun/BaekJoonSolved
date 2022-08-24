using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        
        //신고한사람, 신고당한사람
        //신고한사람은 같은사람을 신고하면 안됨
        string[] nameList = new string[id_list.Length];
        int[] count = new int[id_list.Length];
        string[] name = new string[id_list.Length];

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < id_list.Length; i++)
        {
            dic.Add(id_list[i], new List<string>());
        }
        
        
        for (int i = 0; i < report.Length; i++)
        {
            string[] t = report[i].Split();

            for (int j = 0; j < id_list.Length; j++)
            {
                if (!dic[t[1]].Contains(t[0]))
                {
                    dic[t[1]].Add(t[0]);
                    count[j]++;
                    break;
                    if (t[1] == id_list[j]) //신고당한 사람의 count++, 신고한 사람의 이름은?
                    {
                        
                    }
                }
                else
                {
                    break;
                }
            }
        }

        //var di = dic.OrderByDescending(x => x.Value.Count);


        foreach (var j in dic)
        {
            var q = from num in j.Value
                where j.Value.Count >= k
                select num;
            
            foreach (var result in q)
            {
                answer[Array.IndexOf(id_list, result)]++;
            }
        }
        
        return answer;
    }
}