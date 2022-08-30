public class Solution 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {
        Array.Sort(nums);
        
        int currentClosest = int.MaxValue;
        for (int i = 0; i < nums.Length; ++i)
        {
            int start = i + 1;
            int end = nums.Length - 1;
            
            while (start < end)
            {
                int current = nums[i] + nums[start] + nums[end];
                int currentDiff = Math.Abs(current - target);
                
                if (currentDiff < Math.Abs(currentClosest - target))
                {
                    currentClosest = current;
                }
                
                if (current < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
        }
        
        return currentClosest;
    }
}
