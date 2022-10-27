using System;

namespace NotePad.BaekJoon
{
    public class BJ11399
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int[] time = new int[n];
            int result = 0;

            string[] temp = Console.ReadLine().Split();
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(temp[i]);
            }
            
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    time[i] = arr[i];
                    result += time[i];
                }
                else
                {
                    time[i] = time[i - 1] + arr[i];
                    result += time[i];
                }
            }
            
            Console.WriteLine(result);
        }
    }
}