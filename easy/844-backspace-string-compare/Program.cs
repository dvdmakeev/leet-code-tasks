public class Solution 
{
    private int SkipBackspace(string s, int i)
    {
        int backspacesCount = 0;
        while (i >= 0)
        {
            if (s[i] == '#')
            {
                ++backspacesCount;
                --i;
                continue;
            }

            if (backspacesCount > 0)
            {
                --backspacesCount;
                --i;
            }
            else
            {
                break;
            }
        }

        return i;
    }

    public bool BackspaceCompare(string s, string t) 
    {
        int i = s.Length - 1;
        int j = t.Length - 1;

        while (i >= 0 || j >= 0)
        {
            int iSkipped = SkipBackspace(s, i);
            int jSkipped = SkipBackspace(t, j);

            if (iSkipped < 0 && jSkipped < 0)
            {
                return true;
            }

            if (iSkipped < 0 || jSkipped < 0)
            {
                return false;
            }

            if (s[iSkipped] != t[jSkipped])
            {
                return false;
            }

            i = iSkipped - 1;
            j = jSkipped - 1;
        }

        return true;
    }
}
