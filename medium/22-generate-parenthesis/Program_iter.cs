public class Solution 
{
    public class Parenthesis
    {
        public StringBuilder P = new StringBuilder();

        public int L;
        public int R;
    }

    public IList<string> GenerateParenthesis(int n) 
    {
        var parenthesis = new List<string>();
        var queue = new Queue<Parenthesis>();

        queue.Enqueue(new Parenthesis());
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current.L == n && current.R == n)
            {
                parenthesis.Add(current.P.ToString());
                continue;
            }

            if (current.L < n)
            {
                queue.Enqueue(new Parenthesis { L = current.L + 1, R = current.R, P = new StringBuilder(current.P.ToString() + "(") });
            }

            if (current.L > current.R)
            {
                queue.Enqueue(new Parenthesis { L = current.L, R = current.R + 1, P = new StringBuilder(current.P.ToString() + ")") });
            }
        }

        return parenthesis;
    }
}
