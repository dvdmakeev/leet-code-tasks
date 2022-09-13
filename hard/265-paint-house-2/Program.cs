public class Solution 
{
    private int MinCostIIRec(int[][] costs, int i, int lastColor, Dictionary<int, Dictionary<int, int>> memo)
    {
        if (i > costs.Length - 1)
        {
            return 0;
        }
        
        if (memo.ContainsKey(i) && memo[i].ContainsKey(lastColor))
        {
            return memo[i][lastColor];
        }
        
        int minCost = int.MaxValue;
        for (int j = 0; j < costs[i].Length; ++j)
        {
            if (j != lastColor)
            {
                int curCost = costs[i][j] + MinCostIIRec(costs, i + 1, j, memo);
                minCost = Math.Min(curCost, minCost);
            }
        }
        
        if (!memo.ContainsKey(i))
        {
            memo[i] = new Dictionary<int, int>();
        }
        
        memo[i][lastColor] = minCost;
        
        return minCost;
    }
    
    public int MinCostII(int[][] costs) 
    {
        var memo = new Dictionary<int, Dictionary<int, int>>();
        
        return MinCostIIRec(costs, 0, -1, memo);
    }
}
