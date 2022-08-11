using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace NotePad
{
    class Program
    {
        public static void Main(string[] args)
        {
            var reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = reader.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            HashSet<string> union = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                union.Add(reader.ReadLine());
            }

            int result = 0;
            for (int i = 0; i < m; i++)
            {
                string item;
                if (union.TryGetValue(reader.ReadLine(), out item))
                {
                    result++;
                }
            }
            
            writer.Write(result);

            reader.Close();
            writer.Close();
        }
    }
}