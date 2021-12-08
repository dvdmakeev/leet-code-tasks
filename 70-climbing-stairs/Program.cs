public class Solution 
{
    public int ClimbStairs(int n) 
    {
        if (n == 1)
        {
            return 1;
        }
        if (n == 2)
        {
            return 2;
        }
        
        int prev = 2;
        int prevPrev = 1;
        int res = 0;
        for (int i = 3; i <= n; ++i)
        {
            res = prev + prevPrev;
            prevPrev = prev;
            prev = res;
        }
        
        return res;
    }
}