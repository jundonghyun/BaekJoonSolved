using System;

namespace NotePad
{
    class Program
    {
        /*양의 정수가 들어있는 카드 값(1~100,000)
        바닥에 앞면의 n장(3~100개)의 카드 중 3장을 고른다.
        숫자 m(10~300,000)을 넘지 않으면서 m과 최대한 가깝게 만들어야한다.*/


        public static void Main(string[] args)
        {

            /*입력
            5 21
            5 6 7 8 9 */

            /*출력
            첫째 줄에 M을 넘지 않으면서 M에 최대한 가까운 카드 3장의 합을 출력한다.*/
            String[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int max = 0;
            int dif = Int32.MaxValue;
            int result = 0;
            
            int[] arr = new int[n];
            String[] input2 = Console.ReadLine().Split();
            
            
            for (int i = 0; i < input2.Length; i++)
            {
                arr[i] = int.Parse(input2[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    for (int k = j+1; k < arr.Length; k++)
                    {
                        max = arr[i] + arr[j] + arr[k];
                        if (max <= m)
                        {
                            int temp = m - max;

                            if (dif > temp)
                            {
                                dif = temp;
                                result = max;
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine(result);
        }
    }
}

