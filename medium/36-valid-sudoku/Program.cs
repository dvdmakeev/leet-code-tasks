public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {
        var lines = new HashSet<int>();
        var columns = new HashSet<int>[board[0].Length];
        var boxes = new HashSet<int>[board[0].Length];
        
        for (int i = 0; i < board.Length; ++i)
        {
            lines.Clear();
            
            for (int j = 0; j < board[0].Length; ++j)
            {
                if (columns[j] == null)
                {
                    columns[j] = new HashSet<int>();
                }
                if (boxes[(i / 3) * 3 + j / 3] == null)
                {
                    boxes[(i / 3) * 3 + j / 3] = new HashSet<int>();
                }
                
                if (board[i][j] == '.')
                {
                    continue;
                }
                
                int val = board[i][j] - '0';
                
                if (columns[j].Contains(val))
                {
                    return false;
                }
                columns[j].Add(val);
                
                if (boxes[(i / 3) * 3 + j / 3].Contains(val))
                {
                    return false;
                }
                boxes[(i / 3) * 3 + j / 3].Add(val);
                    
                if (lines.Contains(val))
                {
                    return false;
                }
                
                lines.Add(val);
            }
        }
        
        return true;
    }
}
