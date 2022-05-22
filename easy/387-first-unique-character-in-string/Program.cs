public class Solution 
{
    public int FirstUniqChar(string s) 
    {
        var charCounts = new Dictionary<char, int>();
        
        for (int i = 0; i < s.Length; ++i)
        {
            if (!charCounts.ContainsKey(s[i]))
            {
                charCounts[s[i]] = 0;
            }
            ++charCounts[s[i]];
        }
        
        for (int i = 0; i < s.Length; ++i)
        {
            if (charCounts[s[i]] == 1)
            {
                return i;
            }
        }
        
        return -1;
    }
}