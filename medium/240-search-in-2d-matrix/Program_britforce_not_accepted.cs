public class Solution 
{
    // X
    //
    // (i, j)
    // All arr[m, n] >= x
    // m >= i and n >= j
    //
    // 9
    //
    // M x N matrix
    // N Log M
    // M Log N
    //
    // [1, 3, 6, 7, 8, 9, 10]
    // target = 3
    //  
    //
    //
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        for (int i = 0; i < matrix.Length; ++i)
        {
            int start = 0;
            int end = matrix[0].Length - 1;
            while (start < end)
            {
                int middleIndex = (end - start) / 2;                
                if (matrix[i][middleIndex] < target)
                {
                    start = middleIndex + 1;
                }
                else if (matrix[i][middleIndex] > target)
                {
                    end = middleIndex;
                }
                else
                {
                    return true;
                }
            }
        }
        
        return false;
    }
}
