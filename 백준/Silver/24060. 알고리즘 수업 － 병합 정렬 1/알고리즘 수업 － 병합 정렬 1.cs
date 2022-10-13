using System;

namespace NotePad.BaekJoon
{
    public class BJ24060
    {
        private static int searchNum = 0;
        private static int count = 0;
        private static int result = -1;
        private static int[] tmp = new int[500001];
        
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();

            int n = int.Parse(temp[0]);
            searchNum = int.Parse(temp[1]);

            int[] arr = new int[n];

            temp = Console.ReadLine().Split();
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(temp[i]);
            }
            
            merge_sort(arr, 0, arr.Length - 1);

            Console.WriteLine(result);
        }
        
        static void merge_sort(int[] arr, int start, int end) { //# A[p..r]을 오름차순 정렬한다.
            if (start < end)
            {
                int middle = (int)Math.Floor((double)(start+end) / 2);
                merge_sort(arr, start, middle);      //# 전반부 정렬
                merge_sort(arr, middle+1, end);  //# 후반부 정렬
                merge(arr, start, middle, end);       // # 병합 
            }
        }
        
        static void merge(int[] arr, int start, int middle, int end)
        {
            int i = start;
            int j = middle + 1;
            int t = start;
            
            while (i <= middle && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    tmp[t++] = arr[i++];// # tmp[t] <- A[i]; t++; i++;
                }
                else
                {
                    tmp[t++] = arr[j++]; //# tmp[t] <- A[j]; t++; j++;
                }
            }

            while (i <= middle)
            {
                tmp[t++] = arr[i++]; 
            }  //# 왼쪽 배열 부분이 남은 경우

            while (j <= end)
            {
                tmp[t++] = arr[j++];
            } //# 오른쪽 배열 부분이 남은 경우
            
            
            i = start; 
            t = start;
            while (i <= end)
            {
                count++;
                if (count == searchNum)
                {
                    result = tmp[t];
                }
                arr[i++] = tmp[t++];
            }  //# 결과를 A[p..r]에 저장
        }
    }
}