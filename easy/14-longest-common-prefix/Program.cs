public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return string.Empty;
        }
        
        int minLength = int.MaxValue;
        for (int i = 0; i < strs.Length; ++i)
        {
            if (strs[i].Length < minLength)
            {
                minLength = strs[i].Length;
            }
        }
        
        var res = new StringBuilder();
        for (int i = 0; i < minLength; ++i)
        {
            char? curChar = null;
            for (int j = 0; j < strs.Length; ++j)
            {
                if (curChar == null)
                {
                    curChar = strs[j][i];
                }
                else if (curChar.Value != strs[j][i])
                {
                    return res.ToString();
                }
            }
            res.Append(curChar.Value);
        }
        
        return res.ToString();
    }
}