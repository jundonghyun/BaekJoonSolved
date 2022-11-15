using System;
using System.Collections.Generic;
using System.Text;

namespace NotePad.BaekJoon
{
    public class BJ10828
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            List<int> stack = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();

                if (temp.Length > 1) //push 들어왔을때
                {
                    stack.Add(int.Parse(temp[1]));
                }
                else
                {
                    switch (temp[0])
                    {
                        case "top":
                            if (stack.Count == 0)
                            {
                                sb.Append("-1" + "\n");
                            }
                            else
                            {
                                sb.Append(stack[stack.Count - 1] + "\n");
                            }

                            break;
                        
                        case "size":
                            sb.Append(stack.Count + "\n");
                            break;
                        
                        case "pop":
                            if (stack.Count == 0)
                            {
                                sb.Append("-1" + "\n");
                            }
                            else
                            {
                                sb.Append(stack[stack.Count - 1] + "\n");
                                stack.RemoveAt(stack.Count - 1);
                            }
                            break;
                        
                        case "empty":
                            if (stack.Count == 0) sb.Append(1 + "\n");
                            else sb.Append(0 + "\n");
                            break;
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}