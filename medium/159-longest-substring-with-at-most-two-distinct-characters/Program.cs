public class Solution 
{
    public int LengthOfLongestSubstringTwoDistinct(string s) 
    {
        int i = 0;
        
        var chars = new Dictionary<char, int>();
        int longestLength = 0;
        for (int j = 0; j < s.Length; ++j)
        {
            if (!chars.ContainsKey(s[j]))
            {
                chars[s[j]] = 0;
            }
            
            ++chars[s[j]];
            
            while (chars.Values.Where(val => val > 0).Count() > 2 && i <= j)
            {
                --chars[s[i++]];
            }
            
            longestLength = Math.Max(j - i + 1, longestLength);
        }
        
        return longestLength;
    }
}
