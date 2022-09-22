public class Solution {
    public string solution(string s) {
        string answer = "";

        string[] s1 = s.Split();
        int space = s1.Length - 1;

        foreach (var i in s1)
        {
            string temp = "";
            for (int j = 0; j < i.Length; j++)
            {
                if (j == 0 && !int.TryParse(i[j].ToString(), out _))
                {
                    char a = i[j];
                    temp += a.ToString().ToUpper();
                    continue;
                }

                temp += i[j].ToString().ToLower();
            }
            
            answer += temp;
            
            if (space != 0)
            {
                answer += " ";
                space--;
            }
        }

        return answer;
    }
}