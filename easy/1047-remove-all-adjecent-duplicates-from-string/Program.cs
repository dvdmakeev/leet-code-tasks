public class Solution 
{
    public string RemoveDuplicates(string s) 
    {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; ++i)
        {
            char current = s[i];
            if (stack.Count > 0 && stack.Peek() == current)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(current);
            }
        }
        
        var res = new StringBuilder();
        while (stack.Count > 0)
        {
            res.Insert(0, stack.Pop());
        }
        return res.ToString();
    }
}

