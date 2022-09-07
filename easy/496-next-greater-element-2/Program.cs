public class Solution 
{
    // 5 3 1 2 4 6
    // 6 4 2 4 6 -1
    //
    // 5
    //
    //
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        var greaterElements = new int[nums1.Length];
        var stack = new Stack<int>();
        
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums1.Length; ++i)
        {
            map[nums1[i]] = i;
        }
        
        for (int i = 0; i < nums2.Length; ++i)
        {
            while (stack.Count > 0 && nums2[stack.Peek()] < nums2[i])
            {
                int lessest = stack.Pop();
                
                if (map.ContainsKey(nums2[lessest]))
                {
                    greaterElements[map[nums2[lessest]]] = nums2[i];
                }
            }
            
            stack.Push(i);
        }
        
        while (stack.Count > 0)
        {
            int lessest = stack.Pop();
                
            if (map.ContainsKey(nums2[lessest]))
            {
                greaterElements[map[nums2[lessest]]] = -1;
            }
        }
        
        return greaterElements;
    }
}
