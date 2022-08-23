using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";

        int[] score = { 3, 2, 1, 0, 1, 2, 3 };

        // int[,] left = {{ 114, 0 }, { 99, 0 }, { 106, 0 }, { 97, 0 }};
        // int[,] right = {{ 116, 0 }, { 102, 0 }, { 109, 0 }, { 110 , 0 }};
        //

        int[] R = new int[1];
        int[] T = new int[1];
        int[] C = new int[1];
        int[] F = new int[1];
        int[] J = new int[1];
        int[] M = new int[1];
        int[] A = new int[1];
        int[] N = new int[1];
        
        for (int i = 0; i < survey.Length; i++)
        {
            string temp = survey[i];
            if (choices[i] < 4) //왼쪽으로 키를 잡아야함
            {
                switch (temp[0])
                {
                    case 'R':
                        R[0] += score[choices[i]-1];
                        break;
                    case 'T':
                        T[0] += score[choices[i]-1];
                        break;
                    case 'C':
                        C[0] += score[choices[i]-1];
                        break;
                    case 'F':
                        F[0] += score[choices[i]-1];
                        break;
                    case 'J':
                        J[0] += score[choices[i]-1];
                        break;
                    case 'M':
                        M[0] += score[choices[i]-1];
                        break;
                    case 'A':
                        A[0] += score[choices[i]-1];
                        break;
                    case 'N':
                        N[0] += score[choices[i]-1];
                        break;
                }
            }
            else
            {
                switch (temp[1])
                {
                    case 'R':
                        R[0] += score[choices[i]-1];
                        break;
                    case 'T':
                        T[0] += score[choices[i]-1];
                        break;
                    case 'C':
                        C[0] += score[choices[i]-1];
                        break;
                    case 'F':
                        F[0] += score[choices[i]-1];
                        break;
                    case 'J':
                        J[0] += score[choices[i]-1];
                        break;
                    case 'M':
                        M[0] += score[choices[i]-1];
                        break;
                    case 'A':
                        A[0] += score[choices[i]-1];
                        break;
                    case 'N':
                        N[0] += score[choices[i]-1];
                        break;
                }
            }
        }

        if (R[0] != T[0])
        {
            if (R[0] > T[0])
            {
                answer += "R";
            }
            else
            {
                answer += "T";
            }
        }
        else
        {
            answer += "R";
        }
        if (C[0] != F[0])
        {
            if (C[0] > F[0])
            {
                answer += "C";
            }
            else
            {
                answer += "F";
            }
        }
        else
        {
            answer += "C";
        }
        
        if (J[0] != M[0])
        {
            if (J[0] > M[0])
            {
                answer += "J";
            }
            else
            {
                answer += "M";
            }
        }
        else
        {
            answer += "J";
        }
        
        if (A[0] != N[0])
        {
            if (A[0] > N[0])
            {
                answer += "A";
            }
            else
            {
                answer += "N";
            }
        }
        else
        {
            answer += "A";
        }


        return answer;
    }
}