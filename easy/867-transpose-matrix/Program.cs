public class Solution 
{
    public int[][] Transpose(int[][] matrix) 
    {
        int[][] transposed = new int[matrix[0].Length][];
        for (int i = 0; i < transposed.Length; ++i)
        {
            transposed[i] = new int[matrix.Length];
        }
        
        for (int i = 0; i < matrix.Length; ++i)
        {
            for (int j = 0; j < matrix[i].Length; ++j)
            {
                transposed[j][i] = matrix[i][j];
            }
        }
        
        return transposed;
    }
}