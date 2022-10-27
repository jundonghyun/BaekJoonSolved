using System;

namespace NotePad.BaekJoon
{
    public class BJ1712
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();

            int n = int.Parse(temp[0]);
            int variable = int.Parse(temp[1]);
            int props = int.Parse(temp[2]);

            if (variable >= props)
            {
                Console.WriteLine(-1);
            }
            else
            {
                int count = 0;

                count = props - variable;
                count = n / count;
                Console.WriteLine(++count);
            }
        }
    }
}