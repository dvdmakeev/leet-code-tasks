public class Solution 
{
    /*
        p a p e r
        5 0 5 2 1
        
        t i t l e
        2 3 2 1 0
    */
    public bool IsIsomorphic(string s, string t) 
    {
        var map = new Dictionary<char, char>();
        var sndMap = new Dictionary<char, char>();
        
        for (int i = 0; i < s.Length; ++i)
        {
            if (!map.ContainsKey(s[i]))
            {
                map[s[i]] = t[i];
            }
            
            if (!sndMap.ContainsKey(t[i]))
            {
                sndMap[t[i]] = s[i];
            }
            
            if (map[s[i]] != t[i] || sndMap[t[i]] != s[i])
            {
                return false;
            }
        }
        
        return true;
    }
}
