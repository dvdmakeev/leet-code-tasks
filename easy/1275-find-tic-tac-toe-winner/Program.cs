public class Solution 
{
    public string Tictactoe(int[][] moves) 
    {
        var battleField = new int[3][];
        for (int i = 0; i < battleField.Length; ++i)
        {
            battleField[i] = new int[3];
        }
        
        for (int i = 0; i < moves.Length; ++i)
        {
            int player = (i % 2) + 1;
            battleField[moves[i][0]][moves[i][1]] = player;
        }
        
        bool hasMatch = true;
        // check rows
        for (int i = 0; i < battleField.Length; ++i)
        {
            hasMatch = true;
            for (int j = 0; j < battleField[i].Length - 1; ++j)
            {
                if (battleField[i][j] == 0 || battleField[i][j] != battleField[i][j + 1])
                {
                    hasMatch = false;
                    break;
                }
            }
            
            if (hasMatch)
            {
                return GetPlayerName(battleField[i][0]);
            }
        }
        
        // check columns
        for (int i = 0; i < battleField[0].Length; ++i)
        {
            hasMatch = true;
            for (int j = 0; j < battleField.Length - 1; ++j)
            {
                if (battleField[j][i] == 0 || battleField[j][i] != battleField[j + 1][i])
                {
                    hasMatch = false;
                    break;
                }
            }
            
            if (hasMatch)
            {
                return GetPlayerName(battleField[0][i]);
            }
        }
        
        // check main diagonal
        hasMatch = true;
        for (int i = 0; i < battleField.Length - 1; ++i)
        {
            if (battleField[i][i] == 0 || battleField[i][i] != battleField[i + 1][i + 1])
            {
                hasMatch = false;
                break;
            }
        }
        if (hasMatch)
        {
            return GetPlayerName(battleField[0][0]);
        }
        
        // check antidiagonal
        hasMatch = true;
        for (int i = 0; i < battleField.Length - 1; ++i)
        {
            if (battleField[i][battleField.Length - 1 - i] == 0 || battleField[i][battleField.Length - 1 - i] != battleField[i + 1][battleField.Length - 2 - i])
            {
                hasMatch = false;
                break;
            }
        }
        if (hasMatch)
        {
            return GetPlayerName(battleField[0][battleField[0].Length - 1]);
        }
        
        if (moves.Length < 9)
        {
            return "Pending";
        }
        
        return "Draw";
    }
    
    private string GetPlayerName(int player)
    {
        if (player == 1)
        {
            return "A";
        } else if (player == 2)
        {
            return "B";
        }
        
        throw new Exception();
    }
}