public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int maxCons = 0;
        int currentCons = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 1)
            {
                currentCons++;
            }
            else
            {
                currentCons = 0;
            }
            
            maxCons = Math.Max(currentCons, maxCons);
        }
        
        return maxCons;
    }
}
