public class Solution 
{
    // 1 1 2 1    Sum 3
    // 
    // 
    // 
    private int FindTargetSumWaysRec(int[] nums, int target, int i, int currentSum, Dictionary<int, Dictionary<int, int>> memo)
    {
        if (memo.ContainsKey(i) && memo[i].ContainsKey(currentSum))
        {
            return memo[i][currentSum];
        }
        
        if (i >= nums.Length)
        {
            if (currentSum == target)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        int res1 = FindTargetSumWaysRec(nums, target, i + 1, currentSum + nums[i], memo);
        int res2 = FindTargetSumWaysRec(nums, target, i + 1, currentSum - nums[i], memo);
        
        if (!memo.ContainsKey(i))
        {
            memo[i] = new Dictionary<int, int>();
        }
        memo[i][currentSum] = res1 + res2;
        
        return res1 + res2;
    }
    
    public int FindTargetSumWays(int[] nums, int target) 
    {
        var memo = new Dictionary<int, Dictionary<int, int>>();
        var res = FindTargetSumWaysRec(nums, target, 0, 0, memo);
                
        return res;
    }
}
