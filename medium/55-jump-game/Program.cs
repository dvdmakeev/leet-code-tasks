public class Solution 
{
    public bool CanJump(int[] nums) 
    {
        int lastPos = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; --i)
        {
            if (nums[i] + i >= lastPos)
            {
                lastPos = i;
            }
        }
        
        return lastPos == 0;
    }
}