using System;
using System.Linq;

namespace NotePad.BaekJoon
{
    public class BJ1018
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] chess = new string[arr[0], arr[1]];

            for (int i = 0; i < arr[0]; i++)
            {
                char[] temp = Console.ReadLine().ToCharArray();

                for (int j = 0; j < temp.Length; j++)
                {
                    chess[i, j] = temp[j].ToString();
                }
            }

            string[,] originalW =
            {
                { "W", "B", "W", "B", "W", "B", "W", "B" },
                { "B", "W", "B", "W", "B", "W", "B", "W" },
                { "W", "B", "W", "B", "W", "B", "W", "B" },
                { "B", "W", "B", "W", "B", "W", "B", "W" },
                { "W", "B", "W", "B", "W", "B", "W", "B" },
                { "B", "W", "B", "W", "B", "W", "B", "W" },
                { "W", "B", "W", "B", "W", "B", "W", "B" },
                { "B", "W", "B", "W", "B", "W", "B", "W" },
            };

            string[,] originalB =
            {
                { "B", "W", "B", "W", "B", "W", "B", "W" },
                { "W", "B", "W", "B", "W", "B", "W", "B" },
                { "B", "W", "B", "W", "B", "W", "B", "W" },
                { "W", "B", "W", "B", "W", "B", "W", "B" },
                { "B", "W", "B", "W", "B", "W", "B", "W" },
                { "W", "B", "W", "B", "W", "B", "W", "B" },
                { "B", "W", "B", "W", "B", "W", "B", "W" },
                { "W", "B", "W", "B", "W", "B", "W", "B" },
            };

            int result = int.MaxValue;

            for (int i = 0; i < arr[0]; i++)
            {
                for (int j = 0; j < arr[1]; j++)
                {
                    if (i + 7 < arr[0] && j + 7 < arr[1])
                    {
                        int WStart = 0;
                        int BStart = 0;
                        int row = 0;

                        while (row < 8)
                        {
                            int col = 0;
                            while (col < 8)
                            {
                                if (originalW[row, col] != chess[row + i, col + j]) //w시작먼저 비교
                                {
                                    WStart++;
                                }

                                if (originalB[row, col] != chess[row + i, col + j])
                                {
                                    BStart++;
                                }

                                col++;
                            }

                            row++;
                        }

                        int temp = Math.Min(WStart, BStart);
                        result = Math.Min(result, temp);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}