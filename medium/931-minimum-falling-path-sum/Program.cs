public class Solution 
{
    public int MinFallingPathSum(int[][] matrix) 
    {
        int[][] memo = new int[matrix.Length][];
        for (int i = 0; i < memo.Length; ++i)
        {
            memo[i] = new int[matrix[i].Length];
            for (int j = 0; j < memo[i].Length; ++j)
            {
                memo[i][j] = int.MaxValue;
            }
        }
        
        int res = int.MaxValue;
        for (int i = 0; i < matrix[0].Length; ++i)
        {
            int localRes = MinFallingPathSumRec(matrix, 0, i, memo);
            if (res > localRes)
            {
                res = localRes;
            }
        }
        return res;
    }
    
    private int MinFallingPathSumRec(int[][] matrix, int i, int j, int[][] memo)
    {
        if (i >= matrix.Length)
        {
            return 0;
        }
        if (memo[i][j] != int.MaxValue)
        {
            return memo[i][j];
        }
        
        var res = int.MaxValue;
        if (j >= 0 && j < matrix[i].Length)
        {
            res = Math.Min(res, matrix[i][j] + MinFallingPathSumRec(matrix, i + 1, j, memo));
        }
        
        if (j + 1 >= 0 && j + 1 < matrix[i].Length)
        {
            res = Math.Min(res, matrix[i][j] + MinFallingPathSumRec(matrix, i + 1, j + 1, memo));
        }
        
        if (j - 1 >= 0 && j - 1 < matrix[i].Length)
        {
            res = Math.Min(res, matrix[i][j] + MinFallingPathSumRec(matrix, i + 1, j - 1, memo));
        }
        
        memo[i][j] = res;
        
        return res;
    }
}

