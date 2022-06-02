public class Solution 
{
    public IList<string> WordBreak(string s, IList<string> wordDict) 
    {
        var memo = new Dictionary<string, List<string>>();
        return WordBreakRec(s, wordDict, memo);
    }
    
    private IList<string> WordBreakRec(string s, IList<string> wordDict, Dictionary<string, List<string>> memo)
    {
        if (memo.ContainsKey(s))
        {
            return new List<string>(memo[s]);
        }
        
        if (s.Equals(string.Empty))
        {
            return new string[] { string.Empty }.ToList();
        }
        
        var result = new List<string>();
        foreach (var word in wordDict)
        {
            if (s.IndexOf(word) == 0)
            {
                var tails = WordBreakRec(s.Substring(word.Length), wordDict, memo);
                foreach (var tail in tails)
                {
                    if (tail.Equals(string.Empty))
                    {
                        result.Add($"{word}");
                    }
                    else
                    {
                        result.Add($"{word} {tail}");
                    }
                }
            }
        }
        
        memo[s] = new List<string>(result);
        return result;
    }
}

