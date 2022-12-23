public class Solution 
{
    /*
        A D O B E C O D E B A N C
        A B C
        
        A D O B E C
    */
    public string MinWindow(string s, string t) 
    {
        var patternMap = new Dictionary<char, int>();
        int matchCount = 0;
        for (int i = 0; i < t.Length; ++i)
        {
            if (!patternMap.ContainsKey(t[i]))
            {
                ++matchCount;
                patternMap[t[i]] = 0;
            }

            ++patternMap[t[i]];
        }

        int startMin = -1;
        int endMin = s.Length;

        int start = 0;
        for (int end = 0; end < s.Length; ++end)
        {
            if (patternMap.ContainsKey(s[end]))
            {
                patternMap[s[end]]--;

                if (patternMap[s[end]] == 0)
                {
                    --matchCount;
                }

                Console.WriteLine($"{s[end]}; {patternMap[s[end]]}; {matchCount}");
            }

            while (matchCount == 0)
            {
                if (endMin - startMin > end - start)
                {
                    startMin = start;
                    endMin = end;
                }

                if (patternMap.ContainsKey(s[start]))
                {
                    if (patternMap[s[start]] == 0)
                    {
                        ++matchCount;
                    }

                    patternMap[s[start]]++;
                }

                ++start;
            }
        }

        if (endMin - startMin > s.Length)
        {
            return "";
        }

        return s.Substring(startMin, endMin - startMin + 1);
    }
}
