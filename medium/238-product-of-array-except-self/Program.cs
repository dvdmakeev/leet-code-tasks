public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] leftProducts = new int[nums.Length];
        int[] rightProducts = new int[nums.Length];
        
        for (int i = 0; i < leftProducts.Length; ++i)
        {
            if (i > 0)
            {
                leftProducts[i] = leftProducts[i - 1] * nums[i - 1]; 
            }
            else
            {
                leftProducts[i] = 1;
            }
        }
        
        for (int i = rightProducts.Length - 1; i >= 0; --i)
        {
            if (i < rightProducts.Length - 1)
            {
                rightProducts[i] = rightProducts[i + 1] * nums[i + 1]; 
            }
            else
            {
                rightProducts[i] = 1;
            }
        }
        
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; ++i)
        {
            result[i] = leftProducts[i] * rightProducts[i];
        }
            
        return result;   
    }
}
