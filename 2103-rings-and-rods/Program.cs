public class Solution 
{
    public int CountPoints(string rings) 
    {
        var rodsWithRings = new Dictionary<int, HashSet<char>>();
        for (int i = 0; i < rings.Length - 1; i += 2)
        {
            int rod = rings[i + 1] - '0';
            char ring = rings[i];
            if (!rodsWithRings.ContainsKey(rod))
            {
                rodsWithRings[rod] = new HashSet<char>();
            }
            
            rodsWithRings[rod].Add(ring);
        }
     
        int fullColouredRodsCount = 0;
        foreach (var rodRings in rodsWithRings)
        {
            if (rodRings.Value.Count >= 3)
            {
                ++fullColouredRodsCount;
            }
        }
        
        return fullColouredRodsCount;
    }
}