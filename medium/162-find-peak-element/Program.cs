public class Solution 
{
    
    // 1,2,1,3,5,6,4
    public int FindPeakElement(int[] nums) 
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int middle = (right - left) / 2 + left;
            
            if (middle > 0 && middle < nums.Length - 1 && nums[middle - 1] < nums[middle] && nums[middle] > nums[middle + 1])
            {
                return middle;
            }
            
            if (middle < nums.Length - 1 && nums[middle] < nums[middle + 1])
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        
        return left;
    }
}
