public class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
        var uniqueNums = new HashSet<int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (uniqueNums.Contains(nums[i]))
            {
                return true;
            }
            
            uniqueNums.Add(nums[i]);
        }
        
        return false;
    }
}