public class Solution 
{
    /*
        -4 -2 1 3 10
    */
    public int[] SortedSquares(int[] nums) 
    {
        int i = 0;
        int j = nums.Length - 1;
        
        int[] sortedSquares = new int[nums.Length];
        for (int k = nums.Length - 1; k >= 0; --k)
        {
            int candidate;
            if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                candidate = nums[i++];
            }
            else
            {
                candidate = nums[j--];
            }

            sortedSquares[k] = candidate * candidate;
        }

        return sortedSquares;
    }
}
