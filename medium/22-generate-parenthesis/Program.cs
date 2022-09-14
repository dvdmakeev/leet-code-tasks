public class Solution 
{
    // ()
    // ()()   (())
    // ((())) ()()() (())() ()(()) (()())
    // 3 3    1 1 1  2   1  1 2    1
    //
    private void GenerateParenthesisRec(int l, int r, StringBuilder current, List<string> parenthesis)
    {
        if (l == 0 && r == 0)
        {
            parenthesis.Add(current.ToString());
            return;
        }

        if (l > 0)
        {
            current.Append('(');
            GenerateParenthesisRec(l - 1, r, current, parenthesis);
            current.Length--;
        }
        
        if (r > l)
        {
            current.Append(')');
            GenerateParenthesisRec(l, r - 1, current, parenthesis);
            current.Length--;
        }
    }
    
    public IList<string> GenerateParenthesis(int n) 
    {
        var parenthesis = new List<string>();
        
        GenerateParenthesisRec(n, n, new StringBuilder(), parenthesis);
        
        return parenthesis;
    }
}
