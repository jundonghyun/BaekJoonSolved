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
                } //범위를 구하기 위해서 최대값과 최소값을 판별하는 곳
                
                int count = 1;

                if (dict.ContainsKey(arr[i])) //키가 있을경우
                {
                    avg += arr[i];
                    count = dict[arr[i]];
                    dict[arr[i]] = ++count; //키가 있다면 중복되는 값이 있다는 것이므로 딕셔너리 안에 이미 값이 있으므로 중복값의 count를 늘려줌
                    
                    if (maxCount <= count)
                    {
                        maxCount = count; //최대 빈도수를 갱신
                    }
                    continue;
                }
                avg += arr[i]; //키가 딕셔너리 안에 없을경우 새로 넣어줌
                dict.Add(arr[i], count);
            }

            foreach (var i in dict) // 딕셔너리의 값을 value(count)만 빼서 리스트에 넣고 정렬하면 오름차순으로 정렬됨
            {
                if (i.Value == maxCount)
                {
                    list.Add(i.Key);
                }
            }
            list.Sort();
            
            Array.Sort(arr);

            double temp = avg / idx; // 산술평균을 구하는곳
            
            if (maxCount == 1) //겹치는게 없음
            {
                if (idx == 1) //겹치는게 없고 입력된 값자체가 한개일때
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
                else //겹치는건 없지만 입력된 값이 여러개일때 ex)1, 2, 3, 4
                {
                    highest = list[1]; //리스트정렬을 통해 오름차순으로 정렬되어 있으므로 문제에서준 조건인 최빈값이 여러개라면 두번째로 작은 값이므로 리스트의 두번째 값을 가져옴
                }
                if (temp < 0) //평균값이 음수라면
                {
                    if (temp.ToString().Contains('.')) //평균값이 소수점이라면
                    {
                        string[] t1 = temp.ToString().Split('.'); //소수점 앞뒤로 나눔 (소수점 뒷자리 첫번째 자리만 사용할 것)
                        if (5 > int.Parse(t1[1][0].ToString())) // .5 > .3 ex) -4.123에서 .으로 split한것중 첫번째값 1이 5보다 작으면 버림해야함.
                        {
                            avg = (int)Math.Ceiling(temp); //소수점 아래 올림 ex)-4.31일때 값이 -4가 나와야함
                        }
                        else
                        {
                            avg = (int)Math.Floor(temp); //5보다 크다면 버림 ex)-4.59일때 값이 -5가 나와야함.
                        }
                    }
                    else //평균값이 소수점이 아니라면 그 자체가 평균이됨
                    {
                        avg = temp;
                    }
                
                }
                else //평균값이 음수가 아니라면
                {
                    if (temp.ToString().Contains('.'))
                    {
                        string[] t1 = temp.ToString().Split('.');
                        if (5 > int.Parse(t1[1][0].ToString())) // .5 > .3 
                        {
                            avg = (int)Math.Floor(temp); //ex) 1.4라면 1로 버림해야함
                        }
                        else
                        {
                            avg = (int)Math.Ceiling(temp); //ex) 1.6이면 2로 올림해야함
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