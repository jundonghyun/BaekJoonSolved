using System;

namespace NotePad.BaekJoon
{
    public class BJ5622
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //1 = 2
            //2(ABC) = 3
            //3(DEF) = 4
            //4(GHI) = 5
            //5(JKL) = 6
            //6(MNO) = 7
            //7(PQRS) = 8
            //8(TUV) = 9
            //9(WXYZ) = 10
            //0 = 11;

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'A':
                    case 'B':
                    case 'C':
                        result += 3;
                        break;

                    case 'D':
                    case 'E':
                    case 'F':
                        result += 4;
                        break;

                    case 'G':
                    case 'H':
                    case 'I':
                        result += 5;
                        break;

                    case 'J':
                    case 'K':
                    case 'L':
                        result += 6;
                        break;

                    case 'M':
                    case 'N':
                    case 'O':
                        result += 7;
                        break;

                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                        result += 8;
                        break;

                    case 'T':
                    case 'U':
                    case 'V':
                        result += 9;
                        break;

                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        result += 10;
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}