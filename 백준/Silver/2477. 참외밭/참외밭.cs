using System;
using System.IO;
using System.Net;

namespace NotePad
{
    class Program
    {
        public static void Main(string[] args)
        {
            var reader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var writer = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(reader.ReadLine());
            int startdir = 0;
            int[] arrDir = new int[6];
            int[] arrLength = new int[6];

            int maxNSLength = int.MinValue;
            int maxESLength = int.MinValue;
            int maxNSDir = 0;
            int maxESDir = 0;
            int result = 0;
            
            for (int i = 0; i < 6; i++)
            {
                string[] temp = reader.ReadLine().Split();
                arrDir[i] = int.Parse(temp[0]);
                arrLength[i] = int.Parse(temp[1]);

                if (arrDir[i] == 1 || arrDir[i] == 2)
                {
                    if (maxESLength < arrLength[i])
                    {
                        maxESLength = arrLength[i];
                        maxESDir = i;
                    }
                }
                else
                {
                    if (maxNSLength < arrLength[i])
                    {
                        maxNSLength = arrLength[i];
                        maxNSDir = i;
                    }
                }
            }

            startdir = arrDir[0];

            int tempWidth = 1;
            result = (maxESLength * maxNSLength);

            if (maxESDir + 3 < arrLength.Length) //동서 + 3 
            {
                tempWidth *= arrLength[maxESDir + 3];
            }
            else //동서 + 3이 배열을 벗어난다면
            {
                maxESDir += 3;
                tempWidth *= arrLength[maxESDir - arrLength.Length];
            }

            if (maxNSDir + 3 < arrLength.Length)
            {
                tempWidth *= arrLength[maxNSDir + 3];
            }
            else
            {
                maxNSDir += 3;
                tempWidth *= arrLength[maxNSDir - arrLength.Length];
            }

            result -= tempWidth;
            writer.WriteLine(result *= n);

            writer.Close();
            reader.Close();
        }
    }
}