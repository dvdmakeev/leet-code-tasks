public class Solution 
{
    // aababbab
    // 000112334
    // 332211100
    public int MinimumDeletions(string s) 
    {
        int[] leftAs = new int[s.Length + 1];
        for (int i = 0; i < s.Length; ++i)
        {
            int flip = s[i] == 'b' ? 1 : 0;
            
            leftAs[i + 1] = leftAs[i] + flip;
        }
        
        int[] rightBs = new int[s.Length + 1];
        for (int i = s.Length - 1; i >= 0; --i)
        {
            int flip = s[i] == 'a' ? 1 : 0;
            rightBs[i] = rightBs[i + 1] + flip;
        }
        
        int minDeletions = int.MaxValue;
        for (int i = 0; i < s.Length; ++i)
        {
            minDeletions = Math.Min(minDeletions, leftAs[i] + rightBs[i + 1]);
        }
        
        return minDeletions;
    }
}
