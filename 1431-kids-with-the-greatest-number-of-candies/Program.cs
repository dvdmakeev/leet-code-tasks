public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var result = new List<bool>();
        for (int i = 0; i < candies.Length; ++i)
        {
            int ith = candies[i] + extraCandies;
            bool ithResult = true;
            for (int j = 0; j < candies.Length; ++j)
            {
                if (ith < candies[j])
                {
                    ithResult = false;
                    break;
                }
            }
            result.Add(ithResult);
        }
        
        return result;
    }
	
	public IList<bool> KidsWithCandiesLinear(int[] candies, int extraCandies) {
        int max = int.MinValue;
        for (int i = 0; i < candies.Length; ++i)
        {
            if (candies[i] > max)
            {
                max = candies[i];
            }
        }
        
        var result = new List<bool>();
        for (int i = 0; i < candies.Length; ++i)
        {
            result.Add(candies[i] + extraCandies >= max);
        }
        

        return result;
    }
}