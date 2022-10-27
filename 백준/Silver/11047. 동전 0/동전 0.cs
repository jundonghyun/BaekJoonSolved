using System;

namespace NotePad.BaekJoon
{
    public class BJ11047
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();

            int n = int.Parse(temp[0]);
            int value = int.Parse(temp[1]);

            int[] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int tmp = 0; 
            int count = 0;
            
            while (tmp != value)
            {
                for (int i = arr.Length-1; i >= 0; i--)
                {
                    if (arr[i] <= value && tmp + arr[i] <= value)
                    {
                        tmp += arr[i];
                        count++;
                        break;

                    }
                }
            }
            
            Console.WriteLine(count);
        }
    }
}