using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
        bool answer = true;

        Stack<char> stack = new Stack<char>();

        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals('('))
            {
                stack.Push(s[i]);
                continue;
            }

            if (stack.Count > 0) //스택안에 (가 있으므로 )가 들어오면 빼주면됨
            {
                count--;
                stack.Pop();
            }
            else
            {
                return false;
            }
        }

        if (stack.Count != 0)
        {
            return false;
        }
        
        
        return answer;
    }
}