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
        15 6668
        16 6669
        17 7666 or 66660 // 첫번째자리에 +1 한것과 마지막자리에 +1 한것을 비교
        18 8666
        19 9666
        */


        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string current = "666";
            int cnt = 0;
            int temp = int.Parse(current);

            while (true)
            {
                if (temp.ToString().Contains("666"))
                {
                    cnt++;
                }
                
                if (cnt == input)
                {
                    break;
                }

                temp++;

            }
            
            Console.WriteLine(temp);

        }
    }
}