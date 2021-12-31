public class Solution 
{
    public int[] GetModifiedArray(int length, int[][] updates) 
    {
        int[] arr = new int[length];
        for (int i = 0; i < updates.Length; ++i)
        {
            arr[updates[i][0]] += updates[i][2];
            int end = updates[i][1] + 1;
            if (end < arr.Length)
            {
                arr[end] -= updates[i][2];
            }
        }
        
        for (int i = 1; i < arr.Length; ++i)
        {
            arr[i] += arr[i - 1];
        }
        
        return arr;
    }
}