public class Solution 
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid) 
    {
        int[][] memo = new int[obstacleGrid.Length + 1][];
        for (int i = 0; i < obstacleGrid.Length; ++i)
        {
            memo[i] = new int[obstacleGrid[i].Length + 1];
        }
        
        return UniquePathsWithObstaclesRec(obstacleGrid, memo, 0, 0);
    }
    
    private int UniquePathsWithObstaclesRec(int[][] grid, int[][] memo, int m, int n)
    {   
        if (m >= grid.Length || n >= grid[m].Length)
        {
            return 0;
        }
        
        if (grid[m][n] == 1)
        {
            return 0;
        }
        
        if (m == grid.Length - 1 && n == grid[m].Length - 1)
        {
            return 1;
        }

        if (memo[m][n] != 0)
        {
            return memo[m][n];
        }
        
        int paths = 0;
        if (m + 1 < grid.Length && grid[m + 1][n] != 1)
        {
            int bottomPath = UniquePathsWithObstaclesRec(grid, memo, m + 1, n);
            memo[m + 1][n] = bottomPath;
            
            paths += bottomPath;
        }
        
        if (n + 1 < grid[m].Length && grid[m][n + 1] != 1)
        {
            int rightPath = UniquePathsWithObstaclesRec(grid, memo, m, n + 1);
            memo[m][n + 1] = rightPath;
            
            paths += rightPath;
        }
        
        return paths;
    }
}

