public class Solution 
{
    public int ThreeSumSmaller(int[] nums, int target) 
    {
        Array.Sort(nums);
        
        int triplets = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            int start = i + 1;
            int end = nums.Length - 1;
            while (start < end)
            {
                if (nums[i] + nums[start] + nums[end] < target)
                {
                    triplets += end - start;
                    ++start;
                }
                else
                {
                    --end;
                }
            }
        }
        
        return triplets;
    }
}
