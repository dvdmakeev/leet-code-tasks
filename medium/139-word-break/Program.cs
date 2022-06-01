public class Solution 
{
    public bool WordBreak(string s, IList<string> wordDict) 
    {
        var memo = new Dictionary<string, bool>();
        
        return WordBreakRec(s, wordDict, memo);
    }
    
    private bool WordBreakRec(string s, IList<string> wordDict, Dictionary<string, bool> memo)
    {
        if (memo.ContainsKey(s))
        {
            return memo[s];
        }
        
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }
        
        foreach (var word in wordDict)
        {
            if (s.IndexOf(word) == 0 && WordBreakRec(s.Substring(word.Length), wordDict, memo))
            {
                memo[s] = true;
                return true;
            }
        }
        
        memo[s] = false;
        return false;
    }
}

