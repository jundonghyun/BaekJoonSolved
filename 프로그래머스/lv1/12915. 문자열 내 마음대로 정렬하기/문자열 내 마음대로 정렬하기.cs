using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length];

        List<string> tmp = new List<string>();
        
        IOrderedEnumerable<string> sortedByFirst = strings.OrderBy(y => y[n]).ThenBy(y => y);

        // IEnumerable<string> query = from word in strings
        //     orderby word.Substring(n)
        //     select word;

        foreach (var i in sortedByFirst)
        {
            tmp.Add(i);
        }

        answer = tmp.ToArray();
        
        return answer;
    }
}