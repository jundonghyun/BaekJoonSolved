using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace NotePad.BaekJoon
{
    public class notepad
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
                
                for (int i = 100; i <= n; i++)
                {
                    int one = i % 10;
                    int ten = (i / 10) % 10;
                    int hundread = i / 100;

                    if (one - ten == ten - hundread)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}