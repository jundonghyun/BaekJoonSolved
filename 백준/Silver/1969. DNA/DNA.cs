using System;
using System.Collections.Generic;
using System.Net;

namespace NotePad.BaekJoon
{
    public class BJ1969
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();

            int n = int.Parse(temp[0]);
            int m = int.Parse(temp[1]);
            
            int min = Int32.MaxValue;
            string minString = "";

            string[] DNAs = new string[n];

            for (int i = 0; i < n; i++)
            {
                DNAs[i] = Console.ReadLine();
            }

            int count = 0;

            for (int j = 0; j < m; j++)
            {
                string tmp = "";
                int[] arr = new int[4];

                for (int i = 0; i < n; i++)
                {
                    tmp += DNAs[i][j]; //세로로 한줄씩 받음
                }
                
                int diff = 0;

                //0--a, 1--c,2--g,3--t

                int a = 0;
                int c = 0;
                int g = 0;
                int t = 0;

                for (int i = 0; i < tmp.Length; i++)
                {
                    switch (tmp[i])
                    {
                        case 'A':
                            arr[0]++;
                            a++;
                            break;
                        case 'C':
                            arr[1]++;
                            c++;
                            break;
                        case 'G':
                            arr[2]++;
                            g++;
                            break;
                        case 'T':
                            arr[3]++;
                            t++;
                            break;
                    }
                }

                int max = 0;

                max = Math.Max(a, c);
                max = Math.Max(max, g);
                max = Math.Max(max, t);
                
                string ch = "";
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == max)
                    {
                        max = arr[i];

                        switch (i)
                        {
                            case 0:
                                ch = "A";
                                break;
                            case 1:
                                ch = "C";
                                break;
                            case 2:
                                ch = "G";
                                break;
                            case 3:
                                ch = "T";
                                break;
                        }

                        break;
                    }
                }

                count += n - max;
                minString += ch;

            }

            Console.WriteLine(minString);
            Console.WriteLine(count);
        }
    }
}