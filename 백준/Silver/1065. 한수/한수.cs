using System;

namespace NotePad.BaekJoon
{
    public class BJ1065
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 100)
            {
                Console.WriteLine(n);
            }
            else
            {
                int count = 99;
                int temp = 100;
                
                while (temp <= n)
                {
                    int one = temp % 10;
                    int ten = (temp / 10) % 10;
                    int hundred = temp / 100;

                    if (one - ten == ten - hundred)
                    {
                        count++;
                    }

                    temp++;
                }
                
                Console.WriteLine(count);
            }
        }
    }
}