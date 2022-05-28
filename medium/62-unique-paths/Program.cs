public class Solution 
{
    public int UniquePaths(int m, int n)
    {
        int[][] memo = new int[m + 1][];
        for (int i = 0; i < memo.Length; ++i)
        {
            memo[i] = new int[n + 1];
        }
        
        return UniquePathsRec(m, n, memo);
    }
    
    private int UniquePathsRec(int m, int n, int[][] memo)
    {
        if (memo[m][n] != 0)
        {
            return memo[m][n];
        }
        
        if (m == 0 || n == 0)
        {
            return 0;
        }
        
        if (m == 1 && n == 1)
        {
            return 1;
        }
        
        memo[m][n] = UniquePathsRec(m - 1, n, memo) + UniquePathsRec(m, n - 1, memo);
        return memo[m][n];
    }
}

