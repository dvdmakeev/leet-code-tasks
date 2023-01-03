public class Solution 
{
    public IList<int> FindDuplicates(int[] nums) 
    {
        int i = 0;
        while (i < nums.Length)
        {
            int j = nums[i] - 1;
            if (nums[i] != nums[j])
            {
                int temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
            }
            else
            {
                ++i;
            }
        }

        var result = new List<int>();
        for (i = 0; i < nums.Length; ++i)
        {
            if (nums[i] - 1 != i)
            {
                result.Add(nums[i]);
            }
        }

        return result;
    }
}
