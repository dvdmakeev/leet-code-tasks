public class Solution 
{
    public int PeakIndexInMountainArray(int[] arr) 
    {
        int peak = 1;
        for (int i = 0; i < arr.Length - 1; ++i)
        {
            if (arr[i + 1] > arr[i])
            {
                peak = i + 1;
            }
            else
            {
                break;
            }
        }
        
        return peak;
    }
}