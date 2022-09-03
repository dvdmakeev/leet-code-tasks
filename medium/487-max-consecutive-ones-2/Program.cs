public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int maxCons = 0;
        int zeroes = 0;
        int currentCons = 0;
        int start = 0;
        for (int end = 0; end < nums.Length; ++end)
        {
            currentCons++;
            
            if (nums[end] == 0)
            {
                zeroes++;
                                
                if (zeroes > 1)
                {
                    while (zeroes > 1 && start < end)
                    {
                        if (nums[start] == 0)
                        {
                            zeroes--;
                        }

                        currentCons--;
                        start++;
                    }
                }
            }
            
            maxCons = Math.Max(currentCons, maxCons);
        }
        
        return maxCons;
    }
}
