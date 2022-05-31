public class Solution 
{
    public int MinPathSum(int[][] grid) 
    {
        int?[][] memo = new int?[grid.Length][];
        for (int i = 0; i < memo.Length; ++i)
        {
            memo[i] = new int?[grid[i].Length];
        }
        
        return MinPathSumRec(grid, 0, 0, memo).Value;
    }
    
    private int? MinPathSumRec(int[][] grid, int i, int j, int?[][] memo)
    {
        if (memo[i][j].HasValue)
        {
            return memo[i][j];
        }
        
        if (i == grid.Length - 1 && j == grid[i].Length - 1)
        {
            return grid[i][j];
        }
        
        int? down = null;
        if (i + 1 < grid.Length)
        {
            int? recRes = MinPathSumRec(grid, i + 1, j, memo);
            if (recRes.HasValue)
            {
                down = grid[i][j] + recRes.Value;
            }
        }
        
        int? right = null;
        if (j + 1 < grid[i].Length)
        {
            int? recRes = MinPathSumRec(grid, i, j + 1, memo);
            if (recRes.HasValue)
            {
                right = grid[i][j] + recRes.Value;   
            }
        }
        
        if (down == null && right == null)
        {
            return null;
        }
        
        int result;
        if (down == null)
        {
            result = right.Value;
        }
        else if (right == null)
        {
            result = down.Value;
        }
        else
        {
            result = Math.Min(right.Value, down.Value);
        }
        
        memo[i][j] = result;
        
        return result;
    }
}

