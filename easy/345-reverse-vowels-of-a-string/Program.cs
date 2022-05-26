public class Solution 
{
    public string ReverseVowels(string s) 
    {
        const string vowels = "aeiouAEIOU";
        
        int i = 0;
        int j = s.Length - 1;
        var reversed = new char[s.Length];
        while (i <= j)
        {
            if (!vowels.Contains(s[i]))
            {
                reversed[i] = s[i];
                ++i;
                continue;
            }
            if (!vowels.Contains(s[j]))
            {
                reversed[j] = s[j];
                --j;
                continue;
            }
            
            reversed[i] = s[j];
            reversed[j] = s[i];
            
            ++i;
            --j;
        }
        
        return new string(reversed);
    }
}

