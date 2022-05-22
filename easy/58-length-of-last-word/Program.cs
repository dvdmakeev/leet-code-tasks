public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        int i = s.Length - 1;
        while (i >= 0 && char.IsWhiteSpace(s[i]))
        {
            --i;
        }
        
        int wordLength = 0;
        while (i >= 0 && char.IsLetter(s[i]))
        {
            --i;
            ++wordLength;
        }
        
        return wordLength;
    }
}