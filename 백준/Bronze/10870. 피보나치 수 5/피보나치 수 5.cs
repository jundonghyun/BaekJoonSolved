using System;
using System.Reflection.Emit;

namespace NotePad.BaekJoon
{
    public class BJ10870
    {
        private static int result = 0;
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Fib(n);
            
            Console.WriteLine(result);
        }

        public static int Fib(int num)
        {
            if (num < 2)
            {
                result += num;
                return num;
            }
            
            return Fib(num-1) + Fib(num - 2);
        }
    }
}