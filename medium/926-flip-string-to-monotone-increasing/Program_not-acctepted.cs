public class Solution 
{
    public int MinFlipsMonoIncr(string s) 
    {
        var memo = new Dictionary<string, int>();
        return MinFlipsMonoIncrRec(s, 0, '0', memo);
    }
    
    private int MinFlipsMonoIncrRec(string s, int i, char last, Dictionary<string, int> memo)
    {
        string key = i.ToString() + last;
        if (memo.ContainsKey(key))
        {
            return memo[key];
        }
        
        if (i >= s.Length)
        {
            return 0;
        }
        
        List<int> results = new List<int>();
        if (last == '0' && s[i] == '0')
        {
            int localRes = MinFlipsMonoIncrRec(s, i + 1, s[i], memo);
            results.Add(localRes);
        }
        
        if (last == '0' && s[i] == '1')
        {
            int localRes = MinFlipsMonoIncrRec(s, i + 1, s[i], memo);
            results.Add(localRes);
            
            localRes = 1 + MinFlipsMonoIncrRec(s, i + 1, '0', memo);
            results.Add(localRes);
        }
        
        if (last == '1' && s[i] == '1')
        {
            int localRes = MinFlipsMonoIncrRec(s, i + 1, s[i], memo);
            results.Add(localRes);
        }
        
        if (last == '1' && s[i] == '0')
        {
            int localRes = 1 + MinFlipsMonoIncrRec(s, i + 1, '1', memo);
            results.Add(localRes);
        }
        
        int res = results.Min();
        memo[key] = res;
        
        return res;
    }
}

