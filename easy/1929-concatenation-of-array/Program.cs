public class Solution 
{
    public int[] GetConcatenation(int[] nums) 
	{
        var concatenated = new int[nums.Length * 2];
        
        for (int i = 0; i < concatenated.Length; ++i)
        {
            concatenated[i] = nums[i % nums.Length];
        }
        
        return concatenated;
    }
}