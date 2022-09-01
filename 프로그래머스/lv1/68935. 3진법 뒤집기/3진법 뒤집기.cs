using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        while(n > 0){
            answer*=3;
            answer+=n%3;
            n/=3;
        }
        
        return answer;
    }
}

/*
45 / 3 = 15
15 / 3 = 5
5 / 3 = 2
1

125 / 3 = 41 - 2
41 / 3 = 13 - 2
13 / 3 = 4 - 1
4 / 3 = 1 -1

1 + 1 * 3 + 1 * 9 + 2 * 27 + 2 * 81
1 + 4 + 9 + 54 + 162
14 + 216 = 230

*/