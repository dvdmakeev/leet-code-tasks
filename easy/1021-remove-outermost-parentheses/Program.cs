public class Solution 
{
    // ( ( ) ( ) ) ( ( ( ) ) )
    // ( ( ) ( ) ) ( ( ) ) ( ( ) ( ( ) ) )
    public string RemoveOuterParentheses(string s) 
    {
        bool isInOutermost = false;
        int parenthesisCounter = 0;
        var result = new StringBuilder();
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(')
            {
                if (isInOutermost)
                {
                    ++parenthesisCounter;
                    result.Append(s[i]);
                }
                else
                {
                    isInOutermost = true;
                }
            }
            else if (s[i] == ')')
            {
                if (parenthesisCounter > 0)
                {
                    --parenthesisCounter;
                    result.Append(s[i]);
                }
                else
                {
                    isInOutermost = false;
                }
            }
        }
        
        return result.ToString();
    }
}

