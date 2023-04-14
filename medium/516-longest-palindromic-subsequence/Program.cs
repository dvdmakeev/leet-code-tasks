public class Solution 
{
    public int LongestPalindromeSubseqRec(string s, int i, int j, Dictionary<string, int> memo) 
    {
        if (i > j)
        {
            return 0;
        }

        if (i == j)
        {
            return 1;
        }

        var key = $"{i};{j}";
        if (memo.ContainsKey(key))
        {
            return memo[key];
        }

        var results = new List<int>();
        
        if (s[i] == s[j])
        {
            results.Add(LongestPalindromeSubseqRec(s, i + 1, j - 1, memo) + 2);
        }
        else
        {
            results.Add(LongestPalindromeSubseqRec(s, i + 1, j, memo));
            results.Add(LongestPalindromeSubseqRec(s, i, j - 1, memo));
        }

        memo[key] = results.Max();
        return memo[key];
    }

    public int LongestPalindromeSubseq(string s) 
    {
        var memo = new Dictionary<string, int>();
        return LongestPalindromeSubseqRec(s, 0, s.Length - 1, memo);
    }
}
