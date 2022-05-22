public class Solution 
{
    public int TitleToNumber(string columnTitle) 
    {
        const int baseNum = 26; 
        
        int number = 0;
        int digit = 0;
        for (int i = columnTitle.Length - 1; i >= 0; --i)
        {
            if (digit > 0) 
            {
                number += ((columnTitle[i] - 'A') + 1) * (int)Math.Pow(baseNum, digit);
            }
            else
            {
                number += ((columnTitle[i] - 'A') + 1);
            }
            
            digit++;
        }
        
        return number;
    }
}

