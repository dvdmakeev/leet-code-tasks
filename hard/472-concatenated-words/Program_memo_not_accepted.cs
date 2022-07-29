public class Solution 
{
    private bool CanBeConcatenated(string word, List<string> dict, Dictionary<string, bool> memo)
    {
        if (word.Length == 0)
        {
            return true;
        }
        
        if (memo.ContainsKey(word))
        {
            return memo[word];
        }
        
        foreach (var s in dict)
        {
            if (word.IndexOf(s) == 0)
            {
                string candidate = word.Substring(s.Length, word.Length - s.Length);
                if (CanBeConcatenated(candidate, dict, memo))
                {
                    return true;
                }
            }
        }
        
        memo[word] = false;
        
        return false;
    }
    
    public IList<string> FindAllConcatenatedWordsInADict(string[] words) 
    {
        var result = new List<string>();
        
        foreach (var word in words)
        {
            var memo = new Dictionary<string, bool>();
            if (CanBeConcatenated(word, words.Except(new string[] { word }).ToList(), memo))
            {
                result.Add(word);
            }
        }
        
        return result;
    }
}
