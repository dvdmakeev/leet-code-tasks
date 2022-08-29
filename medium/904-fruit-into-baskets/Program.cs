public class Solution 
{
    public int TotalFruit(int[] fruits) 
    {
        int start = 0;
        int maxFruits = 0;
        
        var fruitsMap = new Dictionary<int, int>();
        for (int end = start; end < fruits.Length; ++end)
        {
            if (!fruitsMap.ContainsKey(fruits[end]))
            {
                fruitsMap[fruits[end]] = 0;
            }
            ++fruitsMap[fruits[end]];
            
            while (fruitsMap.Count() > 2)
            {
                fruitsMap[fruits[start]]--;
                if (fruitsMap[fruits[start]] == 0)
                {
                    fruitsMap.Remove(fruits[start]);
                }
                
                ++start;
            }
            
            maxFruits = Math.Max(end - start + 1, maxFruits);
        }
        
        return maxFruits;
    }
}
