public class Solution 
{
    /*
        Columns
          1 2 3 4 
        1 1 2 3 4
        2   2
        3
        4
        
        Diagonals
          1 2 3 4 
        1 0 1 2
        2   0 1 2 
        3     0 1
        4       0
        
        Antidiagonals
          1 2 3 4 
        1 2     5 
        2     5
        3   5  
        4 5      
    */
    
    private int TotalNQueensRec(
        int n,
        int row, 
        HashSet<int> columns, 
        HashSet<int> diagonals, 
        HashSet<int> antiDiagonals)
    {
        if (row >=n)
        {
            return 1;
        }
        
        int solutionCount = 0;
        
        for (int column = 0; column < n; ++column)
        {
            if (columns.Contains(column) || 
                diagonals.Contains(column - row) || 
                antiDiagonals.Contains(column + row))
            {
                continue;
            }
            
            columns.Add(column);
            diagonals.Add(column - row);
            antiDiagonals.Add(column + row);
            
            solutionCount += TotalNQueensRec(
                n,
                row + 1, 
                columns, 
                diagonals, 
                antiDiagonals);
            
            columns.Remove(column);
            diagonals.Remove(column - row);
            antiDiagonals.Remove(column + row);
        }
        
        return solutionCount;
    }
    
    public int TotalNQueens(int n) 
    {
        var columns = new HashSet<int>();
        var diagonals = new HashSet<int>();
        var antiDiagonals = new HashSet<int>();
        
        return TotalNQueensRec(
            n, 
            0,
            columns, 
            diagonals, 
            antiDiagonals);
    }
}
