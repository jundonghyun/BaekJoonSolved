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
            string[] temp = reader.ReadLine().Split();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int>  list = new List<int>();

            int m = int.Parse(reader.ReadLine());
            string[] temp1 = reader.ReadLine().Split();
            
            for (int i = 0; i < n; i++)
            {
                int idx = int.Parse(temp[i]);
                if (dic.ContainsKey(idx)) //값이 있다면 count증가
                {
                    dic[idx]++;
                }
                else
                {
                   dic.Add(idx, 1);
                }
            }

            for (int i = 0; i < m; i++)
            {
                int idx = int.Parse(temp1[i]);

                if (dic.ContainsKey(idx))
                {
                    writer.Write(dic[idx]+ " ");
                }
                else
                {
                    writer.Write("0"+" ");
                }
            }
            

            writer.Close();
            reader.Close();
        }
    }
}