public class Solution 
{
    /*
        hasOverflow

        1 1 0 1

        i == 1
    */

    public int NumSteps(string s) 
    {
        int res = 0;
        bool hasOverflow = false;
        for (int i = s.Length - 1; i >= 0; --i)
        {
            if (!hasOverflow && s[i] == '0')
            {
                ++res;
                continue;
            }
            if (hasOverflow && s[i] == '1')
            {
                ++res;
                continue;
            }

            if (!hasOverflow && s[i] == '1' && i > 0)
            {
                ++res;
                ++res;
                hasOverflow = true;

                continue;
            }
            if (hasOverflow && s[i] == '0')
            {
                ++res;
                ++res;
                hasOverflow = true;
                continue;
            }
        }

        return res;
    }
}
