using System;
using System.ComponentModel.Design;
using System.Text;

namespace NotePad.BaekJoon
{
    public class BJ6603
    {

        public static void Main(string[] args)
        {
            while (true)
            {
                string[] temp = Console.ReadLine().Split();

                int n = int.Parse(temp[0]);

                if (n == 0)
                {
                    return;
                }

                int[] arr = new int[n];
                bool[] check = new bool[n];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(temp[i + 1]);
                }
                StringBuilder sb = new StringBuilder();

                DFS(arr, 0, 0, "", check);
                Console.WriteLine();
            }
        }

        static void DFS(int[] arr, int idx, int count, string result, bool[] check)
        {
            if (count == 6)
            {
                Console.WriteLine(result);
                return;
            }

            for (int i = idx; i < arr.Length; i++)
            {
                if (!check[i])
                {
                    check[i] = true;

                    result += arr[i];
                    result += " ";
                
                    DFS(arr, i+1, count+1, result, check);

                    string[] tmp = result.Split();
                    result = "";
                    for (int j = 0; j < count; j++)
                    {
                        result += tmp[j] + " ";
                    }
                    check[i] = false;
                }
            }
        }
    }
}