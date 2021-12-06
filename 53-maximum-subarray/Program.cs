public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int maxSubArraySum = int.MinValue;
        
        int [] dp = new int[nums.Length];
        dp[0] = nums[0];
        maxSubArraySum = dp[0];
        
        for (int i = 1; i < nums.Length; ++i)
        {
            dp[i] = Math.Max(nums[i], dp[i - 1] + nums[i]);
            maxSubArraySum = Math.Max(dp[i], maxSubArraySum);
        }
        
        return maxSubArraySum;
    }
}