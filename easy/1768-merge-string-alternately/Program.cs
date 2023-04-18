public class Solution 
{
    public string MergeAlternately(string word1, string word2) 
    {
        int i = 0;
        int j = 0;

        var result = new StringBuilder();
        while (i < word1.Length || j < word2.Length)
        {
            if (i >= word1.Length)
            {
                result.Append(word2[j++]);
                continue;
            }
            if (j >= word2.Length)
            {
                result.Append(word1[i++]);
                continue;
            }

            result.Append(word1[i++]);
            result.Append(word2[j++]);
        }

        return result.ToString();
    }
}
