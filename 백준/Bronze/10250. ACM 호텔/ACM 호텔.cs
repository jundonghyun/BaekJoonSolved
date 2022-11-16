using System;
using System.Linq;

namespace NotePad.BaekJoon
{
    public class BJ10250
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                //6, 12, 10

                int floor = arr[2] % arr[0];

                if (floor == 0)
                {
                    floor = arr[0];
                }

                int ho = 0;
                
                if (arr[2] % arr[0] == 0)
                {
                    ho = arr[2] / arr[0];
                }
                else
                {
                    ho = (arr[2] / arr[0]) + 1;
                }

                Console.WriteLine(floor*100 + ho);
            }
        }
    }
}