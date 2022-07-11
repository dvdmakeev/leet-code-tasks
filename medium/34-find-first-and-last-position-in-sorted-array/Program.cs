public class Solution 
{
    public int[] SearchRange(int[] nums, int target) 
    {
        int[] bounds = new int[2];
        bounds[0] = -1;
        bounds[1] = -1;
        
        int start = 0;
        int end = nums.Length - 1;
        while (start <= end)
        {
            int middle = start + (end - start) / 2;
            if (nums[middle] < target)
            {
                start = middle + 1;
            }
            else if (nums[middle] > target)
            {
                end = middle - 1;
            }
            else
            {
                bounds[0] = middle;
                bounds[1] = middle;
                break;
            }
        }

        if (bounds[0] != -1 && bounds[1] != -1)
        {
            int lower = bounds[0];
            while (lower > 0 && nums[lower - 1] == target)
            {
                --lower;
                bounds[0] = lower;
            }
            
            int higher = bounds[1];
            while (higher < nums.Length - 1 && nums[higher + 1] == target)
            {
                ++higher;
                bounds[1] = higher;
            }
        }
        
        return bounds;
    }
}
