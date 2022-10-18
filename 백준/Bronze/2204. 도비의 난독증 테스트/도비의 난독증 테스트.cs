using System;
using System.Collections.Generic;

namespace NotePad.BaekJoon
{
    public class BJ2204
    {
        public static void Main(string[] args)
        {
            int num = 1;

            while (num != 0)
            {
                string t = Console.ReadLine();

                List<string> list = new List<string>();
                List<string> tempList = new List<string>();
                
                if (int.TryParse(t, out num))
                {
                    if (num == 0)
                    {
                        return;
                    }
                    for (int i = 0; i < num; i++)
                    {
                        string temp = Console.ReadLine();
                        list.Add(temp);
                        tempList.Add(temp.ToLower());
                    }
                }
                
                tempList.Sort();

                string first = tempList[0];
                
                for (int i = 0; i < list.Count; i++)
                {
                    if (first.Equals(list[i], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(list[i]);
                        break;
                    }
                }
            }
        } 
    }
}