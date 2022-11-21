using System;
using System.Linq;
using System.Reflection.Emit;

namespace NotePad.BaekJoon
{
    public class notepad
    {
        public static void Main(string[] args)
        {
            int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = temp[0];
            int target = temp[1];

            int result = 0;

            int[] coin = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                coin[i] = int.Parse(Console.ReadLine());
            }

            for (int i = coin.Length - 1; i >= 0; i--)
            {
                if (target < coin[i])
                {
                    continue;
                }
                else
                {
                    result += target / coin[i];
                    target = target % coin[i];
                }
            }
            
            Console.WriteLine(result);
        }
        
    }
}