public class Solution 
{
    // 4 2 1 5 2
    //
    // Find max sum score (arr)
    //
    // SumScore(i) = Max(Sum(arr[m]), Sum(arr[n])): m <= i and n >= i
    //
    // Max (4, 4 + 2 + 1 + 5 + 2)
    // Max (4 + 2, 2 + 1 + 5 + 2)
    // Max (4 + 2 + 1, 1 + 5 + 2)
    // Max (4 + 2 + 1 + 5, 5 + 2)
    // Max (4 + 2 + 1 + 5 + 2, 2)
    public long MaximumSumScore(int[] nums) 
    {
        long sum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
        }
        
        long maxSumScore = long.MinValue;
        
        long currentLeft = nums[0];
        long currentRight = sum;
        
        for (int i = 0; i < nums.Length; ++i)
        {
            if (i == 0)
            {
                currentLeft = nums[0];
                currentRight = sum;
            }
            else
            {
                currentLeft += nums[i];
                currentRight -= nums[i - 1];
            }
            
            maxSumScore = Math.Max(Math.Max(currentLeft, currentRight), maxSumScore);
        }
        
        return maxSumScore;
    }
}
