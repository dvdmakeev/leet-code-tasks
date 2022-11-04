public class Solution 
{
    /*
        aabbdccc
        
    */
    public int Compress(char[] chars) 
    {
        int k = 0;
        
        int currentLength = 0;
        char curChar = 'a';
        for (int i = 0; i < chars.Length; ++i)
        {
            if (currentLength == 0)
            {
                ++currentLength;
                curChar = chars[i];
            }
            else
            {
                if (curChar == chars[i])
                {
                    ++currentLength;
                }
                else
                {
                    chars[k++] = curChar;
                    
                    if (currentLength > 1)
                    {
                        string strLength = Convert.ToString(currentLength);
                        for (int j = 0; j < strLength.Length; ++j)
                        {
                            chars[k++] = strLength[j];
                        }
                    }
                    
                    currentLength = 1;
                    curChar = chars[i];
                }
            }
        }
        
        chars[k++] = curChar;

        if (currentLength > 1)
        {
            string strLength = Convert.ToString(currentLength);
            for (int j = 0; j < strLength.Length; ++j)
            {
                chars[k++] = strLength[j];
            }
        }
        
        return k;
    }
}
