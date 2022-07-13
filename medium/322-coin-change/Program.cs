public class Solution 
{
    private int CoinChangeRec(int[] coins, int amount, Dictionary<int, int> memo)
    {
        if (amount == 0)
        {
            return 0;
        }
        if (amount < 0)
        {
            return -1;
        }
        
        if (memo.ContainsKey(amount - 1))
        {
            return memo[amount - 1];
        }
        
        int min = int.MaxValue;
        for (int i = 0; i < coins.Length; ++i)
        {
            int res = CoinChangeRec(coins, amount - coins[i], memo);
            if (res >= 0 && min > res)
            {
                min = res + 1;
            }
        }
        
        if (min == int.MaxValue)
        {
            min = -1;
        }
        
        memo[amount - 1] = min;
        
        return min;
    }
    
    public int CoinChange(int[] coins, int amount) 
    {
        var memo = new Dictionary<int, int>();
        return CoinChangeRec(coins, amount, memo);
    }
}
