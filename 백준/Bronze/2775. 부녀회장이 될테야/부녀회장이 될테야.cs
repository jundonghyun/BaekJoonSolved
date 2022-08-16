using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;

namespace NotePad
{
    class Program
    {
        public static void Main(string[] args)
        {
            var reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[,] arr = new int[15,15];

            for (int i = 0; i < 15; i++)//층
            {
                for (int j = 1; j < 15; j++)//호
                {
                    if (i == 0)
                    {
                        arr[i, j] = j;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j] + arr[i,j-1];
                    }
                }
            }

            int n = int.Parse(reader.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int t1 = int.Parse(reader.ReadLine());
                int t2 = int.Parse(reader.ReadLine());
                writer.WriteLine(arr[t1,t2]);
            }

            writer.Close();
            reader.Close();
        }
    }
}