public class Solution 
{
    public string MinRemoveToMakeValid(string s) 
    {
        var stack = new Stack<int>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else if (s[i] == ')')
            {
                if (stack.Count > 0 && s[stack.Peek()] == '(')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(i);
                }
            }
        }
        
        var result = new StringBuilder();
        var toRemove = stack.ToList();
        for (int i = 0; i < s.Length; ++i)
        {
            if (!toRemove.Contains(i))
            {
                result.Append(s[i]);
            }
        }
        
        return result.ToString();
    }
}

