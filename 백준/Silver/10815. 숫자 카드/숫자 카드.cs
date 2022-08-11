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
            
            int n = int.Parse(reader.ReadLine());

            StringBuilder sb = new StringBuilder();

            string[] input = reader.ReadLine().Split();
            int m = int.Parse(reader.ReadLine());
            string[] inputM = reader.ReadLine().Split();
            
            HashSet<int> set = new HashSet<int>();
            
            for (int i = 0; i < n; i++)
            {
                set.Add(int.Parse(input[i]));
            }

            for (int i = 0; i < m; i++)
            {
                int item;
                if (set.TryGetValue(int.Parse(inputM[i]), out item))
                {
                    writer.Write(1+" ");
                }
                else
                {
                    writer.Write(0+" ");
                }
            }
            reader.Close();
            writer.Close();
        }
    }
}