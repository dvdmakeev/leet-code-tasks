public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        int low = 0;
        int high = nums.Length - 1;
        
        while (low <= high)
        {
            int pivot = (low + high) / 2;
            
            if (nums[pivot] < target)
            {
                low = pivot + 1;
            }
            else if (nums[pivot] > target)
            {
                high = pivot - 1;
            }
            else
            {
                return pivot;
            }
        }
        
        return low;
    }
}

