public class Solution {
    public string ReverseOnlyLetters(string s) 
    {
        var chars = s.ToCharArray();
        
        int i = 0;
        int j = chars.Length - 1;
        while (i < j)
        {
            if (!char.IsLetter(chars[i]))
            {
                ++i;
                continue;
            }
            
            if (!char.IsLetter(chars[j]))
            {
                --j;
                continue;
            }
            
            char tmp = chars[i];
            chars[i] = chars[j];
            chars[j] = tmp;
            
            ++i;
            --j;
        }
        
        return new string(chars);
    }
}

