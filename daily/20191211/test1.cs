public class Solution
{
    public long solution(int a, int b)
    {
        int min = System.Math.Min(a,b);
        int max = System.Math.Max(a,b);
        long answer = 0;
        for ( int i = min; i <= max; i++ )
        {
            answer += i;
        }
        return answer;
    }
}