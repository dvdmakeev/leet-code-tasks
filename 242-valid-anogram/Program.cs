public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        int[] alphabet = new int[26];
        for (int i = 0; i < s.Length; ++i)
        {
            ++alphabet[(int)s[i] - 'a'];
        }
        for (int i = 0; i < t.Length; ++i)
        {
            --alphabet[(int)t[i] - 'a'];
        }
        for (int i = 0; i < alphabet.Length; ++i)
        {
            if (alphabet[i] != 0)
            {
                return false;
            }
        }
        
        return true;
    }
}