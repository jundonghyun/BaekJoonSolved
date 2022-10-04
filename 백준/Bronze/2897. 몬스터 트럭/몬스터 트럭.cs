using System;
using System.Collections.Generic;

namespace NotePad.BaekJoon
{
    public class BJ2897
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();

            char[,] map = new char[int.Parse(temp[0]), int.Parse(temp[1])];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                temp = Console.ReadLine().Split();
                char[] ch = temp[0].ToCharArray();
                for (int j = 0; j < ch.Length; j++)
                {
                    map[i, j] = ch[j];
                }
            }

            int[] arr = new int[5];
            List<string> list = new List<string>();
            
            for (int i = 0; i < map.GetLength(0); i++)
            {
                int idx = 0;
                
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    string check = "";
                    if (j + 1 < map.GetLength(1) && i + 1 < map.GetLength(0))
                    {
                        check += map[i, j].ToString();
                        check += map[i, j + 1].ToString();
                        check += map[i + 1, j].ToString();
                        check += map[i + 1, j + 1].ToString();
                        list.Add(check);
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                int count = 0;
                if (list[i].Contains("#"))
                {
                    continue;
                }

                for (int j = 0; j < list[i].Length; j++)
                {
                    if (list[i][j].Equals('X'))
                    {
                        count++;
                    }
                }

                arr[count]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

/*
#..#
..X.
..X.
#XX#

#... -> x
...X -> 1대
.#X. -> x
.... -> 0대
.X.X -> 2대
X.X. -> 2대
..#X -> x
.XXX -> 3대
X.X# -> x
 */