public class Solution 
{    
    public int[] NextGreaterElements(int[] nums) 
    {
        var result = new int[nums.Length];
        for (int i = 0; i < result.Length; ++i)
        {
            result[i] = -1;
        }
        
        var stack = new Stack<int>();
        for (int i = 0; i < 2 * nums.Length; ++i)
        {
            while (stack.Count > 0 && nums[stack.Peek()] < nums[i % nums.Length])
            {
                result[stack.Pop()] = nums[i % nums.Length];
            }
            
            stack.Push(i % nums.Length);
        }
        
        return result;
    }
}
