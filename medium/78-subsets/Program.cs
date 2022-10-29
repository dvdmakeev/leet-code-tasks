public class SolutionBacktrack 
{
    private void SubsetsRec(int[] nums, IList<IList<int>> subsets, List<int> current, int fromI)
    {
        subsets.Add(new List<int>(current));
        
        var newCurrent = new List<int>(current);
        for (int i = fromI; i < nums.Length; ++i)
        {
            newCurrent.Add(nums[i]);
            SubsetsRec(nums, subsets, newCurrent, i + 1);
            newCurrent.RemoveAt(newCurrent.Count - 1);
        }
    }
    
    public IList<IList<int>> Subsets(int[] nums) 
    {
        var subsets = new List<IList<int>>();
        var current = new List<int>();
        
        SubsetsRec(nums, subsets, current, 0);
        
        return subsets;
    }
}

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
