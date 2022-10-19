public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int sum = 0;
        int actualSum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += i + 1;
            actualSum += nums[i];
        }
        
        return sum - actualSum;
    }
}
