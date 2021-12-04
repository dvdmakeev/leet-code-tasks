public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        int i = 0;
        int j = s.Length - 1;
        while (i < j)
        {
            if (IsDelimiter(s[i]))
            {
                ++i;
                continue;
            }
            if (IsDelimiter(s[j]))
            {
                --j;
                continue;
            }
            if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }
            
            ++i;
            --j;
        }
        
        return true;
    }
    
    private bool IsDelimiter(char c)
    {
        return !char.IsLetterOrDigit(c);
    }
}