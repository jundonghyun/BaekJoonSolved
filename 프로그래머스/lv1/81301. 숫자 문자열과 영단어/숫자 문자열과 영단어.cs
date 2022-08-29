using System;
using System.Collections.Generic;
using System.IO;
public class Solution {
    public int solution(string s) {
        int answer = 0;

        List<string> numberToString = new List<string>();
        List<int> number = new List<int>();

        numberToString.Add("zero");
        numberToString.Add("one");
        numberToString.Add("two");
        numberToString.Add("three");
        numberToString.Add("four");
        numberToString.Add("five");
        numberToString.Add("six");
        numberToString.Add("seven");
        numberToString.Add("eight");
        numberToString.Add("nine");

        number.Add(0);
        number.Add(1);
        number.Add(2);
        number.Add(3);
        number.Add(4);
        number.Add(5);
        number.Add(6);
        number.Add(7);
        number.Add(8);
        number.Add(9);

        string temp = "";
        string result = "";

        char[] stringToChar = s.ToCharArray();

        for (int i = 0; i < stringToChar.Length; i++)
        {
            if (number.Contains(stringToChar[i] - '0'))
            {
                result += number[stringToChar[i] - '0'];
            }
            else
            {
                temp += stringToChar[i].ToString();
                if (numberToString.Contains(temp))
                {
                    result += number[numberToString.IndexOf(temp)].ToString();
                    temp = "";
                }
            }
        }
        answer = int.Parse(result);

        return answer;
    }
}