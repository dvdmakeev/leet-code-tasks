public class Solution 
{
    public int MaxArea(int[] height) 
    {
        int maxWater = 0;
        int i = 0;
        int j = height.Length - 1;
        
        while (i < j)
        {
            int candidate = Math.Min(height[i], height[j]) * (j - i);
            if (candidate > maxWater)
            {
                maxWater = candidate;
            }
            
            if (height[i] < height[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        
        return maxWater;
    }
}