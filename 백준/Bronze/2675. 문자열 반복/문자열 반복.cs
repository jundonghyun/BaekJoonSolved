using System;

namespace NotePad.BaekJoon
{
    public class BJ2675
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string result = "";
                string[] temp = Console.ReadLine().Split();
                
                int r = int.Parse(temp[0]);

                string s = temp[1];

                for (int j = 0; j < s.Length; j++)
                {
                    for (int k = 0; k < r; k++)
                    {
                        result += s[j];
                    }
                }
                
                Console.WriteLine(result);
            }
        }
    }
}