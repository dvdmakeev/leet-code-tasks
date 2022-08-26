public class Solution 
{
    public int MinSubArrayLen(int target, int[] nums) 
    {
        int i = 0;
        int minLength = 0;
        int currentSum = 0;

        for (int j = 0; j < nums.Length; ++j)
        {
            currentSum += nums[j];
            
            while (currentSum - nums[i] >= target && i < j)
            {
                currentSum -= nums[i];
                ++i;
            }

            if (currentSum >= target)
            {
                if (minLength > 0)
                {
                    minLength = Math.Min(j - i + 1, minLength);
                }
                else
                {
                    minLength = j - i + 1;
                }
            }
        }
        
        return minLength;
    }
}
