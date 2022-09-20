using System;
using System.IO;
using System.Numerics;

public class Solution
{
    public static void Main(string[] args)
    {
        var reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        while (true)
        {
            string line = Console.ReadLine();
            
            if (string.IsNullOrEmpty(line))
            {
                break;
            }
            
            string[] t2 = line.Split();

            foreach (var i in t2)
            {
                BigInteger t1 = 1;

                while (t1 % BigInteger.Parse(i) != 0)
                {
                    t1 = 10 * t1 + 1;
                }

                string temp = t1.ToString();
                writer.WriteLine(temp.Length);
                writer.Flush();
            }
        }

        
        
  

        reader.Close();
        writer.Close();
    }
}