using System;

namespace NotePad.BaekJoon
{
    public class BJ2292
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int pivot = 6;
            int start = 2;
            int last = 7;
            int count = 1;

            while (true)
            {
                if (n == 1)
                {
                    break;
                }
                if (start <= n && n <= last)
                {
                    count++;
                    break;
                }

                start = (pivot + start);
                pivot += 6;
                last = (start + pivot) - 1;
                count++;
            }
            
            Console.WriteLine(count);


            // 2~ 7 = 6
            // (2+6)8 ~ 19 = 12
            // (8+12)20 ~ 37 = 18
            // (20+18)38 ~ 61 = 24
            // (38+24)62 ~ 91 = 30
        }
    }
}