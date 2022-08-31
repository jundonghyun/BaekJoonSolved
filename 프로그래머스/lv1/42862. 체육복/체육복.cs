using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
       int answer = 0;
        int total = n;

        Array.Sort(lost);
        Array.Sort(reserve);

        List<int> lostList = lost.ToList();
        List<int> reserveList = reserve.ToList();

        lostList.Sort();
        reserveList.Sort();

        // for (int i = 0; i <= lostList.Count; i++)
        // {
        //     if (reserveList.Contains(lostList[i]))
        //     {
        //         int idx = reserveList.IndexOf(lostList[i]);
        //         reserveList.RemoveAt(idx);
        //         lostList.RemoveAt(i);
        //     }
        // }

        bool[] check = new bool[n + 1];

        for (int i = 0; i < reserveList.Count; i++)
        {
            check[reserveList[i]] = true;
        }


        for (int i = 0; i < lostList.Count; i++)
        {
            if (reserveList.Contains(lostList[i]))
            {
                int idx = reserveList.IndexOf(lostList[i]);
                check[lostList[i]] = false;
                // reserveList.RemoveAt(idx);
                // lostList.RemoveAt(i);
            }
        }


        for (int i = 0; i < lostList.Count; i++)
        {
            if(reserveList.Contains(lostList[i]))
            {
                continue;
            }
            if (lostList[i] - 1 > 0 && check[lostList[i] - 1]) //왼쪽에 있을때
            {
                check[lostList[i] - 1] = false;
                continue;
            }

            if (lostList[i] + 1 <= total && check[lostList[i] + 1]) //오른쪽에 있을때
            {
                check[lostList[i] + 1] = false;
                continue;
            }

            n--;
        }

        answer = n;

        return answer;
    }
}