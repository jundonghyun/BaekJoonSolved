using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace NotePad
{
    class Program
    {
        /*
        256(=245+2+4+5)
        */


        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
                result[i] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                int weight = int.Parse(arr[i].Split()[0]);
                int height = int.Parse(arr[i].Split()[1]);
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        int otherWeight = int.Parse(arr[j].Split()[0]);
                        int otherHeight = int.Parse(arr[j].Split()[1]);
                        //나보다 상대가 둘다 클 경우에만 ++
                         if (weight < otherWeight && height < otherHeight) //몸무게 키 둘다 이긴경우
                        {
                            result[i]++;
                        }
                    }
                }
                
                Console.WriteLine(result[i]);
            }
        }

    }
}

