public class Solution 
{
    /*
        1 1 0 1           -> 3
        0 1 1 1 0 1 1 0 1 -> 5
        1 1 1             -> 2

        окно w = [i, j] : w содержит max один 0

        1. while CanExtendWindow -> extend
        2. calc size - 1
        3.
        4. repeat
    */
    public int LongestSubarray(int[] nums) 
    {
        int i = 0;
        int longestSubarray = 0;
        int zeroCount = 0;
        for (int j = 0; j < nums.Length; ++j)
        {
            if (nums[j] == 0)
            {
                ++zeroCount;

                while (i < nums.Length && zeroCount > 1)
                {
                    if (nums[i] == 0)
                    {
                        --zeroCount;
                    }

                    ++i;
                }
            }

            longestSubarray = Math.Max(j - i, longestSubarray);
        }

        return longestSubarray;
    }
}
