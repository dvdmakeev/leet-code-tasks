public class Solution 
{
    // 3 0 1 1 0 2
    // 3 3 4 5 5 7
    // 3
    public int SubarraySum(int[] nums, int k) 
    {
        var prefixes = new Dictionary<int, int>();
        int sum = 0;
        int subarraysCount = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];

            if (prefixes.ContainsKey(sum - k))
            {
                subarraysCount += prefixes[sum - k];
            }
            
            if (sum == k)
            {
                subarraysCount++;
            }
            
            if (!prefixes.ContainsKey(sum))
            {
                prefixes[sum] = 0;
            }
            
            prefixes[sum]++;
        }
        
        return subarraysCount;
    }
}
