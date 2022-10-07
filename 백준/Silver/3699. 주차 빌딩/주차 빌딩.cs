using System;
using System.Collections.Generic;
using System.Linq;

namespace NotePad.BaekJoon
{
    public class BJ3699
    {
        public static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < T; i++)
            {
                int result = 0;
                int num = 1;
                List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>(); 

                string[] temp = Console.ReadLine().Split();

                int[,] arr = new int[int.Parse(temp[0]), int.Parse(temp[1])];

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    temp = Console.ReadLine().Split();

                    for (int k = 0; k < arr.GetLength(1); k++)
                    {
                        arr[j, k] = int.Parse(temp[k]);
                        if (arr[j, k] != -1)
                        {
                            list.Add(new KeyValuePair<int, int>(int.Parse(temp[k]), j));
                        }
                    }
                }//입력끝

                list = list.OrderBy(o => o.Key).ToList();

                while (list.Count != 0)
                {
                    int key = list[0].Key;
                    int floor = list[0].Value;
                    list.RemoveAt(0);

                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[floor, j] == key)
                        {
                            int[] t = new int[arr.GetLength(1)];
                            
                            if (j < arr.GetLength(1) - j) //반시계
                            {
                                if (j == 0)
                                {
                                    result += 1 * 5;
                                    result += (floor * 2) * 10;// 시간더하기
                                }
                                else
                                {
                                    result += j * 5;
                                    result += (floor * 2) * 10;// 시간더하기
                                }
                                

                                if (list.Count == 0)
                                {
                                    break;
                                }
                                t[j] = -1; //더했으니깐 -1로 변경
                                arr[floor, j] = -1; //원래 배열도 -1로 변경
                                
                                for (int k = 0; k < arr.GetLength(1); k++) //배열 반시계로 이동하기
                                {
                                    if (arr[floor, k] != -1)
                                    {
                                        int n = arr[floor, k];
                                        int idx = k;
                                        idx -= j;
                                        if (idx < 0) //반시계로 돌다가 인덱스가 0보다 작아지면 col의 총 크기에서 k를 빼준값을 인덱스로 사용
                                        {
                                            t[arr.GetLength(1) + idx] = n;
                                        }
                                        else
                                        {
                                            t[idx] = n;
                                        }

                                        if (t[k] == 0)
                                        {
                                            t[k] = -1; //위치를 이동했으므로 기존 위치는 -1로 변경

                                        }
                                    }
                                }//새로운 배열을 기존 배열에 복사

                                for (int k = 0; k < arr.GetLength(1); k++)
                                {
                                    arr[floor, k] = t[k];
                                }
                            }
                            else //가운데에 있다면 그냥 시계방향 회전
                            {
                                int currIdx = (arr.GetLength(1) + 1) - j;
                                
                                result += (arr.GetLength(1) - j) * 5;
                                result += (floor * 2) * 10;// 시간더하기

                                if (list.Count == 0)
                                {
                                    break;
                                }
                                t[j] = -1;
                                arr[floor, j] = -1;
                                
                                for (int k = 0; k < arr.GetLength(1); k++) //배열 반시계로 이동하기
                                {
                                    if (arr[floor, k] != -1)
                                    {
                                        int n = arr[floor, k];
                                        int idx = k - 1;
                                        idx += currIdx;
                                        if (idx > arr.GetLength(1)) //반시계로 돌다가 인덱스가 0보다 작아지면 col의 총 크기에서 k를 빼준값을 인덱스로 사용
                                        {
                                            t[idx - arr.GetLength(1)] = n;
                                        }
                                        else if(idx < arr.GetLength(1))
                                        {
                                            t[idx] = n;
                                        }
                                        else
                                        {
                                            idx--;
                                            t[idx] = n;
                                        }

                                        if (t[k] == 0)
                                        {
                                            t[k] = -1; //위치를 이동했으므로 기존 위치는 -1로 변경

                                        }
                                    }
                                }//새로운 배열을 기존 배열에 복사

                                for (int k = 0; k < arr.GetLength(1); k++)
                                {
                                    arr[floor, k] = t[k];
                                }
                            }
                        }
                    }
                }

                Console.WriteLine(result);
                result = 0;
            }
        }
    }
}