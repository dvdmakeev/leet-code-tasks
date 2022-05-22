public class Solution 
{
    public int[] SumZero(int n) 
    {
        var result = new List<int>();
        if (n % 2 == 1)
        {
            result.Add(0);
        }
        
        for (int i = 1; i <= n / 2; ++i)
        {
            result.Add(i);
            result.Add(-1 * i);
        }
        
        return result.ToArray();
    }
}