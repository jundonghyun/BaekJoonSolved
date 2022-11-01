using System;
using System.Linq;

namespace NotePad.BaekJoon
{
    public class Bj11720
    {
        public static void Main(string[] args)
        {
            int.Parse(Console.ReadLine());
            
            int result = 0;

            foreach (var ch in Console.ReadLine())
            {
                result += int.Parse(ch.ToString());
            }

            Console.WriteLine(result);
        }
    }
}