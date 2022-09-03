public class Solution 
{
    // A F A C A D A B B
    // 2
    // 6
    public int CharacterReplacement(string s, int k) 
    {
        int start = 0;
        var chars = new Dictionary<char, int>();
        
        int longest = 0;
        for (int end = 0; end < s.Length; ++end)
        {
            if (!chars.ContainsKey(s[end]))
            {
                chars[s[end]]= 0;  
            }
            
            ++chars[s[end]];
            
            if (chars.Values.Sum() - chars.Values.Max() > k)
            {
                while (chars.Values.Sum() - chars.Values.Max() > k && start < end)
                {
                    chars[s[start++]]--;
                }
            }
            
            longest = Math.Max(end - start + 1, longest);
        }
        
        return longest;
    }
}
