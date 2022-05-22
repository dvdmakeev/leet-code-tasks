public class Solution 
{
    public int NumIslands(char[][] grid) 
    {
        int islandNumber = 0;
        int[][] visited = new int[grid.Length][];
        for (int i = 0; i < visited.Length; ++i)
        {
            visited[i] = new int[grid[i].Length];
        }
        
        for (int i = 0; i < grid.Length; ++i)
        {
            for (int j = 0; j < grid[i].Length; ++j)
            {
                if (visited[i][j] == 1)
                {
                    continue;
                }
                
                if (grid[i][j] == '1')
                {
                    ++islandNumber;
                    
                    var queue = new Queue<int[]>();
                    queue.Enqueue(new int[] { i, j });
                    while (queue.Count > 0)
                    {
                        var cell = queue.Dequeue();
                        visited[cell[0]][cell[1]] = 1;
                        if (grid[cell[0]][cell[1]] == '1')
                        {
                            foreach (var neighbour in GetNeighbours(grid, cell))
                            {
                                if (visited[neighbour[0]][neighbour[1]] != 1)
                                {
                                    visited[neighbour[0]][neighbour[1]] = 1;
                                    queue.Enqueue(neighbour);
                                }
                            }
                        }
                    }
                }
            }
        }
        
        return islandNumber;
    }
    
    private IEnumerable<int[]> GetNeighbours(char[][] grid, int[] cell)
    {
        if (cell[0] + 1 < grid.Length)
        {
            yield return new int[] { cell[0] + 1, cell[1] };
        }
        
        if (cell[0] - 1 >= 0)
        {
            yield return new int[] { cell[0] - 1, cell[1] };
        }
        
        if (cell[1] + 1 < grid[0].Length)
        {
            yield return new int[] { cell[0], cell[1] + 1 };
        }
        
        if (cell[1] - 1 >= 0)
        {
            yield return new int[] { cell[0], cell[1] - 1 };
        }
    }
}