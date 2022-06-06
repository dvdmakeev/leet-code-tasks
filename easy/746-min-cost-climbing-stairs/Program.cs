public class Solution {
    public int MinCostClimbingStairs(int[] cost) 
    {
        var memo = new int?[cost.Length + 1];
        return FindAllCostRec(cost, -1, memo);
    }
    
    private int FindAllCostRec(int[] cost, int n, int?[] memo)
    {   
        if (n >= cost.Length)
        {
            return 0;
        }
        
        if (memo[n + 1] != null)
        {
            return memo[n + 1].Value;
        }
        
        int curCost = n >= 0 ? cost[n] : 0;
        int fst = curCost + FindAllCostRec(cost, n + 1, memo);
        int snd = curCost + FindAllCostRec(cost, n + 2, memo);
        
        int result = Math.Min(fst, snd);
        
        memo[n + 1] = result;
        
        return result;
    }
}
