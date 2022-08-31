public class Solution 
{
    public int NumSubarrayProductLessThanK(int[] nums, int k) 
    {
        int start = 0;
        int product = 1;
        int subarraysCount = 0;
        for (int end = 0; end < nums.Length; ++end)
        {
            product *= nums[end];
            while (product >= k && start < end)
            {
                product /= nums[start];
                start += 1;
            }
            
            if (product < k)
            {
                subarraysCount += end - start + 1;
            }
        }
        
        return subarraysCount;
    }
}
