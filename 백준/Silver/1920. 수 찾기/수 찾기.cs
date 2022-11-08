using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotePad.BaekJoon
{
    public class BJ1920
    {
        static StringBuilder sb = new StringBuilder();
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(arr);

            int m = int.Parse(Console.ReadLine());

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var i in input)
            {
                BinarySearch(arr, 0, arr.Length / 2, arr.Length, i);
            }
            Console.WriteLine(sb);
        }

        static void BinarySearch(int[] arr, int low, int mid, int high, int target)
        {
            if (arr[mid] == target)
            {
                sb.Append(1 + "\n");
                return;
            }
            
            if (low + 1 == high)
            {
                sb.Append(0 + "\n");
                return;
            }

            if (target > arr[mid]) //위로
            {
                BinarySearch(arr, mid, (mid + high) / 2, high, target);
            }
            else
            {
                BinarySearch(arr, low, (low + mid) / 2, mid, target);
            }
        }
    }
}

/*
5
4 1 5 2 3
5
1 3 7 9 5
 */