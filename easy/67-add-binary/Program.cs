public class Solution 
{
    public string AddBinary(string a, string b) 
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int overflow = 0;
        var c = new StringBuilder();
        while (i >= 0 || j >= 0)
        {
            int aTerm = 0;
            if (i >= 0)
            {
                aTerm = a[i] - '0';
                --i;
            }
            int bTerm = 0;
            if (j >= 0)
            {
                bTerm = b[j] - '0';
                --j;
            }
            
            int sum = aTerm + bTerm + overflow;
            int cSum = sum % 2;
            c.Append(cSum);
            
            overflow = sum / 2;
        }
        
        if (overflow > 0)
        {
            c.Append(overflow);
        }
        
        return new string(c.ToString().Reverse().ToArray());
    }
}