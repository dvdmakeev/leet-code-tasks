public class Solution 
{
    private int NumberOfWaysRec(int pos, int endPos, int k, Dictionary<string, int> memo)
    {
        int mod = 1000000007;
        
        if (k == 0 && pos == endPos)
        {
            return 1;
        }
        
        if (k == 0 && pos != endPos)
        {
            return 0;
        }
        
        string key = $"{pos};{k}";
        if (memo.ContainsKey(key))
        {
            return memo[key];
        }
        
        int res = (NumberOfWaysRec(pos + 1, endPos, k - 1, memo) + NumberOfWaysRec(pos - 1, endPos, k - 1, memo)) % mod;
        memo[key] = res;
        
        return res;
    }
    
    public int NumberOfWays(int startPos, int endPos, int k) 
    {
        var memo = new Dictionary<string, int>();
        
        return NumberOfWaysRec(startPos, endPos, k, memo);
    }
}
