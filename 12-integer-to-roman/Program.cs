public class Solution 
{
    private Dictionary<int, string> GetRomanNums()
    {
        var romanNums = new Dictionary<int, string>();
        
        romanNums[1] = "I";
        romanNums[4] = "IV";
        romanNums[5] = "V";
        romanNums[9] = "IX";
        romanNums[10] = "X";
        romanNums[40] = "XL";
        romanNums[50] = "L";
        romanNums[90] = "XC";
        romanNums[100] = "C";
        romanNums[400] = "CD";
        romanNums[500] = "D";
        romanNums[900] = "CM";
        romanNums[1000] = "M";
        
        return romanNums;
    } 
    
    public string IntToRoman(int num) 
    {
        var result = new StringBuilder();
        var romanNums = GetRomanNums();
        var romanNumsDescending = romanNums.Keys.Select(key => key).OrderByDescending(i => i).ToList();
        
        while (num > 0)
        {
            int romanNum = 0;
            for (int i = 0; i < romanNumsDescending.Count; ++i)
            {
                romanNum = romanNumsDescending[i];
                if (romanNum <= num)
                {
                    break;
                }
            }
            num -= romanNum;
            result.Append(romanNums[romanNum]);
        }
        
        return result.ToString();
    }
}