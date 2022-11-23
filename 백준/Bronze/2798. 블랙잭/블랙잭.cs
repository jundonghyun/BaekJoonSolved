using System;
using System.Linq;
using System.Reflection.Emit;

namespace NotePad.BaekJoon
{
    public class notepad
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int target = arr[1];

            int n = arr[0];

            int result = int.MinValue;

            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] > target)
                        {
                            continue;
                        }
                        else
                        {
                            if (result < arr[i] + arr[j] + arr[k])
                            {
                                result = arr[i] + arr[j] + arr[k];
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine(result);
        }
    }
}