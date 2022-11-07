public class Solution 
{
    /*
        3 4 -1 1
        0 1  2 3
        
       1  -1 3 4
        
    */
    public int FirstMissingPositive(int[] nums) 
    {   
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != i + 1)
            {
                int j = nums[i];
                nums[i] = -1;
                
                while (j > 0 && j <= nums.Length && nums[j - 1] != j)
                {
                    int temp = nums[j - 1];
                    nums[j - 1] = j;
                    j = temp;
                }
            }
        }

        int smallest = 1;
        while (smallest <= nums.Length && nums[smallest - 1] == smallest)
        {
            ++smallest;
        }
        
        return smallest;
    }
}
