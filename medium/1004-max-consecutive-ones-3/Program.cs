public class Solution 
{
    public int LongestOnes(int[] nums, int k) 
    {
        int maxCons = 0;
        int currentCons = 0;
        
        int zeroes = 0;
        int start = 0;
        for (int end = 0; end < nums.Length; ++end)
        {
            if (nums[end] == 1)
            {
                currentCons++;
            }
            else if (nums[end] == 0)
            {
                if (k == 0)
                {
                    currentCons = 0;
                }
                else
                {
                    currentCons++;
                    zeroes++;
                
                    while (zeroes > k && start < end)
                    {
                        if (nums[start] == 0)
                        {
                            zeroes--;
                        }
                    
                        start++;
                        currentCons--;
                    }
                }
            }
            
            maxCons = Math.Max(currentCons, maxCons);
        }
        
        return maxCons;
    }
}
