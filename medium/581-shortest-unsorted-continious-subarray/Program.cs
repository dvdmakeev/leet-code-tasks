public class Solution 
{
    public int FindUnsortedSubarray(int[] nums) 
    {
        int left = 0;
        while (left < nums.Length - 1 && nums[left] <= nums[left + 1])
        {
            ++left;
        }

        if (left == nums.Length - 1)
        {
            return 0;
        }

        int right = nums.Length - 1;
        while (right > 0 && nums[right] >= nums[right - 1])
        {
            --right;
        }

        int min = nums[left];
        int max = nums[left];
        for (int i = left; i <= right; ++i)
        {
            min = Math.Min(nums[i], min);
            max = Math.Max(nums[i], max);
        }

        while (left > 0)
        {
            if (nums[left - 1] <= min)
            {
                break;
            }

            --left;
        }

        while (right < nums.Length - 1)
        {
            if (nums[right + 1] >= max)
            {
                break;
            }

            ++right;
        }

        return right - left + 1;
    }
}
