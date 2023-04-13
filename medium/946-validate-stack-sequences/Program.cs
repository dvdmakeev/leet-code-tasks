public class Solution 
{
    public bool ValidateStackSequences(int[] pushed, int[] popped) 
    {
        int i = 0;
        int j = 0;

        var stack = new Stack<int>();
        while (i < pushed.Length || j < popped.Length)
        {
            if (stack.Count > 0 && j < popped.Length && popped[j] == stack.Peek())
            {
                stack.Pop();
                ++j;
                continue;
            }
            else if (i < pushed.Length)
            {
                stack.Push(pushed[i]);
                ++i;
                continue;
            }

            return false;
        }

        return true;
    }
}
