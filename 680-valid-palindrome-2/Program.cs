public class Solution 
{
    public bool ValidPalindrome(string s) 
    {
        int i = 0;
        int j = s.Length - 1;
        
        while (i < j)
        {
            if (s[i] == s[j])
            {
                ++i;
                --j;
            }
            else
            {
                return IsPalindromicSubstring(s, i + 1, j) ||
                    IsPalindromicSubstring(s, i, j - 1);
            }
        }
        
        return true;
    }
    
    private bool IsPalindromicSubstring(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j])
            {
                return false;
            }
            
            ++i;
            --j;
        }
        
        return true;
    }
}