public class Solution 
{
    public int NearestExit(char[][] maze, int[] entrance) 
    {
        const char wall = '+';
        const char empty = '.';
        const char visited = '-';
        
        var queue = new Queue<int[]>();
        queue.Enqueue(entrance);
        int shortestPath = 0;
        while (queue.Count > 0)
        {
            ++shortestPath;
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; ++i)
            {
                int[] currentPos = queue.Dequeue();
                maze[currentPos[0]][currentPos[1]] = visited;
            
                List<int[]> neighbours = GetNeighbours(maze, currentPos);
                foreach (int[] neighbour in neighbours)
                {
                    char neighbourValue = maze[neighbour[0]][neighbour[1]];
                    if (neighbourValue == wall || 
                        neighbourValue == visited ||
                        neighbourValue != empty ||
                        neighbour[0] == entrance[0] && neighbour[1] == entrance[1])
                    {
                        continue;
                    }

                    maze[neighbour[0]][neighbour[1]] = visited;
                    if (neighbour[0] == 0 || 
                        neighbour[1] == maze[0].Length - 1 ||
                        neighbour[1] == 0 || 
                        neighbour[0] == maze.Length - 1)
                    {
                        return shortestPath;
                    }
                
                    queue.Enqueue(neighbour);
                }
            }
        }
        
        return -1;
    }
    
    private List<int[]> GetNeighbours(char[][] maze, int[] currentPos)
    {
        var neighbours = new List<int[]>();
        
        if (currentPos[0] - 1 >= 0)
        {
            neighbours.Add(new int[] { currentPos[0] - 1, currentPos[1] });
        }
        if (currentPos[0] + 1 < maze.Length)
        {
            neighbours.Add(new int[] { currentPos[0] + 1, currentPos[1] });
        }
        if (currentPos[1] - 1 >= 0)
        {
            neighbours.Add(new int[] { currentPos[0], currentPos[1] - 1 });
        }
        if (currentPos[1] + 1 < maze[currentPos[0]].Length)
        {
            neighbours.Add(new int[] { currentPos[0], currentPos[1] + 1 });
        }
        
        return neighbours;
    }
}

