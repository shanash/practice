public class Solution {
    private long[] LongToArr(long n)
    {
        long[] result = new long[n.ToString().Length];
        
        int index = 0;
        while(n > 0)
        {
            result[index] = n%10;
            n /= 10;
            index++;
        }
        
        return result;
    }
    
    private long ArrToLong(long[] arr)
    {
        long result = 0;
        
        long value = 1;
        foreach (long l in arr)
        {
            result += l * value;
            value *= 10;
        }
        
        return result;
    }
    
    public long solution(long n) {
        long[] arr = LongToArr(n);
        System.Array.Sort(arr);
        long answer = ArrToLong(arr);
        return answer;
    }
}