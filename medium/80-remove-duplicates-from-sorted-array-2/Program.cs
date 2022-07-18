public class Solution 
{
    // 1 1 1 2 2 3 3 3 3 3 3 4
    // 1 1 2 2 3 3 4
    // 7
    public int RemoveDuplicates(int[] nums) 
    {
        int lastDuplicatenessIndex = 0;
        int duplicateCount = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (i > 0)
            {
                if (nums[i] == nums[i - 1])
                {
                    ++duplicateCount;
                }
                else
                {
                    duplicateCount = 0;
                }
            }
            
            if (duplicateCount < 2)
            {
                nums[lastDuplicatenessIndex++] = nums[i];
                continue;
            }
            
        }
        
        return lastDuplicatenessIndex;
    }
}
