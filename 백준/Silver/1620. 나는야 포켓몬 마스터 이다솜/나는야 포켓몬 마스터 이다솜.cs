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

            Dictionary<string, int> listString = new Dictionary<string, int>();
            Dictionary<int, string> listInt = new Dictionary<int, string>();
            
            string[] input = reader.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            
            
            
            for (int i = 0; i < n; i++)
            {
                String s = reader.ReadLine();
                listString.Add(s, i+1);
                listInt.Add(i+1, s);
            }

            for (int i = 0; i < m; i++)
            {
                string temp = reader.ReadLine();
                int check = 0;
                if (int.TryParse(temp, out check)) //int 이면
                {
                    writer.WriteLine(listInt[check]);
                }
                else
                {
                    
                    writer.WriteLine(listString[temp]);
                }
            }
            writer.Close();
            reader.Close();
        }
    }
}