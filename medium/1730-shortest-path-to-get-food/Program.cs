public class Solution 
{
    private const char initLocation = '*';
    private const char food = '#';
    private const char free = 'O';
    private const char obstacle = 'X';
    
    private int[] FindInitLocation(char[][] grid)
    {
        for (int i = 0; i < grid.Length; ++i)
        {
            for (int j = 0; j < grid[i].Length; ++j)
            {
                if (grid[i][j] == initLocation)
                {
                    return new int[2] { i, j };
                }
            }
        }
        
        return null;
    }
    
    private IEnumerable<int[]> GetNeighbours(int[] current, char[][] grid)
    {
        var neighbours = new List<int[]>();
        
        if (current[0] - 1 >= 0)
        {
            neighbours.Add(new int[2] { current[0] - 1, current[1] });
        }
        if (current[1] - 1 >= 0)
        {
            neighbours.Add(new int[2] { current[0], current[1] - 1 });
        }
        if (current[1] + 1 < grid[current[0]].Length)
        {
            neighbours.Add(new int[2] { current[0], current[1] + 1 });
        }
        if (current[0] + 1 < grid.Length)
        {
            neighbours.Add(new int[2] { current[0] + 1, current[1] });
        }
        
        return neighbours.Where(neighbour => grid[neighbour[0]][neighbour[1]] != obstacle);
    }
    
    public int GetFood(char[][] grid) 
    {
        int[] init = FindInitLocation(grid);
        
        var queue = new Queue<int[]>();
        queue.Enqueue(init);
        int currentDistance = 0;
        while (queue.Count > 0)
        {
            int currentLevelSize = queue.Count;
            ++currentDistance;
            while (currentLevelSize > 0)
            {
                --currentLevelSize;
                int[] current = queue.Dequeue();
                foreach (int[] neighbour in GetNeighbours(current, grid))
                {
                    if (grid[neighbour[0]][neighbour[1]] == food)
                    {
                        return currentDistance;
                    }
                    
                    queue.Enqueue(neighbour);
                    grid[neighbour[0]][neighbour[1]] = obstacle;
                }
            }
        }
        
        return -1;
    }
}
