public class Solution 
{
    public int LengthOfLongestSubstringKDistinct(string s, int k) 
    {
        int start = 0;
        int longestLength = 0;
        
        var chars = new Dictionary<char, int>();
        for (int end = start; end < s.Length; ++end)
        {
            if (!chars.ContainsKey(s[end]))
            {
                chars[s[end]] = 0;
            }
            
            ++chars[s[end]];
            
            while (chars.Values.Count() > k)
            {
                if (chars[s[start]] > 1)
                {
                    chars[s[start]]--;
                }
                else
                {
                    chars.Remove(s[start]);
                }
                
                ++start;
            }
            
            longestLength = Math.Max(longestLength, end - start + 1);
        }
        
        return longestLength;
    }
}
