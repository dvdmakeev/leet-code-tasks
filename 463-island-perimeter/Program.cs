public class Solution 
{
    public int IslandPerimeter(int[][] grid) 
    {
        int perimeter = 0;
        int[] rootLand = FindFirstLandCell(grid);
        if (rootLand == null)
        {
            return perimeter;
        }
        
        var landsToVisit = new Queue<int[]>();
        landsToVisit.Enqueue(rootLand);
        MarkAsVisited(grid, rootLand);
        while(landsToVisit.Count > 0)
        {
            var visitedLand = landsToVisit.Dequeue();
            var neighbours = new List<int[]>();
            int neighbourLands = 0;
            foreach (var neighbour in GetNeighbours(grid, visitedLand))
            {
                if (grid[neighbour[0]][neighbour[1]] != 0)
                {
                    ++neighbourLands;
                }
                if (grid[neighbour[0]][neighbour[1]] == 1)
                {
                    MarkAsVisited(grid, neighbour);
                    neighbours.Add(neighbour);
                }
            }
            perimeter += 4 - neighbourLands;
            foreach (var neighbour in neighbours)
            {
                landsToVisit.Enqueue(neighbour);
            }
        }
        
        return perimeter;
    }
    
    private int[] FindFirstLandCell(int[][] grid)
    {
        for (int i = 0; i < grid.Length; ++i)
        {
            for (int j = 0; j < grid[i].Length; ++j)
            {
                if (grid[i][j] == 1)
                {
                    return new int[] { i, j };
                }
            }
        }
        
        return null;
    }
    
    private void MarkAsVisited(int[][] grid, int[] cell)
    {
        grid[cell[0]][cell[1]] = 2;
    }
    
    private List<int[]> GetNeighbours(int[][] grid, int[] cell)
    {
        var neighbours = new List<int[]>();
        int i = cell[0];
        int j = cell[1];
        
        if (i - 1 >= 0)
        {
            neighbours.Add(new int[] { i - 1, j });
        }
        if (j - 1 >= 0)
        {
            neighbours.Add(new int[] { i, j - 1 });
        }
        if (i + 1 < grid.Length)
        {
            neighbours.Add(new int[] { i + 1, j });
        }
        if (j + 1 < grid[i].Length)
        {
            neighbours.Add(new int[] { i, j + 1 });
        }
        
        return neighbours;
    }
}