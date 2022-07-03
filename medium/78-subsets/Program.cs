public class Solution 
{
    public IList<IList<int>> Subsets(int[] nums) 
    {
        var subsets = new List<IList<int>>();
        
        subsets.Add(new List<int>());
        for (int i = 0; i < nums.Length; ++i)
        {
            var subsetsLength = subsets.Count;
            
            for (int j = 0; j < subsetsLength; ++j)
            {
                var newSubset = new List<int>(subsets[j]);
                newSubset.Add(nums[i]);
                
                subsets.Add(newSubset);
            }
        }
        
        return subsets;
    }
}
