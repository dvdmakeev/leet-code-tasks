public class Solution 
{
    public int MinFlipsMonoIncr(string s) 
    {
        int[] flip0 = new int[s.Length + 1];
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '1')
            {
                flip0[i + 1] += flip0[i] + 1;
            }
            else
            {
                flip0[i + 1] += flip0[i];
            }
        }
        
        int[] flip1 = new int[s.Length + 2];
        for (int i = s.Length - 1; i >= 0; --i)
        {
            if (s[i] == '0')
            {
                flip1[i] = flip1[i + 1] + 1;
            }
            else
            {
                flip1[i] = flip1[i + 1];
            }
        }
        
        int res = int.MaxValue;
        for (int i = 0; i < s.Length; ++i)
        {
            res = Math.Min(flip0[i] + flip1[i + 1], res);
        }
        
        return res;
    }
}
