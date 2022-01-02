public class MyQueue 
{
	private Stack<int> mainStack = new Stack<int>();
	private Stack<int> auxiliaryStack = new Stack<int>();

    public MyQueue() 
	{
        
    }
    
    public void Push(int x) 
	{
        mainStack.Push(x);
    }
    
    public int Pop() 
	{
        if (auxiliaryStack.Count == 0)
        {
            while(mainStack.Count > 0)
		    {
			    int item = mainStack.Pop();
			    auxiliaryStack.Push(item);
		    }
        }
		
		int result = auxiliaryStack.Pop();
		
		return result;
    }
    
    public int Peek() 
	{
        if (auxiliaryStack.Count == 0)
        {
            while(mainStack.Count > 0)
		    {
			    int item = mainStack.Pop();
			    auxiliaryStack.Push(item);
		    }
        }
		
		int result = auxiliaryStack.Peek();
		
		return result;  
    }
    
    public bool Empty() 
	{
        return auxiliaryStack.Count == 0 && mainStack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */