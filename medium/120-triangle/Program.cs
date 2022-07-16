

/*
Given a triangle array, return the minimum path sum from top to bottom.


triangle = [[2],[3,4],[6,5,7],[4,1,8,3]]

         *2
       *3   4 
     6   *5   7
  4    *1   8   3

answer = 11


1 <= triangle.length <= 200
-10^4 <= triangle[i][j] <= 10^4


if you are on index i you can go to i or (i+1) index on the next row.

*/

public class Solution 
{
    private int MinimumTotalRec(IList<IList<int>> triangle, int level, int levelIndex, Dictionary<int, Dictionary<int, int>> memo)
    {
        if (level == triangle.Count - 1)
        {
            return triangle[level][levelIndex];
        }

        if (memo.ContainsKey(level) && memo[level].ContainsKey(levelIndex))
        {
            return memo[level][levelIndex];
        }

        int fstCost = MinimumTotalRec(triangle, level + 1, levelIndex, memo);
        int sndCost = MinimumTotalRec(triangle, level + 1, levelIndex + 1, memo);

        int minCost = Math.Min(fstCost, sndCost);
        int result = triangle[level][levelIndex] + minCost;

        if (!memo.ContainsKey(level))
        {
            memo[level] = new Dictionary<int, int>();
        }
        memo[level][levelIndex] = result;

        return result;
    }

    public int MinimumTotal(IList<IList<int>> triangle) 
    {
        var memo = new Dictionary<int, Dictionary<int, int>>();
        return MinimumTotalRec(triangle, 0, 0, memo);
    }
}
