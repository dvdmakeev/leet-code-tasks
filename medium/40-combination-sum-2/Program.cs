public class Solution 
{
    private void CombinationSum2Rec(int[] candidates, int target, IList<IList<int>> combinations, List<int> current, int fromI) 
    {
        if (target < 0)
        {
            return;
        }
        
        if (target == 0)
        {
            combinations.Add(new List<int>(current));
            return;
        }
        
        var newCurrent = new List<int>(current);
        for (int i = fromI; i < candidates.Length; ++i)
        {
            if (i > fromI && candidates[i - 1] == candidates[i])
            {
                continue;
            }
            
            newCurrent.Add(candidates[i]);
            CombinationSum2Rec(candidates, target - candidates[i], combinations, newCurrent, i + 1);
            
            newCurrent.RemoveAt(newCurrent.Count - 1);
        }
    }
        
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) 
    {
        Array.Sort(candidates);
        
        var combinations = new List<IList<int>>();
        var current = new List<int>();
        
        CombinationSum2Rec(candidates, target, combinations, current, 0);
        
        return combinations;
    }
}
