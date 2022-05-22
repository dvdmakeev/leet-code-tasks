public class Solution 
{
    public int MaxLengthBetweenEqualCharacters(string s) 
    {
        var occurencesMap = new Dictionary<char, int[]>();
        for (int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            if (!occurencesMap.ContainsKey(c))
            {
                occurencesMap[c] = new int[2] { int.MaxValue, int.MinValue };
            }
            
            if (i < occurencesMap[c][0])
            {
                occurencesMap[c][0] = i;
            }
            if (i > occurencesMap[c][1])
            {
                occurencesMap[c][1] = i;
            }
        }
        
        int maxSubstring = -1;
        foreach (var keyValue in occurencesMap)
        {
            int substringLength = keyValue.Value[1] - keyValue.Value[0] - 1;
            if (maxSubstring < substringLength)
            {
                maxSubstring = substringLength;
            }
        }
        
        return maxSubstring;
    }
}