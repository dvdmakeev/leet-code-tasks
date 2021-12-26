public class Solution 
{
    public int DiagonalSum(int[][] mat) 
    {
        int mainDiagonalSum = GetMainDiagonalSum(mat);
        int antiDiagonalSum = GetAntiDiagonalSum(mat);
        int sum = mainDiagonalSum + antiDiagonalSum;
        
        if (mat.Length % 2 != 0)
        {
            int middle = mat.Length / 2 + 1 - 1;
            if (mat[0].Length >= middle)
            {
                sum -= mat[middle][middle];
            }
        }
        
        return sum;
    }
    
    private int GetMainDiagonalSum(int[][] mat)
    {
        int sum = 0;
        for (int i = 0; i < mat.Length && i < mat[i].Length; ++i)
        {
            sum += mat[i][i];
        }
        return sum;
    }
    
    private int GetAntiDiagonalSum(int[][] mat)
    {
        int sum = 0;
        for (int i = 0; i < mat.Length && i < mat[i].Length; ++i)
        {
            sum += mat[i][mat[i].Length - i - 1];
        }
        return sum;
    }
}