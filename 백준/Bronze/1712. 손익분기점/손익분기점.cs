using System;

namespace NotePad.BaekJoon
{
    public class BJ1712
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();

            long n = int.Parse(temp[0]);
            long variable = int.Parse(temp[1]);
            long props = int.Parse(temp[2]);

            if (variable >= props)
            {
                Console.WriteLine(-1);
            }
            else
            {
                long count = 0;

                count = props - variable;
                count = n / count;
                count++; 
                Console.WriteLine(count);
            }

            
            
            // while (n + variable * count >= props * count)
            // {
            //     count++;
            // }

        }
    }
}