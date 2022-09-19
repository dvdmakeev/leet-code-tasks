public class Solution 
{
    /*
       11001011
                XOR
       11111111
                =
       00110100
    
    */
    public int HammingWeight(uint n) 
    {
        int weight = 0;
        
        uint cur = n;
        while (cur != 0)
        {
            if ((cur & 1) == 1)
            {
                ++weight;
            }
            
            cur = cur >> 1;
        }
        
        return weight;
    }
}
