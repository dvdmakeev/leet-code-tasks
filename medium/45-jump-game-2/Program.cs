public class Solution 
{
    private int JumpRec(int[] nums, int currentPos, Dictionary<int, int> memo) 
    {        
        if (currentPos >= nums.Length - 1)
        {
            return 0;
        }
        if (nums[currentPos] == 0)
        {
            return -1;
        }
        
        if (memo.ContainsKey(currentPos))
        {
            return memo[currentPos];
        }
        
        int minJump = -1;
        for (int i = 1; i <= nums[currentPos]; ++i)
        {
            int canJump = JumpRec(nums, currentPos + i, memo);
            if (canJump >= 0)
            {
                if (minJump == -1)
                {
                    minJump = canJump + 1;
                }
                else
                {
                    minJump = Math.Min(minJump, canJump + 1);
                }
            }
        }
        
        memo[currentPos] = minJump;
        
        return minJump;
        
    }
    
    public int Jump(int[] nums) 
    {
        var memo = new Dictionary<int, int>();
        int res = JumpRec(nums, 0, memo);
        
        return res;
    }
}
