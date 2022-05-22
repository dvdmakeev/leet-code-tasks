public class MinStack 
{
    private class StackNode
    {
        public int value;
        public int minValue;
    }
    
    private Stack<StackNode> stack = new Stack<StackNode>();

    public MinStack() {
        
    }
    
    public void Push(int val) 
    {
        var node = new StackNode();
        node.value = val;
        if (stack.Count > 0)
        {
            node.minValue = Math.Min(stack.Peek().minValue, val);
        }
        else
        {
            node.minValue = val;
        }
        
        stack.Push(node);
    }
    
    public void Pop() 
    {
        stack.Pop();
    }
    
    public int Top() 
    {
        return stack.Peek().value;
    }
    
    public int GetMin() 
    {
        return stack.Peek().minValue;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */