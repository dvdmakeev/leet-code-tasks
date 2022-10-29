public class Solution 
{    
    public IList<IList<int>> SubsetsWithDup(int[] nums) 
    {
        var subsets = new List<IList<int>>();
        subsets.Add(new List<int>());
        Array.Sort(nums);
        
        int subsetSize = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            int startFrom = 0;
            if (i > 0 && nums[i] == nums[i - 1])
            {
                startFrom = subsetSize;
            }
            
            subsetSize = subsets.Count;
            for (int j = startFrom; j < subsetSize; ++j)
            {
                var newSubset = new List<int>(subsets[j]);
                newSubset.Add(nums[i]);
                
                subsets.Add(newSubset);
            }
        }
        
        return subsets;
    }
}
