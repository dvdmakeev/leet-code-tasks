public class Solution 
{
    private int FindStartIndex(int[] nums)
    {
        int minIndex = 0;
        
        for (int i = 1; i < nums.Length; ++i)
        {
            if (Math.Abs(nums[minIndex]) > Math.Abs(nums[i]))
            {
                minIndex = i;
            }
        }
        
        return minIndex;
    }

    public int[] SortedSquares(int[] nums) 
    {
        int[] result = new int[nums.Length];
        int k = 0;
        
        int startIndex = FindStartIndex(nums);
        
        int i = startIndex;
        int j = startIndex - 1;
        while (i < nums.Length || j >= 0)
        {
            if (j < 0)
            {
                result[k++] = nums[i] * nums[i];
                ++i;
                continue;
            }
            if (i > nums.Length - 1)
            {
                result[k++] = nums[j] * nums[j];
                --j;
                continue;
            }
            
            if (Math.Abs(nums[i]) < Math.Abs(nums[j]))
            {
                result[k++] = nums[i] * nums[i];
                ++i;
                continue;
            }
            else
            {
                result[k++] = nums[j] * nums[j];
                --j;
                continue;
            }
        }
        
        return result;
    }
}
