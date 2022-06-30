public class Solution 
{
    public int MaxChunksToSorted(int[] arr) 
    {
        var stack = new Stack<int>();
        for (int i = 0; i < arr.Length; ++i)
        {            
            if (stack.Count == 0 || arr[i] >= stack.Peek())
            {
                stack.Push(arr[i]);
            }
            else
            {
                int newMax = stack.Peek();
                while (stack.Count > 0 && stack.Peek() > arr[i])
                {
                    stack.Pop();
                }
                
                stack.Push(newMax);
            }
        }
        
        return stack.Count;
    }
}
