public class Solution 
{
    // 1 1 2 1,-1,5,-2,3
    // 3
    // 1,-1,5,-2
    //
    public int MaxSubArrayLen(int[] nums, int k) 
    {
        var prefixes = new Dictionary<int, int>();
        int sum = 0;
        int maxLen = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
            
            if (!prefixes.ContainsKey(sum))
            {
                prefixes[sum] = i;
            }
            
            if (prefixes.ContainsKey(sum - k))
            {
                maxLen = Math.Max(i - prefixes[sum - k], maxLen);
            }            
            if (sum == k)
            {
                maxLen = Math.Max(i + 1, maxLen);
            }
            if (nums[i] == k)
            {
                maxLen = Math.Max(1, maxLen);
            }
        }

        return maxLen;
    }
}
