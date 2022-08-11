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

            string input = reader.ReadLine();

            HashSet<string> set = new HashSet<string>();

            int idx = 1;

            for (int i = 0; i < input.Length; i++)
            {
                string temp = "";
                for (int j = i; j < input.Length; j++)
                {
                    temp += input[j];
                    set.Add(temp);
                }
                
            }

            writer.Write(set.Count);
            writer.Close();
            reader.Close();
        }
    }
}