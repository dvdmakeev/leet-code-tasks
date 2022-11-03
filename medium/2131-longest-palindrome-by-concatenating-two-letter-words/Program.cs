public class Solution 
{
    /*
        ["ab","ty","yt","lc","cl","ab"]
    */
    public int LongestPalindrome(string[] words) 
    {
        int pairsCount = 0;
        int doubledCount = 0;
        
        var wordSet = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; ++i)
        {
            string reversed = new string(words[i].Reverse().ToArray());
            if (!wordSet.ContainsKey(reversed))
            {
                if (!wordSet.ContainsKey(words[i]))
                {
                    wordSet[words[i]] = 0;
                }
                
                ++wordSet[words[i]];
                
                if(words[i].Equals(reversed))
                {
                    ++doubledCount;
                }
            }
            else if (wordSet[reversed] > 0)
            {
                ++pairsCount;
                wordSet[reversed]--;
                
                if(words[i].Equals(reversed))
                {
                    --doubledCount;
                }
                
                if (wordSet[reversed] == 0)
                {
                    wordSet.Remove(reversed);
                }
            }
        }
        
        return pairsCount * 4 + (doubledCount > 0 ? 2 : 0);
    }
}
