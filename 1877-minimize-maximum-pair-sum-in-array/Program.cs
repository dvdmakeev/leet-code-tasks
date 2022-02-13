// Proof
// https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/discuss/1243428/Python-greedy-with-explanation
public class Solution 
{
    public int MinPairSum(int[] nums) 
    {
        Array.Sort(nums);
        
        int maxPairSum = int.MinValue;
        for (int i = 0; i < nums.Length / 2; ++i)
        {
            maxPairSum = Math.Max(nums[i] + nums[nums.Length - 1 - i], maxPairSum);
        }
        
        return maxPairSum;
    }
}