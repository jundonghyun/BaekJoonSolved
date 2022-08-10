using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NotePad
{
    class Program
    {
/*
             * 첫째 줄에는 산술평균을 출력한다. 소수점 이하 첫째 자리에서 반올림한 값을 출력한다.
               둘째 줄에는 중앙값을 출력한다.
               셋째 줄에는 최빈값을 출력한다. 여러 개 있을 때에는 최빈값 중 두 번째로 작은 값을 출력한다.
               넷째 줄에는 범위를 출력한다.
             */
        public static void Main(string[] args)
        {
            int idx = int.Parse(Console.ReadLine());

            int[] arr = new int[idx];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> list = new List<int>();
            double avg = 0;
            int middle = 0;
            int highest = 0;
            int range = 0;

            int maxCount = 1;
            int maxValue = 0;

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < idx; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (max < arr[i])
                {
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                }
                
                int count = 1;

                if (dict.ContainsKey(arr[i])) //키가 있을경우
                {
                    avg += arr[i];
                    count = dict[arr[i]];
                    dict[arr[i]] = ++count;
                    if (maxCount <= count)
                    {
                        maxCount = count;
                        maxValue = arr[i]; //최빈값
                    }
                    continue;
                }
                avg += arr[i];
                dict.Add(arr[i], count);
            }

            foreach (var i in dict)
            {
                if (i.Value == maxCount)
                {
                    list.Add(i.Key);
                }
            }
            list.Sort();
            
            // dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            // dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Array.Sort(arr);

            double temp = avg / idx;
            
            if (maxCount == 1) //최빈값이 없는것 두번째로 작은값 출력해야함
            {
                if (idx == 1)
                {
                    highest = arr[0];
                    avg = arr[0];
                    middle = arr[idx / 2];

                    range = Math.Abs(max - min);
            
                    Console.WriteLine(avg);
                    Console.WriteLine(middle);
                    Console.WriteLine(highest);
                    Console.WriteLine(range);
                    return;
                }
                else //두번째로 작은 값 출력
                {
                    highest = list[1];
                }
                if (temp < 0)
                {
                    if (temp.ToString().Contains('.'))
                    {
                        string[] t1 = temp.ToString().Split('.');
                        if (5 > int.Parse(t1[1][0].ToString())) // .5 > .3
                        {
                            avg = (int)Math.Ceiling(temp);
                        }
                        else
                        {
                            avg = (int)Math.Floor(temp);
                        }
                    }
                    else
                    {
                        avg = temp;
                    }
                
                }
                else
                {
                    if (temp.ToString().Contains('.'))
                    {
                        string[] t1 = temp.ToString().Split('.');
                        if (5 > int.Parse(t1[1][0].ToString())) // .5 > .3
                        {
                            avg = (int)Math.Floor(temp);
                        }
                        else
                        {
                            avg = (int)Math.Ceiling(temp);
                        }
                    }
                    else
                    {
                        avg = temp;
                    }
                }
            }
            else //maxCount가 1이상인거 == 최빈값이 여러개
            {
                if (list.Count == 1)
                {
                    highest = list[0];
                }
                else
                {
                    highest = list[1];
                }
                
                
                if (temp < 0)
                {
                    if (temp.ToString().Contains('.')) //산술평균이 소수점일 경우
                    {
                        string[] t1 = temp.ToString().Split('.');
                        if (5 > int.Parse(t1[1][0].ToString())) // .5 > .3
                        {
                            avg = (int)Math.Ceiling(temp);
                        }
                        else
                        {
                            avg = (int)Math.Floor(temp);
                        }
                    }
                    else //소수점이 아닐 경우
                    {
                        avg = temp;
                    }
                    
                
                }
                else
                {
                    if (temp.ToString().Contains('.'))
                    {
                        string[] t1 = temp.ToString().Split('.');
                        if (5 > int.Parse(t1[1][0].ToString())) // .5 > .3
                        {
                            avg = (int)Math.Floor(temp);
                        }
                        else
                        {
                            avg = (int)Math.Ceiling(temp);
                        }
                    }
                    else
                    {
                        avg = temp;
                    }
                    
                }
            }
            
            middle = arr[idx / 2];

            range = Math.Abs(max - min);
            
            Console.WriteLine(avg);
            Console.WriteLine(middle);
            Console.WriteLine(highest);
            Console.WriteLine(range);

        }
    }
}