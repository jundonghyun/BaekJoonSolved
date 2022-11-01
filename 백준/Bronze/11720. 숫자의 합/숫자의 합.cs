using System;

namespace Chapter1
{
    class MainClass
    { 
        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();


            var result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result += int.Parse(input[i].ToString());
            }
            
            Console.Write(result);
        }
    }
}
