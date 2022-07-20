public class Solution 
{
    public int FindMin(int[] nums) 
    {
        int start = 0;
        int end = nums.Length - 1;
        while (start < end)
        {
            int middle = start + (end - start) / 2;
            if (nums[middle] > nums[nums.Length - 1])
            {
                start = middle + 1;
            }
            else if (middle == 0 || nums[middle] < nums[middle - 1])
            {
                return nums[middle];
            }
            else
            {
                end = middle - 1;
            }
        }
        
        return nums[end];
    }
}
