/*
    -1 0 1 0 5 4 0
    -1 1 5 4 0 0 0

*/

public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int i = 0;
        while (i < nums.Length && nums[i] != 0)
        {
            ++i;
        }

        for (int j = i + 1; j < nums.Length; ++j)
        {
            if (nums[j] != 0)
            {
                nums[i] = nums[j];
                ++i;
            }
        }

        while (i < nums.Length)
        {
            nums[i] = 0;
            ++i;
        }
    }
}
