public class Solution 
{
    public int Trap(int[] height) 
    {
        int leftMax = 0;
        int rightMax = 0;
        int waterAmount = 0;
        int i = 0;
        int j = height.Length - 1;
        while (i < j)
        {
            if (height[i] < height[j])
            {
                if (height[i] > leftMax)
                {
                    leftMax = height[i];
                }
                waterAmount += leftMax - height[i];
                ++i;
            }
            else
            {
                if (height[j] > rightMax)
                {
                    rightMax = height[j];
                }
                waterAmount += rightMax - height[j];
                --j;
            }
        }
        
        return waterAmount;
    }
}