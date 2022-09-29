using System;

namespace NotePad.BaekJoon
{
    public class BJ9372
    {
        public static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            /*
             * 1 2 3
             * 1 -> 2
             * 2 -> 3
             *
             * 1 2 3 4
             * 1 -> 2
             * 2 -> 3
             * 3 -> 4
             */
            for (int i = 0; i < T; i++)
            {
                int answer = 0;
                string[] temp = Console.ReadLine().Split();

                bool[] country = new bool[int.Parse(temp[0])+1];
                bool[] air = new bool[int.Parse(temp[1])];

                for (int j = 0; j < int.Parse(temp[1]); j++)
                {
                    string[] temp1 = Console.ReadLine().Split();
                    
                }
                Console.WriteLine(int.Parse(temp[0]) - 1);
                
            }
        }
    }
}