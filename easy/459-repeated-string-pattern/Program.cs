public class Solution 
{
    public bool RepeatedSubstringPattern(string s) 
    {
        for (int i = 0; i < s.Length / 2; ++i)
        {
            if (IsRepeatedSubstringPattern(s, s.Substring(0, i + 1)))
            {
                return true;
            }
        }
        
        return false;
    }
    
    private bool IsRepeatedSubstringPattern(string s, string substring)
    {
        if (s.Length % substring.Length > 0)
        {
            return false;
        }
        
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] != substring[i % substring.Length])
            {
                return false;
            }
        }
        
        return true;
    }
}