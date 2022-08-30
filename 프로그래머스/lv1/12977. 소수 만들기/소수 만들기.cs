using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int temp = nums[i] + nums[j] + nums[k];
                    int count = 0;
                    for (int t = 1; t <= temp; t++)
                    {
                        if (count > 2)
                        {
                            break;
                        }
                        if (temp % t == 0)
                        {
                            count++;
                        }
                    }

                    if (count == 2)
                    {
                        answer++;
                    }
                }
            }
        }
        
        
    return answer;
    }
}