public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int k = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != val)
            {
                if (k != i)
                {
                    nums[k] = nums[i];
                }
                
                ++k;
            }
        }
        
        return k;
    }
}