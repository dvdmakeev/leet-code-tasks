public class Solution 
{
    public int GetMaximumGenerated(int n) 
    {
        int[] array = new int[n + 1];
        int max = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (i == 0)
            {
                array[i] = 0;
            }
            else if (i == 1)
            {
                array[i] = 1;
            }
            else if (i % 2 == 0)
            {
                array[i] = array[i / 2];
            }
            else
            {
                array[i] = array[i / 2] + array[i / 2 + 1];
            }
            
            max = Math.Max(max, array[i]);
        }
        
        return max;
    }
}

