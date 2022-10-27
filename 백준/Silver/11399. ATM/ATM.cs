using System;

namespace NotePad.BaekJoon
{
    public class BJ11399
    {
        public static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());

            int result = 0;

            string[] temp = Console.ReadLine().Split();
            int[] arr = Array.ConvertAll(temp, int.Parse);
            
            Array.Sort(arr);

            int n = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    result = n + arr[i];
                    n = arr[i];
                    continue;
                }

                n = arr[i] + n;
                result += n;
            }
            
            Console.WriteLine(result);
        }
    }
}