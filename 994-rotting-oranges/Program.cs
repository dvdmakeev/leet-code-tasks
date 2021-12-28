public class Solution 
{
    public int OrangesRotting(int[][] grid) 
    {
        var rottenOranges = new List<int[]>();
        int numberOfOranges = 0;
        for (int i = 0; i < grid.Length; ++i)
        {
            for (int j = 0; j < grid[i].Length; ++j)
            {
                if (grid[i][j] != 0)
                {
                    ++numberOfOranges;
                    
                    if (grid[i][j] == 2)
                    {
                        rottenOranges.Add(new int[] { i, j });
                    }
                }
            }
        }
        
        if (numberOfOranges == rottenOranges.Count)
        {
            return 0;
        }
        
        int rottenOrangesCount = 0;
        int minutesCount = -1;
        while (rottenOranges.Count > 0)
        {
            var rottenNeighbours = new List<int[]>();
            
            foreach (var rottenOrange in rottenOranges)
            {
                grid[rottenOrange[0]][rottenOrange[1]] = 2;
                ++rottenOrangesCount;
            }
            
            foreach (var rottenOrange in rottenOranges)
            {
                var neighbours = GetNeighbourOranges(grid, rottenOrange);
                if (neighbours.Count > 0)
                {
                    foreach (var neighbour in neighbours)
                    {
                        if (DoesNotContain(rottenNeighbours, neighbour))
                        {
                            rottenNeighbours.Add(neighbour);
                        }
                    }
                }
            }
            
            rottenOranges.Clear();
            rottenOranges.AddRange(rottenNeighbours);
            
            ++minutesCount;
        }
        
        if (rottenOrangesCount < numberOfOranges)
        {
            return -1;
        }
        
        return minutesCount;
    }
    
    private bool DoesNotContain(List<int[]> rottenNeighbours, int[] neighbour)
    {
        foreach (var current in rottenNeighbours)
        {
            if (current[0] == neighbour[0] && current[1] == neighbour[1])
            {
                return false;
            }
        }
        
        return true;
    }
    
    private List<int[]> GetNeighbourOranges(int[][] grid, int[] orange)
    {
        var neighbours = new List<int[]>();
        int i = orange[0];
        int j = orange[1];
        
        if (i - 1 >= 0 && grid[i - 1][j] == 1)
        {
            neighbours.Add(new int[] { i - 1, j });
        }
        
        if (i + 1 < grid.Length && grid[i + 1][j] == 1)
        {
            neighbours.Add(new int[] { i + 1, j });
        }
        
        if (j + 1 < grid[i].Length && grid[i][j + 1] == 1)
        {
            neighbours.Add(new int[] { i, j + 1 });
        }
        
        if (j - 1 >= 0 && grid[i][j - 1] == 1)
        {
            neighbours.Add(new int[] { i, j - 1 });
        }
        
        return neighbours;
    }
}