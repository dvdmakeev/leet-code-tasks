public class Solution 
{
    private class Elem
    {
        public int val;
        public int i;
        
        public Elem(int i, int val)
        {
            this.i = i;
            this.val = val;
        }
    }
    
    public int LargestRectangleArea(int[] heights) 
    {
        int currentLargest = 0;
        var stack = new Stack<Elem>();
        for (int i = 0; i < heights.Length; ++i)
        {    
            int j = i;
            int prevVal = heights[i];
            while (stack.Count > 0 && stack.Peek().val >= heights[i])
            {
                var prev = stack.Pop();
                j = prev.i;
                prevVal = prev.val;
                
                currentLargest = Math.Max(
                    heights[i],
                    Math.Max(prevVal * (i - j), currentLargest));
            }
            

            stack.Push(new Elem(j, heights[i]));
        }
        
        while (stack.Count > 0)
        {
            var prevElem = stack.Pop();
            currentLargest = Math.Max(prevElem.val * (heights.Length - prevElem.i), currentLargest);
        }
        
        return currentLargest;
    }
}
