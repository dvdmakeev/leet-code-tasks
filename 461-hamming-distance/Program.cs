public class Solution 
{
    public int HammingDistance(int x, int y) 
    {
        int diff = x ^ y;
        
        return GetBitCount(diff);
    }
    
    private int GetBitCount(int x)
    {
        int count = 0;
        int mask = 1;
        for (int i = 0; i < 32; ++i)
        {
            if ((mask & x) != 0)
            {
                ++count;
            }
            
            mask = mask << 1;
        }
        return count;
    }
}