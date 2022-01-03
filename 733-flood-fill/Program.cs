public class Solution 
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) 
    {
        var cellsToVisit = new Queue<int[]>();
        int fromColor = image[sr][sc];
        if (fromColor == newColor)
        {
            return image;
        }
        
        cellsToVisit.Enqueue(new int[] { sr, sc });
        while (cellsToVisit.Count > 0)
        {
            var currentCell = cellsToVisit.Dequeue();
            if (image[currentCell[0]][currentCell[1]] != fromColor)
            {
                continue;
            }
            
            image[currentCell[0]][currentCell[1]] = newColor;
            foreach (var neighbour in GetNeighbours(image, currentCell))
            {
                if (image[neighbour[0]][neighbour[1]] != fromColor)
                {
                    continue;
                }
            
                cellsToVisit.Enqueue(neighbour);
            }
        }
        
        return image;
    }
    
    private IEnumerable<int[]> GetNeighbours(int[][] matrix, int[] cell)
    {
        if (cell[0] + 1 < matrix.Length)
        {
            yield return new [] { cell[0] + 1, cell[1] };
        }
        
        if (cell[1] + 1 < matrix[0].Length)
        {
            yield return new [] { cell[0], cell[1] + 1 };
        }
        
        if (cell[0] - 1 >= 0)
        {
            yield return new [] { cell[0] - 1, cell[1] };
        }
        
        if (cell[1] - 1 >= 0)
        {
            yield return new [] { cell[0], cell[1] - 1 };
        }
    }
}