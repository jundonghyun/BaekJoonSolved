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

            string[] input = reader.ReadLine().Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            HashSet<int> list1 = new HashSet<int>();
            HashSet<int> list2 = new HashSet<int>();

            string[] input1 = reader.ReadLine().Split();
            string[] input2 = reader.ReadLine().Split();

            int a = input1.Length;
            int b = input2.Length;

            for (int i = 0; i < n; i++)
            {
                list1.Add(int.Parse(input1[i]));
            }

            List<int> list = new List<int>();

            list = list1.ToList();

            for (int i = 0; i < m; i++)
            {
                int temp = int.Parse(input2[i]);
                if (list1.Contains(temp))
                {
                    b--;
                }
                list2.Add(int.Parse(input2[i]));
            }

            for (int i = 0; i < n; i++)
            {
                if (list2.Contains(list[i]))
                {
                    a--;
                }
            }
            writer.WriteLine(a+b);
            
            writer.Close();
            reader.Close();
        }
    }
}