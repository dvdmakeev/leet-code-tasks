public class Solution 
{
    private bool CanJumpRec(int[] nums, int currentPos, Dictionary<int, bool> memo)
    {
        if (currentPos >= nums.Length - 1)
        {
            return true;
        }
        
        if (memo.ContainsKey(currentPos))
        {
            return memo[currentPos];
        }
        
        if (nums[currentPos] == 0)
        {
            return false;
        }
        
        bool canJump = false;
        for(int i = 1; i <= nums[currentPos]; ++i)
        {
            canJump = canJump || CanJumpRec(nums, currentPos + i, memo);
            if (canJump)
            {
                break;
            }
        }
        
        memo[currentPos] = canJump;
        
        return canJump;
    }
    
    public bool CanJump(int[] nums) 
    {
        var memo = new Dictionary<int, bool>();
        return CanJumpRec(nums, 0, memo);
    }
}
