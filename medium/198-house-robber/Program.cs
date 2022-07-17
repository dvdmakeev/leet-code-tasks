public class Solution 
{
    // 7 9 8 2 3
    // 
    // 7 
    private int RobRec(int[] nums, int i, Dictionary<int, int> memo)
    {
        if (i > nums.Length - 1)
        {
            return 0;
        }
        
        if (memo.ContainsKey(i))
        {
            return memo[i];
        }
        
        int currentRob = nums[i] + RobRec(nums, i + 2, memo);
        int nextRob = 0;
        if (i < nums.Length - 1)
        {
            nextRob = nums[i + 1] + RobRec(nums, i + 3, memo);
        }
        
        int result = Math.Max(currentRob, nextRob);
        memo[i] = result;
        
        return result;
    }
    
    public int Rob(int[] nums) 
    {
        var memo = new Dictionary<int, int>();
        return RobRec(nums, 0, memo);
    }
}
