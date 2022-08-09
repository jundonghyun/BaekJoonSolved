using System;
using System.IO;

namespace NotePad
{
    class Program
    {

        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] grade = Console.ReadLine().Split();
            

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(grade[i]);
            }
            
            Array.Sort(arr);

            Console.WriteLine(arr[n-k]);

        }
    }
}