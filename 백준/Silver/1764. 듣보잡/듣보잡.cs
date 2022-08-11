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

            List<KeyValuePair<string, int>> set = new List<KeyValuePair<string, int>>();
            HashSet<string> noHear = new HashSet<string>();
            List<string> noEye = new List<string>();

            List<string> result = new List<string>();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            for (int i = 0; i < n; i++)
            {
                noHear.Add(reader.ReadLine());
            }

            noHear.OrderBy(x => x);

            for (int i = 0; i < m; i++)
            {
                string s = reader.ReadLine();
                if (noHear.Contains(s))
                {
                    result.Add(s);
                }
            }

            result.Sort();

            writer.WriteLine(result.Count);
            
            foreach (var i in result)
            {
                writer.WriteLine(i);
            }
            
            writer.Close();
            reader.Close();
        }
    }
}