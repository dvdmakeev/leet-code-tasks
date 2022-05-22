public class Solution 
{
    private void Backtracking(int[] nums, int length, int fixedN, IList<IList<int>> result)
    {
        if (fixedN == length)
        {
            result.Add(nums.ToList());
            return;
        }
        
        for (int i = fixedN; i < length; ++i)
        {
            Swap(nums, i, fixedN);
            
            Backtracking(nums, length, fixedN + 1, result);
            
            Swap(nums, i, fixedN);
        }
    }
    
    private void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    
    public IList<IList<int>> Permute(int[] nums) 
    {
        var result = new List<IList<int>>();
        
        Backtracking(nums, nums.Length, 0, result);
        
        return result;
    }
}