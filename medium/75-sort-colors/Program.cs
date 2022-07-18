public class Solution 
{
    // 2 0 2 1 1 0
    //
    private void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    
    private void PrintArray(int[] nums)
    {
        Console.WriteLine(string.Join(",", nums));
    }
    
    public void SortColors(int[] nums) 
    {
        int zeroes = 0;
        int twoes = nums.Length - 1;
        int i = 0;
        
        while (i <= twoes)
        {
            while (zeroes < nums.Length && nums[zeroes] == 0)
            {
                ++zeroes;
            }
            while (twoes >= 0 && nums[twoes] == 2)
            {
                --twoes;
            }
            if (zeroes > i)
            {
                i = zeroes;   
            }

            Console.WriteLine(i);
            if (i > twoes)
            {
                break;
            }
            
            if (nums[i] == 0)
            {
                Swap(nums, i, zeroes);
                ++zeroes;
            }
            else if (nums[i] == 2 && i <= twoes)
            {
                Swap(nums, i, twoes);
                --twoes;
            }
            else 
            {
                ++i;
            }
        }
    }
}
