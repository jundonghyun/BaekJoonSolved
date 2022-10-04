using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};

            int[,] result = new int[n+1, 1000];

            int min = 1;
            int max = n;
            int downIndex = 1;
            bool down = false;
            bool up = false;

            int lastNum = 0;

            for (int i = 0; i <= n; i++)
            {
                lastNum += i;
            }

            int num = 1;

            while (num < lastNum + 1)
            {
                for (int i = downIndex; i <= max; i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        if (result[i,j] == 0)
                        {
                            result[i, j] = num;
                            num++;
                            break;
                        }
                    }
                }

                min++;
                downIndex = max; //다 내려갔으니깐 옆으로갔다가 올라갈준비
                
                for (int i = 0; i < max; i++) //오른쪽으로 이동하는것
                {
                    if (result[max, i] != 0)
                    {
                        continue;
                    }
                    else
                    {
                        result[max, i] = num;
                        num++;
                    }
                }

                max--;

                for (int i = downIndex - 1; i >= min; i--) //위로 올라오기
                {
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (result[i,j] == 0)
                        {
                            result[i, j] = num;
                            num++;
                            break;
                        }
                    }
                }
                
                min++;
                downIndex = min;
                
            }

            List<int> list = new List<int>();

            for (int i = 1; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (result[i, j] == 0)
                    {
                        break;
                    }
                    else
                    {
                        list.Add(result[i,j]);
                    }
                }
            }

            answer = list.ToArray();
            
            return answer;
    }
}