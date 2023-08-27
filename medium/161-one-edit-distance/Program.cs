public class Solution 
{
    /*
        a d b
        a b b -> true
        insert:  i,j = 1,1 => 1,2
        replace: i,j = 1,1 => 2,2
        delete:  i,j = 1,1 => 2,1

        a
        a     -> false

        b c
        b a   -> true

        i, j, edited
        все что слева i и j - zeroOrOneEditDistance

        if s[i] == s[j] -> continue
        else: 
            1. insert c to s
            2. delete c from s
            3. replace c of s
    */
    public bool IsOneEditDistance(string s, string t) 
    {
        int i = 0;
        int j = 0;

        bool edited = false;

        while (i < s.Length || j < t.Length)
        {
            if (i > s.Length - 1 || j > t.Length - 1 || s[i] != t[j])
            {
                if (edited)
                {
                    break;
                }

                if (s.Length < t.Length)
                {
                    ++j;
                }
                else if (s.Length > t.Length)
                {
                    ++i;
                }
                else
                {
                    ++i;
                    ++j;
                }

                edited = true;
            }
            else
            {
                ++i;
                ++j;
            }
        }

        return i >= s.Length && j >= t.Length && edited;
    }
}
