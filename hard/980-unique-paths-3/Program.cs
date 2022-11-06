public class Solution 
{
    private int UniquePathsIIIRec(
        int[][] grid, 
        int emptySquaresCount, 
        int i, 
        int j, 
        int currentEmptySquaresCount,
        bool[][] visited)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == -1 || visited[i][j])
        {
            return 0;
        }
        
        if (emptySquaresCount == currentEmptySquaresCount &&
           grid[i][j] == 2)
        {
            return 1;
        }
        
        visited[i][j] = true;
        
        if (grid[i][j] == 0)
        {
            ++currentEmptySquaresCount;
        }
        
        int pathsCount = UniquePathsIIIRec(
            grid, 
            emptySquaresCount, 
            i + 1, 
            j, 
            currentEmptySquaresCount,
            visited);
        pathsCount += UniquePathsIIIRec(
            grid, 
            emptySquaresCount, 
            i - 1, 
            j, 
            currentEmptySquaresCount,
            visited);
        pathsCount += UniquePathsIIIRec(
            grid, 
            emptySquaresCount, 
            i, 
            j + 1, 
            currentEmptySquaresCount,
            visited);
        pathsCount += UniquePathsIIIRec(
            grid, 
            emptySquaresCount, 
            i, 
            j - 1, 
            currentEmptySquaresCount,
            visited);
        
 
        visited[i][j] = false;
        
        return pathsCount;
        
    }
    
    public int UniquePathsIII(int[][] grid)
    {
        bool[][] visited = new bool[grid.Length][];
        for (int i = 0; i < visited.Length; ++i)
        {
            visited[i] = new bool[grid[i].Length];
        }
        
        int emptySquaresCount = 0;

        int startI = 0;
        int startJ = 0;
        
        for (int i = 0; i < grid.Length; ++i)
        {
            for (int j = 0; j < grid[i].Length; ++j)
            {
                if (grid[i][j] == 0)
                {
                    ++emptySquaresCount;
                }
                if (grid[i][j] == 1)
                {
                    startI = i;
                    startJ = j;
                }
            }
        }
        
        return UniquePathsIIIRec(
            grid, 
            emptySquaresCount, 
            startI, 
            startJ, 
            0,
            visited);
    }
}
