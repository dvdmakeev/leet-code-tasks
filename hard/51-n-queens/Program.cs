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
    
    private List<string> GetAnswer(List<int[]> queensState, int n)
    {
        var answer = new List<string>();
        
        foreach (int[] state in queensState)
        {
            var row = new StringBuilder();
            row.Append('.', n);
            
            row[state[0]] = 'Q';
            
            answer.Add(row.ToString());
        }
        
        return answer;
    }
    
    private void SolveNQueensRec(
        int n,
        int row,
        IList<IList<string>> solutions,
        HashSet<int> columns,
        HashSet<int> diagonals,
        HashSet<int> antiDiagonals,
        List<int[]> queensState)
    {
        if (row >= n)
        {
            List<string> answer = GetAnswer(queensState, n);
            solutions.Add(answer);
            return;
        }
        
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
            queensState.Add(new int[] { column, row });
            
            SolveNQueensRec(
                n,
                row + 1,
                solutions,
                columns,
                diagonals,
                antiDiagonals,
                queensState);
            
            columns.Remove(column);
            diagonals.Remove(column - row);
            antiDiagonals.Remove(column + row);
            queensState.RemoveAt(queensState.Count - 1);
        }
    }
    
    public IList<IList<string>> SolveNQueens(int n)
    {
        var solutions = new List<IList<string>>();
        var queensState = new List<int[]>();
        var columns = new HashSet<int>();
        var diagonals = new HashSet<int>();
        var antiDiagonals = new HashSet<int>();
        
        SolveNQueensRec(
                n,
                0,
                solutions,
                columns,
                diagonals,
                antiDiagonals,
                queensState);
        
        return solutions;
    }
}
