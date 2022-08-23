using System;
using System.Text;

public class Solution {
    public string solution(int[] numbers) {
        string answer = "";

        StringBuilder sb = new StringBuilder();

        Array.Sort(numbers, (i, i1) => (i.ToString() + i1.ToString()).CompareTo(i1.ToString() + i.ToString()));

        int zeroCount = 0;
        
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] == 0)
            {
                zeroCount++;
                sb.Append(numbers[i]);
            }
            else
            {
                sb.Append(numbers[i]);
            }
        }

        if (zeroCount == numbers.Length)
        {
            sb.Clear();
            sb.Append('0');
        }

        answer = sb.ToString();


        return answer;
    }
}

/*
3 5 9 30 34
3 5 9 3 7
*/