using System;

namespace NotePad.BaekJoon
{
    public class BJ19947
    {
        private static double result = 0;
        
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();

            double money = int.Parse(temp[0]);
            int currentYear = int.Parse(temp[1]);
            
            DFS(currentYear, money);
            
            Console.WriteLine(Math.Floor(result));
        }

        static void DFS(int year, double money)
        {
            if (year == 0)
            {
                result = Math.Max(result, money);
                return;
            }
            
            if(year >= 1)
            {
                year -= 1;

                double temp = money * 1.05;
                money = Math.Floor(temp);
                
                DFS(year, money);

                year += 1;

                temp = money / 1.05;
                money = Math.Ceiling(temp);
                
            }
            
            if (year >= 3)
            {
                year -= 3;

                double temp = money * 1.2;
                money = Math.Floor(temp);
                
                DFS(year, money);

                year += 3;

                temp = money / 1.2;
                money = Math.Ceiling(temp);
            }
            if (year >= 5)
            {
                year -= 5;

                double temp = money * 1.35;
                money = Math.Floor(temp);
                
                DFS(year, money);

                year += 5;

                temp = money / 1.35;
                money = Math.Ceiling(temp);
            }
        }
    }
}