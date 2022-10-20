using System;

namespace NotePad.BaekJoon
{
    public class BJ1769
    {
        public static void Main(string[] args)
        {
            string temp = Console.ReadLine();

            int count = 0;
            
            while (temp.Length > 1)
            {
                int num = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    num += temp[i] - '0';
                }

                temp = num.ToString();
                count++;
            }

            string result = "";

            switch (temp)
            {
                case "3":
                    result = "YES";
                    break;
                case "6":
                    result = "YES";
                    break;
                case "9":
                    result = "YES";
                    break;
                default:
                    result = "NO";
                    break;
            }
            
            Console.WriteLine(count);
            Console.WriteLine(result);
        }
    }
}