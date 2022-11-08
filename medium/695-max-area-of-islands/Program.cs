public class Solution 
{
    private List<int[]> GetValidNeighbours(int i, int j, int[][] grid)
    {
        var neighbours = new List<int[]>();
        
        if (i - 1 >= 0 && grid[i - 1][j] == 1)
        {
            neighbours.Add(new int[] { i - 1, j });
        }
        
        if (j - 1 >= 0 && grid[i][j - 1] == 1)
        {
            neighbours.Add(new int[] { i, j - 1 });
        }
        
        if (i + 1 < grid.Length && grid[i + 1][j] == 1)
        {
            neighbours.Add(new int[] { i + 1, j });
        }
        
        if (j + 1 < grid[0].Length && grid[i][j + 1] == 1)
        {
            neighbours.Add(new int[] { i, j + 1 });
        }
        
        return neighbours;
    }
    
    public int MaxAreaOfIsland(int[][] grid) 
    {
        int maxIsland = 0;
        
        for (int i = 0; i < grid.Length; ++i)
        {
            for (int j = 0; j < grid[i].Length; ++j)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }
                
                int currentIsland = 0;
                var queue = new Queue<int[]>();
                queue.Enqueue(new int[] { i, j });
                while (queue.Count > 0)
                {
                    var layerSize = queue.Count;
                    var currents = new List<int[]>();
                    for (int k = 0; k < layerSize; ++k)
                    {
                        int[] current = queue.Dequeue();
                        if (grid[current[0]][current[1]] == 1)
                        {
                            currents.Add(current);
                            ++currentIsland;
                            grid[current[0]][current[1]] = 0;
                        }
                    }
                    
                    foreach (var current in currents)
                    {
                        var neighbours = GetValidNeighbours(current[0], current[1], grid);
                        foreach (var neighbour in neighbours)
                        {
                            queue.Enqueue(neighbour);
                        }
                    }
                }
                
                maxIsland = Math.Max(currentIsland, maxIsland);
            }
        }
        
        return maxIsland;
    }
}
