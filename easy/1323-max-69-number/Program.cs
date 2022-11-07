public class Solution 
{
    public int Maximum69Number (int num) 
    {
        int current = num;
        
        int maxSixDigit = 0;
        int i = 0;
        while (current != 0)
        {
            ++i;
            if (current % 10 == 6)
            {
                maxSixDigit = i;
            }
            
            current = current / 10;
        }
        
        if (maxSixDigit > 0)
        {
            return num + 3 * (int)Math.Pow(10, maxSixDigit - 1);
        }
        
        return num;
    }
}
