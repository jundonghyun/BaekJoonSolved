using System;

namespace NotePad.BaekJoon
{
    public class BJ20004
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= a; i++)
            {
                if (30 % (i + 1) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}