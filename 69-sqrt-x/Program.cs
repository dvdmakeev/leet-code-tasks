public class Solution 
{
    public int MySqrt(int x) 
    {
        if (x < 2)
        {
            return x;
        }
        
        int a = 0;
        int b = x / 2;

        while (a <= b)
        {
            int c = (a + b) / 2;
            
            long cSqr = (long)c * c;
            if (cSqr < x)
            {
                a = c + 1;
            }
            else if (cSqr > x)
            {
                b = c - 1;
            }
            else
            {
                return c;
            }
        }
        
        return b;
    }
}

