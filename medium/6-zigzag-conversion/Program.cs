public class Solution 
{
    // p a y p a l i s h i r  i  n  g 
    // 0 1 2 3 4 5 6 7 8 9 10 11 12 13
    // 3
    //
    // 0   4   8     12
    // 1 3 5 7 9  11 13
    // 2   6   10
    //
    // 0 4 8 12 1 3 5 7 9 11 13 2 6 10
    //
    //
    // 0     6       12 | i * (2 * k - 2)
    // 1   5 7    11 13 | 
    // 2 4   8 10       |
    // 3     9          |
    //               
    //
    // 0 6 12 1 5 7 11 13 2 4 8 10 3 9
    public string Convert(string s, int numRows) 
    {
        if (numRows == 1)
        {
            return s;
        }
        
        var zigzag = new StringBuilder();
        for (int i = 0; i < numRows; ++i)
        {
            int k = i;
            while (k < s.Length)
            {
                zigzag.Append(s[k]);
                k += (2 * numRows - 2);
                int shift = k - i * 2;
                if (i != 0 && i != numRows - 1 && shift >= 0 && shift < s.Length)
                {
                    zigzag.Append(s[shift]);
                }
            }
        }
        
        return zigzag.ToString();
    }
}
