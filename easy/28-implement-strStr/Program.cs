public class Solution 
{
    public int StrStr(string haystack, string needle) 
    {
        if (needle.Length == 0)
        {
            return 0;
        }
        
        for (int i = 0; i < haystack.Length; ++i)
        {
            bool missmatched = false;
            
            for (int j = 0; j < needle.Length; ++j)
            {
                if (i + j >= haystack.Length || haystack[i + j] != needle[j])
                {
                    missmatched = true;
                    break;
                }
            }
            
            if (missmatched)
            {
                continue;
            }
            
            return i;
        }
        
        return -1;
    }
}

