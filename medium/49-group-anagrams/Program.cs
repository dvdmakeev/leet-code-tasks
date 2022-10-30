public class Solution 
{
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var anagrams = new Dictionary<string, IList<string>>();
        
        for (int i = 0; i < strs.Length; ++i)
        {
            var counts = new int[26];
            
            for (int j = 0; j < strs[i].Length; ++j)
            {
                counts[strs[i][j] - 'a']++;
            }
            
            string key = new string(counts.Select(count => Convert.ToChar(count)).ToArray());
            if (!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
            }
            
            anagrams[key].Add(strs[i]);
        }
        
        return anagrams.Values.ToList();
    }
}
