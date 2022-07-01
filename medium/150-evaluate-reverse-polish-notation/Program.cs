public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        var stack = new Stack<string>();
        
        foreach (var token in tokens)
        {
            if (IsOperation(token))
            {
                var b = stack.Pop();
                var a = stack.Pop();
                
                var c = Evaluate(a, b, token);
                stack.Push(c);
            }
            else
            {
                stack.Push(token);
            }
        }
        
        return int.Parse(stack.Pop());
    }

    private string Evaluate(string a, string b, string op)
    {
        int aVal = int.Parse(a);
        int bVal = int.Parse(b);
        
        int result = 0;
        switch (op)
        {
            case "+":
                result = aVal + bVal;
                break;
            case "-":
                result = aVal - bVal;
                break;
            case "*":
                result = aVal * bVal;
                break;
            case "/":
                result = aVal / bVal;
                break;
            default:
                throw new Exception();
        }
        
        return result.ToString();
    }
    
    private bool IsOperation(string token)
    {
        return token == "+" || 
           token == "-" ||
           token == "*" ||
           token == "/";
    }
}
