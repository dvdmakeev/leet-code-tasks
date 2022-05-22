public class Solution 
{
    private bool IsPalindrome(string s, int start, int end)
    {
        while (start <= end)
        {
            if (s[start] != s[end])
            {
                return false;
            }
            
            ++start;
            --end;
        }
        
        return true;
    }
    
    public string LongestPalindrome(string s) 
    {
        string maxPalindrome = string.Empty;
        for (int i = 0; i < s.Length; ++i)
        {
            for (int j = i; j < s.Length; ++j)
            {
                if (IsPalindrome(s, i, j))
                {
                    var candidate = s.Substring(i, j - i + 1);
                    if (candidate.Length > maxPalindrome.Length)
                    {
                        maxPalindrome = candidate;
                    }
                }
            }
        }
        
        return maxPalindrome;
    }
}