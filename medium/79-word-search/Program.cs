public class Solution
{
    private bool FindWord(char[][] board, string word, int i, int j, int n, bool[][] map)
    {
        if (n >= word.Length)
        {
            return true;
        }
        
        if (i < 0 || j < 0 || i >= board.Length || j >= board[i].Length)
        {
            return false;
        }
        
        if (map[i][j])
        {
            return false;
        }
        
        if (board[i][j] != word[n])
        {
            return false;
        }
        
        map[i][j] = true;
        
        bool res = FindWord(board, word, i + 1, j, n + 1, map);
        if (res)
        {
            return true;
        }
        
        res = FindWord(board, word, i - 1, j, n + 1, map);
        if (res)
        {
            return true;
        }
        
        res = FindWord(board, word, i, j + 1, n + 1, map);
        if (res)
        {
            return true;
        }
        
        res = FindWord(board, word, i, j - 1, n + 1, map);
        if (res)
        {
            return true;
        }
        
        map[i][j] = false;
        
        return false;
    }
    
    public bool Exist(char[][] board, string word)
    {
        var visited = new bool[board.Length][];
        for (int i = 0; i < visited.Length; ++i)
        {
            visited[i] = new bool[board[i].Length];
        }
        
        for (int i = 0; i < board.Length; ++i)
        {
            for (int j = 0; j < board[i].Length; ++j)
            {                
                if (FindWord(board, word, i, j, 0, visited))
                {
                    return true;
                }
            }
        }
        
        return false;
    }
}
