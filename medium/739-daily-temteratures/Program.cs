public class Solution 
{
    // 10 1 5 2 4 9 11
    // 6  1 3 1 1 1 0
    
    public int[] DailyTemperatures(int[] temperatures) 
    {
        var stack = new Stack<int>();
        var answers = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length; ++i)
        {
            while (stack.Count > 0)
            {
                int lastIndex = stack.Peek();
                if (temperatures[i] <= temperatures[lastIndex])
                {
                    break;
                }
                
                lastIndex = stack.Pop();
                answers[lastIndex] = i - lastIndex;
            }
            
            stack.Push(i);
        }
        
        return answers;
    }
}

