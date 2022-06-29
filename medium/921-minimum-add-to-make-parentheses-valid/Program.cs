public class Solution 
{
    // ())(
    
    public int MinAddToMakeValid(string s) 
    {
        int orphanRights = 0;
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '(')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    ++orphanRights;
                }
            }
        }
        
        return stack.Count + orphanRights;
    }
}

