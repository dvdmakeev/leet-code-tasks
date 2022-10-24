public class Solution 
{
    private void CombinationSumRec(int[] candidates, int target, IList<IList<int>> combinations, List<int> current, int fromI)
    {
        if (target < 0)
        {
            return;
        }
        
        if (target == 0)
        {
            combinations.Add(new List<int>(current));
        }
        
        var newCurrent = new List<int>(current);
        for (int i = fromI; i < candidates.Length; ++i)
        {
            newCurrent.Add(candidates[i]);
            CombinationSumRec(candidates, target - candidates[i], combinations, newCurrent, i);

            newCurrent.RemoveAt(newCurrent.Count - 1);
        }
    }
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        var combinations = new List<IList<int>>();
        var current = new List<int>();
        
        CombinationSumRec(candidates, target, combinations, current, 0);
        
        return combinations;
    }
}
