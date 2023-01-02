public class Solution 
{
    public IList<int> FindDisappearedNumbers(int[] nums) 
    {
        int i = 0;
        while (i < nums.Length)
        {
            int j = nums[i];
            if (nums[j - 1] != nums[i])
            {
                int temp = nums[i];
                nums[i] = nums[j - 1];
                nums[j - 1] = temp;
            }
            else
            {
                ++i;
            }
        }

        var missingNumbers = new List<int>();
        for (i = 0; i < nums.Length; ++i)
        {
            if (nums[i] - 1 != i)
            {
                missingNumbers.Add(i + 1);
            }
        }

        return missingNumbers;
    }
}
