using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace NotePad
{
    class Program
    {
        /*
        체스판은 검은색과 흰색이 번갈아서 칠해져 있어야 한다. 구체적으로, 각 칸이 검은색과 흰색 중 하나로 색칠되어 있고, 변을 공유하는 두 개의 사각형은 다른 색으로 칠해져 있어야 한다. 
        따라서 이 정의를 따르면 체스판을 색칠하는 경우는 두 가지뿐이다. 하나는 맨 왼쪽 위 칸이 흰색인 경우, 하나는 검은색인 경우이다.
        */


        public static void Main(string[] args)
        {
            //B = 0, W = 1;
            string[] inputNum = Console.ReadLine().Split();

            int n = int.Parse(inputNum[0]);
            int m = int.Parse(inputNum[1]);

            int[,] chess = new int[n, m];
            int[,] dir = { { 0, 1 }, { 1, 0 } };
            bool[,] check = new bool[n, m];


            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == 'B')
                    {
                        chess[i, j] = 0; //b
                    }
                    else
                    {
                        chess[i, j] = 1; //w
                    }
                }
            }

            //0,0이랑 8,8을 확인해서 둘이 다르면 0,0을 8,8과 똑같은걸로 바꿔줌
            //같으면 다음거를 바꿔줌.
            checkChess(chess, n, m);
        }

        static void checkChess(int[,] chess, int n, int m)
        {
            int[,] check = new int[n, m];
            int row = 8, col = 8;
            int result = Int32.MaxValue;

            while (row != n + 1)
            {
                while (col != m + 1) //열을 먼저 끝까지 검사
                {
                    int rowIdx = row - 8;
                    int colIdx = col - 8;
                    int resultTemp = 0; //변수 초기화


                    if (rowIdx + 7 < row && colIdx + 7 < col) // 8*8을 넘어가는지 확인
                    {

                        for (int first = 0; first < 2; first++) //번갈아 칠하는 곳
                        {
                            rowIdx = row - 8;
                            colIdx = col - 8;
                            resultTemp = 0;
                            
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    check[i, j] = chess[i, j];
                                }
                            } //배열 초기화
                            
                            if (first != 0) //왼쪽 가장 위가 검은색일때
                            {
                                if (chess[rowIdx, colIdx] == 0)
                                {
                                    check[rowIdx, colIdx] = 1;
                                    resultTemp++;
                                }
                                else
                                {
                                    check[rowIdx, colIdx] = 0;
                                    resultTemp++;
                                }
                            }

                            for (rowIdx = row - 8; rowIdx < row; rowIdx++)
                            {
                                for (colIdx = col - 8; colIdx < col; colIdx++)
                                {
                                    //다른 색이면 다음단계 진행
                                    int dirIdx = 0;
                                    int current = check[rowIdx, colIdx];
                                    while (dirIdx != 2)
                                    {
                                        if (dirIdx == 0)
                                        {
                                            if (colIdx + 1 < col)
                                            {
                                                if (current == check[rowIdx + 0, colIdx + 1]) //오른쪽 색이 같다면
                                                {
                                                    resultTemp++;
                                                    if (current == 1)
                                                    {
                                                        check[rowIdx + 0, colIdx + 1] = 0;
                                                    }
                                                    else
                                                    {
                                                        check[rowIdx + 0, colIdx + 1] = 1;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (rowIdx + 1 < row)
                                            {
                                                if (current == check[rowIdx + 1, colIdx + 0]) //아래 색이 같다면
                                                {
                                                    resultTemp++;
                                                    if (current == 1)
                                                    {
                                                        check[rowIdx + 1, colIdx + 0] = 0;
                                                    }
                                                    else
                                                    {
                                                        check[rowIdx + 1, colIdx + 0] = 1;
                                                    }
                                                }
                                            }
                                        }

                                        dirIdx++;
                                    }
                                }
                            }
                            if (result > resultTemp)
                            {
                                result = resultTemp;
                            }
                        }
                    }
                    col++;
                }

                col = 8;
                row++;
            }

            Console.WriteLine(result);
        }
    }
}