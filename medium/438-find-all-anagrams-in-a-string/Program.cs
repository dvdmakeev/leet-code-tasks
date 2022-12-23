public class Solution 
{
    public IList<int> FindAnagrams(string s, string p) 
    {
        var anagrams = new List<int>();
        
        var patternMap = new Dictionary<char, int>();
        int matchCount = 0;
        for (int i = 0; i < p.Length; ++i)
        {
            if (!patternMap.ContainsKey(p[i]))
            {
                patternMap[p[i]] = 0;
                ++matchCount;
            }

            ++patternMap[p[i]];
        }

        int start = 0;
        for (int end = 0; end < s.Length; ++end)
        {
            if (patternMap.ContainsKey(s[end]))
            {
                --patternMap[s[end]];
                if (patternMap[s[end]] == 0)
                {
                    --matchCount;
                }
            }

            if (matchCount == 0)
            {
                anagrams.Add(start);
            }

            if (end - start + 1 >= p.Length)
            {
                if (patternMap.ContainsKey(s[start]))
                {
                    if (patternMap[s[start]] == 0)
                    {
                        ++matchCount;
                    }

                    ++patternMap[s[start]];
                }

                ++start;
            }
        }

        return anagrams;
    }
}
