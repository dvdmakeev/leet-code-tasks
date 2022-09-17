public class Solution 
{
    public int ArraySign(int[] nums) 
    {
        int sign = 1;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 0)
            {
                return 0;
            }
            
            if (nums[i] < 0)
            {
                sign = -sign;
            }
        }
        
        return sign;
    }
}
