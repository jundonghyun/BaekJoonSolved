using System;
using System.Collections.Generic;

public class Solution {
        private static int[] y = { 1, 1, 0, -1, -1}; // 3,4,6,7
        private static int[] x = { 0, 1, 1, 1, 0};
    
    public int[] solution(string[,] places) {
        int[] answer;
            bool[,] check = new bool[places.GetLength(0), places.GetLength(1)];
            bool isContinue = false;
            char[,] place = new char[5, 5];

            List<int> list = new List<int>();

            int idx = 0;

            while (idx < places.GetLength(1))
            {
                isContinue = false;
                for (int l = 0; l < place.GetLength(0); l++)
                {
                    for (int k = 0; k < place.GetLength(1); k++)
                    {
                        char[] temp = places[idx, k].ToCharArray();
                        for (int j = 0; j < place.GetLength(1); j++)
                        {
                            place[k, j] = temp[j];
                        }
                    }

                    for (int i = 0; i < place.GetLength(0); i++)
                    {
                        for (int j = 0; j < place.GetLength(1); j++)
                        {
                            if (place[i, j] == 'P') //사람만 찾기
                            {
                                check[i, j] = true;
                                int dir = 0;
                                List<int> xCount = new List<int>();
                                while (dir < 4)
                                {
                                    int dirX = i + x[dir];
                                    int dirY = j + y[dir];
                                    char previous = '0';
                                    if (dirX < 5 && dirY < 5 && dirX > -1 && dirY > -1)
                                    {
                                        char current = place[dirX, dirY]; // 앞 아래가 x인지 확인해야함
                                        if (current == 'O') //칸막이 없으니깐 같은방향으로 한번 더가기
                                        {
                                            int dirX2 = dirX + x[dir];
                                            int dirY2 = dirY + y[dir];
                                            
                                            if (dirX2 < 5 && dirY2 < 5 && dirX2 > -1 && dirY2 > -1)
                                            {
                                                char current2 = place[dirX2, dirY2];

                                                if (current2 == 'P')
                                                {
                                                    if (dir == 1) //4시방향 P
                                                    {
                                                        if (place[dirX + x[0], dirY + y[0]] != 'X'
                                                            && place[dirX + x[2], dirY + y[2]] != 'X')
                                                        {
                                                            isContinue = true;
                                                            break;
                                                        }
                                                    }

                                                    else if (dir == 3)
                                                    {
                                                        if (place[dirX + x[2], dirY + y[0]] != 'X'
                                                            && place[dirX + x[4], dirY + y[4]] != 'X')
                                                        {
                                                            isContinue = true;
                                                            break;
                                                        } 
                                                    }
                                                    else
                                                    {
                                                        isContinue = true;
                                                        break;
                                                    }
                                                } 
                                            }
                                        }

                                        if (current == 'P')
                                        {
                                            if (dir == 1) //4시방향 P
                                            {
                                                if (place[dirX - 1, dirY] == 'X'
                                                    && place[dirX, dirY - 1] == 'X')
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    isContinue = true;
                                                    break;
                                                }
                                            }

                                            else if (dir == 3)
                                            {
                                                if (place[dirX, dirY + 1] == 'X'
                                                    && place[dirX - 1, dirY] == 'X')
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    isContinue = true;
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                isContinue = true;
                                                break; 
                                            }
                                        }

                                        if (isContinue)
                                        {
                                            break;
                                        }
                                    }

                                    dir++;
                                }
                            }
                            if (isContinue)
                            {
                                break;
                            }
                        }

                        if (isContinue)
                        {
                            break;
                        }
                    }
                    if (isContinue)
                    {
                        break;
                    }
                }

                if (!isContinue)
                {
                    list.Add(1);
                }
                else
                {
                    list.Add(0);
                }

                idx++;
            }


            answer = list.ToArray();

            return answer;
    }
}