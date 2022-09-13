public class Solution 
{
    private int MinCostRec(int[][] costs, int i, int lastColor, Dictionary<int, Dictionary<int, int>> memo)
    {
        if (i > costs.Length - 1)
        {
            return 0;
        }
        
        if (memo.ContainsKey(i) && memo[i].ContainsKey(lastColor))
        {
            return memo[i][lastColor];
        }
        
        var curCosts = new List<int>();
        
        if (lastColor != 0)
        {
            int red = costs[i][0] + MinCostRec(costs, i + 1, 0, memo);
            curCosts.Add(red);
        }
        if (lastColor != 1)
        {
            int blue = costs[i][1] + MinCostRec(costs, i + 1, 1, memo);
            curCosts.Add(blue);
        }
        if (lastColor != 2)
        {
            int green = costs[i][2] + MinCostRec(costs, i + 1, 2, memo);
            curCosts.Add(green);
        }
        
        if (!memo.ContainsKey(i))
        {
            memo[i] = new Dictionary<int, int>();
        }
        
        int min = curCosts.Min();
        memo[i][lastColor] = min;
        
        return min;
    }
    
    public int MinCost(int[][] costs)
    {
        var memo = new Dictionary<int, Dictionary<int, int>>();
        return MinCostRec(costs, 0, -1, memo);
    }
}
