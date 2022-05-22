public class Solution 
{
    public int Tribonacci(int n) 
    {
        int t0 = 0;
        if (n == 0)
        {
            return t0; 
        }
        
        int t1 = 1;
        if (n == 1)
        {
            return t1;
        }
        
        int t2 = 1;
        if (n == 2)
        {
            return t2;
        }
        
        int i = 3;
        while (i++ <= n)
        {
            int tmp = t0 + t1 + t2;
            t0 = t1;
            t1 = t2;
            t2 = tmp;
        }
        
        return t2;
    }
}