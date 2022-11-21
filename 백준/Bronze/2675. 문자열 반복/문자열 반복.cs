using System;
using System.Linq;
using System.Reflection.Emit;

namespace NotePad.BaekJoon
{
    public class notepad
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string result = "";
                
                string[] temp = Console.ReadLine().Split();

                char[] c = temp[1].ToCharArray();

                for (int j = 0; j < c.Length; j++)
                {
                    for (int k = 0; k < int.Parse(temp[0]); k++)
                    {
                        result += c[j];
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}