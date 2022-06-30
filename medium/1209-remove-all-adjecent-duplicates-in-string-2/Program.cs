public class Solution 
{
    public string RemoveDuplicates(string s, int k) 
    {
        var stack = new Stack<Tuple<char, int>>();
        
        for (int i = 0; i < s.Length; ++i)
        {
            var current = s[i];
            
            if (stack.Count > 0 && stack.Peek().Item1 == current)
            {
                var item = stack.Pop();
                
                if (item.Item2 < k - 1)
                {
                    var newItem = new Tuple<char, int>(item.Item1, item.Item2 + 1);
                    stack.Push(newItem);    
                }
            }
            else
            {
                stack.Push(new Tuple<char, int>(current, 1));
            }
        }
        
        var result = new StringBuilder();
        while (stack.Count > 0)
        {
            var item = stack.Pop();
            result.Insert(0, new string(item.Item1, item.Item2));
        }
        
        return result.ToString();
    }
}

