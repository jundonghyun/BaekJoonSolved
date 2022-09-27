using System;
using System.Collections.Generic;
using System.Linq;

namespace Bj1337
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            List<int> list = new List<int>();

            int count = 0;
            int result = int.MaxValue;
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(arr);

            list = arr.ToList();

            for (int i = 0; i < arr.Length; i++)
            {
                temp = (5 + arr[i]) - 1;
                count = 0;

                for (int j = arr[i]; j <= temp; j++)
                {
                    if (!list.Contains(j))
                    {
                        count++;
                    }
                }

                result = Math.Min(result, count);
            }
            
            Console.WriteLine(result);
        }
    }
}