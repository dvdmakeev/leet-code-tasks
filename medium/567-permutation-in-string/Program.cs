public class Solution 
{
    // 
    // ab 
    // eidbaoo
    //
    // char[26] [ 1, 1, 0, .., 0 ]
    // char[26] [ 1, 1, 2, 4, 0, 1, 1, ..., 0 ]
    //
    // 
    public bool CheckInclusion(string s1, string s2) 
    {
        int windowLength = s1.Length;
        int[] windowChars = new int[26];
        int[] patternChars = new int[26];
        for (int i = 0; i <= s2.Length - windowLength; ++i)
        {
            if (i == 0)
            {
                for (int j = 0; j < windowLength; ++j)
                {
                    windowChars[s2[j] - 'a']++;
                    patternChars[s1[j] - 'a']++;
                }
            }
            else
            {
                windowChars[s2[i - 1] - 'a']--;
                windowChars[s2[i + windowLength - 1] - 'a']++;
            }

            bool isMatch = true;
            for (int j = 0; j < 26; ++j)
            {
                if (windowChars[j] != patternChars[j])
                {
                    isMatch = false;
                    break;
                }
            }
            
            if (isMatch)
            {
                return true;
            }
        }
        
        return false;
    }
}
