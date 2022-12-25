public class Solution 
{
    private int NumTreesRec(int start, int end, Dictionary<string, int> memo)
    {
        string key = $"{start};{end}";
        if (memo.ContainsKey(key))
        {
            return memo[key];
        }

        if (start > end)
        {
            return 1;
        }

        int count = 0;
        for (int i = start; i <= end; ++i)
        {
            var leftTreesCount = NumTreesRec(start, i - 1, memo);
            var rightTreesCount = NumTreesRec(i + 1, end, memo);

            count += leftTreesCount * rightTreesCount;
        }

        memo[key] = count;

        return count;
    }

    public int NumTrees(int n) 
    {
        var memo = new Dictionary<string, int>();
        return NumTreesRec(1, n, memo);
    }
}
